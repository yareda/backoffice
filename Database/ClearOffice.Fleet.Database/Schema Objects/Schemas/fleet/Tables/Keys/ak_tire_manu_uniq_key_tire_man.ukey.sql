﻿ALTER TABLE [fleet].[tire_manufacturer]
    ADD CONSTRAINT [ak_tire_manu_uniq_key_tire_man] UNIQUE NONCLUSTERED ([name] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];
