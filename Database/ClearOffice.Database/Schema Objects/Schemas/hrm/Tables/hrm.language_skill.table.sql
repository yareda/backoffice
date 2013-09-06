CREATE TABLE [hrm].[language_skill] (
    [language_skill_id] INT IDENTITY (1, 1) NOT NULL,
    [employee_id]       INT NULL,
    [language_id]       INT NULL,
    [speak]             BIT NULL,
    [read]              BIT NULL,
    [write]             BIT NULL,
    [listen]            BIT NULL
);

