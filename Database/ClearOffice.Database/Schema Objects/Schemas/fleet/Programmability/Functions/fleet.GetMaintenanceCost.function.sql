
CREATE FUNCTION [fleet].[GetMaintenanceCost] 
(
	@mid AS INT
)
RETURNS DECIMAL
AS
BEGIN
	DECLARE @val AS DECIMAL
	IF @mid IS NOT NULL
	BEGIN
		SELECT @val= SUM(fleet.expense.amount)
		FROM fleet.maintenance_expense
		INNER JOIN fleet.expense ON fleet.maintenance_expense.expense_id = fleet.expense.expense_id
		WHERE fleet.maintenance_expense.maintenance_id = @mid
		GROUP BY fleet.maintenance_expense.maintenance_id												   
	END
	ELSE
	begin
		SET @val = NULL
	END
	RETURN @val
END