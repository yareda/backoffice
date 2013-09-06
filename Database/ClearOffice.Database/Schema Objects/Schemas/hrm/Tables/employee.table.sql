CREATE TABLE [hrm].[employee] (
    [employee_id]          INT             IDENTITY (1, 1) NOT NULL,
    [person_id]            INT             NULL,
    [employee_no]          NVARCHAR (50)   NOT NULL,
    [employee_type]        INT             NULL,
    [hire_date]            DATETIME        NULL,
    [salary]               DECIMAL (18, 2) NOT NULL,
    [remark]               NVARCHAR (MAX)  NULL,
    [back_pay]             DECIMAL (18, 2) NULL,
    [pf_amount]            DECIMAL (18, 2) NULL,
    [deleted]              BIT             NULL,
    [medical_deposit]      DECIMAL (18, 2) NULL,
    [accrued_leave]        DECIMAL (18, 2) NULL,
    [grade_id]             INT             NULL,
    [account_no]           NVARCHAR (MAX)  NULL,
    [is_managment]         BIT             NULL,
    [current_leave_days]   DECIMAL (18, 1) NULL,
    [contract_expire_date] DATETIME        NULL,
    [year_count]           INT             NULL,
    [licence_expire_date]  DATETIME        NULL,
    [pf_account_no]        NVARCHAR (MAX)  NULL,
    [bank_branch_id]       INT             NULL,
    [status_id]            INT             NULL,
    [job_id]               INT             NULL,
    [node_id]              INT             NULL
);







