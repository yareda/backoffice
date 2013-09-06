CREATE TABLE [stock].[receiving_detail] (
    [receiving_detail_id] INT             IDENTITY (1, 1) NOT NULL,
    [item_id]             INT             NULL,
    [receiving_id]        INT             NULL,
    [unit_price]          DECIMAL (10, 2) NULL,
    [quantity]            DECIMAL (10, 2) NULL,
    [remark]              NVARCHAR (MAX)  NULL
);

