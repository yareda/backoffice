ALTER TABLE [hrm].[training_attendance]
    ADD CONSTRAINT [DF_training_attendance_has_completed] DEFAULT ((0)) FOR [has_completed];

