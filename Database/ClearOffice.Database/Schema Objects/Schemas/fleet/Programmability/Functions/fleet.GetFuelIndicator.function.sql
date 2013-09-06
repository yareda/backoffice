CREATE FUNCTION [fleet].[GetFuelIndicator](@ID as int)
RETURNS nvarchar(20)

BEGIN
	DECLARE @Text AS nvarchar(20)
	
	IF @ID = 0 
		SET @Text = 'Empty'
	ELSE IF @ID = 1
		SET @Text = 'Quarter'
	ELSE IF @ID = 2 
		SET @Text = 'Half'
	ELSE 
		SET @Text = 'Three-Fourth'
		
	RETURN @Text
END