CREATE TABLE [fleet].[vehicle_tire] (
    [transaction_id] INT            IDENTITY (1, 1) NOT NULL,
    [tire_id]        INT            NOT NULL,
    [vehicle_id]     INT            NOT NULL,
    [position]       NVARCHAR (200) NULL,
    [status]         INT            NULL,
    [mounted_date]   DATETIME       NULL,
    [mounted_milage] FLOAT          NULL,
    [unmounted_date] DATETIME       NULL,
    [unmount_milage] FLOAT          NULL,
    [remark]         NVARCHAR (MAX) NULL
);





