CREATE TABLE [payroll].[payroll_setting] (
    [setting_id]   INT          IDENTITY (1, 1) NOT NULL,
    [tax_table_id] INT          NULL,
    [wrk_dys]      INT          NULL,
    [wrk_hrs]      DECIMAL (18) NULL,
    [pay_period]   DATETIME     NULL,
    [data_version] TIMESTAMP    NULL
);

