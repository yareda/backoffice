/*CREATE VIEW dbo.contract_renewal_info
AS
SELECT     wms.contract_renewal.renewal_id, wms.contract_renewal.contract_id, wms.contract_renewal.contract_no, wms.contract_renewal.contract_type, 
                      wms.contract_renewal.date_renewed, wms.contract_renewal.start_date, wms.contract_renewal.expiry_date, wms.contract_renewal.payment_terms, 
                      wms.contract_renewal.amount, wms.contract_renewal.description, wms.contract.contract_date, wms.contract.customer_id, wms.contract.remark, 
                      wms.lookup_item.name AS contract_type_name, wms.contract_renewal.status
FROM         wms.contract_renewal INNER JOIN
                      wms.contract ON wms.contract_renewal.contract_id = wms.contract.contract_id INNER JOIN
                      wms.lookup_item ON wms.contract_renewal.contract_type = wms.lookup_item.item_id*/