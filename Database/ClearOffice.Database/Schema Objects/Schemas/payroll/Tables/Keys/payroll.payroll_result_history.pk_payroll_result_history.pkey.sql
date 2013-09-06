ALTER TABLE [payroll].[payroll_result_history]
    ADD CONSTRAINT [pk_payroll_result_history] PRIMARY KEY CLUSTERED ([result_history_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

