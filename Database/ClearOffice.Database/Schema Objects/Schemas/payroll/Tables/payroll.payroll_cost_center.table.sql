CREATE TABLE [payroll].[payroll_cost_center] (
    [cost_center_id] INT            IDENTITY (1, 1) NOT NULL,
    [cost_center]    NVARCHAR (MAX) NULL,
    [data_version]   TIMESTAMP      NULL
);

