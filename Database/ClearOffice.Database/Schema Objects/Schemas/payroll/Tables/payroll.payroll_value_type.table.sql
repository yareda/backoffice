CREATE TABLE [payroll].[payroll_value_type] (
    [value_type_id]   INT            IDENTITY (1, 1) NOT NULL,
    [value_type_name] NVARCHAR (MAX) NULL,
    [data_version]    TIMESTAMP      NULL
);

