CREATE TABLE [hrm].[employee_work_experiance] (
    [work_experiance_id] INT             IDENTITY (1, 1) NOT NULL,
    [employee_id]        INT             NULL,
    [start_date]         DATETIME        NULL,
    [end_date]           DATETIME        NULL,
    [position]           NVARCHAR (MAX)  NULL,
    [salary]             DECIMAL (18, 2) NULL,
    [organization]       NVARCHAR (MAX)  NULL,
    [year_duration]      INT             NULL
);

