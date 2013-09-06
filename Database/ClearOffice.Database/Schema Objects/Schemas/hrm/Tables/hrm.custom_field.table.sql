CREATE TABLE [hrm].[custom_field] (
    [custom_field_id] INT            IDENTITY (1, 1) NOT NULL,
    [field_name]      NVARCHAR (MAX) NULL,
    [field_type]      NVARCHAR (MAX) NULL,
    [field_value]     NVARCHAR (MAX) NULL,
    [help_text]       NVARCHAR (MAX) NULL
);

