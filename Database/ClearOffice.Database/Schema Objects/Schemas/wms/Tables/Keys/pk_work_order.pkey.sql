﻿ALTER TABLE [wms].[work_order]
    ADD CONSTRAINT [pk_work_order] PRIMARY KEY CLUSTERED ([work_order_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

