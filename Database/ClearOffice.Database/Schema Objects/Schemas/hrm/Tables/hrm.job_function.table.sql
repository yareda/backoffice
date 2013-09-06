CREATE TABLE [hrm].[job_function] (
    [job_function_id] INT            IDENTITY (1, 1) NOT NULL,
    [job_id]          INT            NULL,
    [explanation]     NVARCHAR (MAX) NULL
);

