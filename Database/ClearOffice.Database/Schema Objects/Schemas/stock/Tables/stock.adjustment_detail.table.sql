CREATE TABLE [stock].[adjustment_detail] (
    [adjustment_detail_id] INT             IDENTITY (1, 1) NOT NULL,
    [adjustment_id]        INT             NULL,
    [item_id]              INT             NULL,
    [current_quantity]     DECIMAL (10, 2) NULL,
    [adjusted_quantity]    DECIMAL (10, 2) NULL
);

