CREATE TABLE [hrm].[document] (
    [doc_id]       INT            IDENTITY (1, 1) NOT NULL,
    [file_path]    VARCHAR (1000) NOT NULL,
    [file_name]    VARCHAR (500)  NOT NULL,
    [description]  VARCHAR (MAX)  NULL,
    [data_version] TIMESTAMP      NOT NULL
);

