CREATE TABLE [fleet].[maintanance] (
    [maintenance_id]      INT            IDENTITY (1, 1) NOT NULL,
    [vehicle_id]          INT            NOT NULL,
    [creation_date]       DATETIME       NULL,
    [completion_date]     DATETIME       NULL,
    [service_request_no]  NVARCHAR (200) NULL,
    [serviced_by_type_id] BIT            NULL,
    [serviced_by]         INT            NULL,
    [account_no]          NVARCHAR (200) NULL,
    [service_type_id]     INT            NULL,
    [description]         NTEXT          NULL,
    [status]              INT            NULL,
    [closed_date]         DATE           NULL,
    [closed_by]           NVARCHAR (200) NULL,
    [closing_remark]      NVARCHAR (MAX) NULL
);



