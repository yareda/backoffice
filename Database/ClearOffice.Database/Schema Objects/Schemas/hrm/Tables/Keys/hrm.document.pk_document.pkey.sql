﻿ALTER TABLE [hrm].[document]
    ADD CONSTRAINT [pk_document] PRIMARY KEY CLUSTERED ([doc_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
