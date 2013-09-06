CREATE TABLE [fixedasset].[asset] (
    [asset_id]            INT             IDENTITY (1, 1) NOT NULL,
    [asset_number]        VARCHAR (50)    NOT NULL,
    [description]         NVARCHAR (MAX)  NULL,
    [category]            INT             NOT NULL,
    [vendor]              INT             NULL,
    [group_id]            INT             NULL,
    [cost_center_id]      INT             NULL,
    [location_id]         INT             NULL,
    [physical_condition]  INT             NULL,
    [document_number]     NVARCHAR (200)  NULL,
    [status]              INT             NOT NULL,
    [purchase_date]       DATE            NULL,
    [useful_life]         INT             NULL,
    [depreciation_method] INT             NULL,
    [asset_value]         DECIMAL (18, 2) NULL,
    [salvage_value]       DECIMAL (18, 2) NULL,
    [image]               IMAGE           NULL,
    [remark]              NVARCHAR (MAX)  NULL
);



