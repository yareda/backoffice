CREATE TABLE [wms].[equipment] (
    [equipment_id]   INT            IDENTITY (1, 1) NOT NULL,
    [category_id]    INT            NULL,
    [contract_id]    INT            NULL,
    [renewal_id]     INT            NULL,
    [status_id]      INT            NULL,
    [make]           INT            NULL,
    [model]          INT            NULL,
    [serial]         NVARCHAR (200) NULL,
    [date_installed] DATE           NULL,
    [mileage]        NVARCHAR (200) NULL,
    [hours]          NVARCHAR (200) NULL,
    [base_mileage]   NVARCHAR (200) NULL,
    [base_hours]     NVARCHAR (200) NULL,
    [base_date]      DATE           NULL,
    [assigned]       NVARCHAR (200) NULL,
    [photo]          IMAGE          NULL,
    [description]    NVARCHAR (200) NULL,
    [remark]         NVARCHAR (MAX) NULL
);



