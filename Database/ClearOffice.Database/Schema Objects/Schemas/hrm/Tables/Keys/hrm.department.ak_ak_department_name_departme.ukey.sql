﻿ALTER TABLE [hrm].[department]
    ADD CONSTRAINT [ak_ak_department_name_departme] UNIQUE NONCLUSTERED ([department_name] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];
