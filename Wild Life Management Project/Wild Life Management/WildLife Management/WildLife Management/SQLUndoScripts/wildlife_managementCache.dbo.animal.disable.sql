IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[animal]')) 
   ALTER TABLE [dbo].[animal] 
   DISABLE  CHANGE_TRACKING
GO
