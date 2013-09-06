﻿ALTER TABLE [payroll].[payroll_denomination]
    ADD CONSTRAINT [pk_payroll_denomination] PRIMARY KEY CLUSTERED ([denom_record_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

