CREATE TABLE [hrm].[employee_pto_status] (
    [leave_status_id] INT             IDENTITY (1, 1) NOT NULL,
    [employee_id]     INT             NULL,
    [prev_count]      DECIMAL (18, 1) NULL,
    [current_count]   DECIMAL (18, 1) NULL
);

