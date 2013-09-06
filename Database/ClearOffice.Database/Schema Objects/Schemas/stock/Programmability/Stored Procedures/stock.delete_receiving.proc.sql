CREATE PROCEDURE stock.delete_receiving
@receiving_id INT
AS
DELETE stock.receiving_detail
WHERE receiving_id=@receiving_id	

DELETE stock.receiving
WHERE receiving_id=@receiving_id