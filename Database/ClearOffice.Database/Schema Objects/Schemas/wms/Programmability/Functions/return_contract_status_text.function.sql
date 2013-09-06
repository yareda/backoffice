-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION wms.return_contract_status_text 
(
	@status as int 
)
RETURNS nvarchar(50)
AS
BEGIN
	if @status = 0
	begin
		return 'Inactive'
	end
	return 'Active'
END