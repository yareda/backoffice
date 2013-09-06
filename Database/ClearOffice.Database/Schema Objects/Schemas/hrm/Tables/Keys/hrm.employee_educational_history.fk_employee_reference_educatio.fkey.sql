ALTER TABLE [hrm].[employee_educational_history]
    ADD CONSTRAINT [fk_employee_reference_educatio] FOREIGN KEY ([education_level_id]) REFERENCES [hrm].[education_level] ([education_level_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

