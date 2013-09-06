ALTER TABLE [hrm].[employee_custom_field_value]
    ADD CONSTRAINT [fk_employee_reference_custom_f] FOREIGN KEY ([custom_field_id]) REFERENCES [hrm].[custom_field] ([custom_field_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

