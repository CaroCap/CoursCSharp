CREATE TABLE [dbo].[Location]
(
	[Id] INT NOT NULL IDENTITY,
	[user_ID] INT NOT NULL,
	[logement_ID] INT NOT NULL,
	[dateDebut] DATE NOT NULL,
	[dateFin] DATE NOT NULL,
	-- BOOL = BIT --> 1 for TRUE and 0 for FALSE
	[valide] BIT DEFAULT 0 NOT NULL,
	CONSTRAINT PK_Location PRIMARY KEY([Id])
)
GO
ALTER TABLE [Location] ADD CONSTRAINT FK_Location_User FOREIGN KEY ([user_Id]) REFERENCES [User]([Id])
GO
ALTER TABLE [Location] ADD CONSTRAINT FK_Location_Logement FOREIGN KEY ([logement_ID]) REFERENCES [Logement]([Id])
GO