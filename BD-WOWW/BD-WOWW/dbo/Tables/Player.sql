CREATE TABLE [dbo].[Player](
	[Id] [int] NOT NULL PRIMARY KEY,
	[name] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[FK_Team] [int] NULL)
GO
ALTER TABLE [dbo].[Player]  WITH CHECK ADD  CONSTRAINT [FK_Player_Team] FOREIGN KEY([FK_Team])
REFERENCES [dbo].[Team] ([Id])
ON UPDATE SET NULL
ON DELETE SET NULL
GO

ALTER TABLE [dbo].[Player] CHECK CONSTRAINT [FK_Player_Team]