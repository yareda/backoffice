ALTER TABLE [hrm].[employee_disciplinary_measure]
    ADD CONSTRAINT [fk_employee_ref_emp_d_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

