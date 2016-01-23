IF NOT EXISTS (SELECT * FROM sys.change_tracking_databases WHERE database_id = DB_ID(N'wildlife_management')) 
   ALTER DATABASE [wildlife_management] 
   SET  CHANGE_TRACKING = ON
GO
