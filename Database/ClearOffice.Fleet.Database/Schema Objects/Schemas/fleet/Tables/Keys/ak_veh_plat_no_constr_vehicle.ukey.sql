﻿ALTER TABLE [fleet].[vehicle]
    ADD CONSTRAINT [ak_veh_plat_no_constr_vehicle] UNIQUE NONCLUSTERED ([plate_number] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];

