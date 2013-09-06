CREATE VIEW fleet.vehicle_info
AS
SELECT     fleet.vehicle.vehicle_id, fleet.vehicle.plate_number, fleet.vehicle.make_id, fleet.vehicle.vehicle_type, fleet.vehicle.ownership, fleet.vehicle.production_year, 
                      fleet.vehicle.chasis_no, fleet.vehicle.engine_serial, fleet.vehicle.libre_no, fleet.vehicle_make_info.item_name AS vehicle_make_name, 
                      fleet.vehicle_ownership_info.item_name AS vehicle_ownership_name, fleet.vehicle_type_info.item_name AS vehicle_type_name
FROM         fleet.vehicle LEFT OUTER JOIN
                      fleet.vehicle_ownership_info ON fleet.vehicle.ownership = fleet.vehicle_ownership_info.lookup_item_id LEFT OUTER JOIN
                      fleet.vehicle_make_info ON fleet.vehicle.make_id = fleet.vehicle_make_info.lookup_item_id LEFT OUTER JOIN
                      fleet.vehicle_type_info ON fleet.vehicle.vehicle_type = fleet.vehicle_type_info.lookup_item_id