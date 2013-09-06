CREATE PROCEDURE [stock].[delete_transfer]
@transfer_id INT
AS
DELETE stock.transfer_detail
WHERE transfer_id=@transfer_id

DELETE stock.transfer
WHERE transfer_id=@transfer_id