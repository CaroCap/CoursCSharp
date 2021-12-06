/****** Object:  Table [dbo].[Character]    Script Date: 06-12-21 13:58:16 ******/
CREATE TABLE [dbo].[Character](
	[Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[name] [nvarchar](50) NOT NULL,
	[LP] [int] NOT NULL,
	[AP] [int] NOT NULL,
	[status] [bit] NOT NULL,
	[FK_Type] [int] NULL,
	[FK_Player] [int] NULL)
GO
ALTER TABLE [dbo].[Character]  WITH CHECK ADD  CONSTRAINT [FK_Character_Player] FOREIGN KEY([FK_Player])
REFERENCES [dbo].[Player] ([Id])
ON UPDATE SET NULL
ON DELETE SET NULL
GO

ALTER TABLE [dbo].[Character] CHECK CONSTRAINT [FK_Character_Player]
GO
ALTER TABLE [dbo].[Character]  WITH CHECK ADD  CONSTRAINT [FK_Character_Type] FOREIGN KEY([FK_Type])
REFERENCES [dbo].[Type] ([Id])
ON UPDATE SET NULL
ON DELETE SET NULL
GO

ALTER TABLE [dbo].[Character] CHECK CONSTRAINT [FK_Character_Type]
GO
ALTER TABLE [dbo].[Character] ADD  CONSTRAINT [DF_Character_status]  DEFAULT ((1)) FOR [status]