CREATE VIEW wms.invoice_received_amount_info
AS
SELECT     invoice_id, CASE WHEN SUM(amount_received) IS NULL THEN 0 ELSE SUM(amount_received) END AS received_total
FROM         wms.payment_record
GROUP BY invoice_id