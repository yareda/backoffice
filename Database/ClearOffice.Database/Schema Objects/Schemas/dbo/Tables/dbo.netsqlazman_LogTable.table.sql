CREATE TABLE [dbo].[netsqlazman_LogTable] (
    [LogId]            INT              IDENTITY (1, 1) NOT NULL,
    [LogDateTime]      DATETIME         NOT NULL,
    [WindowsIdentity]  NVARCHAR (255)   NOT NULL,
    [SqlIdentity]      NVARCHAR (128)   NULL,
    [MachineName]      NVARCHAR (255)   NOT NULL,
    [InstanceGuid]     UNIQUEIDENTIFIER NOT NULL,
    [TransactionGuid]  UNIQUEIDENTIFIER NULL,
    [OperationCounter] INT              NOT NULL,
    [ENSType]          NVARCHAR (255)   NOT NULL,
    [ENSDescription]   NVARCHAR (4000)  NOT NULL,
    [LogType]          CHAR (1)         NOT NULL
);

