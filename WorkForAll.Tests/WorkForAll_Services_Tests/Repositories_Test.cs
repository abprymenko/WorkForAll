namespace WorkForAll.Tests.WorkForAll_Services_Tests;

#region Repositories_Test
internal class Repositories_Test
{
    #region Private : Fields
#pragma warning disable NUnit1032
    private IRepository _repository;
#pragma warning restore NUnit1032
    private IGrade _grade;
    private IInsertVisitor _insertVisitor;
    private static int _count = 1;
    #endregion

    #region Setup
    [SetUp]
    public void Setup()
    {
        try
        {
            var container = IoC.Container ?? throw new ArgumentNullException("container is null");
            _repository = container.Resolve<IRepository>();
            _grade = container.Resolve<IGrade>();
            _insertVisitor = container.Resolve<IInsertVisitor>();
        }
        catch (Exception ex)
        {
            Assert.Fail(ex.Message);
        }
    }
    #endregion

    #region Test : Methods

    #region INSERT
    [Test]
    [TestCase((int)Grade.A)]
    [TestCase((int)Grade.B)]
    [TestCase((int)Grade.C)]
    [TestCase((int)Grade.D)]
    public async Task InsertGrade_Test(int code)
    {
        using (_repository)
            try
            {
                _grade.Code = code;
                var @params = _grade.AcceptInsert(_insertVisitor);
                await _repository.ExecuteAsync(AppConstant.StoredProcedureName.InsertGrade, @params);
                Assert.That(@params.Get<int>("@insertedid"), Is.EqualTo(_count++));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
    }
    #endregion
    
    #endregion
}
#endregion