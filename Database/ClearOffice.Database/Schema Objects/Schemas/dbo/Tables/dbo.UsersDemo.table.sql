CREATE TABLE [dbo].[UsersDemo] (
    [UserID]      INT            IDENTITY (1, 1) NOT NULL,
    [UserName]    NVARCHAR (255) NOT NULL,
    [Password]    VARBINARY (50) NULL,
    [FullName]    NVARCHAR (255) NOT NULL,
    [OtherFields] NVARCHAR (255) NULL
);

