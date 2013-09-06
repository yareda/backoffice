CREATE TABLE [wms].[repair_schedule] (
    [repair_schedule_id] INT            IDENTITY (1, 1) NOT NULL,
    [equipment]          INT            NOT NULL,
    [repair_date]        DATE           NULL,
    [repair_unit]        INT            NULL,
    [request_by]         NVARCHAR (200) NULL
);

