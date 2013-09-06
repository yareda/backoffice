ALTER TABLE [wms].[contract]
    ADD CONSTRAINT [DF_contract_is_default_contract] DEFAULT ((0)) FOR [is_default_contract];

