ALTER TABLE [payroll].[payroll_parameter_setting]
    ADD CONSTRAINT [pk_payroll_parameter_setting] PRIMARY KEY CLUSTERED ([param_setting_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

