﻿ALTER TABLE [hrm].[organization_node_type]
    ADD CONSTRAINT [pk_organization_node_type] PRIMARY KEY CLUSTERED ([node_type_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
