﻿ALTER TABLE [dbo].[application_option]
    ADD CONSTRAINT [ak_ak_option_name_uni_applicat] UNIQUE NONCLUSTERED ([option_name] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];

