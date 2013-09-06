CREATE VIEW fleet.tire_info
AS
SELECT     fleet.tire.*, fleet.tire_size_info.item_name AS tire_size_name, fleet.tire_brand_info.item_name AS tire_brand_name, fleet.tire_type_info.item_name AS tire_type_name, 
                      fleet.tire_status_info.item_name AS tire_status_name, fleet.vendor.name AS vendor_name
FROM         fleet.tire LEFT OUTER JOIN
                      fleet.tire_status_info ON fleet.tire.status = fleet.tire_status_info.lookup_item_id LEFT OUTER JOIN
                      fleet.tire_type_info ON fleet.tire.tire_type = fleet.tire_type_info.lookup_item_id LEFT OUTER JOIN
                      fleet.tire_brand_info ON fleet.tire.brand = fleet.tire_brand_info.lookup_item_id LEFT OUTER JOIN
                      fleet.tire_size_info ON fleet.tire.size = fleet.tire_size_info.lookup_item_id LEFT OUTER JOIN
                      fleet.vendor ON fleet.tire.vendor = fleet.vendor.id