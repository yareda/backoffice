CREATE FUNCTION [payroll].[GetCurrentDate]()
RETURNS datetime

BEGIN
	DECLARE @CurrentDate AS datetime
	SET @CurrentDate =  GETDATE()
	RETURN @CurrentDate	
END