CREATE TABLE [hrm].[location] (
    [location_id]   INT            IDENTITY (1, 1) NOT NULL,
    [location_code] NVARCHAR (100) NULL,
    [local_name]    NVARCHAR (MAX) NULL,
    [parent_id]     INT            NULL
);



