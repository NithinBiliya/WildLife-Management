IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[log_in]')) 
   ALTER TABLE [dbo].[log_in] 
   ENABLE  CHANGE_TRACKING
GO
