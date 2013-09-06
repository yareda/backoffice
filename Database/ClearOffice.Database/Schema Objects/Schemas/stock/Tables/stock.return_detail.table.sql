CREATE TABLE [stock].[return_detail] (
    [return_detail_id] INT             IDENTITY (1, 1) NOT NULL,
    [return_id]        INT             NULL,
    [item_id]          INT             NULL,
    [quantity]         DECIMAL (10, 2) NULL,
    [unit_price]       DECIMAL (10, 2) NULL,
    [remark]           NVARCHAR (MAX)  NULL
);

