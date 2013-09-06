CREATE TABLE [fleet].[insurance_history] (
    [history_id]      INT            IDENTITY (1, 1) NOT NULL,
    [vehicle_id]      INT            NULL,
    [company_id]      INT            NULL,
    [policy_type]     INT            NULL,
    [policy_no]       NVARCHAR (500) NULL,
    [coverage_limit]  DECIMAL (18)   NULL,
    [premium]         DECIMAL (18)   NULL,
    [date_insured]    DATETIME       NULL,
    [agent_name]      NVARCHAR (500) NULL,
    [agent_telephone] NVARCHAR (100) NULL,
    [agent_email]     NVARCHAR (100) NULL,
    [remark]          NVARCHAR (MAX) NULL
);



