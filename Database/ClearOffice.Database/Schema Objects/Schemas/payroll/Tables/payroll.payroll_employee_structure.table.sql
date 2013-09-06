CREATE TABLE [payroll].[payroll_employee_structure] (
    [cost_center_id] INT             NOT NULL,
    [employee_id]    INT             NOT NULL,
    [salary]         DECIMAL (18, 2) NULL,
    [data_version]   TIMESTAMP       NULL,
    [record_id]      INT             IDENTITY (1, 1) NOT NULL
);

