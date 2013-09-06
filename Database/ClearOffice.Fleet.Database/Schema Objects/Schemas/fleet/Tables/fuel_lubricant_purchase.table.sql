CREATE TABLE [fleet].[fuel_lubricant_purchase] (
    [fuel_order_id]        INT             IDENTITY (1, 1) NOT NULL,
    [vehicle_id]           INT             NULL,
    [fuel_guage_indicator] INT             NULL,
    [prev_km_reading]      DECIMAL (18, 2) NULL,
    [prev_fuel_purchase]   DECIMAL (18, 2) NULL,
    [current_km_reading]   DECIMAL (18, 2) NULL,
    [order_id]             INT             NULL,
    [fuel_station_id]      INT             NULL,
    [quantity]             DECIMAL (18, 2) NULL,
    [amount]               DECIMAL (18, 2) NULL,
    [purchase_date]        DATETIME        NULL,
    [form_no]              NVARCHAR (MAX)  NULL,
    [difference_km]        DECIMAL (18, 2) NULL,
    [consumption]          DECIMAL (18, 2) NULL,
    [isPrevious]           BIT             NULL,
    [driver_id]            INT             NULL,
    [data_version]         TIMESTAMP       NULL,
    [reqular_quantity]     DECIMAL (18, 2) NULL,
    [regular_amount]       DECIMAL (18, 2) NULL,
    [gas_oil_quantity]     DECIMAL (18, 2) NULL,
    [gas_oil_amount]       DECIMAL (18, 2) NULL,
    [engine_oil_quantity]  DECIMAL (18, 2) NULL,
    [engine_oil_amount]    DECIMAL (18, 2) NULL,
    [grease_quantity]      DECIMAL (18, 2) NULL,
    [grease_amount]        DECIMAL (18, 2) NULL,
    [washing_quantity]     DECIMAL (18, 2) NULL,
    [washing_amount]       DECIMAL (18, 2) NULL,
    [order_status]         INT             NULL
);



