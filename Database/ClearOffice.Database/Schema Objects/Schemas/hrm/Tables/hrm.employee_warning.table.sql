CREATE TABLE [hrm].[employee_warning] (
    [warning_id]       INT            IDENTITY (1, 1) NOT NULL,
    [employee_id]      INT            NULL,
    [warning_type_id]  INT            NULL,
    [warning_date]     DATETIME       NULL,
    [warning_given_by] NVARCHAR (200) NULL,
    [warning_reason]   NVARCHAR (MAX) NULL
);

