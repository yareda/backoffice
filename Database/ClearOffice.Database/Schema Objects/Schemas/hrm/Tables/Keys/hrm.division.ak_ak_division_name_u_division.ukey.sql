﻿ALTER TABLE [hrm].[division]
    ADD CONSTRAINT [ak_ak_division_name_u_division] UNIQUE NONCLUSTERED ([division_name] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];

