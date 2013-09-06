ALTER TABLE [fleet].[fuel_lubricant_purchase]
    ADD CONSTRAINT [fk_fuel_lubricant_purchase_ref_order] FOREIGN KEY ([order_id]) REFERENCES [fleet].[order_type] ([order_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
ALTER TABLE [fleet].[fuel_lubricant_purchase] NOCHECK CONSTRAINT [fk_fuel_lubricant_purchase_ref_order];






GO
/*ALTER TABLE [fleet].[fuel_lubricant_purchase] NOCHECK CONSTRAINT [fk_fuel_lubricant_purchase_ref_order];*/



