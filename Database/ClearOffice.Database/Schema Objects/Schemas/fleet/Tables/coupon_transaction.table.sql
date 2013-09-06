CREATE TABLE [fleet].[coupon_transaction] (
    [coupon_transaction_id] INT            IDENTITY (1, 1) NOT NULL,
    [coupon_id]             INT            NULL,
    [vehicle_id]            INT            NULL,
    [fuel_type_id]          INT            NULL,
    [leaf_no]               NVARCHAR (200) NULL,
    [cash_amount]           FLOAT          NULL,
    [value_amount]          FLOAT          NULL,
    [transaction_date]      DATETIME       NULL,
    [remark]                NTEXT          NULL,
    [driver_name]           NVARCHAR (200) NULL
);













