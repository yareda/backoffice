﻿ALTER TABLE [fixedasset].[lookup]
    ADD CONSTRAINT [pk_lookup] PRIMARY KEY CLUSTERED ([lookup_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

