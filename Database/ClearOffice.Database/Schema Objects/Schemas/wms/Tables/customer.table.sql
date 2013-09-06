CREATE TABLE [wms].[customer] (
    [customer_id] INT            IDENTITY (1, 1) NOT NULL,
    [type]        INT            NULL,
    [name]        NVARCHAR (200) NULL,
    [contact]     NVARCHAR (200) NULL,
    [address]     NVARCHAR (200) NULL,
    [city]        NVARCHAR (200) NULL,
    [postal_code] NVARCHAR (200) NULL,
    [phone1]      NVARCHAR (200) NULL,
    [phone2]      NVARCHAR (200) NULL,
    [fax]         NVARCHAR (200) NULL,
    [email]       NVARCHAR (200) NULL,
    [remark]      NVARCHAR (MAX) NULL
);



