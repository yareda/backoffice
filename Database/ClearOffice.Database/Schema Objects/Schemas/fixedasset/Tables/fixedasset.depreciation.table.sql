CREATE TABLE [fixedasset].[depreciation] (
    [depreciation_id]                 INT             IDENTITY (1, 1) NOT NULL,
    [asset_id]                        INT             NULL,
    [fiscal_year]                     CHAR (4)        NULL,
    [fiscal_period]                   INT             NULL,
    [book_value_at_beginning_of_year] DECIMAL (18, 2) NULL,
    [book_value_at_end_of_year]       DECIMAL (18, 2) NULL,
    [total_depreciation_cost]         DECIMAL (18, 2) NULL,
    [depreciation_rate]               DECIMAL (18, 2) NULL,
    [deprecation_expense]             DECIMAL (18, 2) NULL,
    [accumulated_depreciation]        DECIMAL (18, 2) NULL,
    [year]                            INT             NULL,
    [month]                           INT             NULL
);





