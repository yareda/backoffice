﻿ALTER TABLE [hrm].[employee_training]
    ADD CONSTRAINT [pk_employee_training] PRIMARY KEY CLUSTERED ([training_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
