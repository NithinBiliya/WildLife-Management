IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[member]')) 
   ALTER TABLE [dbo].[member] 
   DISABLE  CHANGE_TRACKING
GO
