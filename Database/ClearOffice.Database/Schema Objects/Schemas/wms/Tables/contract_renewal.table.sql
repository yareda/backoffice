CREATE TABLE [wms].[contract_renewal] (
    [renewal_id]    INT             IDENTITY (1, 1) NOT NULL,
    [contract_id]   INT             NOT NULL,
    [date_renewed]  DATE            NULL,
    [start_date]    DATE            NULL,
    [duration]      INT             NULL,
    [payment_terms] INT             NULL,
    [amount]        DECIMAL (10, 2) NULL,
    [description]   NVARCHAR (200)  NULL,
    [status]        INT             NOT NULL
);









