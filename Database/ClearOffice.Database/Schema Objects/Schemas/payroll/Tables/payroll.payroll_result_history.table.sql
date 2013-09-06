CREATE TABLE [payroll].[payroll_result_history] (
    [result_history_id] INT             IDENTITY (1, 1) NOT NULL,
    [employee_id]       INT             NULL,
    [tol_earnings]      DECIMAL (18)    NULL,
    [tol_deductions]    DECIMAL (18)    NULL,
    [gross_salary]      DECIMAL (18)    NULL,
    [income_tax]        DECIMAL (18)    NULL,
    [net_pay]           DECIMAL (18)    NULL,
    [over_pay]          DECIMAL (18)    NULL,
    [pay_period]        DATETIME        NULL,
    [data_version]      TIMESTAMP       NULL,
    [basic_salary]      DECIMAL (18, 2) NULL
);

