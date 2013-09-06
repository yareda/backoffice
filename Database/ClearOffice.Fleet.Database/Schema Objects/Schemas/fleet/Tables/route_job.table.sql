CREATE TABLE [fleet].[route_job] (
    [job_id]       INT            IDENTITY (1, 1) NOT NULL,
    [route_id]     INT            NULL,
    [job_name]     NVARCHAR (200) NULL,
    [start_date]   DATETIME       NULL,
    [start_time]   NUMERIC (18)   NULL,
    [end_date]     DATETIME       NULL,
    [end_time]     NUMERIC (18)   NULL,
    [location]     INT            NULL,
    [status]       INT            NULL,
    [comment]      NVARCHAR (MAX) NULL,
    [data_version] TIMESTAMP      NULL
);



