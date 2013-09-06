-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [fleet].[GetTireStatus](@mounted as bit,@disposed as bit)
RETURNS nvarchar(20)

BEGIN
	DECLARE @text as nvarchar(20)
	
	IF @mounted = 1
		SET @text = 'Mounted'
	ELSE IF @mounted = 0
		SET  @text = 'Unmounted'
	ELSE IF @mounted = 0 and @disposed = 1
		SET @text = 'Disposed'
	ELSE 
		SET @text = 'N/A'
		
	RETURN @text
END
