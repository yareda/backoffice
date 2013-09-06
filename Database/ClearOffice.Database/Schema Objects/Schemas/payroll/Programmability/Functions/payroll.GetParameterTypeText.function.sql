CREATE FUNCTION [payroll].[GetParameterTypeText](@type as int)

RETURNS nvarchar(20)

BEGIN
	DECLARE @Text as nvarchar(20)
	
	IF @type = 1
		SET @Text = 'Earnings'
	ELSE IF @type = 2
		SET @Text = 'Deductions'
	RETURN @Text
END