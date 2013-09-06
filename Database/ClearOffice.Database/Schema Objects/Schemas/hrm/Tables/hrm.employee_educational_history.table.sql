CREATE TABLE [hrm].[employee_educational_history] (
    [education_id]       INT            IDENTITY (1, 1) NOT NULL,
    [employee_id]        INT            NULL,
    [education_type_id]  INT            NULL,
    [education_level_id] INT            NULL,
    [end_date]           DATETIME       NULL,
    [start_date]         DATETIME       NULL,
    [institution]        NVARCHAR (MAX) NULL,
    [grade_completed]    NVARCHAR (MAX) NULL,
    [award]              NVARCHAR (MAX) NULL
);

