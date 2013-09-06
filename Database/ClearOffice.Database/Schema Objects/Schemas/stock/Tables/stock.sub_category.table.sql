CREATE TABLE [stock].[sub_category] (
    [sub_category_id] INT            IDENTITY (1, 1) NOT NULL,
    [category_id]     INT            NULL,
    [name]            NVARCHAR (200) NULL,
    [description]     NVARCHAR (MAX) NULL
);

