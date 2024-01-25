namespace WorkForAll.Tests.WorkForAll_Managers_Tests;

#region DbConnection_Test
internal class DbConnection_Test
{
    #region Private : Fields
    private IDbConnection? _dbConnection;
    #endregion

    #region Setup
    [SetUp]
    public void Setup()
    {
        _dbConnection = IoC.Container?.Resolve<IDbConnection>();
    }
    #endregion

    #region Test : Methods
    [Test]
    public void IDbConnectionState_Test()
    {
        using (_dbConnection)
            try
            {
                Assert.That(_dbConnection, Is.Not.Null);
                if (_dbConnection?.State == ConnectionState.Closed)
                    _dbConnection.Open();
                Assert.That(_dbConnection?.State, Is.EqualTo(ConnectionState.Open));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        //finally
        //{
        //    if (_dbConnection?.State == ConnectionState.Open)
        //        _dbConnection.Close();
        //    Assert.That(_dbConnection?.State, Is.EqualTo(ConnectionState.Closed));
        //}
        Assert.That(_dbConnection?.State, Is.EqualTo(ConnectionState.Closed));
    }

    [Test]
    public void IDbConnectionConnectionStringNUllOrEmpty_Test()
    {
        try
        {
            using (_dbConnection)
                Assert.That(_dbConnection?.ConnectionString, Is.Not.Null);
            Assert.That(_dbConnection?.ConnectionString, Is.EqualTo(string.Empty));
            var resolvedDbConnectionAfterUsing = IoC.Container?.Resolve<IDbConnection>();
            Assert.That(resolvedDbConnectionAfterUsing?.ConnectionString, Is.Not.Null);
            Assert.That(resolvedDbConnectionAfterUsing?.ConnectionString, Is.Not.EqualTo(string.Empty));
        }
        catch (Exception ex)
        {
            Assert.Fail(ex.Message);
        }
    }
    #endregion
}
#endregion