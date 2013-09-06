CREATE TABLE [stock].[transfer_detail] (
    [transfer_detail_id] INT             IDENTITY (1, 1) NOT NULL,
    [transfer_id]        INT             NULL,
    [item_id]            INT             NULL,
    [quantity]           DECIMAL (10, 2) NULL,
    [description]        NVARCHAR (MAX)  NULL
);



