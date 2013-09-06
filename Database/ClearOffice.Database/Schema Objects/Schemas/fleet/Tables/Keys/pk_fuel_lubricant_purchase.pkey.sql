﻿ALTER TABLE [fleet].[fuel_lubricant_purchase]
    ADD CONSTRAINT [pk_fuel_lubricant_purchase] PRIMARY KEY CLUSTERED ([fuel_order_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

