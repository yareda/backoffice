CREATE TABLE [hrm].[training_request] (
    [training_request_id]            INT             IDENTITY (1, 1) NOT NULL,
    [training_title]                 NVARCHAR (MAX)  NULL,
    [requested_date]                 DATETIME        NULL,
    [requested_by]                   NVARCHAR (200)  NULL,
    [training_description]           NVARCHAR (MAX)  NULL,
    [estimated_number_of_attendants] INT             NULL,
    [training_category_id]           INT             NULL,
    [estimated_budget]               DECIMAL (18, 2) NULL,
    [budget_secured]                 BIT             NULL,
    [status]                         INT             NULL
);



