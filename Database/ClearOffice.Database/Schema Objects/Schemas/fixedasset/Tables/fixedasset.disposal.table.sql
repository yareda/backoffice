CREATE TABLE [fixedasset].[disposal] (
    [disposal_id]     INT             IDENTITY (1, 1) NOT NULL,
    [asset_id]        INT             NULL,
    [disposal_date]   DATETIME        NULL,
    [document_number] VARCHAR (50)    NULL,
    [document_date]   DATETIME        NULL,
    [fiscal_year]     INT             NULL,
    [amount]          DECIMAL (18, 4) NULL,
    [remark]          NVARCHAR (MAX)  NULL,
    [disposal_type]   INT             NULL
);

