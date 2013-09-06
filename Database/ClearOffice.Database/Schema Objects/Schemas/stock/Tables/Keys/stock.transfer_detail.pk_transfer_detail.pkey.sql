﻿ALTER TABLE [stock].[transfer_detail]
    ADD CONSTRAINT [pk_transfer_detail] PRIMARY KEY CLUSTERED ([transfer_detail_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
