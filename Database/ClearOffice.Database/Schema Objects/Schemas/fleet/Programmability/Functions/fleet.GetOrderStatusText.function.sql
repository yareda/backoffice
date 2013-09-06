
CREATE  FUNCTION [fleet].[GetOrderStatusText](@Status as int)
RETURNS nvarchar(20)

AS 

BEGIN
DECLARE @Text as nvarchar(20)
	IF @Status = 0
		SET @Text = 'Prepared'
	ELSE IF @Status = 1 
		SET @Text = 'Printed'
	ELSE IF @Status = 2 
		SET @Text = 'Void'
	ELSE 
		SET @Text = 'Posted'
		
	RETURN @Text
END