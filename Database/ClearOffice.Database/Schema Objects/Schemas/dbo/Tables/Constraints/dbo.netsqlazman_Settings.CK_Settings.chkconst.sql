ALTER TABLE [dbo].[netsqlazman_Settings]
    ADD CONSTRAINT [CK_Settings] CHECK ([SettingName]='Mode' AND ([SettingValue]='Developer' OR [SettingValue]='Administrator') OR [SettingName]='LogErrors' AND ([SettingValue]='True' OR [SettingValue]='False') OR [SettingName]='LogWarnings' AND ([SettingValue]='True' OR [SettingValue]='False') OR [SettingName]='LogInformations' AND ([SettingValue]='True' OR [SettingValue]='False') OR [SettingName]='LogOnEventLog' AND ([SettingValue]='True' OR [SettingValue]='False') OR [SettingName]='LogOnDb' AND ([SettingValue]='True' OR [SettingValue]='False'));

