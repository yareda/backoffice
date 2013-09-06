CREATE VIEW fixedasset.custodian_info
AS
SELECT     fixedasset.custodian.custodian_id, fixedasset.custodian.badge_no, fixedasset.custodian.first_name, fixedasset.custodian.last_name, 
                      CASE WHEN fixedasset.custodian.status = 'True' THEN 'Active' ELSE 'In Active' END AS status_text, fixedasset.custodian.location, fixedasset.custodian.department, 
                      fixedasset.custodian.remark, fixedasset.lookup_item.item_name AS departement_text
FROM         fixedasset.custodian LEFT OUTER JOIN
                      fixedasset.lookup_item ON fixedasset.custodian.department = fixedasset.lookup_item.lookup_item_id