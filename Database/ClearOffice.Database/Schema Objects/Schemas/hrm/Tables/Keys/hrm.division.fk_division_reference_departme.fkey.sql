ALTER TABLE [hrm].[division]
    ADD CONSTRAINT [fk_division_reference_departme] FOREIGN KEY ([department_id]) REFERENCES [hrm].[department] ([department_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

