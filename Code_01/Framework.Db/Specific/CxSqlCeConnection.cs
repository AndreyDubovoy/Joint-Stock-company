/*=====================================================================================
 * This class should be used for connection to MSSQL Compact database. 
 * It is commented because it is not required for now.
 * ==================================================================================*/

// using System;
// using System.Collections.Generic;
// using System.Data;
// using System.Data.Common;
// using System.Linq;
// using System.Text;
// using System.Data.SqlServerCe;
// using Framework.Utils;
// 
// namespace Framework.Db.Specific
// {
//   public class CxSqlCeConnection : CxDbConnection
//   {
//     //--------------------------------------------------------------------------
//     /// <summary>
//     /// Constructor.
//     /// </summary>
//     protected internal CxSqlCeConnection()
//     {
// 
//       m_Connection = new SqlCeConnection();
//       m_DatabaseType = NxDatabaseType.SqlCe;
//     }
// 
//     //--------------------------------------------------------------------------
//     /// <summary>
//     /// Composes connection string.
//     /// </summary>
//     /// <param name="database"></param>
//     /// <param name="password">password (may be empty)</param>
//     /// <returns>connection string for the given parameters</returns>
//     static public string ComposeConnectionString(string database, string password)
//     {
//       string s = string.Format("Data Source = {0}; Password ='{1}';", database, password);
//       return s;
//     }
// 
//     protected override CxDbScriptGenerator CreateScriptGenerator()
//     {
//       return new CxSqlCeScriptGenerator(this);
//     }
// 
//     protected override IDbCommand CreateCommand()
//     {
//       return new SqlCeCommand();
//     }
// 
//     protected override DbDataAdapter CreateDataAdapter(IDbCommand command)
//     {
//       return new SqlCeDataAdapter((SqlCeCommand)command);
//     }
// 
//     protected override IDataParameter CreateParameter()
//     {
//       return new SqlCeParameter();
//     }
// 
//     protected override IDataParameter CreateParameterLob(NxLobType lobType, int size)
//     {
//       var parameter = (SqlCeParameter)CreateParameter();
//       parameter.SqlDbType = (lobType == NxLobType.NClob ? SqlDbType.NText :
//                              lobType == NxLobType.Clob ? SqlDbType.Text :
//                              lobType == NxLobType.NewBlob ? SqlDbType.VarBinary :
//                                                           SqlDbType.Image);
//       parameter.Size = size;
//       return parameter;
//     }
//   }
// }
