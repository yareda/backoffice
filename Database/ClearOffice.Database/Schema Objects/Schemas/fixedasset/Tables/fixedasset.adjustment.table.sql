CREATE TABLE [fixedasset].[adjustment] (
    [adjustment_id]   INT             IDENTITY (1, 1) NOT NULL,
    [document_number] VARCHAR (50)    NULL,
    [document_date]   DATETIME        NULL,
    [adjustment_type] INT             NULL,
    [asset_id]        INT             NULL,
    [fiscal_period]   INT             NULL,
    [fiscal_year]     INT             NULL,
    [previous_value]  DECIMAL (18, 2) NULL,
    [adjusted_value]  DECIMAL (18, 2) NULL,
    [status]          INT             NULL,
    [remark]          NVARCHAR (MAX)  NULL
);

