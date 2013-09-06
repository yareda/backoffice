ALTER TABLE [wms].[payment_record]
    ADD CONSTRAINT [FK_payment_record_invoice] FOREIGN KEY ([invoice_id]) REFERENCES [wms].[invoice] ([id]) ON DELETE CASCADE ON UPDATE CASCADE;



