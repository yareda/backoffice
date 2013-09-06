CREATE TABLE [hrm].[person] (
    [person_id]         INT            IDENTITY (1, 1) NOT NULL,
    [nationality_id]    INT            NULL,
    [country_id]        INT            NULL,
    [ethnicity_id]      INT            NULL,
    [religion_id]       INT            NULL,
    [first_name]        NVARCHAR (200) NULL,
    [last_name]         NVARCHAR (200) NULL,
    [grand_father_name] NVARCHAR (200) NULL,
    [sex]               INT            NULL,
    [dob]               DATETIME       NULL,
    [place_of_birth]    NVARCHAR (200) NULL,
    [remark]            NVARCHAR (MAX) NULL,
    [photo]             IMAGE          NULL,
    [marital_status_id] INT            NULL
);









