CREATE TABLE [dbo].[Tournament](
	[Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[name] [nvarchar](50) NOT NULL,
	[category] [nvarchar](50) NOT NULL)
GO
ALTER TABLE [dbo].[Tournament]  WITH CHECK ADD  CONSTRAINT [CK_Tournament] CHECK  (([category]='Advanced' OR [category]='Intermediate' OR [category]='Beginner'))
GO

ALTER TABLE [dbo].[Tournament] CHECK CONSTRAINT [CK_Tournament]