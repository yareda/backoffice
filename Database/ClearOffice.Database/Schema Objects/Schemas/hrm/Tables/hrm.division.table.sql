CREATE TABLE [hrm].[division] (
    [division_id]   INT            IDENTITY (1, 1) NOT NULL,
    [department_id] INT            NULL,
    [division_name] NVARCHAR (200) NULL,
    [description]   NVARCHAR (MAX) NULL
);

