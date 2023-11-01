namespace NUnitSample;

/// <summary>
/// Szerkezeti minta egy teszteket definiáló osztályra.
/// </summary>
public class TestClassSample
{
    /// <summary>
    /// A tesztek kiértékelésének elején egyszer fut le.
    /// </summary>
    [OneTimeSetUp]
    public void OneTimeSetup()
    {
    }

    /// <summary>
    /// Minden egyes teszteset lefutása előtt lefut.
    /// </summary>
    [SetUp]
    public void Setup()
    {
    }

    /// <summary>
    /// Egy egyszerű teszt metódus
    /// </summary>
    [Test]
    public void SimpleTest()
    {
        Assert.Pass();
    }

    /// <summary>
    /// Teszt metódus aminek aminek TestCase-ekkel definiáljuk a bemeneti paramétereit és az elvárt kimenetet.
    /// </summary>
    /// <param name="arg1">Első operandus</param>
    /// <param name="arg2">Második operandus</param>
    /// <param name="result">Elvárt kimenet</param>
    [Test]
    [TestCase(1,1,"2")]
    [TestCase(2,2,"4")]
    public void TestWithTestCases(int arg1, int arg2, string result)
    {
        //Assert.True((arg1 + arg2).ToString() == result);
        Assert.That((arg1 + arg2).ToString(), Is.EqualTo(result));
    }

    /// <summary>
    /// Minden teszteset lefutása után lefut.
    /// </summary>
    [TearDown]
    public void TearDown()
    {
    }

    /// <summary>
    /// Az összes teszteset befejezése után fut le.
    /// </summary>
    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
    }
}
