REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @6/24/2018 7:54:54 PM


Imports System.Data.Linq.Mapping
Imports System.Xml.Serialization
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes
Imports MySqlScript = Oracle.LinuxCompatibility.MySQL.Scripting.Extensions

Namespace MySql.bioCAD

''' <summary>
''' ```SQL
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `analysis`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `analysis` (
'''   `id` int(11) NOT NULL AUTO_INCREMENT,
'''   `app` int(11) NOT NULL,
'''   `main_file` int(11) NOT NULL COMMENT '如果分析只需要一个文件，那么就使用这个属性来储存',
'''   `files` tinytext NOT NULL COMMENT '分析文件的id编号的数组的json字符串',
'''   `project` int(11) NOT NULL,
'''   `user_id` int(11) NOT NULL,
'''   `parameters` longtext NOT NULL COMMENT '分析用的参数json',
'''   `create_time` datetime NOT NULL,
'''   `update_time` datetime NOT NULL,
'''   PRIMARY KEY (`id`),
'''   UNIQUE KEY `id_UNIQUE` (`id`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("analysis", Database:="biocad", SchemaSQL:="
CREATE TABLE `analysis` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `app` int(11) NOT NULL,
  `main_file` int(11) NOT NULL COMMENT '如果分析只需要一个文件，那么就使用这个属性来储存',
  `files` tinytext NOT NULL COMMENT '分析文件的id编号的数组的json字符串',
  `project` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `parameters` longtext NOT NULL COMMENT '分析用的参数json',
  `create_time` datetime NOT NULL,
  `update_time` datetime NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
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
    Friend Shared ReadOnly INSERT_SQL$ = 
        <SQL>INSERT INTO `analysis` (`app`, `main_file`, `files`, `project`, `user_id`, `parameters`, `create_time`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');</SQL>

    Friend Shared ReadOnly INSERT_AI_SQL$ = 
        <SQL>INSERT INTO `analysis` (`id`, `app`, `main_file`, `files`, `project`, `user_id`, `parameters`, `create_time`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');</SQL>

    Friend Shared ReadOnly REPLACE_SQL$ = 
        <SQL>REPLACE INTO `analysis` (`app`, `main_file`, `files`, `project`, `user_id`, `parameters`, `create_time`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');</SQL>

    Friend Shared ReadOnly REPLACE_AI_SQL$ = 
        <SQL>REPLACE INTO `analysis` (`id`, `app`, `main_file`, `files`, `project`, `user_id`, `parameters`, `create_time`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');</SQL>

    Friend Shared ReadOnly DELETE_SQL$ =
        <SQL>DELETE FROM `analysis` WHERE `id` = '{0}';</SQL>

    Friend Shared ReadOnly UPDATE_SQL$ = 
        <SQL>UPDATE `analysis` SET `id`='{0}', `app`='{1}', `main_file`='{2}', `files`='{3}', `project`='{4}', `user_id`='{5}', `parameters`='{6}', `create_time`='{7}', `update_time`='{8}' WHERE `id` = '{9}';</SQL>

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
        Return String.Format(INSERT_SQL, app, main_file, files, project, user_id, parameters, MySqlScript.ToMySqlDateTimeString(create_time), MySqlScript.ToMySqlDateTimeString(update_time))
    End Function

''' <summary>
''' ```SQL
''' INSERT INTO `analysis` (`id`, `app`, `main_file`, `files`, `project`, `user_id`, `parameters`, `create_time`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL(AI As Boolean) As String
        If AI Then
        Return String.Format(INSERT_AI_SQL, id, app, main_file, files, project, user_id, parameters, MySqlScript.ToMySqlDateTimeString(create_time), MySqlScript.ToMySqlDateTimeString(update_time))
        Else
        Return String.Format(INSERT_SQL, app, main_file, files, project, user_id, parameters, MySqlScript.ToMySqlDateTimeString(create_time), MySqlScript.ToMySqlDateTimeString(update_time))
        End If
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue(AI As Boolean) As String
        If AI Then
            Return $"('{id}', '{app}', '{main_file}', '{files}', '{project}', '{user_id}', '{parameters}', '{create_time}', '{update_time}')"
        Else
            Return $"('{app}', '{main_file}', '{files}', '{project}', '{user_id}', '{parameters}', '{create_time}', '{update_time}')"
        End If
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `analysis` (`id`, `app`, `main_file`, `files`, `project`, `user_id`, `parameters`, `create_time`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, app, main_file, files, project, user_id, parameters, MySqlScript.ToMySqlDateTimeString(create_time), MySqlScript.ToMySqlDateTimeString(update_time))
    End Function

''' <summary>
''' ```SQL
''' REPLACE INTO `analysis` (`id`, `app`, `main_file`, `files`, `project`, `user_id`, `parameters`, `create_time`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL(AI As Boolean) As String
        If AI Then
        Return String.Format(REPLACE_AI_SQL, id, app, main_file, files, project, user_id, parameters, MySqlScript.ToMySqlDateTimeString(create_time), MySqlScript.ToMySqlDateTimeString(update_time))
        Else
        Return String.Format(REPLACE_SQL, app, main_file, files, project, user_id, parameters, MySqlScript.ToMySqlDateTimeString(create_time), MySqlScript.ToMySqlDateTimeString(update_time))
        End If
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

''' <summary>
                     ''' Memberwise clone of current table Object.
                     ''' </summary>
                     Public Function Clone() As analysis
                         Return DirectCast(MyClass.MemberwiseClone, analysis)
                     End Function
End Class


End Namespace
