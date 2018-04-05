REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @4/5/2018 10:31:32 PM


Imports System.Data.Linq.Mapping
Imports System.Xml.Serialization
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes
Imports MySqlScript = Oracle.LinuxCompatibility.MySQL.Scripting.Extensions

Namespace MySql

''' <summary>
''' ```SQL
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("project_files", Database:="bioCAD", SchemaSQL:="
CREATE TABLE IF NOT EXISTS `bioCAD`.`project_files` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `user_id` INT NOT NULL,
  `project_id` INT NOT NULL,
  `file_id` INT NOT NULL,
  `join_time` DATETIME NOT NULL COMMENT '将用户的项目和文件这两个实体之间建立起关联的时间',
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC))
ENGINE = InnoDB
COMMENT = '分析项目和文件池之中的文件的关联关系';")>
Public Class project_files: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="id"), XmlAttribute> Public Property id As Long
    <DatabaseField("user_id"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="user_id")> Public Property user_id As Long
    <DatabaseField("project_id"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="project_id")> Public Property project_id As Long
    <DatabaseField("file_id"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="file_id")> Public Property file_id As Long
''' <summary>
''' 将用户的项目和文件这两个实体之间建立起关联的时间
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("join_time"), NotNull, DataType(MySqlDbType.DateTime), Column(Name:="join_time")> Public Property join_time As Date
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `project_files` (`id`, `user_id`, `project_id`, `file_id`, `join_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `project_files` (`id`, `user_id`, `project_id`, `file_id`, `join_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `project_files` WHERE `id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `project_files` SET `id`='{0}', `user_id`='{1}', `project_id`='{2}', `file_id`='{3}', `join_time`='{4}' WHERE `id` = '{5}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `project_files` WHERE `id` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, id)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `project_files` (`id`, `user_id`, `project_id`, `file_id`, `join_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, id, user_id, project_id, file_id, MySqlScript.ToMySqlDateTimeString(join_time))
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{id}', '{user_id}', '{project_id}', '{file_id}', '{join_time}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `project_files` (`id`, `user_id`, `project_id`, `file_id`, `join_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, id, user_id, project_id, file_id, MySqlScript.ToMySqlDateTimeString(join_time))
    End Function
''' <summary>
''' ```SQL
''' UPDATE `project_files` SET `id`='{0}', `user_id`='{1}', `project_id`='{2}', `file_id`='{3}', `join_time`='{4}' WHERE `id` = '{5}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, id, user_id, project_id, file_id, MySqlScript.ToMySqlDateTimeString(join_time), id)
    End Function
#End Region
Public Function Clone() As project_files
                  Return DirectCast(MyClass.MemberwiseClone, project_files)
              End Function
End Class


End Namespace
