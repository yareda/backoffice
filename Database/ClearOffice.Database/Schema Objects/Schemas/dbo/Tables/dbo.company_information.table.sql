CREATE TABLE [dbo].[company_information] (
    [company_id]   INT            NOT NULL,
    [company_name] NVARCHAR (200) NULL,
    [address]      NVARCHAR (MAX) NULL,
    [city]         NVARCHAR (200) NULL,
    [country]      NVARCHAR (200) NULL,
    [phone]        NVARCHAR (200) NULL,
    [emial]        NVARCHAR (200) NULL,
    [website]      NVARCHAR (200) NULL,
    [postal_code]  NVARCHAR (200) NULL
);

