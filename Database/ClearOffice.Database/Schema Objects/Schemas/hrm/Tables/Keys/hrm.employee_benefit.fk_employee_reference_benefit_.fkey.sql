ALTER TABLE [hrm].[employee_benefit]
    ADD CONSTRAINT [fk_employee_reference_benefit_] FOREIGN KEY ([benefit_type_id]) REFERENCES [hrm].[benefit_type] ([benefit_type_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

