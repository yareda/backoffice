CREATE TABLE [payroll].[payroll_history] (
    [record_id]    INT             NULL,
    [employee_id]  INT             NULL,
    [param_id]     INT             NULL,
    [hrs]          DECIMAL (18, 2) NULL,
    [amount]       DECIMAL (18, 2) NULL,
    [pay_period]   DATETIME        NULL,
    [is_approved]  BIT             NULL,
    [is_transfer]  BIT             NULL,
    [data_version] TIMESTAMP       NULL
);

