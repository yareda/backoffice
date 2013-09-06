CREATE PROCEDURE [stock].[UpdateTransferNo]
	@newNo nvarchar(20)	
AS
	UPDATE stock.sequence_counter
	SET transfer_no=@newNo
	WHERE record_id=1