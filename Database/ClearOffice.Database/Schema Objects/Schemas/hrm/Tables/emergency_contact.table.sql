CREATE TABLE [hrm].[emergency_contact] (
    [contact_id]     INT            IDENTITY (1, 1) NOT NULL,
    [person_id]      INT            NULL,
    [name]           VARCHAR (50)   NOT NULL,
    [relation]       VARCHAR (50)   NULL,
    [information]    NVARCHAR (MAX) NULL,
    [telephone]      VARCHAR (50)   NULL,
    [pobox]          VARCHAR (50)   NULL,
    [email]          VARCHAR (50)   NULL,
    [night_time_tel] NVARCHAR (MAX) NULL,
    [day_time_tel]   NVARCHAR (MAX) NULL
);



