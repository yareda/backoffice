CREATE TABLE [payroll].[payroll_pay_slip_history] (
    [pay_slip_history_id] INT       IDENTITY (1, 1) NOT NULL,
    [employee_id]         INT       NULL,
    [earnings]            NTEXT     NULL,
    [deductions]          NTEXT     NULL,
    [earnvals]            NTEXT     NULL,
    [deducvals]           NTEXT     NULL,
    [pay_period]          DATETIME  NULL,
    [data_version]        TIMESTAMP NULL
);

