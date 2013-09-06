ALTER TABLE [hrm].[employee_work_experiance]
    ADD CONSTRAINT [fk_employee_ref_emp_w_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

