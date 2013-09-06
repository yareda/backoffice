ALTER TABLE [fleet].[vehicle_tire]
    ADD CONSTRAINT [DF_vehicle_tire_disposed] DEFAULT ((0)) FOR [disposed];

