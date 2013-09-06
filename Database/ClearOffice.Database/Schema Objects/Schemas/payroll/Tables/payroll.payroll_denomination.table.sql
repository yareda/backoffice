CREATE TABLE [payroll].[payroll_denomination] (
    [denom_record_id] INT             IDENTITY (1, 1) NOT NULL,
    [employee_id]     INT             NULL,
    [net_pay]         DECIMAL (18, 2) NULL,
    [note100]         INT             NULL,
    [note50]          INT             NULL,
    [note10]          INT             NULL,
    [note5]           INT             NULL,
    [note1]           INT             NULL,
    [cent50]          INT             NULL,
    [cent25]          INT             NULL,
    [cent10]          INT             NULL,
    [cent5]           INT             NULL,
    [cent1]           INT             NULL,
    [data_version]    TIMESTAMP       NULL
);

