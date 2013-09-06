CREATE TABLE [dbo].[netsqlazman_StoreGroupMembersTable] (
    [StoreGroupMemberId] INT            IDENTITY (1, 1) NOT NULL,
    [StoreGroupId]       INT            NOT NULL,
    [objectSid]          VARBINARY (85) NOT NULL,
    [WhereDefined]       TINYINT        NOT NULL,
    [IsMember]           BIT            NOT NULL
);

