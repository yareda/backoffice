ALTER TABLE [hrm].[employee_educational_history]
    ADD CONSTRAINT [fk_employee_ref_edu_t_educatio] FOREIGN KEY ([education_type_id]) REFERENCES [hrm].[education_type] ([education_type_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

