CREATE TABLE [hrm].[employee_transfer] (
    [transfer_id]     INT           IDENTITY (1, 1) NOT NULL,
    [employee_id]     INT           NULL,
    [transfer_date]   DATETIME      NOT NULL,
    [transfer_reason] VARCHAR (250) NOT NULL,
    [summary]         VARCHAR (250) NULL,
    [prev_title]      INT           NOT NULL,
    [prev_location]   INT           NOT NULL,
    [new_title]       INT           NOT NULL,
    [new_location]    INT           NOT NULL,
    [effective_date]  DATETIME      NOT NULL,
    [remark]          VARCHAR (500) NULL,
    [approved_by]     VARCHAR (250) NOT NULL
);









