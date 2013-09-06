ALTER TABLE [hrm].[employee_medical_record]
    ADD CONSTRAINT [df_patientrecord_daterecorded] DEFAULT (getdate()) FOR [date_recorded];

