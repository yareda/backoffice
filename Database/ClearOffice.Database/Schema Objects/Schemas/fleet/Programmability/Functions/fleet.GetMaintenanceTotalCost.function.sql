
CREATE FUNCTION [fleet].[GetMaintenanceTotalCost] 
(
	@mid AS INT
)
RETURNS DECIMAL
AS
BEGIN
	DECLARE @ret_val AS DECIMAL
	DECLARE @totalExp AS DECIMAL
	DECLARE @partCost AS DECIMAL
	DECLARE @labourCost AS DECIMAL
	IF @mid IS NOT NULL
	BEGIN
		SELECT @totalExp = SUM(fleet.expense.amount)
		FROM fleet.maintenance_expense
		INNER JOIN fleet.expense ON fleet.maintenance_expense.expense_id = fleet.expense.expense_id
		WHERE fleet.maintenance_expense.maintenance_id = @mid
		GROUP BY fleet.maintenance_expense.maintenance_id	
		
		SELECT @partCost = SUM(fleet.maintenance_part.unit_price*fleet.maintenance_part.quantity)
		FROM fleet.maintenance_part
		WHERE fleet.maintenance_part.maintenance_id = @mid
		GROUP BY fleet.maintenance_part.maintenance_id
		
		SELECT @labourCost = SUM(fleet.maintenance_activity.labor_units*fleet.maintenance_activity.unit_cost)
		FROM fleet.maintenance_activity
		WHERE fleet.maintenance_activity.maintenance_id = @mid
		GROUP BY fleet.maintenance_activity.maintenance_id
		
		IF @totalExp IS NULL
			SET @totalExp = 0
		IF @partCost IS NULL
			SET @partCost = 0
		IF @labourCost IS NULL
			SET @labourCost = 0
			
		SET @ret_val = @totalExp+@labourCost+@partCost
	END
	ELSE
	begin
		SET @ret_val = NULL
	END
	RETURN @ret_val
END