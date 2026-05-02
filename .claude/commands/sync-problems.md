---
description: Sync newly solved problems from this repo into the Notion Competitive Programming knowledge base.
argument-hint: (no arguments)
---

You are syncing solved problems into Notion. This command is **add-only** — it never overwrites existing Notion entries, because those pages contain user-authored notes.

## Notion targets (already wired — do not re-discover)

- **Knowledge Base** parent page: `3542935a-b4d6-8188-8aa6-cbe24acc9d02`
- **Competitive Programming** sub-page: `3542935a-b4d6-81cd-8457-eca3e0af5ea8`
- **Solved Problems** data source: `89079b16-b6e0-4b79-9220-93a527d52abc`
- **Reusable Methods** data source: `0b5ed5b5-e711-4e4f-9a2a-2763adb3a38d`

GitHub repo: `https://github.com/HashanEranga/LeetCodeCSharp` (branch `main`)

## Preconditions

1. Confirm the Notion MCP is connected by calling `mcp__notion__notion-search` with a trivial query. If it errors with auth, stop and tell the user to authenticate the Notion MCP, then re-run.
2. Confirm git status is clean-ish (warn if there are uncommitted changes to `LeetCodeCSharp/` source files — they won't have a stable GitHub URL yet).

## Steps

### 1. Enumerate local problems

Use `Glob` for `LeetCodeCSharp/**/*.cs`, then drop anything under `obj/` or `bin/`. Group by category folder (`Arrays`, `TwoPointers`, `BinarySearch`).

For each file, read it and extract:
- **Class name** (problem identifier, e.g. `TwoSum`)
- **Approach comments** (lines starting with `//` near methods — they often state time/space complexity)
- **Helper methods** (any `public` method on the class beyond the main solver — e.g. `FindMax` on `KokoEatingBanana`)

Convert class name to a human title with spaces (`SearchRotatedSortedArry` → `Search in Rotated Sorted Array`; use your judgment, fix typos in the title).

### 2. Diff against Notion

Fetch the Solved Problems data source schema:

```
mcp__notion__notion-fetch with id "collection://89079b16-b6e0-4b79-9220-93a527d52abc"
```

Then list its existing pages by searching within the data source:

```
mcp__notion__notion-search with data_source_url="collection://89079b16-b6e0-4b79-9220-93a527d52abc", query="" (or category-specific term), page_size=25
```

Pages already in Notion → **skip silently** (do not update). Pages found locally but missing from Notion → **create**.

### 3. Create new entries

For each missing problem, build a page with:

**Properties**
- `Problem` (Title) — human-readable name
- `Category` — `Arrays` | `Two Pointers` | `Binary Search` (matches the source folder)
- `Difficulty` — `Easy` | `Medium` | `Hard` (your best guess from the problem name; leave null if uncertain)
- `LeetCode Link` — canonical URL `https://leetcode.com/problems/<slug>/` (slug = kebab-case of the title; verify by web search if unsure, otherwise leave null)
- `GitHub Source` — `https://github.com/HashanEranga/LeetCodeCSharp/blob/main/LeetCodeCSharp/<Category>/<File>.cs`
- `Approaches` — JSON array; pick from `Brute Force`, `Optimized`, `Sorting`, `Hashing`, `Two Pointers`, `Binary Search`, `Bucket Sort`, `Prefix/Suffix`
- `Time Complexity` / `Space Complexity` — derived from the inline `//` comments where present
- `Status` — `Solved`

**Body** (Notion markdown, no code blocks, prose only):

```
## Description
<one or two sentences stating what the problem asks>

## Approach
<brief plain-prose explanation of the core idea, no code>

## Complexity
- **Time** — <bound + one-line reasoning>
- **Space** — <bound + one-line reasoning>

## Similar Problems
- **<Variant 1>**: <how the constraint changes and what shifts in the solution>
- **<Variant 2>**: ...
- (2–4 variants, no more)

## Source
[`<Category>/<File>.cs`](<GitHub URL>)
```

Use `mcp__notion__notion-create-pages` with `parent.type = "data_source_id"` and `data_source_id = "89079b16-b6e0-4b79-9220-93a527d52abc"`. Batch all new pages in one call.

### 4. Wire Variants self-relation (best-effort)

If any of the *new* problems is an obvious variant of an *existing* problem (rotated array, sliding window, k-sum, etc.), update the new page's `Variants` property with the related page URL via `mcp__notion__notion-update-page`. Only set the relation if the link is unambiguous; otherwise leave empty and let the user wire it.

### 5. Report uncatalogued helper methods

Compare helper methods discovered in step 1 against the Reusable Methods data source. For each helper not yet in Notion, **report it back** in your final summary as a candidate. Do **not** create entries — let the user decide.

Format the report as:

```
Candidate reusable methods (not yet in Notion):
- FindMax (BinarySearch/KokoEatingBanana.cs) — returns the max int in an array
- ...
```

### 6. Final summary

Print:
1. New problems added (with Notion URLs)
2. Problems already present (skipped)
3. Variant relations wired
4. Candidate reusable methods to consider

## Hard rules

- **Never update** an existing Solved Problems page — if a file changed, leave the Notion page alone. The user's notes live there.
- **Never create** Reusable Methods entries automatically — only surface candidates.
- **Never invent** a LeetCode URL you can't verify; leaving the field blank is better than a 404.
- **Never delete** a Notion page even if its source file was removed locally — surface the orphan in the report instead.
