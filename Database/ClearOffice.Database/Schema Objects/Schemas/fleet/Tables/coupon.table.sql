CREATE TABLE [fleet].[coupon] (
    [coupon_id]      INT            IDENTITY (1, 1) NOT NULL,
    [coupon_label]   NVARCHAR (MAX) NULL,
    [purchased_from] NVARCHAR (500) NULL,
    [date_purchased] DATETIME       NULL,
    [cash_value]     FLOAT          NULL,
    [remark]         NVARCHAR (MAX) NULL
);













