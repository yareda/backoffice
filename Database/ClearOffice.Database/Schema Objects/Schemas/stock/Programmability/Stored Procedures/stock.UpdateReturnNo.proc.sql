CREATE PROCEDURE [stock].[UpdateReturnNo]
	@newNo nvarchar(20)	
AS
	UPDATE stock.sequence_counter
	SET return_no=@newNo
	WHERE record_id=1