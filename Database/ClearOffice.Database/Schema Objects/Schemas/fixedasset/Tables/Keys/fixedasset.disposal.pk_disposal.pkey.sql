﻿ALTER TABLE [fixedasset].[disposal]
    ADD CONSTRAINT [pk_disposal] PRIMARY KEY CLUSTERED ([disposal_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

