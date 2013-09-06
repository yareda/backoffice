-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
Create FUNCTION [wms].[calculate_invoice_total] 
(
	@invoice_id as int 
)
RETURNS decimal(10,2)
AS
BEGIN
	Declare @parts_total as decimal(10,2)
	declare @labour_total as decimal(10,2)
	declare @misc_total as decimal(10,2)
	declare @wid as int
	declare @invoice_total as decimal(10,2)
	
	select @wid = wms.invoice.work_order_id
	from wms.invoice
	where wms.invoice.id =@invoice_id
	
	select @parts_total = wms.work_order_value_total.part_total
	from wms.work_order_value_total
	where wms.work_order_value_total.work_order_id = @wid
	
	select @labour_total = wms.work_order_value_total.labor_total
	from wms.work_order_value_total
	where wms.work_order_value_total.work_order_id = @wid
	
	select @misc_total  = wms.miscellaneous_total_info.miscellaneous_total
	from wms.miscellaneous_total_info
	where wms.miscellaneous_total_info.id = @invoice_id
	
	set @invoice_total = @parts_total + @labour_total +@misc_total
	
	return @invoice_total
	
END