ALTER TABLE [dbo].[netsqlazman_LogTable]
    ADD CONSTRAINT [CK_Log] CHECK ([LogType]='I' OR [LogType]='W' OR [LogType]='E');

