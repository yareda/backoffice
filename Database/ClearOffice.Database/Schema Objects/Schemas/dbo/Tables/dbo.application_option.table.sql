CREATE TABLE [dbo].[application_option] (
    [option_id]        INT            IDENTITY (1, 1) NOT NULL,
    [module_id]        INT            NULL,
    [option_name]      NVARCHAR (200) NULL,
    [option_value]     NVARCHAR (200) NULL,
    [option_help_text] NVARCHAR (200) NULL
);

