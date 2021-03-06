﻿/* 
    NetSqlAzMan GetDBUsers TABLE Function
    ************************************************************************
    Creation Date: August, 23  2006
    Purpose: Retrieve from a DB a list of custom Users (DBUserSid, DBUserName)
    Author: Andrea Ferendeles 
    Revision: 1.0.0.0
    Updated by: <put here your name>
    Parameters: 
	use: 
		1)     SELECT * FROM dbo.GetDBUsers(<storename>, <applicationname>, NULL, NULL)            -- to retrieve all DB Users
		2)     SELECT * FROM dbo.GetDBUsers(<storename>, <applicationname>, <customsid>, NULL)  -- to retrieve DB User with specified <customsid>
		3)     SELECT * FROM dbo.GetDBUsers(<storename>, <applicationname>, NULL, <username>)  -- to retrieve DB User with specified <username>

    Remarks: 
	- Update this Function with your CUSTOM CODE
	- Returned DBUserSid must be unique
	- Returned DBUserName must be unique
*/
CREATE FUNCTION [dbo].[netsqlazman_GetDBUsers] (@StoreName nvarchar(255), @ApplicationName nvarchar(255), @DBUserSid VARBINARY(85) = NULL, @DBUserName nvarchar(255) = NULL)  
RETURNS TABLE 
AS  
RETURN 
	SELECT TOP 100 PERCENT CONVERT(VARBINARY(85), [user_id]) AS DBUserSid, [user_name] AS DBUserName, full_name AS [Full Name],[disabled] AS [Disabled] FROM dbo.[user]
	WHERE 
		(@DBUserSid IS NOT NULL AND CONVERT(VARBINARY(85), [user_id]) = @DBUserSid OR @DBUserSid  IS NULL)
		AND
		(@DBUserName IS NOT NULL AND [user_name] = @DBUserName OR @DBUserName IS NULL)
	ORDER BY [user_name]
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- THIS CODE IS JUST FOR AN EXAMPLE: comment this section and customize "INSERT HERE YOUR CUSTOM T-SQL" section below
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------