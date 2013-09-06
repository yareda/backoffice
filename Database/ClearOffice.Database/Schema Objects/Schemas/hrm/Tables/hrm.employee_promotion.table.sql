CREATE TABLE [hrm].[employee_promotion] (
    [promotion_id]   INT            IDENTITY (1, 1) NOT NULL,
    [employee_id]    INT            NULL,
    [type]           INT            NULL,
    [action_date]    DATETIME       NULL,
    [action_by]      NVARCHAR (200) NULL,
    [action_reason]  NVARCHAR (MAX) NULL,
    [previous_title] INT            NULL,
    [new_title]      INT            NULL,
    [previous_node]  INT            NULL,
    [new_node]       INT            NULL
);

