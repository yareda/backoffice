CREATE TABLE [hrm].[employee_insurance] (
    [insurance_id]   INT             IDENTITY (1, 1) NOT NULL,
    [employee_id]    INT             NULL,
    [policy_type_id] INT             NULL,
    [start_date]     DATETIME        NULL,
    [duration]       INT             NULL,
    [policy_no]      NVARCHAR (200)  NULL,
    [company_id]     INT             NULL,
    [coverage_limit] DECIMAL (18, 2) NULL,
    [remark]         NVARCHAR (MAX)  NULL
);

