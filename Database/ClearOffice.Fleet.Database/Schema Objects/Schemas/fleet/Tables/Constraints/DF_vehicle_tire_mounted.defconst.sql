ALTER TABLE [fleet].[vehicle_tire]
    ADD CONSTRAINT [DF_vehicle_tire_mounted] DEFAULT ((0)) FOR [mounted];

