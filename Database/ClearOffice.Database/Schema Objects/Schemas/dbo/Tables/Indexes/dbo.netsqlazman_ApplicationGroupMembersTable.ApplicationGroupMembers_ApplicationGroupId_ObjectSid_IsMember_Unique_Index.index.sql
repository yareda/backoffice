CREATE UNIQUE NONCLUSTERED INDEX [ApplicationGroupMembers_ApplicationGroupId_ObjectSid_IsMember_Unique_Index]
    ON [dbo].[netsqlazman_ApplicationGroupMembersTable]([ApplicationGroupId] ASC, [objectSid] ASC, [IsMember] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF, ONLINE = OFF, MAXDOP = 0)
    ON [PRIMARY];

