--Récupérer les informations complètes d’un bien à partir de son id

CREATE PROCEDURE [dbo].[SP_DetailLogement]
	@logementID int
AS
	SELECT [Id], [titre], [resum], [description], [pays], [ville], [rue], [numero], [CP], [photo], [capacite], [assurance], [actif], [dateLastModification], [user_ID] FROM [Logement] WHERE Id = @logementID
RETURN 0
