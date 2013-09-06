CREATE TABLE [hrm].[certificate] (
    [certificate_id] INT            IDENTITY (1, 1) NOT NULL,
    [title]          NVARCHAR (100) NOT NULL,
    [description]    NVARCHAR (MAX) NULL,
    [data_version]   TIMESTAMP      NULL
);

