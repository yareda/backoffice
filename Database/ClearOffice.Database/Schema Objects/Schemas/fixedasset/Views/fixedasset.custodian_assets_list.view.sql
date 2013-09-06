CREATE VIEW fixedasset.custodian_assets_list
AS
SELECT     fixedasset.lookup_item.item_name, fixedasset.custodian_asset.*, fixedasset.asset.asset_number
FROM         fixedasset.asset RIGHT OUTER JOIN
                      fixedasset.custodian_asset ON fixedasset.asset.asset_id = fixedasset.custodian_asset.asset_id LEFT OUTER JOIN
                      fixedasset.lookup_item ON fixedasset.custodian_asset.status = fixedasset.lookup_item.lookup_item_id