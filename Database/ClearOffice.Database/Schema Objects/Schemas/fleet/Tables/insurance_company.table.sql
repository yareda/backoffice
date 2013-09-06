CREATE TABLE [fleet].[insurance_company] (
    [company_id] INT            IDENTITY (1, 1) NOT NULL,
    [name]       NVARCHAR (200) NULL,
    [address]    NTEXT          NULL,
    [city]       NVARCHAR (200) NULL,
    [agent_name] NVARCHAR (200) NULL,
    [phone]      NVARCHAR (200) NULL,
    [email]      NVARCHAR (200) NULL,
    [remark]     NTEXT          NULL
);

