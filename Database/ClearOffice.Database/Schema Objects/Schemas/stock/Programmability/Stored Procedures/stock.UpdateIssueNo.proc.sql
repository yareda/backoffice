CREATE PROCEDURE [stock].[UpdateIssueNo]
	@newNo nvarchar(20)	
AS
	UPDATE stock.sequence_counter
	SET issue_no=@newNo
	WHERE record_id=1