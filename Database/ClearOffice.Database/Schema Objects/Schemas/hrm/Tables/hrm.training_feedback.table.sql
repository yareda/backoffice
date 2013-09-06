CREATE TABLE [hrm].[training_feedback] (
    [training_feedback_id] INT            IDENTITY (1, 1) NOT NULL,
    [training_id]          INT            NULL,
    [feedback_by]          NVARCHAR (200) NULL,
    [feedback]             NVARCHAR (MAX) NULL
);

