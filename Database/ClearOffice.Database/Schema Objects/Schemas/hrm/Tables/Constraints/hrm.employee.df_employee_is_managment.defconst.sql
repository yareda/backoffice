ALTER TABLE [hrm].[employee]
    ADD CONSTRAINT [df_employee_is_managment] DEFAULT ((0)) FOR [is_managment];

