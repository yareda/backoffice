CREATE TABLE [wms].[miscellaneous_items] (
    [mis_part_id] INT            IDENTITY (1, 1) NOT NULL,
    [part_id]     INT            NOT NULL,
    [invoice_id]  INT            NOT NULL,
    [quantity]    INT            NULL,
    [unit_price]  DECIMAL (10)   NULL,
    [description] NVARCHAR (MAX) NULL
);







