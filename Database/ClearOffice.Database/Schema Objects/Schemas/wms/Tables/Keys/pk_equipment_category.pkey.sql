﻿ALTER TABLE [wms].[equipment_category]
    ADD CONSTRAINT [pk_equipment_category] PRIMARY KEY CLUSTERED ([category_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

