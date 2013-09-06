/*-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [wms].[get_workorder_total] 
(
	@workorder_id as int 
)
RETURNS decimal(20,2)
AS
BEGIN
    declare @total_cost as decimal(20,2);
	Declare @part_total as decimal(20,2);
	declare @labour_total as decimal(10,2);
	declare @tax as decimal(10,2);
	declare @discount as decimal(10,2);
	Declare @unit_cost as float;
	declare @quantity as int;
	declare @hour as int
	declare @labour_rate as float;
	declare @temp as decimal(10,2);
	declare @temp2 as decimal(10,2);
	declare @ptemp as decimal(10,2);
	declare @ptemp2 as decimal(10,2);
DECLARE part_cursor CURSOR FOR
	select wms.maintenance_part.unit_cost,wms.maintenance_part.quantity
	from wms.maintenance_part
	where wms.maintenance_part.work_order_id = @workorder_id
	
OPEN part_cursor 
	FETCH NEXT FROM part_cursor 
	        INTO @unit_cost,@quantity
				
WHILE @@FETCH_STATUS=0

BEGIN
	 set @ptemp2 = @part_total;
	 set @ptemp = @unit_cost * @quantity;
	 set @part_total = @ptemp2 + @ptemp;
	 	FETCH NEXT FROM part_cursor 
	        INTO @unit_cost,@quantity
	
END
CLOSE part_cursor
DEALLOCATE part_cursor

declare labour_cursor Cursor For
	select wms.maintenance_labour.[hour],wms.maintenance_labour.labour_rate
	from wms.maintenance_labour
	where wms.maintenance_labour.work_order_id = @workorder_id

open labour_cursor
	fetch next from labour_cursor
	into @hour,@labour_rate
while @@fetch_status =0
begin
	set @labour_total = @labour_total + (@hour*@labour_rate);
		fetch next from labour_cursor
	into @hour,@labour_rate
end
close labour_cursor
deallocate labour_cursor

select @discount=wms.work_order.discount,@tax = wms.work_order.tax
from wms.work_order
where wms.work_order.work_order_id = @workorder_id

 set @temp = (@part_total+@labour_total)*@tax;
 set @temp2 = (@part_total+@labour_total)*@discount;
 set @total_cost =@part_total+@labour_total
 return @part_total;
END*/