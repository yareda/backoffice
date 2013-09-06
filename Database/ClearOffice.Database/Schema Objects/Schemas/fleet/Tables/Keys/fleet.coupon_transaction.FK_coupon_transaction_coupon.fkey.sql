ALTER TABLE [fleet].[coupon_transaction]
    ADD CONSTRAINT [FK_coupon_transaction_coupon] FOREIGN KEY ([coupon_id]) REFERENCES [fleet].[coupon] ([coupon_id]) ON DELETE CASCADE ON UPDATE NO ACTION;

