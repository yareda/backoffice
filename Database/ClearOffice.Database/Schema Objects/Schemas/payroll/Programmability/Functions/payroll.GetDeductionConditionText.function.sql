CREATE FUNCTION [payroll].[GetDeductionConditionText](@condition as int)

RETURNS nvarchar(20)

BEGIN
	DECLARE @Text as nvarchar(20)
	
	IF @condition = 0
		SET @Text = 'After Tax'
	ELSE IF @condition = 1
		SET @Text = 'Before Tax'
	RETURN @Text
END