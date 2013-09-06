CREATE TABLE [fleet].[vehicle_tire] (
    [id]             INT            IDENTITY (1, 1) NOT NULL,
    [tire_id]        INT            NOT NULL,
    [vehicle_id]     INT            NOT NULL,
    [position]       NVARCHAR (200) NULL,
    [mounted]        BIT            NULL,
    [mounted_date]   DATETIME       NULL,
    [mounted_milage] FLOAT          NULL,
    [unmounted_date] DATETIME       NULL,
    [disposed]       BIT            NULL,
    [unmount_milage] FLOAT          NULL,
    [comment]        NTEXT          NULL
);



