ALTER TABLE [hrm].[employee_custom_field_value]
    ADD CONSTRAINT [fk_employee_ref_emp_c_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

