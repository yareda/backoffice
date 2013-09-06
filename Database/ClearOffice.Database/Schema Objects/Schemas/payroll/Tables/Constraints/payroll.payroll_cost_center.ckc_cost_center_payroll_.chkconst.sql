ALTER TABLE [payroll].[payroll_cost_center]
    ADD CONSTRAINT [ckc_cost_center_payroll_] CHECK ([cost_center] IS NULL OR [cost_center]=lower([cost_center]));

