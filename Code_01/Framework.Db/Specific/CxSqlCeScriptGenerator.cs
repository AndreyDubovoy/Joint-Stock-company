/*=====================================================================================
 * This class should be used for connection to MSSQL Compact database. 
 * It is commented because it is not required for now.
 * ==================================================================================*/

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using Framework.Utils;
// 
// namespace Framework.Db.Specific
// {
//   internal class CxSqlCeScriptGenerator : CxDbScriptGenerator
//   {
//     public CxSqlCeScriptGenerator(CxSqlCeConnection connection) : base(connection)
//     {
//     }
//     //----------------------------------------------------------------------------
//     /// <summary>
//     /// Returns SQL text for getting top N records from the original SQL statement result.
//     /// </summary>
//     /// <param name="sqlText">original SQL text</param>
//     /// <param name="topCount">amount of top records to obtain</param>
//     /// <returns>modified SQL text</returns>
//     override public string GetTopRecordsSqlText(string sqlText, int topCount)
//     {
//       return "SELECT TOP(" + topCount + ") data.* FROM (" + sqlText + ") data";
//     }
//     //----------------------------------------------------------------------------
//     /// <summary>
//     /// Returns lock clause for SELECT statement.
//     /// </summary>
//     override public string GetLockClauseForSelect()
//     {
//       return "WITH (HOLDLOCK)";
//     }
//     //----------------------------------------------------------------------------
//     /// <summary>
//     /// Returns the field name in a format that eliminates incorrect field-name
//     /// comprehension by the DBMS layer. 
//     /// That means, all the field-names should be percepted by SQL server as 
//     /// field-names, doesn't matter if they're equal to SQL keyword.
//     /// </summary>
//     /// <param name="fieldName">a field name to be casted explicitly</param>
//     /// <returns>an explicit cast of the given field name</returns>
//     public override string GetExplicitFieldName(string fieldName)
//     {
//       return "[" + fieldName + "]";
//     }
//     //----------------------------------------------------------------------------
//     /// <summary>
//     /// Adds row count limitation to the query depending on the database type.
//     /// </summary>
//     /// <param name="sql">SQL SELECT statement to add limitation to</param>
//     /// <param name="rowCount">number of rows to return</param>
//     /// <returns>SQl SELECT statment with row count limitation</returns>
//     public override string AddRowCountLimitation(string sql, int rowCount)
//     {
//       string s = CxText.TrimSpace(sql);
//       if (s.ToLower().StartsWith("select"))
//         return s.Insert("select".Length, " top(" + rowCount + ") ");
//       else
//         return sql;
//     }
//     //----------------------------------------------------------------------------
//     /// <summary>
//     /// Returns substitute for the parameter in the provider-dependent format.
//     /// </summary>
//     /// <param name="name">cross-provider parameter name</param>
//     /// <param name="index">parameter index</param>
//     /// <returns>substitute for the parameter in the provider-dependent format</returns>
//     override public string PrepareParameterSubstitute(string name, int index)
//     {
//       return (name.StartsWith("@") ? name : "@" + name);
//     }
//     //----------------------------------------------------------------------------
//     /// <summary>
//     /// Returns parameter name in the provider-dependent format.
//     /// </summary>
//     /// <param name="name">cross-provider parameter name</param>
//     /// <param name="index">parameter index</param>
//     /// <returns>parameter name in the provider-dependent format</returns>
//     override public string PrepareParameterName(string name, int index)
//     {
//       return (name.StartsWith("@") ? name : "@" + name);
//     }
//     //----------------------------------------------------------------------------
//   }
// }
