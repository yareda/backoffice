ALTER TABLE [hrm].[employee_insurance]
    ADD CONSTRAINT [fk_employee_ref_emp_i_insuranc] FOREIGN KEY ([policy_type_id]) REFERENCES [hrm].[insurance_policy_type] ([policy_type_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

