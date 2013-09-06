﻿ALTER TABLE [stock].[stock_transaction]
    ADD CONSTRAINT [pk_stock_transaction] PRIMARY KEY CLUSTERED ([transaction_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

