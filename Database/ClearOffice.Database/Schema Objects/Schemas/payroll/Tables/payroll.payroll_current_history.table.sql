CREATE TABLE [payroll].[payroll_current_history] (
    [current_record_id] INT          IDENTITY (1, 1) NOT NULL,
    [employee_id]       INT          NULL,
    [param_id]          INT          NULL,
    [hrs]               DECIMAL (18) NULL,
    [amount]            DECIMAL (18) NULL,
    [is_approve]        BIT          NULL,
    [is_transfer]       BIT          NULL,
    [pay_period]        DATETIME     NULL,
    [data_version]      TIMESTAMP    NULL
);

