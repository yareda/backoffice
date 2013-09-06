CREATE VIEW fleet.vehicle_fuel_report
AS
SELECT     fleet.lookup_item.item_name AS vehicle_type, fleet.vehicle.plate_number, fleet.fuel_log.filled_date, fleet.fuel_log.fuel_amount, fleet.fuel_log.total_cost, 
                      fleet.fuel_log.remark, fleet.vehicle.vehicle_id, '###' AS unit_price
FROM         fleet.fuel_log INNER JOIN
                      fleet.vehicle ON fleet.fuel_log.vehicle_id = fleet.vehicle.vehicle_id LEFT OUTER JOIN
                      fleet.lookup_item ON fleet.vehicle.vehicle_type = fleet.lookup_item.lookup_item_id