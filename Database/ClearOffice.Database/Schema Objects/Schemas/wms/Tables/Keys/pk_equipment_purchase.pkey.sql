﻿ALTER TABLE [wms].[equipment_purchase]
    ADD CONSTRAINT [pk_equipment_purchase] PRIMARY KEY CLUSTERED ([purchase_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
