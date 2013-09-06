ALTER TABLE [hrm].[employee]
    ADD CONSTRAINT [FK_employee_organization] FOREIGN KEY ([node_id]) REFERENCES [hrm].[organization] ([node_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

