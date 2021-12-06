CREATE TABLE [dbo].[Type](
	[Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[nameType] [nvarchar](50) NOT NULL,
	[minLP] [int] NOT NULL,
	[maxLP] [int] NOT NULL,
	[minAP] [int] NOT NULL,
	[maxAP] [int] NOT NULL)