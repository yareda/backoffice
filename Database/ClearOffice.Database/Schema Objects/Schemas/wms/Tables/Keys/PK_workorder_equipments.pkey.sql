ALTER TABLE [wms].[workorder_equipments]
    ADD CONSTRAINT [PK_workorder_equipments] PRIMARY KEY CLUSTERED ([equipment_id] ASC, [workorder_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

