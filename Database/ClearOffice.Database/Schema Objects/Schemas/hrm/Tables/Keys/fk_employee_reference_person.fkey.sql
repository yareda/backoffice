ALTER TABLE [hrm].[employee]
    ADD CONSTRAINT [fk_employee_reference_person] FOREIGN KEY ([person_id]) REFERENCES [hrm].[person] ([person_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;





