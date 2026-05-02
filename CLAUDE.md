# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Overview

A personal collection of LeetCode problem solutions in C# (.NET 8) with xUnit tests. The solution (`LeetCodeCSharp.slnx`) contains two projects: `LeetCodeCSharp` (solutions) and `LeetCodeCSharp.Tests` (xUnit tests that reference the main project).

## Commands

Run from the repo root.

- Restore: `dotnet restore`
- Build: `dotnet build`
- Run all tests: `dotnet test`
- Run tests for a single class: `dotnet test --filter "FullyQualifiedName~ContainsDuplicateTests"`
- Run one test method: `dotnet test --filter "FullyQualifiedName~ContainsDuplicateTests.ContainsDuplicateOptimized_WithDuplicates_ReturnsTrue"`
- Run all tests in a category folder: `dotnet test --filter "FullyQualifiedName~LeetCodeCSharp.Tests.Arrays"`

`nuget.config` clears inherited package sources and pins to `nuget.org` only — keep this in mind if a restore fails on a machine that expects a private feed.

## Structure conventions

Solutions live in category folders under `LeetCodeCSharp/` (`Arrays/`, `BinarySearch/`, `TwoPointers/`). Each problem is one `public class` per file, named after the problem (e.g. `ContainsDuplicate.cs`), in namespace `LeetCodeCSharp.<Category>`. Tests mirror this layout under `LeetCodeCSharp.Tests/<Category>/<Problem>Tests.cs`.

When adding a new problem:
1. Create `LeetCodeCSharp/<Category>/<Problem>.cs` with the solution class.
2. Create `LeetCodeCSharp.Tests/<Category>/<Problem>Tests.cs` mirroring it.
3. If the category folder doesn't exist, create both sides. Reuse existing categories rather than inventing finer-grained ones.

Note the test-side folder for binary search is spelled `BinarySeach/` (typo) while the source-side is `BinarySearch/`. Namespaces on both sides use `BinarySearch`. Don't "fix" the folder name without checking — match the existing layout when adding tests.

## Solution style

Several problems include multiple implementations on one class (e.g. `ContainsDuplicateBruteForce` and `ContainsDuplicateOptimized`) with a one-line comment noting time/space complexity above each. When a problem has an obvious naive approach, follow the same pattern — keep both, label them, and test both. Tests typically include `[Fact]` cases for explicit edge cases (empty, single element, negatives, zeros) plus a `[Theory]` with `[InlineData]` for parameterized cases; when both a brute-force and optimized method exist, there is usually a `BothMethods_SameInput_ReturnSameResult` cross-check test.

`Nullable` and `ImplicitUsings` are enabled in both projects.

## Notion knowledge base

Solved problems are mirrored to a Notion knowledge base under `Knowledge Base → Competitive Programming`:

- **Solved Problems** database — one page per problem with description, approach, complexity, and similar-problems analysis. Notion data source: `89079b16-b6e0-4b79-9220-93a527d52abc`.
- **Reusable Methods** database — helper utilities (e.g. `FindMax`) extracted from solutions. Data source: `0b5ed5b5-e711-4e4f-9a2a-2763adb3a38d`.

To add new problems to Notion, run `/sync-problems`. The command is **add-only** — it never overwrites existing Notion entries because they contain user-authored notes. It surfaces candidate reusable helper methods in its report but does not create them automatically.
