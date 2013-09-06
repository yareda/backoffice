CREATE TABLE [hrm].[insurance_company] (
    [company_id]   INT            IDENTITY (1, 1) NOT NULL,
    [company_name] NVARCHAR (200) NULL,
    [address]      NVARCHAR (MAX) NULL,
    [contact]      NVARCHAR (MAX) NULL
);

