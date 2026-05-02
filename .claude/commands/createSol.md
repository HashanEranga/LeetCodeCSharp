---
description: Scaffold a new LeetCode solution + xUnit test file pair under the right category folder.
argument-hint: <Category> <ProblemName>
---

You are scaffolding a new problem in this repo. Arguments: `$ARGUMENTS` (expected: `<Category> <ProblemName>`, e.g. `Arrays TwoSum` or `BinarySearch SearchMatrix`).

## Steps

1. Parse `$ARGUMENTS` into `<Category>` and `<ProblemName>`. If either is missing, stop and ask the user for the missing piece.

2. Resolve the **test folder name**. The source folder always uses `<Category>` verbatim, but the test side has a known typo for `BinarySearch` → `BinarySeach`. Map:
   - `BinarySearch` → test folder `BinarySeach`
   - everything else → test folder same as `<Category>`
   Verify by listing `LeetCodeCSharp.Tests/` if unsure; match the existing folder, do not create a new spelling.

3. If either category folder is missing (`LeetCodeCSharp/<Category>/` or `LeetCodeCSharp.Tests/<TestFolder>/`), create it.

4. Write `LeetCodeCSharp/<Category>/<ProblemName>.cs` with:

```csharp
namespace LeetCodeCSharp.<Category>;

public class <ProblemName>
{
    // TODO: time complexity / space complexity
    public void Solve()
    {
        throw new NotImplementedException();
    }
}
```

Adjust the method signature/return type to match the LeetCode problem if you can infer it from the name; otherwise leave the `Solve()` placeholder for the user to fill in.

5. Write `LeetCodeCSharp.Tests/<TestFolder>/<ProblemName>Tests.cs` with:

```csharp
using LeetCodeCSharp.<Category>;

namespace LeetCodeCSharp.Tests.<Category>;

public class <ProblemName>Tests
{
    private readonly <ProblemName> _sut = new();

    [Fact]
    public void Solve_TODO_DescribeCase()
    {
        // Arrange

        // Act

        // Assert
        Assert.True(false, "TODO: implement test");
    }
}
```

Note: the test **namespace** uses `<Category>` (correct spelling), even when the **folder** uses the typo. Match this to the existing convention seen in the other tests.

6. Do NOT run `dotnet new class` — write the files directly with the Write tool. The boilerplate from `dotnet new` doesn't match this project's style (file-scoped namespaces, xUnit imports via `<Using>` in the csproj, no extra usings).

7. Report the two created file paths so the user can open them.

## Refusals

- If a file at either target path already exists, stop and tell the user — don't overwrite.
- If `<ProblemName>` isn't a valid C# identifier (must start with a letter/underscore, contain only letters/digits/underscore), stop and ask the user to rename.
