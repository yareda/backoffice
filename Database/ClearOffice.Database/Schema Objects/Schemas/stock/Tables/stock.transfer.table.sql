CREATE TABLE [stock].[transfer] (
    [transfer_id]    INT            IDENTITY (1, 1) NOT NULL,
    [status_id]      INT            NULL,
    [transfer_no]    NVARCHAR (200) NULL,
    [transfer_date]  DATETIME       NULL,
    [transfer_by]    NVARCHAR (200) NULL,
    [posted_date]    DATETIME       NULL,
    [posted_by]      NVARCHAR (200) NULL,
    [warehouse_from] INT            NULL,
    [warehouse_to]   INT            NULL,
    [remark]         NVARCHAR (MAX) NULL,
    [reason]         NVARCHAR (MAX) NULL
);



