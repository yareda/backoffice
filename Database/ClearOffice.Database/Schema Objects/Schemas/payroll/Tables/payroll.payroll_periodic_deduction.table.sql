CREATE TABLE [payroll].[payroll_periodic_deduction] (
    [periodic_id]      INT             IDENTITY (1, 1) NOT NULL,
    [employee_id]      INT             NULL,
    [param_id]         INT             NULL,
    [monthly_amount]   DECIMAL (18, 2) NULL,
    [pay_period]       INT             NULL,
    [remaining_period] INT             NULL,
    [initail_amount]   DECIMAL (18, 2) NULL,
    [balance]          DECIMAL (18, 2) NULL,
    [data_version]     TIMESTAMP       NULL,
    [loan_id]          INT             NULL
);

