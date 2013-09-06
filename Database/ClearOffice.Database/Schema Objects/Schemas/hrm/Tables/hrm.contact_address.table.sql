CREATE TABLE [hrm].[contact_address] (
    [address_id]   INT            IDENTITY (1, 1) NOT NULL,
    [person_id]    INT            NULL,
    [pobox]        NVARCHAR (50)  NULL,
    [kebele]       NVARCHAR (50)  NULL,
    [subcity]      NVARCHAR (50)  NULL,
    [housenumber]  NVARCHAR (50)  NULL,
    [city]         NVARCHAR (50)  NULL,
    [country]      NVARCHAR (255) NULL,
    [mobilenumber] NVARCHAR (50)  NULL,
    [homenumber]   NVARCHAR (50)  NULL,
    [faxnumber]    NVARCHAR (50)  NULL,
    [officenumber] NVARCHAR (50)  NULL,
    [region]       NVARCHAR (50)  NULL,
    [email]        NVARCHAR (50)  NULL
);

