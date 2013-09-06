﻿CREATE TABLE [fleet].[tire_manufacturer] (
    [id]           INT            IDENTITY (1, 1) NOT NULL,
    [name]         NVARCHAR (200) NOT NULL,
    [description]  NTEXT          NULL,
    [data_version] TIMESTAMP      NULL
);



