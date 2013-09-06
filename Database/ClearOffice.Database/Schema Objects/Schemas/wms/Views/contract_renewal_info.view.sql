CREATE VIEW wms.contract_renewal_info
AS
SELECT     wms.contract_renewal.renewal_id, wms.contract_renewal.contract_id, wms.contract_renewal.date_renewed, wms.contract_renewal.start_date, 
                      wms.contract_renewal.duration, wms.GetExpireDate(wms.contract_renewal.start_date, wms.contract_renewal.duration) AS expiration_date, 
                      wms.contract_renewal.amount, wms.contract_renewal.description, wms.contract_renewal.status, wms.contract.contract_type, wms.contract.contract_no, 
                      wms.contract.customer_id, wms.contract_renewal.payment_terms, wms.lookup_item.name AS payment_term_text, lookup_item_1.name AS contract_type_text, 
                      wms.contract.is_default_contract, wms.return_contract_status_text(wms.contract_renewal.status) AS status_text, wms.customer.name AS customer_name, 
                      wms.get_contract_status_text(wms.contract.status) AS contract_status_text
FROM         wms.contract_renewal INNER JOIN
                      wms.contract ON wms.contract_renewal.contract_id = wms.contract.contract_id LEFT OUTER JOIN
                      wms.lookup_item ON wms.contract_renewal.payment_terms = wms.lookup_item.item_id LEFT OUTER JOIN
                      wms.customer ON wms.contract.customer_id = wms.customer.customer_id LEFT OUTER JOIN
                      wms.lookup_item AS lookup_item_1 ON wms.contract.contract_type = lookup_item_1.item_id