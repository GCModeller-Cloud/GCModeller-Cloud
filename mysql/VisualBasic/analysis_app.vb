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
''' DROP TABLE IF EXISTS `analysis_app`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `analysis_app` (
'''   `id` int(11) NOT NULL AUTO_INCREMENT,
'''   `description` mediumtext NOT NULL,
'''   `project_type` int(11) NOT NULL,
'''   `update_time` datetime NOT NULL,
'''   `version` varchar(32) NOT NULL DEFAULT '1.0.0.0',
'''   PRIMARY KEY (`id`),
'''   UNIQUE KEY `id_UNIQUE` (`id`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("analysis_app", Database:="biocad", SchemaSQL:="
CREATE TABLE `analysis_app` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `description` mediumtext NOT NULL,
  `project_type` int(11) NOT NULL,
  `update_time` datetime NOT NULL,
  `version` varchar(32) NOT NULL DEFAULT '1.0.0.0',
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class analysis_app: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="id"), XmlAttribute> Public Property id As Long
    <DatabaseField("description"), NotNull, DataType(MySqlDbType.Text), Column(Name:="description")> Public Property description As String
    <DatabaseField("project_type"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="project_type")> Public Property project_type As Long
    <DatabaseField("update_time"), NotNull, DataType(MySqlDbType.DateTime), Column(Name:="update_time")> Public Property update_time As Date
    <DatabaseField("version"), NotNull, DataType(MySqlDbType.VarChar, "32"), Column(Name:="version")> Public Property version As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Friend Shared ReadOnly INSERT_SQL$ = 
        <SQL>INSERT INTO `analysis_app` (`description`, `project_type`, `update_time`, `version`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>

    Friend Shared ReadOnly INSERT_AI_SQL$ = 
        <SQL>INSERT INTO `analysis_app` (`id`, `description`, `project_type`, `update_time`, `version`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>

    Friend Shared ReadOnly REPLACE_SQL$ = 
        <SQL>REPLACE INTO `analysis_app` (`description`, `project_type`, `update_time`, `version`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>

    Friend Shared ReadOnly REPLACE_AI_SQL$ = 
        <SQL>REPLACE INTO `analysis_app` (`id`, `description`, `project_type`, `update_time`, `version`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>

    Friend Shared ReadOnly DELETE_SQL$ =
        <SQL>DELETE FROM `analysis_app` WHERE `id` = '{0}';</SQL>

    Friend Shared ReadOnly UPDATE_SQL$ = 
        <SQL>UPDATE `analysis_app` SET `id`='{0}', `description`='{1}', `project_type`='{2}', `update_time`='{3}', `version`='{4}' WHERE `id` = '{5}';</SQL>

#End Region

''' <summary>
''' ```SQL
''' DELETE FROM `analysis_app` WHERE `id` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, id)
    End Function

''' <summary>
''' ```SQL
''' INSERT INTO `analysis_app` (`id`, `description`, `project_type`, `update_time`, `version`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, description, project_type, MySqlScript.ToMySqlDateTimeString(update_time), version)
    End Function

''' <summary>
''' ```SQL
''' INSERT INTO `analysis_app` (`id`, `description`, `project_type`, `update_time`, `version`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL(AI As Boolean) As String
        If AI Then
        Return String.Format(INSERT_AI_SQL, id, description, project_type, MySqlScript.ToMySqlDateTimeString(update_time), version)
        Else
        Return String.Format(INSERT_SQL, description, project_type, MySqlScript.ToMySqlDateTimeString(update_time), version)
        End If
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue(AI As Boolean) As String
        If AI Then
            Return $"('{id}', '{description}', '{project_type}', '{update_time}', '{version}')"
        Else
            Return $"('{description}', '{project_type}', '{update_time}', '{version}')"
        End If
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `analysis_app` (`id`, `description`, `project_type`, `update_time`, `version`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, description, project_type, MySqlScript.ToMySqlDateTimeString(update_time), version)
    End Function

''' <summary>
''' ```SQL
''' REPLACE INTO `analysis_app` (`id`, `description`, `project_type`, `update_time`, `version`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL(AI As Boolean) As String
        If AI Then
        Return String.Format(REPLACE_AI_SQL, id, description, project_type, MySqlScript.ToMySqlDateTimeString(update_time), version)
        Else
        Return String.Format(REPLACE_SQL, description, project_type, MySqlScript.ToMySqlDateTimeString(update_time), version)
        End If
    End Function

''' <summary>
''' ```SQL
''' UPDATE `analysis_app` SET `id`='{0}', `description`='{1}', `project_type`='{2}', `update_time`='{3}', `version`='{4}' WHERE `id` = '{5}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, id, description, project_type, MySqlScript.ToMySqlDateTimeString(update_time), version, id)
    End Function
#End Region

''' <summary>
                     ''' Memberwise clone of current table Object.
                     ''' </summary>
                     Public Function Clone() As analysis_app
                         Return DirectCast(MyClass.MemberwiseClone, analysis_app)
                     End Function
End Class


End Namespace
