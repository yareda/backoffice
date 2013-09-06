CREATE TABLE [wms].[invoice] (
    [id]            INT             IDENTITY (1, 1) NOT NULL,
    [invoice_no]    NVARCHAR (200)  NULL,
    [work_order_id] INT             NOT NULL,
    [part_cost]     DECIMAL (10, 2) NULL,
    [labour_cost]   DECIMAL (10, 2) NULL,
    [notes]         NVARCHAR (MAX)  NULL,
    [invoice_date]  DATE            NULL,
    [due_date]      DATE            NULL,
    [customer_id]   INT             NULL,
    [status]        INT             NULL
);





