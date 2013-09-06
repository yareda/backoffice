ALTER TABLE [hrm].[appraisal]
    ADD CONSTRAINT [df_appraisal_appraisaldate] DEFAULT (getdate()) FOR [startdate];

