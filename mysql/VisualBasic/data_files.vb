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
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("data_files", Database:="bioCAD", SchemaSQL:="
CREATE TABLE IF NOT EXISTS `bioCAD`.`data_files` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `user_id` INT NOT NULL COMMENT '这个文件拥有者的用户表编号',
  `name` VARCHAR(128) NOT NULL COMMENT '从浏览器端得到的原始文件名',
  `suffix` VARCHAR(16) NOT NULL,
  `uri` VARCHAR(256) NOT NULL COMMENT '文件在服务器上面的真实路径，为了保护用户数据，用户所上传的数据文件的文件名都是经过随机唯一编码的，所以会需要使用这个字段来记录文件的真实路径',
  `size` INT NOT NULL,
  `upload_time` DATETIME NOT NULL,
  `md5` VARCHAR(32) NOT NULL,
  `description` MEDIUMTEXT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC))
ENGINE = InnoDB
COMMENT = '共享文件池';")>
Public Class data_files: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="id"), XmlAttribute> Public Property id As Long
''' <summary>
''' 这个文件拥有者的用户表编号
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("user_id"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="user_id")> Public Property user_id As Long
''' <summary>
''' 从浏览器端得到的原始文件名
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("name"), NotNull, DataType(MySqlDbType.VarChar, "128"), Column(Name:="name")> Public Property name As String
    <DatabaseField("suffix"), NotNull, DataType(MySqlDbType.VarChar, "16"), Column(Name:="suffix")> Public Property suffix As String
''' <summary>
''' 文件在服务器上面的真实路径，为了保护用户数据，用户所上传的数据文件的文件名都是经过随机唯一编码的，所以会需要使用这个字段来记录文件的真实路径
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("uri"), NotNull, DataType(MySqlDbType.VarChar, "256"), Column(Name:="uri")> Public Property uri As String
    <DatabaseField("size"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="size")> Public Property size As Long
    <DatabaseField("upload_time"), NotNull, DataType(MySqlDbType.DateTime), Column(Name:="upload_time")> Public Property upload_time As Date
    <DatabaseField("md5"), NotNull, DataType(MySqlDbType.VarChar, "32"), Column(Name:="md5")> Public Property md5 As String
    <DatabaseField("description"), DataType(MySqlDbType.Text), Column(Name:="description")> Public Property description As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `data_files` (`id`, `user_id`, `name`, `suffix`, `uri`, `size`, `upload_time`, `md5`, `description`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `data_files` (`id`, `user_id`, `name`, `suffix`, `uri`, `size`, `upload_time`, `md5`, `description`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `data_files` WHERE `id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `data_files` SET `id`='{0}', `user_id`='{1}', `name`='{2}', `suffix`='{3}', `uri`='{4}', `size`='{5}', `upload_time`='{6}', `md5`='{7}', `description`='{8}' WHERE `id` = '{9}';</SQL>
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
''' INSERT INTO `data_files` (`id`, `user_id`, `name`, `suffix`, `uri`, `size`, `upload_time`, `md5`, `description`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, id, user_id, name, suffix, uri, size, MySqlScript.ToMySqlDateTimeString(upload_time), md5, description)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{id}', '{user_id}', '{name}', '{suffix}', '{uri}', '{size}', '{upload_time}', '{md5}', '{description}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `data_files` (`id`, `user_id`, `name`, `suffix`, `uri`, `size`, `upload_time`, `md5`, `description`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, id, user_id, name, suffix, uri, size, MySqlScript.ToMySqlDateTimeString(upload_time), md5, description)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `data_files` SET `id`='{0}', `user_id`='{1}', `name`='{2}', `suffix`='{3}', `uri`='{4}', `size`='{5}', `upload_time`='{6}', `md5`='{7}', `description`='{8}' WHERE `id` = '{9}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, id, user_id, name, suffix, uri, size, MySqlScript.ToMySqlDateTimeString(upload_time), md5, description, id)
    End Function
#End Region
Public Function Clone() As data_files
                  Return DirectCast(MyClass.MemberwiseClone, data_files)
              End Function
End Class


End Namespace
