﻿ALTER TABLE [hrm].[employee_warning]
    ADD CONSTRAINT [PK_employee_warning] PRIMARY KEY CLUSTERED ([warning_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

