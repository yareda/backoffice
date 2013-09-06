CREATE TABLE [hrm].[training_attendance] (
    [training_atendant_id] INT IDENTITY (1, 1) NOT NULL,
    [training_id]          INT NULL,
    [employee_id]          INT NULL,
    [has_completed]        BIT NULL
);

