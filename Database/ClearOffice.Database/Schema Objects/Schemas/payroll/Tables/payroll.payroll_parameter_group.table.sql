CREATE TABLE [payroll].[payroll_parameter_group] (
    [parameter_group_id]   INT            IDENTITY (1, 1) NOT NULL,
    [parameter_group_name] NVARCHAR (MAX) NULL,
    [data_version]         TIMESTAMP      NULL
);

