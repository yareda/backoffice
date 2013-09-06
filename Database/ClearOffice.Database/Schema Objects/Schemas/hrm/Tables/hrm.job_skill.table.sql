CREATE TABLE [hrm].[job_skill] (
    [job_skill_id] INT IDENTITY (1, 1) NOT NULL,
    [job_id]       INT NULL,
    [skill_id]     INT NULL,
    [skill_level]  INT NULL,
    [required]     BIT NULL
);

