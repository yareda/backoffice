﻿ALTER TABLE [hrm].[employee_accident]
    ADD CONSTRAINT [fk_employee_ref_emp_a_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

