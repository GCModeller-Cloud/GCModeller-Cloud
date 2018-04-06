REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @4/6/2018 2:21:48 PM


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
''' DROP TABLE IF EXISTS `task`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `task` (
'''   `id` int(11) NOT NULL AUTO_INCREMENT,
'''   `user_id` int(11) NOT NULL,
'''   `project_id` int(11) NOT NULL,
'''   `title` varchar(128) NOT NULL,
'''   `note` tinytext,
'''   `create_time` datetime NOT NULL,
'''   `status` int(11) NOT NULL,
'''   `parameters` longtext NOT NULL,
'''   PRIMARY KEY (`id`),
'''   UNIQUE KEY `id_UNIQUE` (`id`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("task", Database:="biocad", SchemaSQL:="
CREATE TABLE `task` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `project_id` int(11) NOT NULL,
  `title` varchar(128) NOT NULL,
  `note` tinytext,
  `create_time` datetime NOT NULL,
  `status` int(11) NOT NULL,
  `parameters` longtext NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class task: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="id"), XmlAttribute> Public Property id As Long
    <DatabaseField("user_id"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="user_id")> Public Property user_id As Long
    <DatabaseField("project_id"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="project_id")> Public Property project_id As Long
    <DatabaseField("title"), NotNull, DataType(MySqlDbType.VarChar, "128"), Column(Name:="title")> Public Property title As String
    <DatabaseField("note"), DataType(MySqlDbType.Text), Column(Name:="note")> Public Property note As String
    <DatabaseField("create_time"), NotNull, DataType(MySqlDbType.DateTime), Column(Name:="create_time")> Public Property create_time As Date
    <DatabaseField("status"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="status")> Public Property status As Long
    <DatabaseField("parameters"), NotNull, DataType(MySqlDbType.Text), Column(Name:="parameters")> Public Property parameters As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `task` (`id`, `user_id`, `project_id`, `title`, `note`, `create_time`, `status`, `parameters`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `task` (`id`, `user_id`, `project_id`, `title`, `note`, `create_time`, `status`, `parameters`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `task` WHERE `id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `task` SET `id`='{0}', `user_id`='{1}', `project_id`='{2}', `title`='{3}', `note`='{4}', `create_time`='{5}', `status`='{6}', `parameters`='{7}' WHERE `id` = '{8}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `task` WHERE `id` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, id)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `task` (`id`, `user_id`, `project_id`, `title`, `note`, `create_time`, `status`, `parameters`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, id, user_id, project_id, title, note, MySqlScript.ToMySqlDateTimeString(create_time), status, parameters)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{id}', '{user_id}', '{project_id}', '{title}', '{note}', '{create_time}', '{status}', '{parameters}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `task` (`id`, `user_id`, `project_id`, `title`, `note`, `create_time`, `status`, `parameters`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, id, user_id, project_id, title, note, MySqlScript.ToMySqlDateTimeString(create_time), status, parameters)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `task` SET `id`='{0}', `user_id`='{1}', `project_id`='{2}', `title`='{3}', `note`='{4}', `create_time`='{5}', `status`='{6}', `parameters`='{7}' WHERE `id` = '{8}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, id, user_id, project_id, title, note, MySqlScript.ToMySqlDateTimeString(create_time), status, parameters, id)
    End Function
#End Region
Public Function Clone() As task
                  Return DirectCast(MyClass.MemberwiseClone, task)
              End Function
End Class


End Namespace
