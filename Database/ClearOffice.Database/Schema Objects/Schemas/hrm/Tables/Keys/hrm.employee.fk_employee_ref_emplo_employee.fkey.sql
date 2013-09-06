ALTER TABLE [hrm].[employee]
    ADD CONSTRAINT [fk_employee_ref_emplo_employee] FOREIGN KEY ([status_id]) REFERENCES [hrm].[employee_status] ([status_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;





