CREATE TABLE [payroll].[payroll_pay_slip] (
    [pay_slip_id]  INT       IDENTITY (1, 1) NOT NULL,
    [employee_id]  INT       NULL,
    [earnings]     NTEXT     NULL,
    [deductions]   NTEXT     NULL,
    [earnvals]     NTEXT     NULL,
    [deducvals]    NTEXT     NULL,
    [data_version] TIMESTAMP NULL
);

