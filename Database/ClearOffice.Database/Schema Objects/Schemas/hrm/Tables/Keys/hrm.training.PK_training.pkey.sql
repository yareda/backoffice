﻿ALTER TABLE [hrm].[training]
    ADD CONSTRAINT [PK_training] PRIMARY KEY CLUSTERED ([training_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

