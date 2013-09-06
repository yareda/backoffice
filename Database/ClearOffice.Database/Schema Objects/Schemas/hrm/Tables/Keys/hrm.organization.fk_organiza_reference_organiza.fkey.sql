ALTER TABLE [hrm].[organization]
    ADD CONSTRAINT [fk_organiza_reference_organiza] FOREIGN KEY ([node_type_id]) REFERENCES [hrm].[organization_node_type] ([node_type_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

