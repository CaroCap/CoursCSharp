CREATE TABLE [dbo].[Fight](
	[Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[dateFight] [datetime2](7) NULL,
	[FK_Tournament] [int] NULL,
	[FK_Winner] [int] NULL,
	[FK_Looser] [int] NULL)
GO
ALTER TABLE [dbo].[Fight]  WITH CHECK ADD  CONSTRAINT [FK_Fight_Tournament] FOREIGN KEY([FK_Tournament])
REFERENCES [dbo].[Tournament] ([Id])
ON UPDATE SET NULL
ON DELETE SET NULL
GO

ALTER TABLE [dbo].[Fight] CHECK CONSTRAINT [FK_Fight_Tournament]
GO
ALTER TABLE [dbo].[Fight]  WITH CHECK ADD  CONSTRAINT [FK_Looser] FOREIGN KEY([FK_Looser])
REFERENCES [dbo].[Character] ([Id])
GO

ALTER TABLE [dbo].[Fight] CHECK CONSTRAINT [FK_Looser]
GO
ALTER TABLE [dbo].[Fight]  WITH CHECK ADD  CONSTRAINT [FK_Winner] FOREIGN KEY([FK_Winner])
REFERENCES [dbo].[Character] ([Id])
GO

ALTER TABLE [dbo].[Fight] CHECK CONSTRAINT [FK_Winner]