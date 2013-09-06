CREATE TABLE [wms].[maintenance_task] (
    [task_id]         INT            IDENTITY (1, 1) NOT NULL,
    [work_order_id]   INT            NULL,
    [is_itemized]     BIT            NULL,
    [service_type_id] INT            NOT NULL,
    [parts_cost]      FLOAT          NULL,
    [labour_cost]     FLOAT          NULL,
    [note]            NVARCHAR (MAX) NULL
);













