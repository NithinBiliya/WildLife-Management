IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[lives_in]')) 
   ALTER TABLE [dbo].[lives_in] 
   DISABLE  CHANGE_TRACKING
GO
