CREATE TABLE [fleet].[maintenance_part] (
    [item_id]        INT            IDENTITY (1, 1) NOT NULL,
    [maintenance_id] INT            NULL,
    [part_no]        NVARCHAR (200) NULL,
    [quantity]       INT            NULL,
    [unit_price]     MONEY          NULL,
    [replaced_date]  DATETIME       NULL,
    [description]    NVARCHAR (MAX) NULL
);

