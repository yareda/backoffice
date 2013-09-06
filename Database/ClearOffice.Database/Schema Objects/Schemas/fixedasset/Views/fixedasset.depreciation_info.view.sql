CREATE VIEW fixedasset.depreciation_info
AS
SELECT     fixedasset.depreciation.depreciation_id, fixedasset.depreciation.asset_id, fixedasset.depreciation.fiscal_year, fixedasset.depreciation.fiscal_period, 
                      fixedasset.depreciation.book_value_at_beginning_of_year, fixedasset.depreciation.book_value_at_end_of_year, fixedasset.depreciation.total_depreciation_cost, 
                      fixedasset.depreciation.depreciation_rate, fixedasset.depreciation.deprecation_expense, fixedasset.depreciation.accumulated_depreciation, 
                      fixedasset.depreciation.year, fixedasset.depreciation.month, fixedasset.asset.asset_number, fixedasset.asset.description, fixedasset.asset.group_id, 
                      fixedasset.asset.status, fixedasset.asset.useful_life, fixedasset.asset.depreciation_method, fixedasset.asset.asset_value, fixedasset.asset.salvage_value, 
                      fixedasset.asset.category, fixedasset.asset_category.category_name
FROM         fixedasset.depreciation INNER JOIN
                      fixedasset.asset ON fixedasset.depreciation.asset_id = fixedasset.asset.asset_id INNER JOIN
                      fixedasset.asset_category ON fixedasset.asset.category = fixedasset.asset_category.category_id