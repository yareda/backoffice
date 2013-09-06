CREATE TABLE [wms].[payment_record] (
    [payment_id]      INT             IDENTITY (1, 1) NOT NULL,
    [invoice_id]      INT             NOT NULL,
    [amount_received] DECIMAL (10, 2) NULL,
    [payment_date]    DATE            NULL,
    [payment_method]  INT             NULL,
    [reference]       NVARCHAR (200)  NULL
);

















