CREATE TABLE [fleet].[vehicle] (
    [vehicle_id]        INT            IDENTITY (1, 1) NOT NULL,
    [plate_number]      NVARCHAR (200) NULL,
    [make_id]           INT            NULL,
    [vehicle_type]      INT            NULL,
    [model_id]          NVARCHAR (200) NULL,
    [vendor_id]         INT            NULL,
    [status_id]         NVARCHAR (MAX) NULL,
    [ownership]         INT            NULL,
    [production_year]   INT            NULL,
    [purchased_from]    NVARCHAR (200) NULL,
    [purchase_date]     DATETIME       NULL,
    [purchase_price]    MONEY          NULL,
    [purchase_odometer] FLOAT          NULL,
    [engine_serial]     NVARCHAR (200) NULL,
    [chasis_no]         NVARCHAR (200) NULL,
    [cylinders]         INT            NULL,
    [power]             INT            NULL,
    [fuel_type_id]      INT            NULL,
    [color_id]          INT            NULL,
    [no_of_tires]       INT            NULL,
    [tyre_config]       INT            NULL,
    [libre_no]          NVARCHAR (100) NULL,
    [fueltank_capacity] INT            NULL,
    [picture]           IMAGE          NULL,
    [remark]            NVARCHAR (MAX) NULL
);



