CREATE VIEW fleet.vehicle_status_report
AS
SELECT     fleet.vehicle.plate_number, fleet.vehicle.purchase_date, fleet.lookup_item.item_name AS model_no, fleet.vehicle.chasis_no, fleet.vehicle.remark AS vehicle_remark, 
                      fleet.maintanance.closing_remark, fleet.GetMaintenanceCost(fleet.maintanance.maintenance_id) AS maintenance_cost, 
                      fleet.GetMaintenanceTotalCost(fleet.maintanance.maintenance_id) AS total_cost
FROM         fleet.vehicle INNER JOIN
                      fleet.maintanance ON fleet.vehicle.vehicle_id = fleet.maintanance.vehicle_id LEFT OUTER JOIN
                      fleet.lookup_item ON fleet.vehicle.model_id = fleet.lookup_item.lookup_item_id