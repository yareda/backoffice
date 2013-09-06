CREATE TABLE [payroll].[payroll_result] (
    [result_id]     INT             IDENTITY (1, 1) NOT NULL,
    [employee_id]   INT             NULL,
    [basic_salary]  DECIMAL (18, 2) NULL,
    [tolearnings]   DECIMAL (18, 2) NULL,
    [toldeductions] DECIMAL (18, 2) NULL,
    [grosssalary]   DECIMAL (18, 2) NULL,
    [incometax]     DECIMAL (18, 2) NULL,
    [netpay]        DECIMAL (18, 2) NULL,
    [overpay]       DECIMAL (18, 2) NULL,
    [data_version]  TIMESTAMP       NULL
);

