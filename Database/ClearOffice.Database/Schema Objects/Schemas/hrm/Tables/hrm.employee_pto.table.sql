CREATE TABLE [hrm].[employee_pto] (
    [pto_id]       INT             IDENTITY (1, 1) NOT NULL,
    [employee_id]  INT             NOT NULL,
    [from]         DATETIME        NULL,
    [to]           DATETIME        NULL,
    [request_date] DATETIME        NULL,
    [num_days]     DECIMAL (18, 1) NOT NULL,
    [status]       INT             NULL,
    [remark]       NVARCHAR (MAX)  NULL
);



