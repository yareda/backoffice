-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [wms].[return_invoice_status_text] 
(
	@invoice_id as int 
)
RETURNS nvarchar(50)
AS
BEGIN
	Declare @inv_total as decimal;
	declare @inv_rec_total as decimal;
	
	select @inv_total = wms.invoice_list_info.invoice_total,@inv_rec_total = wms.invoice_list_info.received_total
	from wms.invoice_list_info
	where wms.invoice_list_info.id = @invoice_id
	
	if @inv_total > @inv_rec_total
	begin
		return 'Out Standing';
	end
	return 'Paid in Full';
END