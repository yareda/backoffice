CREATE TABLE [fixedasset].[custodian] (
    [custodian_id] INT            IDENTITY (1, 1) NOT NULL,
    [badge_no]     NVARCHAR (200) NULL,
    [first_name]   NVARCHAR (200) NULL,
    [last_name]    NVARCHAR (200) NULL,
    [status]       BIT            NULL,
    [location]     NVARCHAR (200) NULL,
    [department]   INT            NULL,
    [remark]       NVARCHAR (MAX) NULL
);

