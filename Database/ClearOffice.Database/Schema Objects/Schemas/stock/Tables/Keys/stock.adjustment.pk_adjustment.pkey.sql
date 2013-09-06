﻿ALTER TABLE [stock].[adjustment]
    ADD CONSTRAINT [pk_adjustment] PRIMARY KEY CLUSTERED ([adjustment_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
