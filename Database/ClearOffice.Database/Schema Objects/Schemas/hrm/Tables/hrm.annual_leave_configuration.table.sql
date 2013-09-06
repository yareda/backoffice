CREATE TABLE [hrm].[annual_leave_configuration] (
    [leave_config_id]     INT            IDENTITY (1, 1) NOT NULL,
    [position]            INT            NULL,
    [experiance_in_years] INT            NULL,
    [allowed_no_of_days]  INT            NULL,
    [remark]              NVARCHAR (MAX) NULL,
    [data_version]        TIMESTAMP      NULL
);

