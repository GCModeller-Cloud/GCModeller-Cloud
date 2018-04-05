REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @4/5/2018 11:12:58 AM


Imports System.Data.Linq.Mapping
Imports System.Xml.Serialization
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes
Imports MySqlScript = Oracle.LinuxCompatibility.MySQL.Scripting.Extensions

Namespace MySql

''' <summary>
''' ```SQL
''' Statistics
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `user_activity`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `user_activity` (
'''   `id` int(11) NOT NULL AUTO_INCREMENT,
'''   `user_id` int(11) NOT NULL,
'''   `ip` varchar(45) NOT NULL,
'''   `api` varchar(128) NOT NULL COMMENT 'web api',
'''   `method` varchar(16) NOT NULL COMMENT 'GET/POST/PUT/DELETE, etc',
'''   `status_code` int(11) NOT NULL DEFAULT '200' COMMENT '200: api call success\n500: api call throw exception\n403: access denied\n404: app not found',
'''   `time` datetime NOT NULL,
'''   PRIMARY KEY (`id`),
'''   UNIQUE KEY `id_UNIQUE` (`id`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Statistics';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("user_activity", Database:="biocad", SchemaSQL:="
CREATE TABLE `user_activity` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `ip` varchar(45) NOT NULL,
  `api` varchar(128) NOT NULL COMMENT 'web api',
  `method` varchar(16) NOT NULL COMMENT 'GET/POST/PUT/DELETE, etc',
  `status_code` int(11) NOT NULL DEFAULT '200' COMMENT '200: api call success\n500: api call throw exception\n403: access denied\n404: app not found',
  `time` datetime NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Statistics';")>
Public Class user_activity: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="id"), XmlAttribute> Public Property id As Long
    <DatabaseField("user_id"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="user_id")> Public Property user_id As Long
    <DatabaseField("ip"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="ip")> Public Property ip As String
''' <summary>
''' web api
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("api"), NotNull, DataType(MySqlDbType.VarChar, "128"), Column(Name:="api")> Public Property api As String
''' <summary>
''' GET/POST/PUT/DELETE, etc
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("method"), NotNull, DataType(MySqlDbType.VarChar, "16"), Column(Name:="method")> Public Property method As String
''' <summary>
''' 200: api call success\n500: api call throw exception\n403: access denied\n404: app not found
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("status_code"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="status_code")> Public Property status_code As Long
    <DatabaseField("time"), NotNull, DataType(MySqlDbType.DateTime), Column(Name:="time")> Public Property time As Date
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `user_activity` (`id`, `user_id`, `ip`, `api`, `method`, `status_code`, `time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `user_activity` (`id`, `user_id`, `ip`, `api`, `method`, `status_code`, `time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `user_activity` WHERE `id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `user_activity` SET `id`='{0}', `user_id`='{1}', `ip`='{2}', `api`='{3}', `method`='{4}', `status_code`='{5}', `time`='{6}' WHERE `id` = '{7}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `user_activity` WHERE `id` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, id)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `user_activity` (`id`, `user_id`, `ip`, `api`, `method`, `status_code`, `time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, id, user_id, ip, api, method, status_code, MySqlScript.ToMySqlDateTimeString(time))
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{id}', '{user_id}', '{ip}', '{api}', '{method}', '{status_code}', '{time}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `user_activity` (`id`, `user_id`, `ip`, `api`, `method`, `status_code`, `time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, id, user_id, ip, api, method, status_code, MySqlScript.ToMySqlDateTimeString(time))
    End Function
''' <summary>
''' ```SQL
''' UPDATE `user_activity` SET `id`='{0}', `user_id`='{1}', `ip`='{2}', `api`='{3}', `method`='{4}', `status_code`='{5}', `time`='{6}' WHERE `id` = '{7}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, id, user_id, ip, api, method, status_code, MySqlScript.ToMySqlDateTimeString(time), id)
    End Function
#End Region
Public Function Clone() As user_activity
                  Return DirectCast(MyClass.MemberwiseClone, user_activity)
              End Function
End Class


End Namespace
