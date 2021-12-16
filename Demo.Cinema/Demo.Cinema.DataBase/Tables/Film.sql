CREATE TABLE [dbo].[Film]
(
	[Id] INT NOT NULL IDENTITY,
	[Titre] NVARCHAR(128) NOT NULL,
	-- DateTime2 Scoop plus large (an 0 -> 9999) tandis que date (1780 -> 2300)
	[DateSortie] DATE NOT NULL,
	CONSTRAINT PK_Film PRIMARY KEY ([Id]),
	-- Contrainte d'unicité pour éviter les doublons -> interdit d'avoir le même titre avec la même date de sortie
	CONSTRAINT UK_Film_Titre_DateSortie UNIQUE ([Titre],[DateSortie])
)
