﻿ALTER TABLE [fleet].[insurance_company]
    ADD CONSTRAINT [ak_insu_comp_name_uni_insuranc] UNIQUE NONCLUSTERED ([name] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];
