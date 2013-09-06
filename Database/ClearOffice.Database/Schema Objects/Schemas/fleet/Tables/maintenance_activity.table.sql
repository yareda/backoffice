CREATE TABLE [fleet].[maintenance_activity] (
    [activity_id]      INT            IDENTITY (1, 1) NOT NULL,
    [maintenance_id]   INT            NULL,
    [performed_by]     BIT            NULL,
    [performer]        NVARCHAR (200) NULL,
    [labor_units]      INT            NULL,
    [unit_cost]        MONEY          NULL,
    [activity_type_id] INT            NULL,
    [description]      NTEXT          NULL,
    [notes]            NTEXT          NULL
);



