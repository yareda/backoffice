﻿ALTER TABLE [stock].[receiving_detail]
    ADD CONSTRAINT [pk_receiving_detail] PRIMARY KEY CLUSTERED ([receiving_detail_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

