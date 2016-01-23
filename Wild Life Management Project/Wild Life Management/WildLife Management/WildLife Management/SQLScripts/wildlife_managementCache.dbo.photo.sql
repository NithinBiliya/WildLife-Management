IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[photo]')) 
   ALTER TABLE [dbo].[photo] 
   ENABLE  CHANGE_TRACKING
GO
