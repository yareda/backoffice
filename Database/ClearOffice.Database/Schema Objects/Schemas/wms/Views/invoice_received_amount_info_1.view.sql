CREATE VIEW [wms].[invoice_received_amount_info]
AS
SELECT     invoice_id, SUM(amount_received) AS received_total
FROM         wms.payment_record
GROUP BY invoice_id