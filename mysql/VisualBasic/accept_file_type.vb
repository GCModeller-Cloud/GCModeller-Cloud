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
''' DROP TABLE IF EXISTS `accept_file_type`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `accept_file_type` (
'''   `id` int(11) NOT NULL AUTO_INCREMENT,
'''   `app_id` int(11) NOT NULL,
'''   `content_type` int(11) NOT NULL,
'''   `note` mediumtext,
'''   PRIMARY KEY (`id`),
'''   UNIQUE KEY `id_UNIQUE` (`id`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("accept_file_type", Database:="biocad", SchemaSQL:="
CREATE TABLE `accept_file_type` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `app_id` int(11) NOT NULL,
  `content_type` int(11) NOT NULL,
  `note` mediumtext,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class accept_file_type: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="id"), XmlAttribute> Public Property id As Long
    <DatabaseField("app_id"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="app_id")> Public Property app_id As Long
    <DatabaseField("content_type"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="content_type")> Public Property content_type As Long
    <DatabaseField("note"), DataType(MySqlDbType.Text), Column(Name:="note")> Public Property note As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Friend Shared ReadOnly INSERT_SQL$ = 
        <SQL>INSERT INTO `accept_file_type` (`app_id`, `content_type`, `note`) VALUES ('{0}', '{1}', '{2}');</SQL>

    Friend Shared ReadOnly INSERT_AI_SQL$ = 
        <SQL>INSERT INTO `accept_file_type` (`id`, `app_id`, `content_type`, `note`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>

    Friend Shared ReadOnly REPLACE_SQL$ = 
        <SQL>REPLACE INTO `accept_file_type` (`app_id`, `content_type`, `note`) VALUES ('{0}', '{1}', '{2}');</SQL>

    Friend Shared ReadOnly REPLACE_AI_SQL$ = 
        <SQL>REPLACE INTO `accept_file_type` (`id`, `app_id`, `content_type`, `note`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>

    Friend Shared ReadOnly DELETE_SQL$ =
        <SQL>DELETE FROM `accept_file_type` WHERE `id` = '{0}';</SQL>

    Friend Shared ReadOnly UPDATE_SQL$ = 
        <SQL>UPDATE `accept_file_type` SET `id`='{0}', `app_id`='{1}', `content_type`='{2}', `note`='{3}' WHERE `id` = '{4}';</SQL>

#End Region

''' <summary>
''' ```SQL
''' DELETE FROM `accept_file_type` WHERE `id` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, id)
    End Function

''' <summary>
''' ```SQL
''' INSERT INTO `accept_file_type` (`id`, `app_id`, `content_type`, `note`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, app_id, content_type, note)
    End Function

''' <summary>
''' ```SQL
''' INSERT INTO `accept_file_type` (`id`, `app_id`, `content_type`, `note`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL(AI As Boolean) As String
        If AI Then
        Return String.Format(INSERT_AI_SQL, id, app_id, content_type, note)
        Else
        Return String.Format(INSERT_SQL, app_id, content_type, note)
        End If
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue(AI As Boolean) As String
        If AI Then
            Return $"('{id}', '{app_id}', '{content_type}', '{note}')"
        Else
            Return $"('{app_id}', '{content_type}', '{note}')"
        End If
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `accept_file_type` (`id`, `app_id`, `content_type`, `note`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, app_id, content_type, note)
    End Function

''' <summary>
''' ```SQL
''' REPLACE INTO `accept_file_type` (`id`, `app_id`, `content_type`, `note`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL(AI As Boolean) As String
        If AI Then
        Return String.Format(REPLACE_AI_SQL, id, app_id, content_type, note)
        Else
        Return String.Format(REPLACE_SQL, app_id, content_type, note)
        End If
    End Function

''' <summary>
''' ```SQL
''' UPDATE `accept_file_type` SET `id`='{0}', `app_id`='{1}', `content_type`='{2}', `note`='{3}' WHERE `id` = '{4}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, id, app_id, content_type, note, id)
    End Function
#End Region

''' <summary>
                     ''' Memberwise clone of current table Object.
                     ''' </summary>
                     Public Function Clone() As accept_file_type
                         Return DirectCast(MyClass.MemberwiseClone, accept_file_type)
                     End Function
End Class


End Namespace
