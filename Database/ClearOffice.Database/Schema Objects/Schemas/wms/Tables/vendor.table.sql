CREATE TABLE [wms].[vendor] (
    [vendor_id]   INT            IDENTITY (100000, 1) NOT NULL,
    [name]        NVARCHAR (200) NULL,
    [vendor_type] INT            NOT NULL,
    [contact]     NVARCHAR (200) NULL,
    [address]     NVARCHAR (200) NULL,
    [city]        NVARCHAR (200) NULL,
    [postal_code] NVARCHAR (200) NULL,
    [country]     INT            NOT NULL,
    [phone1]      NVARCHAR (200) NULL,
    [phone2]      NVARCHAR (200) NULL,
    [fax]         NVARCHAR (200) NULL,
    [email]       NVARCHAR (200) NULL,
    [remark]      NVARCHAR (MAX) NULL
);











