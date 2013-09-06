ALTER TABLE [hrm].[employee_skill]
    ADD CONSTRAINT [fk_employee_ref_emp_s_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

