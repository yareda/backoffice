CREATE TABLE [dbo].[netsqlazman_AuthorizationsTable] (
    [AuthorizationId]       INT            IDENTITY (1, 1) NOT NULL,
    [ItemId]                INT            NOT NULL,
    [ownerSid]              VARBINARY (85) NOT NULL,
    [ownerSidWhereDefined]  TINYINT        NOT NULL,
    [objectSid]             VARBINARY (85) NOT NULL,
    [objectSidWhereDefined] TINYINT        NOT NULL,
    [AuthorizationType]     TINYINT        NOT NULL,
    [ValidFrom]             DATETIME       NULL,
    [ValidTo]               DATETIME       NULL
);

