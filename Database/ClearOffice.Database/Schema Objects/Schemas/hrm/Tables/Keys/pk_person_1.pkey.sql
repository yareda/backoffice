﻿ALTER TABLE [hrm].[person]
    ADD CONSTRAINT [pk_person] PRIMARY KEY CLUSTERED ([person_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

