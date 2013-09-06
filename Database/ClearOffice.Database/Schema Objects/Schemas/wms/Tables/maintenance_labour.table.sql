CREATE TABLE [wms].[maintenance_labour] (
    [labour_id]     INT            IDENTITY (1, 1) NOT NULL,
    [work_order_id] INT            NULL,
    [task_id]       INT            NULL,
    [performed_by]  INT            NULL,
    [performer_id]  INT            NOT NULL,
    [labour_rate]   FLOAT          NULL,
    [hour]          INT            NULL,
    [cost]          FLOAT          NULL,
    [description]   NVARCHAR (MAX) NULL
);













