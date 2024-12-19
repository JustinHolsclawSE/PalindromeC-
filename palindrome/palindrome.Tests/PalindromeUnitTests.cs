namespace palindrome.Tests;

public class PalinderomeTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase("x82ax")]
    [TestCase("x82ax9")]
    [TestCase("9xax9")]
    [TestCase("!xax%$")]
    [TestCase("x-a+x")]
    public static void SanatizeInputTests(string input)
    {
        string result = Palindrome.Palindrome.SanatizeInput(input);
        Assert.That(result, Is.EqualTo("xax"));
    }

}