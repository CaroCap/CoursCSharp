--Récupérer les biens d’un membre

CREATE PROCEDURE [dbo].[SP_LogementsParUser]
	@userID INT
AS
	SELECT [Id], [photo], [titre], [resum], [pays], [capacite] FROM [Logement] WHERE user_ID = @userID
-- Return 0 est ajoutée automatiquement par Windows pour dire que tout s'est bien passé sinon retournera -1 
RETURN 0
-- Il suffira d'écrire dans l'ADO le nom de la procédure Stockée et les valeurs des variables @
-- Plus besoin de faire des requêtes SQL dans l'ADO


