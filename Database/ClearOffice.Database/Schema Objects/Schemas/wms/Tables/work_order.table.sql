CREATE TABLE [wms].[work_order] (
    [work_order_id] INT             IDENTITY (1, 1) NOT NULL,
    [equipment_id]  INT             NOT NULL,
    [contract_id]   INT             NULL,
    [customer_id]   INT             NULL,
    [work_order_no] NVARCHAR (200)  NOT NULL,
    [priority]      NVARCHAR (200)  NULL,
    [issue_date]    DATE            NULL,
    [start_date]    DATE            NULL,
    [end_date]      DATE            NULL,
    [assigned_to]   NVARCHAR (200)  NULL,
    [status]        INT             NULL,
    [remark]        NVARCHAR (MAX)  NULL,
    [discount]      DECIMAL (18, 2) NULL,
    [tax]           DECIMAL (18, 2) NULL,
    [total_cost]    DECIMAL (18, 2) NULL
);









