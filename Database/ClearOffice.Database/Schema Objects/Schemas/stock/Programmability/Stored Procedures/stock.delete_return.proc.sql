CREATE PROCEDURE [stock].[delete_return]
@return_id INT
AS
DELETE stock.return_detail
WHERE return_id=@return_id

DELETE stock.[return]
WHERE return_id=@return_id