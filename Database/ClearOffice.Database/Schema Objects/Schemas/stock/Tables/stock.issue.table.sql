CREATE TABLE [stock].[issue] (
    [issue_id]     INT            IDENTITY (1, 1) NOT NULL,
    [status_id]    INT            NULL,
    [warehouse_id] INT            NULL,
    [issue_no]     NVARCHAR (200) NULL,
    [issue_date]   DATETIME       NULL,
    [issued_by]    NVARCHAR (200) NULL,
    [posted_date]  DATETIME       NULL,
    [posted_by]    NVARCHAR (200) NULL,
    [remark]       NVARCHAR (MAX) NULL,
    [issued_to]    NVARCHAR (200) NULL,
    [issue_reason] NVARCHAR (MAX) NULL
);



