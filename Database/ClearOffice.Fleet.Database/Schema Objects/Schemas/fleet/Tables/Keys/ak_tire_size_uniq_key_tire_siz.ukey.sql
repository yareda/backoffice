﻿ALTER TABLE [fleet].[tire_size]
    ADD CONSTRAINT [ak_tire_size_uniq_key_tire_siz] UNIQUE NONCLUSTERED ([name] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];

