CREATE TABLE [dbo].[Team](
	[Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[name] [nvarchar](50) NOT NULL,
	[score] [int] NOT NULL)
GO
ALTER TABLE [dbo].[Team] ADD  CONSTRAINT [DF_Team_score]  DEFAULT ((0)) FOR [score]