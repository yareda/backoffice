-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
Create FUNCTION [wms].[get_contract_status_text] 
(
	@status as int 
)
RETURNS nvarchar(50)
AS
BEGIN
	if @status = 0
	begin
		return 'Canceled'
	end
	return 'open'
END