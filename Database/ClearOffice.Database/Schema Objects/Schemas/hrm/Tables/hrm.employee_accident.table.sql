CREATE TABLE [hrm].[employee_accident] (
    [accident_id]    INT            IDENTITY (1, 1) NOT NULL,
    [employee_id]    INT            NULL,
    [accident_date]  DATETIME       NOT NULL,
    [location]       NVARCHAR (200) NULL,
    [accident_level] VARCHAR (MAX)  NULL,
    [body_part]      NVARCHAR (MAX) NULL,
    [insurance]      NVARCHAR (MAX) NULL,
    [reference]      NVARCHAR (MAX) NULL,
    [remark]         NVARCHAR (MAX) NULL
);

