CREATE TABLE [payroll].[payroll_current] (
    [current_record_id] INT             IDENTITY (1, 1) NOT NULL,
    [param_id]          INT             NULL,
    [employee_id]       INT             NULL,
    [hrs]               DECIMAL (18, 2) NULL,
    [amount]            DECIMAL (18, 2) NULL,
    [isapprove]         BIT             NULL,
    [istransfer]        BIT             NULL,
    [data_version]      TIMESTAMP       NULL
);

