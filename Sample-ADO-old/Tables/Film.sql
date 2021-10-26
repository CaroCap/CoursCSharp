CREATE TABLE [dbo].[Film]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Titre] VARCHAR(50) NOT NULL, 
    [YearRealisation] INT NOT NULL, 
    [idActor] INT NOT NULL, 
    CONSTRAINT [FK_Actor] FOREIGN KEY ([idActor]) REFERENCES [Actor]([Id])
)
