CREATE TABLE [dbo].[Diffusion]
(
	[Id] INT IDENTITY NOT NULL,
	[Cinema_Id] INT NOT NULL,
	[Film_Id] INT NOT NULL,
	[DateDiffusion] DATETIME2 NULL,
	CONSTRAINT PK_Diffusion PRIMARY KEY ([Id])
	-- Habituellement dans un cas de Many to Many, on combine les 2 clés étrangères pour créer un ID unique pour diffusion sauf que dans le cas des films ça voudrait dire que le film ne peut être diffuser qu'une seule fois dans le même cinéma donc pas bien !
	--CONSTRAINT PK_Diffusion PRIMARY KEY ([Cinema_Id], [Film_Id])
	-- Foreign key pour lier la colonne cinema_ID (de cette table) qui va communiquer avec la colonne Id de la table Cinema.
	--CONSTRAINT FK_Diffusion_Cinema FOREIGN KEY ([Cinema_Id]) REFERENCES [Cinema]([Id]),
	--CONSTRAINT FK_Diffusion_Film FOREIGN KEY ([Film_Id]) REFERENCES Film([Id])
)
-- Mieux de créer en dehors de la table pour qu'il n'y ait pas de problèmes d'ordre de création des tables
GO
ALTER TABLE [Diffusion] ADD CONSTRAINT FK_Diffusion_Cinema FOREIGN KEY ([Cinema_Id]) REFERENCES [Cinema]([Id])
GO
ALTER TABLE [Diffusion] ADD CONSTRAINT FK_Diffusion_Film FOREIGN KEY ([Film_Id]) REFERENCES Film([Id])
GO