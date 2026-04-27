[CmdletBinding()]
param(
    [Parameter(Mandatory)] [string] $Category,
    [Parameter(Mandatory)] [string] $ProblemName
)

$ErrorActionPreference = 'Stop'

if ($ProblemName -notmatch '^[A-Za-z_][A-Za-z0-9_]*$') {
    throw "ProblemName '$ProblemName' is not a valid C# identifier."
}

$testFolderMap = @{ 'BinarySearch' = 'BinarySeach' }
$testFolder = if ($testFolderMap.ContainsKey($Category)) { $testFolderMap[$Category] } else { $Category }

$repoRoot = Split-Path -Parent $PSScriptRoot
$srcDir   = Join-Path $repoRoot "LeetCodeCSharp/$Category"
$testDir  = Join-Path $repoRoot "LeetCodeCSharp.Tests/$testFolder"
$srcFile  = Join-Path $srcDir  "$ProblemName.cs"
$testFile = Join-Path $testDir "${ProblemName}Tests.cs"

if (Test-Path $srcFile)  { throw "Already exists: $srcFile" }
if (Test-Path $testFile) { throw "Already exists: $testFile" }

New-Item -ItemType Directory -Path $srcDir,$testDir -Force | Out-Null

$srcContent = @"
namespace LeetCodeCSharp.$Category;

public class $ProblemName
{
    // TODO: time complexity / space complexity
    public void Solve()
    {
        throw new NotImplementedException();
    }
}
"@

$testContent = @"
using LeetCodeCSharp.$Category;

namespace LeetCodeCSharp.Tests.$Category;

public class ${ProblemName}Tests
{
    private readonly $ProblemName _sut = new();

    [Fact]
    public void Solve_TODO_DescribeCase()
    {
        Assert.True(false, "TODO: implement test");
    }
}
"@

Set-Content -Path $srcFile  -Value $srcContent  -Encoding UTF8
Set-Content -Path $testFile -Value $testContent -Encoding UTF8

Write-Host "Created: $srcFile"
Write-Host "Created: $testFile"
