CREATE TABLE [hrm].[employee_medical_record] (
    [medical_id]           INT             IDENTITY (1, 1) NOT NULL,
    [employee_id]          INT             NULL,
    [date_recorded]        DATETIME        NOT NULL,
    [referal]              VARCHAR (50)    NOT NULL,
    [prescription]         VARCHAR (MAX)   NULL,
    [cost]                 DECIMAL (18, 2) NULL,
    [pharmacy]             NVARCHAR (MAX)  NULL,
    [receipt_no]           NVARCHAR (MAX)  NULL,
    [sickness]             NVARCHAR (MAX)  NULL,
    [dependant_id]         INT             NULL,
    [lab_paid_amount]      DECIMAL (18, 2) NULL,
    [xray_paid_amount]     DECIMAL (18, 2) NULL,
    [pharmacy_paid_amount] DECIMAL (18, 2) NULL,
    [registration_fee]     DECIMAL (18, 2) NULL
);

