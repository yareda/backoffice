/*CREATE VIEW dbo.contract_info
AS
SELECT     wms.customer.name AS customer_name, wms.customer.address, wms.customer.postal_code, wms.customer.city, wms.customer.email, wms.contract.contract_id, 
                      wms.contract.customer_id, wms.contract.contract_date, wms.contract.remark, dbo.contract_renewal_info.contract_no, dbo.contract_renewal_info.date_renewed, 
                      dbo.contract_renewal_info.start_date, dbo.contract_renewal_info.expiry_date, dbo.contract_renewal_info.payment_terms, dbo.contract_renewal_info.amount, 
                      dbo.contract_renewal_info.contract_type_name
FROM         wms.contract INNER JOIN
                      wms.customer ON wms.contract.customer_id = wms.customer.customer_id INNER JOIN
                      dbo.contract_renewal_info ON wms.contract.contract_id = dbo.contract_renewal_info.contract_id AND dbo.contract_renewal_info.status = 1*/