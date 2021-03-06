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
''' 用户的基本信息表
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `user`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `user` (
'''   `id` int(11) NOT NULL AUTO_INCREMENT,
'''   `account` varchar(64) NOT NULL,
'''   `email` varchar(128) NOT NULL,
'''   `password` varchar(32) NOT NULL COMMENT 'lower(md5)',
'''   `role` int(11) NOT NULL DEFAULT '0' COMMENT '用户在这个网站上面的角色类型',
'''   `create_time` datetime NOT NULL,
'''   PRIMARY KEY (`id`),
'''   UNIQUE KEY `id_UNIQUE` (`id`),
'''   UNIQUE KEY `account_UNIQUE` (`account`),
'''   UNIQUE KEY `email_UNIQUE` (`email`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='用户的基本信息表';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("user", Database:="biocad", SchemaSQL:="
CREATE TABLE `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `account` varchar(64) NOT NULL,
  `email` varchar(128) NOT NULL,
  `password` varchar(32) NOT NULL COMMENT 'lower(md5)',
  `role` int(11) NOT NULL DEFAULT '0' COMMENT '用户在这个网站上面的角色类型',
  `create_time` datetime NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `account_UNIQUE` (`account`),
  UNIQUE KEY `email_UNIQUE` (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='用户的基本信息表';")>
Public Class user: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="id"), XmlAttribute> Public Property id As Long
    <DatabaseField("account"), NotNull, DataType(MySqlDbType.VarChar, "64"), Column(Name:="account")> Public Property account As String
    <DatabaseField("email"), NotNull, DataType(MySqlDbType.VarChar, "128"), Column(Name:="email")> Public Property email As String
''' <summary>
''' lower(md5)
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("password"), NotNull, DataType(MySqlDbType.VarChar, "32"), Column(Name:="password")> Public Property password As String
''' <summary>
''' 用户在这个网站上面的角色类型
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("role"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="role")> Public Property role As Long
    <DatabaseField("create_time"), NotNull, DataType(MySqlDbType.DateTime), Column(Name:="create_time")> Public Property create_time As Date
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Friend Shared ReadOnly INSERT_SQL$ = 
        <SQL>INSERT INTO `user` (`account`, `email`, `password`, `role`, `create_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>

    Friend Shared ReadOnly INSERT_AI_SQL$ = 
        <SQL>INSERT INTO `user` (`id`, `account`, `email`, `password`, `role`, `create_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');</SQL>

    Friend Shared ReadOnly REPLACE_SQL$ = 
        <SQL>REPLACE INTO `user` (`account`, `email`, `password`, `role`, `create_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>

    Friend Shared ReadOnly REPLACE_AI_SQL$ = 
        <SQL>REPLACE INTO `user` (`id`, `account`, `email`, `password`, `role`, `create_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');</SQL>

    Friend Shared ReadOnly DELETE_SQL$ =
        <SQL>DELETE FROM `user` WHERE `id` = '{0}';</SQL>

    Friend Shared ReadOnly UPDATE_SQL$ = 
        <SQL>UPDATE `user` SET `id`='{0}', `account`='{1}', `email`='{2}', `password`='{3}', `role`='{4}', `create_time`='{5}' WHERE `id` = '{6}';</SQL>

#End Region

''' <summary>
''' ```SQL
''' DELETE FROM `user` WHERE `id` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, id)
    End Function

''' <summary>
''' ```SQL
''' INSERT INTO `user` (`id`, `account`, `email`, `password`, `role`, `create_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, account, email, password, role, MySqlScript.ToMySqlDateTimeString(create_time))
    End Function

''' <summary>
''' ```SQL
''' INSERT INTO `user` (`id`, `account`, `email`, `password`, `role`, `create_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL(AI As Boolean) As String
        If AI Then
        Return String.Format(INSERT_AI_SQL, id, account, email, password, role, MySqlScript.ToMySqlDateTimeString(create_time))
        Else
        Return String.Format(INSERT_SQL, account, email, password, role, MySqlScript.ToMySqlDateTimeString(create_time))
        End If
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue(AI As Boolean) As String
        If AI Then
            Return $"('{id}', '{account}', '{email}', '{password}', '{role}', '{create_time}')"
        Else
            Return $"('{account}', '{email}', '{password}', '{role}', '{create_time}')"
        End If
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `user` (`id`, `account`, `email`, `password`, `role`, `create_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, account, email, password, role, MySqlScript.ToMySqlDateTimeString(create_time))
    End Function

''' <summary>
''' ```SQL
''' REPLACE INTO `user` (`id`, `account`, `email`, `password`, `role`, `create_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL(AI As Boolean) As String
        If AI Then
        Return String.Format(REPLACE_AI_SQL, id, account, email, password, role, MySqlScript.ToMySqlDateTimeString(create_time))
        Else
        Return String.Format(REPLACE_SQL, account, email, password, role, MySqlScript.ToMySqlDateTimeString(create_time))
        End If
    End Function

''' <summary>
''' ```SQL
''' UPDATE `user` SET `id`='{0}', `account`='{1}', `email`='{2}', `password`='{3}', `role`='{4}', `create_time`='{5}' WHERE `id` = '{6}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, id, account, email, password, role, MySqlScript.ToMySqlDateTimeString(create_time), id)
    End Function
#End Region

''' <summary>
                     ''' Memberwise clone of current table Object.
                     ''' </summary>
                     Public Function Clone() As user
                         Return DirectCast(MyClass.MemberwiseClone, user)
                     End Function
End Class


End Namespace
