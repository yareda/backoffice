CREATE VIEW fleet.tireview
AS
SELECT     fleet.vehicle_tire.id AS vehicle_tire, fleet.tire.tire_id, fleet.tire.brand, fleet.tire.size, fleet.tire.tire_type, fleet.tire.serial_no, fleet.tire.purchased_date, fleet.tire.vendor, 
                      fleet.tire.comment, fleet.tire.data_version, fleet.vehicle_tire.position, fleet.vehicle_tire.mounted_date, fleet.vehicle.plate_number, fleet.vehicle_tire.unmounted_date, 
                      fleet.vehicle_tire.mounted_milage, fleet.tire_status.id, fleet.GetTireStatus(fleet.vehicle_tire.mounted, fleet.vehicle_tire.disposed) AS status_name, fleet.tire.status, 
                      fleet.vehicle_tire.disposed, fleet.vehicle_tire.mounted, fleet.vehicle.vehicle_id
FROM         fleet.tire_status RIGHT OUTER JOIN
                      fleet.tire ON fleet.tire_status.id = fleet.tire.status LEFT OUTER JOIN
                      fleet.vehicle_tire ON fleet.tire.tire_id = fleet.vehicle_tire.tire_id LEFT OUTER JOIN
                      fleet.vehicle ON fleet.vehicle_tire.vehicle_id = fleet.vehicle.vehicle_id

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[70] 4[4] 2[6] 3) )"
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
         Begin Table = "tire_status (fleet)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 95
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tire (fleet)"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 125
               Right = 403
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vehicle_tire (fleet)"
            Begin Extent = 
               Top = 6
               Left = 441
               Bottom = 125
               Right = 612
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vehicle (fleet)"
            Begin Extent = 
               Top = 6
               Left = 650
               Bottom = 125
               Right = 845
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 19
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
         Alias = 900', @level0type = N'SCHEMA', @level0name = N'fleet', @level1type = N'VIEW', @level1name = N'tireview';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'Table = 1170
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
End', @level0type = N'SCHEMA', @level0name = N'fleet', @level1type = N'VIEW', @level1name = N'tireview';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'fleet', @level1type = N'VIEW', @level1name = N'tireview';

