CREATE TABLE [fleet].[route] (
    [route_id]       INT            IDENTITY (1, 1) NOT NULL,
    [start_date]     DATETIME       NULL,
    [start_time]     DATETIME       NULL,
    [end_date]       DATETIME       NULL,
    [end_time]       DATETIME       NULL,
    [vehicle]        INT            NULL,
    [odometer_start] INT            NULL,
    [odometer_stop]  INT            NULL,
    [description]    NVARCHAR (MAX) NULL,
    [comment]        NVARCHAR (MAX) NULL,
    [data_version]   TIMESTAMP      NULL
);



