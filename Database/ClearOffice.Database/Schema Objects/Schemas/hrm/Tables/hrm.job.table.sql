CREATE TABLE [hrm].[job] (
    [job_id]                 INT             IDENTITY (1, 1) NOT NULL,
    [node_id]                INT             NULL,
    [job_title]              NVARCHAR (MAX)  NULL,
    [job_summary]            NVARCHAR (MAX)  NULL,
    [job_code]               NVARCHAR (100)  NULL,
    [active]                 BIT             NULL,
    [original_approval_date] DATE            NULL,
    [revision_date]          DATE            NULL,
    [comment]                NVARCHAR (MAX)  NULL,
    [responsibility]         NVARCHAR (MAX)  NULL,
    [work_condition]         NVARCHAR (MAX)  NULL,
    [required_experience]    NVARCHAR (MAX)  NULL,
    [required_education]     NVARCHAR (MAX)  NULL,
    [initial_leave_amount]   DECIMAL (18, 1) NULL
);



