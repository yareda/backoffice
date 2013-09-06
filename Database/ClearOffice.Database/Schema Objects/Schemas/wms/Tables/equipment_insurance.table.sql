CREATE TABLE [wms].[equipment_insurance] (
    [insurance_id]  INT             IDENTITY (1, 1) NOT NULL,
    [equipment_id]  INT             NULL,
    [company_id]    INT             NOT NULL,
    [policy_number] NVARCHAR (200)  NULL,
    [start_date]    DATE            NULL,
    [end_date]      DATE            NULL,
    [payment]       DECIMAL (10, 2) NULL,
    [deductable]    DECIMAL (10, 2) NULL,
    [remark]        NVARCHAR (MAX)  NULL
);











