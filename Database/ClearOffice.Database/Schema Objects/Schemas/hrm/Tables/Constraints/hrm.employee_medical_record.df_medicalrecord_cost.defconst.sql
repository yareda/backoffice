ALTER TABLE [hrm].[employee_medical_record]
    ADD CONSTRAINT [df_medicalrecord_cost] DEFAULT ((0)) FOR [cost];

