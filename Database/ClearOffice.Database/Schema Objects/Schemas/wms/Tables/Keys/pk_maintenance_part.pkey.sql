﻿ALTER TABLE [wms].[maintenance_part]
    ADD CONSTRAINT [pk_maintenance_part] PRIMARY KEY CLUSTERED ([maintained_part_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

