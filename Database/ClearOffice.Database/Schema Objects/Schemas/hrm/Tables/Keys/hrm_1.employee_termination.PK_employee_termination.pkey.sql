﻿ALTER TABLE [hrm].[employee_termination]
    ADD CONSTRAINT [PK_employee_termination] PRIMARY KEY CLUSTERED ([termination_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

