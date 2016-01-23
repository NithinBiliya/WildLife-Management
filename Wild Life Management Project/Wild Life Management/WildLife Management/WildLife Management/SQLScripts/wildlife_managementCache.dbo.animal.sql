IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[animal]')) 
   ALTER TABLE [dbo].[animal] 
   ENABLE  CHANGE_TRACKING
GO
