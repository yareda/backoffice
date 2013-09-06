ALTER TABLE [dbo].[user_option_value]
    ADD CONSTRAINT [fk_user_opt_reference_applicat] FOREIGN KEY ([option_id]) REFERENCES [dbo].[application_option] ([option_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

