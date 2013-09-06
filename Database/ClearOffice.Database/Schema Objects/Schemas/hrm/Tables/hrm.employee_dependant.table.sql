CREATE TABLE [hrm].[employee_dependant] (
    [dependant_id]      INT           IDENTITY (1, 1) NOT NULL,
    [dependant_type_id] INT           NULL,
    [employee_id]       INT           NULL,
    [first_name]        VARCHAR (200) NULL,
    [father_name]       VARCHAR (200) NULL,
    [sex]               INT           NULL,
    [birth_date]        DATETIME      NULL
);

