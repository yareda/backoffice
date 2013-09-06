CREATE TABLE [wms].[part] (
    [part_id]      INT             IDENTITY (1, 1) NOT NULL,
    [part_name]    NVARCHAR (200)  NULL,
    [description]  NVARCHAR (MAX)  NULL,
    [manufacturer] NVARCHAR (200)  NULL,
    [unit_measure] INT             NULL,
    [unit_cost]    DECIMAL (10, 2) NULL,
    [warranty]     INT             NULL
);

