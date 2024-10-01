namespace BusinessCentral.LinterCop.Test;

public class Rule0071
{
    private string _testCaseDir = "";

    [SetUp]
    public void Setup()
    {
        _testCaseDir = Path.Combine(Directory.GetParent(Environment.CurrentDirectory)!.Parent!.Parent!.FullName,
            "TestCases", "Rule0071");
    }

    [Test]
    [TestCase("ToFewParameters")]
    [TestCase("ToManyParameters")]
    public async Task HasDiagnosticForParameterCount(string testCase)
    {
        var code = await File.ReadAllTextAsync(Path.Combine(_testCaseDir, "HasDiagnostic", $"{testCase}.al"))
            .ConfigureAwait(false);

        var fixture = RoslynFixtureFactory.Create<Rule71AnalyzeGetInvocations>();
        fixture.HasDiagnostic(code, DiagnosticDescriptors.Rule0071_1IncorrectArgumentCount.Id);
    }

    [Test]
    [TestCase("WrongParameterType")]
    public async Task HasDiagnosticForParameterType(string testCase)
    {
        var code = await File.ReadAllTextAsync(Path.Combine(_testCaseDir, "HasDiagnostic", $"{testCase}.al"))
            .ConfigureAwait(false);

        var fixture = RoslynFixtureFactory.Create<Rule71AnalyzeGetInvocations>();
        fixture.HasDiagnostic(code, DiagnosticDescriptors.Rule0071_2InvalidArgumentTypeInGetCall.Id);
    }    

    [Test]
    [TestCase("ParameterTooLong")]
    public async Task HasDiagnosticForParameterLength(string testCase)
    {
        var code = await File.ReadAllTextAsync(Path.Combine(_testCaseDir, "HasDiagnostic", $"{testCase}.al"))
            .ConfigureAwait(false);

        var fixture = RoslynFixtureFactory.Create<Rule71AnalyzeGetInvocations>();
        fixture.HasDiagnostic(code, DiagnosticDescriptors.Rule0071_3ArgumentLengthExceedsMaxLength.Id);
    }    

    [Test]
    [TestCase("1")]
    [TestCase("2")]
    [TestCase("3")]
    public async Task NoDiagnostic(string testCase)
    {
        var code = await File.ReadAllTextAsync(Path.Combine(_testCaseDir, "NoDiagnostic", $"{testCase}.al"))
            .ConfigureAwait(false);

        var fixture = RoslynFixtureFactory.Create<Rule71AnalyzeGetInvocations>();
        fixture.NoDiagnosticAtMarker(code, DiagnosticDescriptors.Rule0071_1IncorrectArgumentCount.Id);
        fixture.NoDiagnosticAtMarker(code, DiagnosticDescriptors.Rule0071_2InvalidArgumentTypeInGetCall.Id);
        fixture.NoDiagnosticAtMarker(code, DiagnosticDescriptors.Rule0071_3ArgumentLengthExceedsMaxLength.Id);
    }
}