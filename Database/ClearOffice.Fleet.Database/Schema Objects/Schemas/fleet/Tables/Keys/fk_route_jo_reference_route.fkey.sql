ALTER TABLE [fleet].[route_job]
    ADD CONSTRAINT [fk_route_jo_reference_route] FOREIGN KEY ([route_id]) REFERENCES [fleet].[route] ([route_id]) ON DELETE CASCADE ON UPDATE NO ACTION;

