CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [BirthDate] DATETIME2 NOT NULL, 
    [YearResult] INT NOT NULL, 
    [SectionID] INT NOT NULL, 
    [Active] BIT NOT NULL DEFAULT 1, 
    CONSTRAINT [FK_Section] FOREIGN KEY ([SectionID]) REFERENCES [Section]([Id]), 
    CONSTRAINT [CK_Student_YearResult] CHECK (YearResult BETWEEN 0 AND 20), 
    CONSTRAINT [CK_Student_BirthDate] CHECK (BirthDate >= '1930-01-01'), 
)
GO
CREATE TRIGGER [dbo].[TR_Student_SoftDelete]
    ON [dbo].[Student]
    INSTEAD OF DELETE
    AS 
    BEGIN
        Set NoCount ON -- pour ne plus voir le nombre de ligne affectée par la requete (facultatif)--
        UPDATE[Student] SET Active = 0 WHERE Id = (SELECT Id FROM deleted)
    END
GO
