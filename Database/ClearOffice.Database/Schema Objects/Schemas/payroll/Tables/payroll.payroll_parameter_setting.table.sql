CREATE TABLE [payroll].[payroll_parameter_setting] (
    [param_setting_id] INT       IDENTITY (1, 1) NOT NULL,
    [employee_id]      INT       NULL,
    [param_id]         INT       NULL,
    [is_active]        BIT       NULL,
    [data_version]     TIMESTAMP NULL
);

