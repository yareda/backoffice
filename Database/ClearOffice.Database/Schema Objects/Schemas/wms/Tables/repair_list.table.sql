CREATE TABLE [wms].[repair_list] (
    [id]              INT            IDENTITY (1, 1) NOT NULL,
    [repair_schedule] INT            NOT NULL,
    [repair]          BIT            NULL,
    [comment]         NVARCHAR (MAX) NULL
);

