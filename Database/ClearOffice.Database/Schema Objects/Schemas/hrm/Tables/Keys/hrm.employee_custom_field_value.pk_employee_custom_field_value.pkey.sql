ALTER TABLE [hrm].[employee_custom_field_value]
    ADD CONSTRAINT [pk_employee_custom_field_value] PRIMARY KEY CLUSTERED ([custom_field_value_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

