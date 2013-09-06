CREATE TABLE [stock].[stock_transaction] (
    [transaction_id]      INT             IDENTITY (1, 1) NOT NULL,
    [transaction_type_id] INT             NULL,
    [owner_id]            INT             NULL,
    [item_id]             INT             NULL,
    [quantity]            DECIMAL (10, 2) NULL,
    [warehouse_id]        INT             NULL,
    [transaction_date]    DATETIME        NULL
);

