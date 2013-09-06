ALTER TABLE [hrm].[language_skill]
    ADD CONSTRAINT [fk_language_ref_lang__employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

