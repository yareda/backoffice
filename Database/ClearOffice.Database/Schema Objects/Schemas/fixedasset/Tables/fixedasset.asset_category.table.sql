CREATE TABLE [fixedasset].[asset_category] (
    [category_id]       INT            IDENTITY (1, 1) NOT NULL,
    [category_name]     NVARCHAR (200) NULL,
    [depreciation_rate] DECIMAL (4, 2) NULL
);

