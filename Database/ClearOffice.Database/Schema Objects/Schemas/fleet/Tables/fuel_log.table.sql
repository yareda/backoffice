CREATE TABLE [fleet].[fuel_log] (
    [fuel_log_id]      INT            IDENTITY (1, 1) NOT NULL,
    [vehicle_id]       INT            NULL,
    [filled_date]      DATETIME       NULL,
    [last_odometer]    FLOAT          NULL,
    [current_odometer] FLOAT          NULL,
    [distance_covered] INT            NULL,
    [fuel_amount]      FLOAT          NULL,
    [driver_id]        INT            NULL,
    [account_no]       NVARCHAR (200) NULL,
    [remark]           NTEXT          NULL,
    [total_cost]       DECIMAL (18)   NULL
);



