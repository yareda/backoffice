CREATE TABLE [hrm].[country] (
    [country_id]   INT            IDENTITY (1, 1) NOT NULL,
    [name]         NVARCHAR (100) NOT NULL,
    [country_code] NVARCHAR (10)  NULL
);

