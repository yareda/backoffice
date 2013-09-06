ALTER TABLE [hrm].[employee]
    ADD CONSTRAINT [FK_employee_employee_type] FOREIGN KEY ([employee_type]) REFERENCES [hrm].[employee_type] ([employement_type_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

