﻿ALTER TABLE [fleet].[lookup_item]
    ADD CONSTRAINT [PK_lookup_item] PRIMARY KEY CLUSTERED ([lookup_item_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

