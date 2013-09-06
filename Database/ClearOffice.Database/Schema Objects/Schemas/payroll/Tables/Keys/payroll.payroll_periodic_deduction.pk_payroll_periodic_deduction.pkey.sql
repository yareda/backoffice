ALTER TABLE [payroll].[payroll_periodic_deduction]
    ADD CONSTRAINT [pk_payroll_periodic_deduction] PRIMARY KEY CLUSTERED ([periodic_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

