﻿ALTER TABLE [wms].[services]
    ADD CONSTRAINT [pk_services] PRIMARY KEY CLUSTERED ([service_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
