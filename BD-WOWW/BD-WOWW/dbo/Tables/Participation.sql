CREATE TABLE [dbo].[Participation](
	[Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[registrationDate] [datetime2](7) NOT NULL,
	[FK_Team] [int] NULL,
	[FK_Tournament] [int] NULL)
GO
ALTER TABLE [dbo].[Participation]  WITH CHECK ADD  CONSTRAINT [FK_Participation_Team] FOREIGN KEY([FK_Team])
REFERENCES [dbo].[Team] ([Id])
ON UPDATE SET NULL
ON DELETE SET NULL
GO

ALTER TABLE [dbo].[Participation] CHECK CONSTRAINT [FK_Participation_Team]
GO
ALTER TABLE [dbo].[Participation]  WITH CHECK ADD  CONSTRAINT [FK_Participation_Tournament] FOREIGN KEY([FK_Tournament])
REFERENCES [dbo].[Tournament] ([Id])
ON UPDATE SET NULL
ON DELETE SET NULL
GO

ALTER TABLE [dbo].[Participation] CHECK CONSTRAINT [FK_Participation_Tournament]