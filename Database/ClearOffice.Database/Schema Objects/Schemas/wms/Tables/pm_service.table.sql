CREATE TABLE [wms].[pm_service] (
    [pm_service_id]  INT            IDENTITY (1, 1) NOT NULL,
    [task_name]      NVARCHAR (200) NULL,
    [category]       INT            NOT NULL,
    [priority]       INT            NULL,
    [fixed_date]     DATE           NULL,
    [recurring_date] INT            NULL,
    [fixed_hour]     NVARCHAR (200) NULL,
    [recurring_hour] NVARCHAR (200) NULL
);









