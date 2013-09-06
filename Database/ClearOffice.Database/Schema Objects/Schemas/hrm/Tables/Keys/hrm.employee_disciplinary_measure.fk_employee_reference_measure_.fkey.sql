ALTER TABLE [hrm].[employee_disciplinary_measure]
    ADD CONSTRAINT [fk_employee_reference_measure_] FOREIGN KEY ([measure_type_id]) REFERENCES [hrm].[measure_type] ([measure_type_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

