
CREATE PROCEDURE [fleet].[ChangeOrderStatus](@OrderId as int, @Status as int)
AS 

UPDATE fuel_lubricant_purchase
SET order_status = @Status
WHERE fuel_order_id = @OrderId