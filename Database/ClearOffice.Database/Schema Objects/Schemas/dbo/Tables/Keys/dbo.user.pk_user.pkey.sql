﻿ALTER TABLE [dbo].[user]
    ADD CONSTRAINT [pk_user] PRIMARY KEY CLUSTERED ([user_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

