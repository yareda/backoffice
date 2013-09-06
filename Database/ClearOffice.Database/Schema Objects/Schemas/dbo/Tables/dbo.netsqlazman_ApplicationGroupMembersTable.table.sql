CREATE TABLE [dbo].[netsqlazman_ApplicationGroupMembersTable] (
    [ApplicationGroupMemberId] INT            IDENTITY (1, 1) NOT NULL,
    [ApplicationGroupId]       INT            NOT NULL,
    [objectSid]                VARBINARY (85) NOT NULL,
    [WhereDefined]             TINYINT        NOT NULL,
    [IsMember]                 BIT            NOT NULL
);

