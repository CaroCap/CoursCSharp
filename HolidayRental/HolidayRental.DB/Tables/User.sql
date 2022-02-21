CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL IDENTITY,
	[nom] NVARCHAR(64) NOT NULL,
	[prenom] NVARCHAR(64) NOT NULL, 
	[email] NVARCHAR(250) NOT NULL, 
	[pays] NVARCHAR(64) NOT NULL, 
	[tel] VARCHAR(20) NOT NULL, 
	[password] NVARCHAR(64) NOT NULL,
	CONSTRAINT PK_User PRIMARY KEY([Id]),
	CONSTRAINT ck_tel CHECK(tel LIKE ('[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') OR tel LIKE ('[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
)
