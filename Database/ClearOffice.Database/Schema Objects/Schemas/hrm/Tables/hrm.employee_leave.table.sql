CREATE TABLE [hrm].[employee_leave] (
    [leave_id]      INT             IDENTITY (1, 1) NOT NULL,
    [leave_type_id] INT             NULL,
    [employee_id]   INT             NULL,
    [from]          DATETIME        NULL,
    [to]            DATETIME        NULL,
    [num_days]      DECIMAL (18, 1) NULL,
    [request_date]  DATETIME        NULL,
    [remark]        NVARCHAR (MAX)  NULL
);

