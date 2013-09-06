CREATE PROCEDURE [stock].[delete_issue]
@issue_id INT
AS
DELETE stock.issue_detail
WHERE issue_id=@issue_id

DELETE stock.issue
WHERE issue_id=@issue_id