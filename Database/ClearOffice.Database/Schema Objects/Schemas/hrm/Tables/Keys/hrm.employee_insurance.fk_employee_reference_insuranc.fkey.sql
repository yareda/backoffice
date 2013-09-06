ALTER TABLE [hrm].[employee_insurance]
    ADD CONSTRAINT [fk_employee_reference_insuranc] FOREIGN KEY ([company_id]) REFERENCES [hrm].[insurance_company] ([company_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

