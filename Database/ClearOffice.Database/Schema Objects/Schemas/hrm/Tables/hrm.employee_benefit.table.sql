CREATE TABLE [hrm].[employee_benefit] (
    [employee_benefit_id] INT             IDENTITY (1, 1) NOT NULL,
    [benefit_type_id]     INT             NULL,
    [employee_id]         INT             NULL,
    [benefit_name]        NVARCHAR (200)  NULL,
    [benefit_amount]      DECIMAL (18, 2) NULL,
    [description]         NVARCHAR (MAX)  NULL
);

