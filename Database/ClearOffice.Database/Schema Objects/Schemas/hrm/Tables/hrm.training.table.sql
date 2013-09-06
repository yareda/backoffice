CREATE TABLE [hrm].[training] (
    [training_id]         INT             IDENTITY (1, 1) NOT NULL,
    [training_request_id] INT             NULL,
    [approved_date]       DATETIME        NULL,
    [approved_by]         NVARCHAR (200)  NULL,
    [approval_remark]     NVARCHAR (MAX)  NULL,
    [allocated_budget]    DECIMAL (18, 2) NULL,
    [schedule_from]       DATETIME        NULL,
    [schedule_to]         DATETIME        NULL,
    [conducted_from]      DATETIME        NULL,
    [conducted_to]        DATETIME        NULL,
    [conducted_by]        NVARCHAR (MAX)  NULL,
    [actual_cost]         DECIMAL (18, 2) NULL
);

