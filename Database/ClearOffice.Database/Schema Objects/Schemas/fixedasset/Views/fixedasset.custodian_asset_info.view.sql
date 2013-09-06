CREATE VIEW fixedasset.custodian_asset_info
AS
SELECT     fixedasset.custodian_asset.record_id, fixedasset.custodian_asset.custodian_id, fixedasset.custodian_asset.asset_id, fixedasset.custodian_asset.date_from, 
                      fixedasset.custodian_asset.date_to, fixedasset.custodian_asset.remark, fixedasset.custodian.first_name, fixedasset.custodian.last_name, 
                      fixedasset.custodian.badge_no, fixedasset.lookup_item.item_name, fixedasset.custodian_asset.status
FROM         fixedasset.custodian_asset INNER JOIN
                      fixedasset.custodian ON fixedasset.custodian_asset.custodian_id = fixedasset.custodian.custodian_id INNER JOIN
                      fixedasset.lookup_item ON fixedasset.custodian_asset.status = fixedasset.lookup_item.lookup_item_id LEFT OUTER JOIN
                      fixedasset.asset ON fixedasset.custodian_asset.asset_id = fixedasset.asset.asset_id