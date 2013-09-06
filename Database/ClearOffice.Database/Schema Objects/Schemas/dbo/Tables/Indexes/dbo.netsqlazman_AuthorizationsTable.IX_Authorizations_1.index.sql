CREATE NONCLUSTERED INDEX [IX_Authorizations_1]
    ON [dbo].[netsqlazman_AuthorizationsTable]([ItemId] ASC, [objectSid] ASC, [objectSidWhereDefined] ASC, [AuthorizationType] ASC, [ValidFrom] ASC, [ValidTo] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF, ONLINE = OFF, MAXDOP = 0)
    ON [PRIMARY];

