CREATE TABLE [payroll].[payroll_parameter] (
    [param_id]           INT             IDENTITY (1, 1) NOT NULL,
    [type_id]            INT             NULL,
    [condition_id]       INT             NULL,
    [value_type_id]      INT             NULL,
    [param_name]         NVARCHAR (MAX)  NULL,
    [param_description]  NVARCHAR (MAX)  NULL,
    [is_taxable]         BIT             NULL,
    [tax_above]          DECIMAL (18, 2) NULL,
    [param_value]        DECIMAL (18, 2) NULL,
    [rate]               DECIMAL (18, 2) NULL,
    [salary_percent]     DECIMAL (18, 2) NULL,
    [data_version]       TIMESTAMP       NULL,
    [is_ot]              BIT             NULL,
    [is_other]           BIT             NULL,
    [parameter_group_id] INT             NULL
);

