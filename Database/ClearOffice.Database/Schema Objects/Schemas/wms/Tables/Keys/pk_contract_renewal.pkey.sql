﻿ALTER TABLE [wms].[contract_renewal]
    ADD CONSTRAINT [pk_contract_renewal] PRIMARY KEY CLUSTERED ([renewal_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

