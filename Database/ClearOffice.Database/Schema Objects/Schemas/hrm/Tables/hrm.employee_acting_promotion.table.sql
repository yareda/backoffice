CREATE TABLE [hrm].[employee_acting_promotion] (
    [acting_id]      INT             IDENTITY (1, 1) NOT NULL,
    [promotion_date] DATETIME        NULL,
    [new_salary]     DECIMAL (18, 2) NULL,
    [old_salary]     DECIMAL (18, 2) NULL,
    [remark]         NVARCHAR (MAX)  NULL
);

