ALTER TABLE [wms].[contract_renewal]
    ADD CONSTRAINT [DF_contract_renewal_status] DEFAULT ((1)) FOR [status];

