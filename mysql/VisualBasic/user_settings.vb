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
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("user_settings", Database:="bioCAD", SchemaSQL:="
CREATE TABLE IF NOT EXISTS `bioCAD`.`user_settings` (
  `user_id` INT NOT NULL,
  `email_notify.login` INT NOT NULL DEFAULT 1,
  `email_notify.security` INT NOT NULL DEFAULT 1,
  `email_notify.task.start` INT NOT NULL DEFAULT 1,
  `email_notify.task.success` INT NOT NULL DEFAULT 1,
  `email_notify.task.error` INT NOT NULL DEFAULT 1,
  `update_time` DATETIME NOT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE INDEX `user_id_UNIQUE` (`user_id` ASC))
ENGINE = InnoDB
COMMENT = '1: boolean TRUE\n0: boolean FALSE';")>
Public Class user_settings: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("user_id"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="user_id"), XmlAttribute> Public Property user_id As Long
    <DatabaseField("email_notify.login"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="email_notify.login")> Public Property email_notify_login As Long
    <DatabaseField("email_notify.security"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="email_notify.security")> Public Property email_notify_security As Long
    <DatabaseField("email_notify.task.start"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="email_notify.task.start")> Public Property email_notify_task_start As Long
    <DatabaseField("email_notify.task.success"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="email_notify.task.success")> Public Property email_notify_task_success As Long
    <DatabaseField("email_notify.task.error"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="email_notify.task.error")> Public Property email_notify_task_error As Long
    <DatabaseField("update_time"), NotNull, DataType(MySqlDbType.DateTime), Column(Name:="update_time")> Public Property update_time As Date
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `user_settings` (`user_id`, `email_notify.login`, `email_notify.security`, `email_notify.task.start`, `email_notify.task.success`, `email_notify.task.error`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `user_settings` (`user_id`, `email_notify.login`, `email_notify.security`, `email_notify.task.start`, `email_notify.task.success`, `email_notify.task.error`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `user_settings` WHERE `user_id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `user_settings` SET `user_id`='{0}', `email_notify.login`='{1}', `email_notify.security`='{2}', `email_notify.task.start`='{3}', `email_notify.task.success`='{4}', `email_notify.task.error`='{5}', `update_time`='{6}' WHERE `user_id` = '{7}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `user_settings` WHERE `user_id` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, user_id)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `user_settings` (`user_id`, `email_notify.login`, `email_notify.security`, `email_notify.task.start`, `email_notify.task.success`, `email_notify.task.error`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, user_id, email_notify_login, email_notify_security, email_notify_task_start, email_notify_task_success, email_notify_task_error, MySqlScript.ToMySqlDateTimeString(update_time))
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{user_id}', '{email_notify_login}', '{email_notify_security}', '{email_notify_task_start}', '{email_notify_task_success}', '{email_notify_task_error}', '{update_time}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `user_settings` (`user_id`, `email_notify.login`, `email_notify.security`, `email_notify.task.start`, `email_notify.task.success`, `email_notify.task.error`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, user_id, email_notify_login, email_notify_security, email_notify_task_start, email_notify_task_success, email_notify_task_error, MySqlScript.ToMySqlDateTimeString(update_time))
    End Function
''' <summary>
''' ```SQL
''' UPDATE `user_settings` SET `user_id`='{0}', `email_notify.login`='{1}', `email_notify.security`='{2}', `email_notify.task.start`='{3}', `email_notify.task.success`='{4}', `email_notify.task.error`='{5}', `update_time`='{6}' WHERE `user_id` = '{7}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, user_id, email_notify_login, email_notify_security, email_notify_task_start, email_notify_task_success, email_notify_task_error, MySqlScript.ToMySqlDateTimeString(update_time), user_id)
    End Function
#End Region
Public Function Clone() As user_settings
                  Return DirectCast(MyClass.MemberwiseClone, user_settings)
              End Function
End Class


End Namespace
