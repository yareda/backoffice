CREATE PROCEDURE [fleet].[sp_Change_Order_State]
 (
	@VehicleId as int
 )
 AS 
 
 DECLARE @Count AS int 
 
 SELECT @Count = COUNT(*) FROM fuel_lubricant_purchase WHERE vehicle_id = @VehicleId
 BEGIN
	IF @Count > 1
		UPDATE fuel_lubricant_purchase
		SET isPrevious = 0
		WHERE vehicle_id = @VehicleId
 END
