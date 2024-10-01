namespace BusinessCentral.LinterCop.Test;

public class Rule0072
{
    private string _testCaseDir = "";

    [SetUp]
    public void Setup()
    {
        _testCaseDir = Path.Combine(Directory.GetParent(Environment.CurrentDirectory)!.Parent!.Parent!.FullName,
            "TestCases", "Rule0072");
    }

    [Test]
    [TestCase("ApplicationArea")]
    [TestCase("DataClassification")]
    public async Task HasDiagnostic(string testCase)
    {
        var code = await File.ReadAllTextAsync(Path.Combine(_testCaseDir, "HasDiagnostic", $"{testCase}.al"))
            .ConfigureAwait(false);

        var fixture = RoslynFixtureFactory.Create<Rule0070ListObjectsAreOneBased>();
        fixture.HasDiagnostic(code, DiagnosticDescriptors.Rule0072DuplicateProperty.Id);
    }

    [Test]
    [TestCase("ApplicationArea1")]
    [TestCase("ApplicationArea2")]
    [TestCase("DataClassification1")]
    [TestCase("DataClassification2")]
    public async Task NoDiagnostic(string testCase)
    {
        var code = await File.ReadAllTextAsync(Path.Combine(_testCaseDir, "NoDiagnostic", $"{testCase}.al"))
            .ConfigureAwait(false);

        var fixture = RoslynFixtureFactory.Create<Rule0070ListObjectsAreOneBased>();
        fixture.NoDiagnosticAtMarker(code, DiagnosticDescriptors.Rule0072DuplicateProperty.Id);
    }
}