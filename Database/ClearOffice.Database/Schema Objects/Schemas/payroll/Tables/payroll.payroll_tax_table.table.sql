CREATE TABLE [payroll].[payroll_tax_table] (
    [tax_table_id] INT             IDENTITY (1, 1) NOT NULL,
    [govno]        NVARCHAR (MAX)  NULL,
    [dec_date]     DATETIME        NULL,
    [min_sal]      DECIMAL (18, 2) NULL,
    [max_sal]      DECIMAL (18, 2) NULL,
    [tax_percent]  DECIMAL (18, 2) NULL,
    [deduction]    DECIMAL (18, 2) NULL,
    [data_version] TIMESTAMP       NULL
);

