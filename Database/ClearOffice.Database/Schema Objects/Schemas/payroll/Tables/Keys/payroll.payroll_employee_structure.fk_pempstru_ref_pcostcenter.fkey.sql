ALTER TABLE [payroll].[payroll_employee_structure]
    ADD CONSTRAINT [fk_pempstru_ref_pcostcenter] FOREIGN KEY ([cost_center_id]) REFERENCES [payroll].[payroll_cost_center] ([cost_center_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

