CREATE TABLE [hrm].[employee_training] (
    [training_id] INT           IDENTITY (1, 1) NOT NULL,
    [course_name] VARCHAR (50)  NOT NULL,
    [start_date]  DATETIME      NULL,
    [end_date]    DATETIME      NULL,
    [given_by]    VARCHAR (100) NULL,
    [funded_by]   VARCHAR (100) NULL,
    [acheivement] NTEXT         NULL
);

