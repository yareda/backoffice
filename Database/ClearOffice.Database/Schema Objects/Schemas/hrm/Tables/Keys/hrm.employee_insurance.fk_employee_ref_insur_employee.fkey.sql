ALTER TABLE [hrm].[employee_insurance]
    ADD CONSTRAINT [fk_employee_ref_insur_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

