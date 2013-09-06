CREATE TABLE [fleet].[coupon] (
    [coupon_id]        INT            IDENTITY (1, 1) NOT NULL,
    [coupon_label]     NVARCHAR (200) NULL,
    [purchased_from]   NVARCHAR (500) NULL,
    [date_purchased]   DATETIME       NULL,
    [price_per_litter] FLOAT          NULL,
    [cash_value]       FLOAT          NULL,
    [amount_value]     FLOAT          NULL,
    [remark]           NTEXT          NULL,
    [data_version]     TIMESTAMP      NULL
);



