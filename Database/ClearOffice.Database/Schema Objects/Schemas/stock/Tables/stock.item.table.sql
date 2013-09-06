CREATE TABLE [stock].[item] (
    [item_id]         INT             IDENTITY (1, 1) NOT NULL,
    [unit_id]         INT             NULL,
    [category_id]     INT             NULL,
    [sub_category_id] INT             NULL,
    [item_no]         NVARCHAR (100)  NULL,
    [description]     NVARCHAR (MAX)  NULL,
    [remark]          NVARCHAR (MAX)  NULL,
    [image]           VARBINARY (MAX) NULL
);

