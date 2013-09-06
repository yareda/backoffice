CREATE TABLE [dbo].[user] (
    [user_id]                 INT            IDENTITY (1, 1) NOT NULL,
    [user_name]               NVARCHAR (200) NULL,
    [full_name]               NVARCHAR (200) NULL,
    [password]                NVARCHAR (MAX) NULL,
    [password_never_expires]  BIT            NULL,
    [disabled]                BIT            NULL,
    [can_not_change_password] BIT            NULL
);

