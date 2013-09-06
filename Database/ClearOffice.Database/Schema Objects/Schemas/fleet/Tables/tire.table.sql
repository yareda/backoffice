CREATE TABLE [fleet].[tire] (
    [tire_id]        INT            IDENTITY (1, 1) NOT NULL,
    [brand]          INT            NULL,
    [size]           INT            NULL,
    [tire_type]      INT            NULL,
    [serial_no]      NVARCHAR (200) NULL,
    [purchased_date] DATETIME       NULL,
    [status]         INT            NULL,
    [vendor]         INT            NULL,
    [comment]        NTEXT          NULL
);









