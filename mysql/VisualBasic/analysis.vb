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
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("analysis", Database:="bioCAD", SchemaSQL:="
CREATE TABLE IF NOT EXISTS `bioCAD`.`analysis` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `app` INT NOT NULL,
  `main_file` INT NOT NULL COMMENT '如果分析只需要一个文件，那么就使用这个属性来储存',
  `files` TINYTEXT NOT NULL COMMENT '分析文件的id编号的数组的json字符串',
  `project` INT NOT NULL,
  `user_id` INT NOT NULL,
  `parameters` LONGTEXT NOT NULL COMMENT '分析用的参数json',
  `create_time` DATETIME NOT NULL,
  `update_time` DATETIME NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC))
ENGINE = InnoDB;")>
Public Class analysis: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="id"), XmlAttribute> Public Property id As Long
    <DatabaseField("app"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="app")> Public Property app As Long
''' <summary>
''' 如果分析只需要一个文件，那么就使用这个属性来储存
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("main_file"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="main_file")> Public Property main_file As Long
''' <summary>
''' 分析文件的id编号的数组的json字符串
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("files"), NotNull, DataType(MySqlDbType.Text), Column(Name:="files")> Public Property files As String
    <DatabaseField("project"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="project")> Public Property project As Long
    <DatabaseField("user_id"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="user_id")> Public Property user_id As Long
''' <summary>
''' 分析用的参数json
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("parameters"), NotNull, DataType(MySqlDbType.Text), Column(Name:="parameters")> Public Property parameters As String
    <DatabaseField("create_time"), NotNull, DataType(MySqlDbType.DateTime), Column(Name:="create_time")> Public Property create_time As Date
    <DatabaseField("update_time"), NotNull, DataType(MySqlDbType.DateTime), Column(Name:="update_time")> Public Property update_time As Date
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `analysis` (`id`, `app`, `main_file`, `files`, `project`, `user_id`, `parameters`, `create_time`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `analysis` (`id`, `app`, `main_file`, `files`, `project`, `user_id`, `parameters`, `create_time`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `analysis` WHERE `id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `analysis` SET `id`='{0}', `app`='{1}', `main_file`='{2}', `files`='{3}', `project`='{4}', `user_id`='{5}', `parameters`='{6}', `create_time`='{7}', `update_time`='{8}' WHERE `id` = '{9}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `analysis` WHERE `id` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, id)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `analysis` (`id`, `app`, `main_file`, `files`, `project`, `user_id`, `parameters`, `create_time`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, id, app, main_file, files, project, user_id, parameters, MySqlScript.ToMySqlDateTimeString(create_time), MySqlScript.ToMySqlDateTimeString(update_time))
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{id}', '{app}', '{main_file}', '{files}', '{project}', '{user_id}', '{parameters}', '{create_time}', '{update_time}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `analysis` (`id`, `app`, `main_file`, `files`, `project`, `user_id`, `parameters`, `create_time`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, id, app, main_file, files, project, user_id, parameters, MySqlScript.ToMySqlDateTimeString(create_time), MySqlScript.ToMySqlDateTimeString(update_time))
    End Function
''' <summary>
''' ```SQL
''' UPDATE `analysis` SET `id`='{0}', `app`='{1}', `main_file`='{2}', `files`='{3}', `project`='{4}', `user_id`='{5}', `parameters`='{6}', `create_time`='{7}', `update_time`='{8}' WHERE `id` = '{9}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, id, app, main_file, files, project, user_id, parameters, MySqlScript.ToMySqlDateTimeString(create_time), MySqlScript.ToMySqlDateTimeString(update_time), id)
    End Function
#End Region
Public Function Clone() As analysis
                  Return DirectCast(MyClass.MemberwiseClone, analysis)
              End Function
End Class


End Namespace
