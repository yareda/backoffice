CREATE TABLE [hrm].[employee_custom_field_value] (
    [custom_field_value_id] NUMERIC (18)   IDENTITY (1, 1) NOT NULL,
    [custom_field_id]       INT            NULL,
    [employee_id]           INT            NULL,
    [field_value]           NVARCHAR (MAX) NULL
);

