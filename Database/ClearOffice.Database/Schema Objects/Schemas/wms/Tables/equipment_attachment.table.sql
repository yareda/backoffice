CREATE TABLE [wms].[equipment_attachment] (
    [attachment_id] INT             IDENTITY (1, 1) NOT NULL,
    [equipment_id]  INT             NULL,
    [file_name]     NVARCHAR (200)  NULL,
    [file]          VARBINARY (MAX) NULL,
    [file_type]     NVARCHAR (50)   NULL,
    [description]   NVARCHAR (MAX)  NULL
);













