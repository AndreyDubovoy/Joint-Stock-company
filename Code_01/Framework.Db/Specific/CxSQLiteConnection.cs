using System.Data;
using System.Data.Common;
using System.Data.SQLite;


namespace Framework.Db
{
  /// <summary>
  /// Class that encapsulates SQLite connection.
  /// </summary>
  class CxSQLiteConnection : CxDbConnection
  {
    //--------------------------------------------------------------------------
    /// <summary>
    /// Constructor.
    /// </summary>
    protected internal CxSQLiteConnection()
    {
      m_Connection = new SQLiteConnection();
      m_DatabaseType = NxDatabaseType.SQLite;
    }
    //--------------------------------------------------------------------------
    /// <summary>
    /// Composes connection string.
    /// </summary>
    /// <param name="tnsAlias">TNS Alias</param>
    /// <param name="userName">user name</param>
    /// <param name="password">password</param>
    /// <returns>connection string for the given parameters</returns>
    static public string ComposeConnectionString(string tnsFileName)
    {
      string s = string.Format("Data Source={0};", tnsFileName);
      return s;
    }
    //--------------------------------------------------------------------------
    /// <summary>
    /// Creates database command.
    /// </summary>
    /// <returns>created command</returns>
    override protected IDbCommand CreateCommand()
    {
      return new SQLiteCommand();
    }
    //----------------------------------------------------------------------------
    /// <summary>
    /// Creates data adapter.
    /// </summary>
    /// <param name="command">database command to create adapter for</param>
    /// <returns>created data adapter</returns>
    override protected DbDataAdapter CreateDataAdapter(IDbCommand command)
    {
      return new SQLiteDataAdapter((SQLiteCommand)command);
    }
    //----------------------------------------------------------------------------
    /// <summary>
    /// Creates database parameter.
    /// </summary>
    /// <returns>created parameter</returns>
    override protected IDataParameter CreateParameter()
    {
      return new SQLiteParameter();
    }
    //----------------------------------------------------------------------------
    /// <summary>
    /// Creates database LOB parameter.
    /// </summary>
    /// <param name="lobType">type of the LOB this parameter represents</param>
    /// <param name="size">paremeter size</param>
    /// <returns>created parameter</returns>
    override protected IDataParameter CreateParameterLob(NxLobType lobType, int size)
    {
      SQLiteParameter parameter = (SQLiteParameter)CreateParameter();
      parameter.DbType = DbType.Object;

      parameter.Size = size;
      return parameter;
    }
    //----------------------------------------------------------------------------
    protected override CxDbScriptGenerator CreateScriptGenerator()
    {
      return new CxSQLiteScriptGenerator(this);
    }
    //----------------------------------------------------------------------------

  }
}
