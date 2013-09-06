CREATE VIEW wms.customer_info
AS
SELECT     wms.contract.contract_id, wms.contract.contract_no, wms.contract.is_default_contract, wms.contract.customer_id, wms.contract.contract_date, wms.contract.remark, 
                      wms.customer.name, wms.customer.type, wms.customer.contact, wms.customer.address, wms.customer.city, wms.customer.postal_code, wms.customer.phone1, 
                      wms.customer.phone2, wms.customer.fax, wms.customer.email, wms.lookup_item.name AS customer_type_name, lookup_item_1.name AS contract_type_name, 
                      wms.contract_renewal.start_date, wms.contract_renewal.duration, wms.contract_renewal.amount, wms.contract_renewal.description, 
                      wms.get_contract_status_text(wms.contract.status) AS contract_status_text, wms.contract_renewal.payment_terms, lookup_item_2.name AS payment_term_name, 
                      wms.contract.contract_type, wms.GetExpireDate(wms.contract_renewal.start_date, wms.contract_renewal.duration) AS expiration_date
FROM         wms.contract INNER JOIN
                      wms.customer ON wms.contract.customer_id = wms.customer.customer_id LEFT OUTER JOIN
                      wms.lookup_item ON wms.customer.type = wms.lookup_item.item_id LEFT OUTER JOIN
                      wms.lookup_item AS lookup_item_1 ON wms.contract.contract_type = lookup_item_1.item_id INNER JOIN
                      wms.contract_renewal ON wms.contract.contract_id = wms.contract_renewal.contract_id AND wms.contract_renewal.status = 1 LEFT OUTER JOIN
                      wms.lookup_item AS lookup_item_2 ON wms.contract_renewal.payment_terms = lookup_item_2.item_id