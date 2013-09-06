CREATE TABLE [wms].[contract] (
    [contract_id]         INT            IDENTITY (1, 1) NOT NULL,
    [contract_type]       INT            NULL,
    [contract_no]         NVARCHAR (200) NULL,
    [is_default_contract] INT            NOT NULL,
    [customer_id]         INT            NOT NULL,
    [contract_date]       DATE           NULL,
    [status]              INT            NULL,
    [remark]              NVARCHAR (MAX) NULL
);

















