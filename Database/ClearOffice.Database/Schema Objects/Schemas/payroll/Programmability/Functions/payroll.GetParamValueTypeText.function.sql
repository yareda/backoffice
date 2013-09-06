CREATE FUNCTION [payroll].[GetParamValueTypeText](@value_type as int)

RETURNS nvarchar(20)

BEGIN
	DECLARE @Text as nvarchar(20)
	
	IF @value_type = 1
		SET @Text = 'Fixed'
	ELSE IF @value_type = 2
		SET @Text = 'Daily'
	ELSE IF @value_type = 3
		SET @Text = 'Hourly'
	ELSE IF @value_type = 4
		SET @Text = 'Variable'
	ELSE IF @value_type = 5
		SET @Text = 'Percentage'
	ELSE IF @value_type = 6
		SET @Text = 'Periodic'
	ELSE IF @value_type = 7
		SET @Text = 'Daily Salary'
	ELSE IF @value_type = 8
		SET @Text = 'Variable In Percent'
	RETURN @Text
END