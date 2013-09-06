CREATE TABLE [wms].[pm_schedule] (
    [pm_schedule_id] INT            IDENTITY (1, 1) NOT NULL,
    [name]           NVARCHAR (200) NULL,
    [tracking_date]  DATE           NULL,
    [tracking_unit]  INT            NULL,
    [tracking_meter] INT            NULL
);

