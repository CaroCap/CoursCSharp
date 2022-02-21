CREATE TABLE [dbo].[Commentaire]
(
	[Id] INT NOT NULL IDENTITY,
	[location_ID] INT NOT NULL,
	[comm] NVARCHAR(500) NOT NULL,
	[score] INT NOT NULL,
	[dateCommentaire] DATE DEFAULT CURRENT_TIMESTAMP NOT NULL,
	-- BOOL = BIT --> 1 for TRUE and 0 for FALSE
	[valide] BIT DEFAULT 0 NOT NULL,
	CONSTRAINT PK_Commentaire PRIMARY KEY([Id])
)
GO
ALTER TABLE [Commentaire] ADD CONSTRAINT FK_Commentaire_User FOREIGN KEY ([location_ID]) REFERENCES [Location]([Id])
GO