﻿ALTER TABLE [fleet].[coupon_transaction]
    ADD CONSTRAINT [pk_coupon_transaction] PRIMARY KEY CLUSTERED ([coupon_transaction_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
