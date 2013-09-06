ALTER TABLE [hrm].[employee_skill]
    ADD CONSTRAINT [fk_employee_reference_employee] FOREIGN KEY ([skill_id]) REFERENCES [hrm].[employee_skill_type] ([skill_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

