﻿ALTER TABLE [wms].[company]
    ADD CONSTRAINT [pk_company] PRIMARY KEY CLUSTERED ([company_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

