CREATE VIEW fixedasset.asset_list_info
AS
SELECT     fixedasset.asset.asset_number, fixedasset.asset.status, fixedasset.asset.depreciation_method, fixedasset.asset.asset_value, fixedasset.asset.asset_id, 
                      fixedasset.asset.group_id, [Group].item_name AS group_text, AssetStatus.item_name AS status_text, DeprMethod.item_name AS depreciation_method_text, 
                      fixedasset.get_depericiation_to_date(fixedasset.asset.asset_id) AS depreciation_to_date, fixedasset.get_current_bookvalue(fixedasset.asset.asset_id) 
                      AS current_book_value, fixedasset.asset.category, fixedasset.asset_category.category_name AS catagory_text
FROM         fixedasset.asset LEFT OUTER JOIN
                      fixedasset.asset_category ON fixedasset.asset.category = fixedasset.asset_category.category_id LEFT OUTER JOIN
                      fixedasset.lookup_item AS DeprMethod ON fixedasset.asset.depreciation_method = DeprMethod.lookup_item_id LEFT OUTER JOIN
                      fixedasset.lookup_item AS AssetStatus ON fixedasset.asset.status = AssetStatus.lookup_item_id LEFT OUTER JOIN
                      fixedasset.lookup_item AS [Group] ON fixedasset.asset.group_id = [Group].lookup_item_id