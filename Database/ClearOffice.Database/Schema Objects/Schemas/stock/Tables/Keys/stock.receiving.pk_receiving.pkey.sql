﻿ALTER TABLE [stock].[receiving]
    ADD CONSTRAINT [pk_receiving] PRIMARY KEY CLUSTERED ([receiving_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

