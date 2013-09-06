CREATE TABLE [hrm].[employee_termination] (
    [termination_id]     INT            IDENTITY (1, 1) NOT NULL,
    [employee_id]        INT            NULL,
    [termination_date]   DATETIME       NULL,
    [effective_date]     DATETIME       NULL,
    [action_taken_by]    NVARCHAR (200) NULL,
    [termination_reason] NVARCHAR (MAX) NULL
)

