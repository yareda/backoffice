CREATE TABLE [stock].[adjustment] (
    [adjustment_id] INT            IDENTITY (1, 1) NOT NULL,
    [status_id]     INT            NULL,
    [warehouse_id]  INT            NULL,
    [adjustment_no] NVARCHAR (200) NULL,
    [reason]        NVARCHAR (MAX) NULL,
    [created_by]    NVARCHAR (200) NULL,
    [created_date]  DATETIME       NULL,
    [posted_by]     NVARCHAR (200) NULL,
    [posted_date]   DATETIME       NULL
);

