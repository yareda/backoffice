ALTER TABLE [payroll].[payroll_pay_slip_history]
    ADD CONSTRAINT [PK_payroll_pay_slip_history] PRIMARY KEY CLUSTERED ([pay_slip_history_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

