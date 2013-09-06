CREATE TABLE [fixedasset].[custodian_asset] (
    [record_id]    INT            IDENTITY (1, 1) NOT NULL,
    [custodian_id] INT            NULL,
    [asset_id]     INT            NULL,
    [date_from]    DATE           NULL,
    [date_to]      DATE           NULL,
    [remark]       NVARCHAR (MAX) NULL,
    [status]       INT            NULL
);

