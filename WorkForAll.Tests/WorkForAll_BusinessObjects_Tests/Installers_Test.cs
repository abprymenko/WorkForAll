namespace WorkForAll.Tests.WorkForAll_BusinessObjects_Tests;

#region Installers_Test
internal class Installers_Test
{
    #region Private : Fields
    private ICollection<IPosition>? _positions;
    private readonly ICollection<ISalary>? _salaries;
    #endregion

    #region Setup
    [SetUp]
    public void Setup()
    {
        _positions = IoC.Container?.Resolve<ICollection<IPosition>>();
    }
    #endregion

    #region Test : Methods
    [Test]
    public void ICollectionIsEmpty_Test()
    {
        Assert.That(_positions, Is.Empty);
    }
    /// <summary>
    /// _salaries are deliberately not resolved!!!
    /// </summary>
    [Test]
    public void ICollectionIsNull_Test()
    {
        Assert.That(_salaries, Is.Null);
    }
    #endregion
}
#endregion