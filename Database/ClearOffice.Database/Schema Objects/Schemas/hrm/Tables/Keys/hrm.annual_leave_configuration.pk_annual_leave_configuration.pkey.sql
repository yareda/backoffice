ALTER TABLE [hrm].[annual_leave_configuration]
    ADD CONSTRAINT [pk_annual_leave_configuration] PRIMARY KEY CLUSTERED ([leave_config_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

