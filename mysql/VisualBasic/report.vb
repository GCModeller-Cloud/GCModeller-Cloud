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
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("report", Database:="bioCAD", SchemaSQL:="
CREATE TABLE IF NOT EXISTS `bioCAD`.`report` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `user_id` INT NOT NULL,
  `project_id` INT NOT NULL,
  `create_time` DATETIME NOT NULL,
  `analysis_list` MEDIUMTEXT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC))
ENGINE = InnoDB;")>
Public Class report: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="id"), XmlAttribute> Public Property id As Long
    <DatabaseField("user_id"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="user_id")> Public Property user_id As Long
    <DatabaseField("project_id"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="project_id")> Public Property project_id As Long
    <DatabaseField("create_time"), NotNull, DataType(MySqlDbType.DateTime), Column(Name:="create_time")> Public Property create_time As Date
    <DatabaseField("analysis_list"), NotNull, DataType(MySqlDbType.Text), Column(Name:="analysis_list")> Public Property analysis_list As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `report` (`id`, `user_id`, `project_id`, `create_time`, `analysis_list`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `report` (`id`, `user_id`, `project_id`, `create_time`, `analysis_list`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `report` WHERE `id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `report` SET `id`='{0}', `user_id`='{1}', `project_id`='{2}', `create_time`='{3}', `analysis_list`='{4}' WHERE `id` = '{5}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `report` WHERE `id` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, id)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `report` (`id`, `user_id`, `project_id`, `create_time`, `analysis_list`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, id, user_id, project_id, MySqlScript.ToMySqlDateTimeString(create_time), analysis_list)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{id}', '{user_id}', '{project_id}', '{create_time}', '{analysis_list}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `report` (`id`, `user_id`, `project_id`, `create_time`, `analysis_list`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, id, user_id, project_id, MySqlScript.ToMySqlDateTimeString(create_time), analysis_list)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `report` SET `id`='{0}', `user_id`='{1}', `project_id`='{2}', `create_time`='{3}', `analysis_list`='{4}' WHERE `id` = '{5}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, id, user_id, project_id, MySqlScript.ToMySqlDateTimeString(create_time), analysis_list, id)
    End Function
#End Region
Public Function Clone() As report
                  Return DirectCast(MyClass.MemberwiseClone, report)
              End Function
End Class


End Namespace
