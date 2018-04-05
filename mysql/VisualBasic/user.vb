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
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `user`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `user` (
'''   `id` int(11) NOT NULL AUTO_INCREMENT,
'''   `account` varchar(64) NOT NULL,
'''   `email` varchar(128) NOT NULL,
'''   `password` varchar(32) NOT NULL,
'''   `role` int(11) NOT NULL DEFAULT '0',
'''   `create_time` datetime NOT NULL,
'''   PRIMARY KEY (`id`),
'''   UNIQUE KEY `id_UNIQUE` (`id`),
'''   UNIQUE KEY `account_UNIQUE` (`account`),
'''   UNIQUE KEY `email_UNIQUE` (`email`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("user", Database:="biocad", SchemaSQL:="
CREATE TABLE `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `account` varchar(64) NOT NULL,
  `email` varchar(128) NOT NULL,
  `password` varchar(32) NOT NULL,
  `role` int(11) NOT NULL DEFAULT '0',
  `create_time` datetime NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `account_UNIQUE` (`account`),
  UNIQUE KEY `email_UNIQUE` (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class user: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="id"), XmlAttribute> Public Property id As Long
    <DatabaseField("account"), NotNull, DataType(MySqlDbType.VarChar, "64"), Column(Name:="account")> Public Property account As String
    <DatabaseField("email"), NotNull, DataType(MySqlDbType.VarChar, "128"), Column(Name:="email")> Public Property email As String
    <DatabaseField("password"), NotNull, DataType(MySqlDbType.VarChar, "32"), Column(Name:="password")> Public Property password As String
    <DatabaseField("role"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="role")> Public Property role As Long
    <DatabaseField("create_time"), NotNull, DataType(MySqlDbType.DateTime), Column(Name:="create_time")> Public Property create_time As Date
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `user` (`id`, `account`, `email`, `password`, `role`, `create_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `user` (`id`, `account`, `email`, `password`, `role`, `create_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `user` WHERE `id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `user` SET `id`='{0}', `account`='{1}', `email`='{2}', `password`='{3}', `role`='{4}', `create_time`='{5}' WHERE `id` = '{6}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `user` WHERE `id` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, id)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `user` (`id`, `account`, `email`, `password`, `role`, `create_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, id, account, email, password, role, MySqlScript.ToMySqlDateTimeString(create_time))
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{id}', '{account}', '{email}', '{password}', '{role}', '{create_time}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `user` (`id`, `account`, `email`, `password`, `role`, `create_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, id, account, email, password, role, MySqlScript.ToMySqlDateTimeString(create_time))
    End Function
''' <summary>
''' ```SQL
''' UPDATE `user` SET `id`='{0}', `account`='{1}', `email`='{2}', `password`='{3}', `role`='{4}', `create_time`='{5}' WHERE `id` = '{6}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, id, account, email, password, role, MySqlScript.ToMySqlDateTimeString(create_time), id)
    End Function
#End Region
Public Function Clone() As user
                  Return DirectCast(MyClass.MemberwiseClone, user)
              End Function
End Class


End Namespace
