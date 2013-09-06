CREATE TABLE [fleet].[expense] (
    [expense_id]      INT            IDENTITY (1, 1) NOT NULL,
    [vehicle_id]      INT            NULL,
    [payment_type_id] INT            NULL,
    [amount]          MONEY          NULL,
    [payment_date]    DATETIME       NULL,
    [invoice]         NVARCHAR (200) NULL,
    [description]     NTEXT          NULL,
    [remark]          NTEXT          NULL
);



