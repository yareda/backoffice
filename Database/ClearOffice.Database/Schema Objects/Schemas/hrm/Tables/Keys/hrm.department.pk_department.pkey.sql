﻿ALTER TABLE [hrm].[department]
    ADD CONSTRAINT [pk_department] PRIMARY KEY CLUSTERED ([department_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

