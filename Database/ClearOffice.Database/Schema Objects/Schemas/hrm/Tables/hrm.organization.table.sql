CREATE TABLE [hrm].[organization] (
    [node_id]      INT            IDENTITY (1, 1) NOT NULL,
    [parent_id]    INT            NULL,
    [node_type_id] INT            NULL,
    [active]       BIT            NULL,
    [node_name]    NVARCHAR (MAX) NULL,
    [description]  NVARCHAR (MAX) NULL,
    [created_date] DATETIME       NULL,
    [removed_date] DATETIME       NULL
);

