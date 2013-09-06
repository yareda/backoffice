CREATE TABLE [stock].[receiving] (
    [receiving_id]  INT            IDENTITY (1, 1) NOT NULL,
    [warehouse_id]  INT            NOT NULL,
    [supplier_id]   INT            NULL,
    [grn]           NVARCHAR (50)  NULL,
    [airwaybill_no] NVARCHAR (200) NULL,
    [invoice_no]    NVARCHAR (200) NULL,
    [received_by]   NVARCHAR (200) NULL,
    [received_date] DATETIME       NULL,
    [status_id]     INT            NOT NULL,
    [posted_date]   DATETIME       NULL,
    [posted_by]     NVARCHAR (200) NULL,
    [remark]        NVARCHAR (MAX) NULL
);

