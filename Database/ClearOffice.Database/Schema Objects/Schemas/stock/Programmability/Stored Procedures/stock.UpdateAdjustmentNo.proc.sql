CREATE PROCEDURE [stock].[UpdateAdjustmentNo]
	@newNo nvarchar(20)	
AS
	UPDATE stock.sequence_counter
	SET adjustment_no=@newNo
	WHERE record_id=1