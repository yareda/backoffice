﻿CREATE VIEW fleet.vw_fuel_lubricate_order
AS
SELECT     1 AS copy_no, fleet.fuel_lubricant_purchase.fuel_order_id, fleet.fuel_lubricant_purchase.purchase_date, fleet.fuel_lubricant_purchase.form_no, 
                      fleet.fuel_lubricant_purchase.prev_fuel_purchase, fleet.fuel_lubricant_purchase.amount, fleet.order_type.order_name, fleet.fuel_station.station_name, 
                      fleet.vehicle.vehicle_id, fleet.vehicle.plate_number
FROM         fleet.fuel_lubricant_purchase INNER JOIN
                      fleet.order_type ON fleet.fuel_lubricant_purchase.order_id = fleet.order_type.order_id INNER JOIN
                      fleet.fuel_station ON fleet.fuel_lubricant_purchase.fuel_station_id = fleet.fuel_station.fuel_station_id INNER JOIN
                      fleet.vehicle ON fleet.fuel_lubricant_purchase.vehicle_id = fleet.vehicle.vehicle_id
UNION ALL
SELECT     2 AS copy_no, fleet.fuel_lubricant_purchase.fuel_order_id, fleet.fuel_lubricant_purchase.purchase_date, fleet.fuel_lubricant_purchase.form_no, 
                      fleet.fuel_lubricant_purchase.prev_fuel_purchase, fleet.fuel_lubricant_purchase.amount, fleet.order_type.order_name, fleet.fuel_station.station_name, 
                      fleet.vehicle.vehicle_id, fleet.vehicle.plate_number
FROM         fleet.fuel_lubricant_purchase INNER JOIN
                      fleet.order_type ON fleet.fuel_lubricant_purchase.order_id = fleet.order_type.order_id INNER JOIN
                      fleet.fuel_station ON fleet.fuel_lubricant_purchase.fuel_station_id = fleet.fuel_station.fuel_station_id INNER JOIN
                      fleet.vehicle ON fleet.fuel_lubricant_purchase.vehicle_id = fleet.vehicle.vehicle_id

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[19] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End', @level0type = N'SCHEMA', @level0name = N'fleet', @level1type = N'VIEW', @level1name = N'vw_fuel_lubricate_order';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'fleet', @level1type = N'VIEW', @level1name = N'vw_fuel_lubricate_order';

