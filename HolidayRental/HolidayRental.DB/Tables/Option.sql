CREATE TABLE [dbo].[Option]
(
	[Id] INT NOT NULL IDENTITY,
	[logement_ID] INT NOT NULL,
	[typeOption_ID] INT NOT NULL, 
	[nombre] INT DEFAULT 1, 
	CONSTRAINT PK_Option PRIMARY KEY([Id])
)
GO
ALTER TABLE [Option] ADD CONSTRAINT FK_Option_TypeOption FOREIGN KEY ([typeOption_Id]) REFERENCES [TypeOption]([Id])
GO
ALTER TABLE [Option] ADD CONSTRAINT FK_Option_Logement FOREIGN KEY ([logement_Id]) REFERENCES Logement([Id])
GO