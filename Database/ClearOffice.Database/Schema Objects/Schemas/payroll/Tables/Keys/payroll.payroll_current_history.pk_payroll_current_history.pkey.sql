ALTER TABLE [payroll].[payroll_current_history]
    ADD CONSTRAINT [pk_payroll_current_history] PRIMARY KEY CLUSTERED ([current_record_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

