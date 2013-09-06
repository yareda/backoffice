CREATE TABLE [hrm].[employee_pto_transaction] (
    [transaction_id] INT             IDENTITY (1, 1) NOT NULL,
    [employee_id]    INT             NOT NULL,
    [year]           INT             NULL,
    [no_days]        DECIMAL (18, 1) NOT NULL,
    [approved_date]  DATETIME        NULL,
    [approved_by]    NVARCHAR (50)   NULL
);

