﻿ALTER TABLE [hrm].[custom_field]
    ADD CONSTRAINT [pk_custom_field] PRIMARY KEY CLUSTERED ([custom_field_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

