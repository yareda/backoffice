CREATE TABLE [hrm].[appraisal] (
    [appraisalid]  INT          IDENTITY (1, 1) NOT NULL,
    [startdate]    DATETIME     NULL,
    [enddate]      DATETIME     NULL,
    [score]        VARCHAR (50) NULL,
    [evaluatedby]  INT          NULL,
    [summary]      VARCHAR (50) NULL,
    [data_version] TIMESTAMP    NOT NULL
);



