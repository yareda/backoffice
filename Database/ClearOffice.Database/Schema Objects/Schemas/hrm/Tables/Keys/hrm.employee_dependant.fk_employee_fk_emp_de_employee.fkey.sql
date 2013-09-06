ALTER TABLE [hrm].[employee_dependant]
    ADD CONSTRAINT [fk_employee_fk_emp_de_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

