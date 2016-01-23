IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[sighting]')) 
   ALTER TABLE [dbo].[sighting] 
   ENABLE  CHANGE_TRACKING
GO
