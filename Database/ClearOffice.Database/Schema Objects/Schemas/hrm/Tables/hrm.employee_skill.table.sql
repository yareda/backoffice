CREATE TABLE [hrm].[employee_skill] (
    [employee_skill_id] INT            IDENTITY (1, 1) NOT NULL,
    [skill_id]          INT            NULL,
    [employee_id]       INT            NULL,
    [skill_score]       NVARCHAR (MAX) NULL,
    [skill_description] NVARCHAR (MAX) NULL
);

