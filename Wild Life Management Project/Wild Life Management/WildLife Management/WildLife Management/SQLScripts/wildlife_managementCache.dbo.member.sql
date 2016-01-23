IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[member]')) 
   ALTER TABLE [dbo].[member] 
   ENABLE  CHANGE_TRACKING
GO
