CREATE TABLE [wms].[maintenance_part] (
    [maintained_part_id] INT            IDENTITY (1, 1) NOT NULL,
    [work_order_id]      INT            NULL,
    [task_id]            INT            NULL,
    [part_id]            INT            NOT NULL,
    [vendor]             INT            NOT NULL,
    [quantity]           INT            NULL,
    [unit_cost]          FLOAT          NULL,
    [description]        NVARCHAR (MAX) NULL
);















