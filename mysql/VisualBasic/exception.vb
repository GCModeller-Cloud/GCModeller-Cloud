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
''' 程序的错误信息表
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `exception`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `exception` (
'''   `id` int(11) NOT NULL COMMENT '(user_activity id for code 500) 当在用户活动表之中出现500错误的时候，所记录下的对应的用于程序调试的错误信息，这个id是对应的用户活动表的记录id',
'''   `expression` longtext NOT NULL COMMENT '产生这个错误所需要的表达式，包括：\n\n+ SQL查询语句\n+ 命令行命令',
'''   `stack_trace` longtext NOT NULL COMMENT '堆栈追踪信息',
'''   PRIMARY KEY (`id`),
'''   UNIQUE KEY `id_UNIQUE` (`id`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='程序的错误信息表';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("exception", Database:="biocad", SchemaSQL:="
CREATE TABLE `exception` (
  `id` int(11) NOT NULL COMMENT '(user_activity id for code 500) 当在用户活动表之中出现500错误的时候，所记录下的对应的用于程序调试的错误信息，这个id是对应的用户活动表的记录id',
  `expression` longtext NOT NULL COMMENT '产生这个错误所需要的表达式，包括：\n\n+ SQL查询语句\n+ 命令行命令',
  `stack_trace` longtext NOT NULL COMMENT '堆栈追踪信息',
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='程序的错误信息表';")>
Public Class exception: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
''' <summary>
''' (user_activity id for code 500) 当在用户活动表之中出现500错误的时候，所记录下的对应的用于程序调试的错误信息，这个id是对应的用户活动表的记录id
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("id"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="id"), XmlAttribute> Public Property id As Long
''' <summary>
''' 产生这个错误所需要的表达式，包括：\n\n+ SQL查询语句\n+ 命令行命令
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("expression"), NotNull, DataType(MySqlDbType.Text), Column(Name:="expression")> Public Property expression As String
''' <summary>
''' 堆栈追踪信息
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("stack_trace"), NotNull, DataType(MySqlDbType.Text), Column(Name:="stack_trace")> Public Property stack_trace As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Friend Shared ReadOnly INSERT_SQL$ = 
        <SQL>INSERT INTO `exception` (`id`, `expression`, `stack_trace`) VALUES ('{0}', '{1}', '{2}');</SQL>

    Friend Shared ReadOnly INSERT_AI_SQL$ = 
        <SQL>INSERT INTO `exception` (`id`, `expression`, `stack_trace`) VALUES ('{0}', '{1}', '{2}');</SQL>

    Friend Shared ReadOnly REPLACE_SQL$ = 
        <SQL>REPLACE INTO `exception` (`id`, `expression`, `stack_trace`) VALUES ('{0}', '{1}', '{2}');</SQL>

    Friend Shared ReadOnly REPLACE_AI_SQL$ = 
        <SQL>REPLACE INTO `exception` (`id`, `expression`, `stack_trace`) VALUES ('{0}', '{1}', '{2}');</SQL>

    Friend Shared ReadOnly DELETE_SQL$ =
        <SQL>DELETE FROM `exception` WHERE `id` = '{0}';</SQL>

    Friend Shared ReadOnly UPDATE_SQL$ = 
        <SQL>UPDATE `exception` SET `id`='{0}', `expression`='{1}', `stack_trace`='{2}' WHERE `id` = '{3}';</SQL>

#End Region

''' <summary>
''' ```SQL
''' DELETE FROM `exception` WHERE `id` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, id)
    End Function

''' <summary>
''' ```SQL
''' INSERT INTO `exception` (`id`, `expression`, `stack_trace`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, id, expression, stack_trace)
    End Function

''' <summary>
''' ```SQL
''' INSERT INTO `exception` (`id`, `expression`, `stack_trace`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL(AI As Boolean) As String
        If AI Then
        Return String.Format(INSERT_AI_SQL, id, expression, stack_trace)
        Else
        Return String.Format(INSERT_SQL, id, expression, stack_trace)
        End If
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue(AI As Boolean) As String
        If AI Then
            Return $"('{id}', '{expression}', '{stack_trace}')"
        Else
            Return $"('{id}', '{expression}', '{stack_trace}')"
        End If
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `exception` (`id`, `expression`, `stack_trace`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, id, expression, stack_trace)
    End Function

''' <summary>
''' ```SQL
''' REPLACE INTO `exception` (`id`, `expression`, `stack_trace`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL(AI As Boolean) As String
        If AI Then
        Return String.Format(REPLACE_AI_SQL, id, expression, stack_trace)
        Else
        Return String.Format(REPLACE_SQL, id, expression, stack_trace)
        End If
    End Function

''' <summary>
''' ```SQL
''' UPDATE `exception` SET `id`='{0}', `expression`='{1}', `stack_trace`='{2}' WHERE `id` = '{3}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, id, expression, stack_trace, id)
    End Function
#End Region

''' <summary>
                     ''' Memberwise clone of current table Object.
                     ''' </summary>
                     Public Function Clone() As exception
                         Return DirectCast(MyClass.MemberwiseClone, exception)
                     End Function
End Class


End Namespace
