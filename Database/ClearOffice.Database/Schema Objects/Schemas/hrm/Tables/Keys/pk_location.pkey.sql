﻿ALTER TABLE [hrm].[location]
    ADD CONSTRAINT [pk_location] PRIMARY KEY CLUSTERED ([location_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
