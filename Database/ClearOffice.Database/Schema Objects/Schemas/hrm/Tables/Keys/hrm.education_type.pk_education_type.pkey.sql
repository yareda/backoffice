﻿ALTER TABLE [hrm].[education_type]
    ADD CONSTRAINT [pk_education_type] PRIMARY KEY CLUSTERED ([education_type_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
