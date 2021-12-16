CREATE PROCEDURE [dbo].[SP_Film_Insert]
-- @date = variable pour stocker les données qui rentrent dans la fonction qui insérera dans la DB
	@titre NVARCHAR(128),
	@date DATE
AS
	INSERT INTO [Film] ([Titre],[DateSortie])
	VALUES (@titre, @date)
-- Return 0 est ajoutée automatiquement par Windows pour dire que tout s'est bien passé sinon retournera -1 
RETURN 0
-- Il suffira d'écrire dans l'ADO le nom de la procédure Stockée et les valeurs des variables @
-- Plus besoin de faire des requêtes SQL dans l'ADO
