/*CREATE VIEW fixedasset.[custodian_asste _info]
AS
SELECT     fixedasset.asset.category, fixedasset.asset.asset_number, fixedasset.custodian_asset.date_from, fixedasset.custodian_asset.date_to, 
                      fixedasset.custodian_asset.status, fixedasset.lookup_item.lookup_item_id, fixedasset.lookup_item.item_name, fixedasset.custodian_asset.custodian_id
FROM         fixedasset.asset INNER JOIN
                      fixedasset.custodian_asset ON fixedasset.asset.asset_id = fixedasset.custodian_asset.asset_id INNER JOIN
                      fixedasset.lookup_item ON fixedasset.custodian_asset.status = fixedasset.lookup_item.lookup_item_id*/