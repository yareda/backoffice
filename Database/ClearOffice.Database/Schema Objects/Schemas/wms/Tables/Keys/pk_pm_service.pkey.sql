﻿ALTER TABLE [wms].[pm_service]
    ADD CONSTRAINT [pk_pm_service] PRIMARY KEY CLUSTERED ([pm_service_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

