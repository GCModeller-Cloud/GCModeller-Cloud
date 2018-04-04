REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @4/4/2018 11:37:00 PM


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
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("data_files", Database:="bioCAD", SchemaSQL:="
CREATE TABLE IF NOT EXISTS `bioCAD`.`data_files` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(128) NOT NULL,
  `uri` VARCHAR(256) NOT NULL,
  `create_time` DATETIME NOT NULL,
  `user_id` INT NOT NULL,
  `description` MEDIUMTEXT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC))
ENGINE = InnoDB;")>
Public Class data_files: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="id"), XmlAttribute> Public Property id As Long
    <DatabaseField("name"), NotNull, DataType(MySqlDbType.VarChar, "128"), Column(Name:="name")> Public Property name As String
    <DatabaseField("uri"), NotNull, DataType(MySqlDbType.VarChar, "256"), Column(Name:="uri")> Public Property uri As String
    <DatabaseField("create_time"), NotNull, DataType(MySqlDbType.DateTime), Column(Name:="create_time")> Public Property create_time As Date
    <DatabaseField("user_id"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="user_id")> Public Property user_id As Long
    <DatabaseField("description"), DataType(MySqlDbType.Text), Column(Name:="description")> Public Property description As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `data_files` (`id`, `name`, `uri`, `create_time`, `user_id`, `description`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `data_files` (`id`, `name`, `uri`, `create_time`, `user_id`, `description`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `data_files` WHERE `id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `data_files` SET `id`='{0}', `name`='{1}', `uri`='{2}', `create_time`='{3}', `user_id`='{4}', `description`='{5}' WHERE `id` = '{6}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `data_files` WHERE `id` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, id)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `data_files` (`id`, `name`, `uri`, `create_time`, `user_id`, `description`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, id, name, uri, MySqlScript.ToMySqlDateTimeString(create_time), user_id, description)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{id}', '{name}', '{uri}', '{create_time}', '{user_id}', '{description}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `data_files` (`id`, `name`, `uri`, `create_time`, `user_id`, `description`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, id, name, uri, MySqlScript.ToMySqlDateTimeString(create_time), user_id, description)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `data_files` SET `id`='{0}', `name`='{1}', `uri`='{2}', `create_time`='{3}', `user_id`='{4}', `description`='{5}' WHERE `id` = '{6}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, id, name, uri, MySqlScript.ToMySqlDateTimeString(create_time), user_id, description, id)
    End Function
#End Region
Public Function Clone() As data_files
                  Return DirectCast(MyClass.MemberwiseClone, data_files)
              End Function
End Class


End Namespace
