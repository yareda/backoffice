CREATE TABLE [hrm].[employee_disciplinary_measure] (
    [measure_id]      INT            IDENTITY (1, 1) NOT NULL,
    [measure_type_id] INT            NULL,
    [employee_id]     INT            NULL,
    [date_taken]      DATETIME       NULL,
    [measure]         NVARCHAR (MAX) NULL,
    [reference]       NVARCHAR (MAX) NULL,
    [taken_by]        NVARCHAR (MAX) NULL
);

