﻿ALTER TABLE [hrm].[employee_pto_status]
    ADD CONSTRAINT [PK_employee_pto_status] PRIMARY KEY CLUSTERED ([leave_status_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
