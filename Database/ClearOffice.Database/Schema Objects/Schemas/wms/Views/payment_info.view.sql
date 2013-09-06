/*CREATE VIEW wms.payment_info
AS
SELECT     payment_id, invoice_id, amount_received,payment_method, payment_date, cash, check_no, bank_transfer, other, wms.get_payment_method_text(payment_method) 
                      AS payment_method_text
FROM         wms.payment_record*/