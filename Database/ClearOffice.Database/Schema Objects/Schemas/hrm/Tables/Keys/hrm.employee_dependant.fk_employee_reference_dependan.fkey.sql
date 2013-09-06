ALTER TABLE [hrm].[employee_dependant]
    ADD CONSTRAINT [fk_employee_reference_dependan] FOREIGN KEY ([dependant_type_id]) REFERENCES [hrm].[dependant_type] ([dependant_type_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

