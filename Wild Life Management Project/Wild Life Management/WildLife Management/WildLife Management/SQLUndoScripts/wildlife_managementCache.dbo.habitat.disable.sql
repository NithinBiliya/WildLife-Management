IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[habitat]')) 
   ALTER TABLE [dbo].[habitat] 
   DISABLE  CHANGE_TRACKING
GO
