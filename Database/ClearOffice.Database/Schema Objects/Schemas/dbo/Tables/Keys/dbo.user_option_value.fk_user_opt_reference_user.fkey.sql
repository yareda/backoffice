ALTER TABLE [dbo].[user_option_value]
    ADD CONSTRAINT [fk_user_opt_reference_user] FOREIGN KEY ([user_id]) REFERENCES [dbo].[user] ([user_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

