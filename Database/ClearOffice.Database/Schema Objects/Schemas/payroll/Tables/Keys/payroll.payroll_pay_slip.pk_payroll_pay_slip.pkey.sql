﻿ALTER TABLE [payroll].[payroll_pay_slip]
    ADD CONSTRAINT [pk_payroll_pay_slip] PRIMARY KEY CLUSTERED ([pay_slip_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

