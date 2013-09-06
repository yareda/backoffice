ALTER TABLE [fleet].[maintenance_expense]
    ADD CONSTRAINT [pk_maintenance_expense] PRIMARY KEY CLUSTERED ([maintenance_id] ASC, [expense_id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

