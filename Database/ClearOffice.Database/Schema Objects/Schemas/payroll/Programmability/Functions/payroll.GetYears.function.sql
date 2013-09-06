
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION payroll.[GetYears] 
(
	-- Add the parameters for the function here
	@Months int
)
RETURNS int
AS
BEGIN
	declare @val as int
	SET @val = @Months/12
	return @val

END