ALTER TABLE [payroll].[payroll_parameter_group]
    ADD CONSTRAINT [PK_payroll_parameter_group] PRIMARY KEY CLUSTERED ([parameter_group_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

