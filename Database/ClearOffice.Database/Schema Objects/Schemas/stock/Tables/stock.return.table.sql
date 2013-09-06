CREATE TABLE [stock].[return] (
    [return_id]     INT            IDENTITY (1, 1) NOT NULL,
    [status_id]     INT            NULL,
    [warehouse_id]  INT            NULL,
    [return_no]     NVARCHAR (200) NULL,
    [reason]        NVARCHAR (MAX) NULL,
    [accepted_by]   NVARCHAR (200) NULL,
    [accepted_date] DATETIME       NULL,
    [posted_by]     NVARCHAR (200) NULL,
    [posted_date]   DATETIME       NULL,
    [remark]        NVARCHAR (MAX) NULL
);



