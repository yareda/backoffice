﻿ALTER TABLE [hrm].[competency_type]
    ADD CONSTRAINT [pk_competency_type] PRIMARY KEY CLUSTERED ([competency_type_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
