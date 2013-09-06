CREATE TABLE [wms].[equipment_purchase] (
    [purchase_id]           INT             IDENTITY (1, 1) NOT NULL,
    [equipment_id]          INT             NULL,
    [purchase_date]         DATE            NULL,
    [dealer]                NVARCHAR (100)  NULL,
    [mileage]               NVARCHAR (200)  NULL,
    [price]                 DECIMAL (10, 2) NULL,
    [warranty_expiry]       DATE            NULL,
    [warranty_expiry_meter] NVARCHAR (200)  NULL,
    [service_start]         DATE            NULL,
    [service_end]           DATE            NULL,
    [transfer_date]         DATE            NULL,
    [date_sold]             DATE            NULL,
    [sold_to]               NVARCHAR (200)  NULL,
    [comment]               NVARCHAR (MAX)  NULL
);





