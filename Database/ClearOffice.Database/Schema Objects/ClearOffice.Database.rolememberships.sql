EXECUTE sp_addrolemember @rolename = N'NetSqlAzMan_Users', @membername = N'BUILTIN\Administrators';


GO
EXECUTE sp_addrolemember @rolename = N'NetSqlAzMan_Users', @membername = N'NetSqlAzMan_Administrators';


GO
EXECUTE sp_addrolemember @rolename = N'NetSqlAzMan_Users', @membername = N'NetSqlAzMan_Managers';


GO
EXECUTE sp_addrolemember @rolename = N'NetSqlAzMan_Readers', @membername = N'NetSqlAzMan_Users';


GO
EXECUTE sp_addrolemember @rolename = N'NetSqlAzMan_Readers', @membername = N'BUILTIN\Administrators';


GO
EXECUTE sp_addrolemember @rolename = N'NetSqlAzMan_Readers', @membername = N'NetSqlAzMan_Administrators';


GO
EXECUTE sp_addrolemember @rolename = N'NetSqlAzMan_Readers', @membername = N'NetSqlAzMan_Managers';


GO
EXECUTE sp_addrolemember @rolename = N'NetSqlAzMan_Managers', @membername = N'BUILTIN\Administrators';


GO
EXECUTE sp_addrolemember @rolename = N'NetSqlAzMan_Managers', @membername = N'NetSqlAzMan_Administrators';


GO
EXECUTE sp_addrolemember @rolename = N'NetSqlAzMan_Administrators', @membername = N'BUILTIN\Administrators';

