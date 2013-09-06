ALTER TABLE [hrm].[employee_medical_record]
    ADD CONSTRAINT [fk_employee_ref_emp_m_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

