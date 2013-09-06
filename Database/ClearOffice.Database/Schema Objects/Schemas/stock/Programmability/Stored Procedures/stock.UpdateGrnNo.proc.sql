CREATE PROCEDURE [stock].[UpdateGrnNo]
	@newNo nvarchar(20)	
AS
	UPDATE stock.sequence_counter
	SET grn=@newNo
	WHERE record_id=1