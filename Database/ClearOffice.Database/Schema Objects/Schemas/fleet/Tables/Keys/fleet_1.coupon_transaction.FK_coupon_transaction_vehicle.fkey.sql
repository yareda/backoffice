ALTER TABLE [fleet].[coupon_transaction]
    ADD CONSTRAINT [FK_coupon_transaction_vehicle] FOREIGN KEY ([vehicle_id]) REFERENCES [fleet].[vehicle] ([vehicle_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

