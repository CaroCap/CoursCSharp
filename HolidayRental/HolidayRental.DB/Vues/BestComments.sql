CREATE VIEW [dbo].[BestComments]
	(id, photo, titre, resum, pays, capacite)
	AS SELECT Logement.Id, Logement.photo, Logement.titre, Logement.resum, Logement.pays, Logement.capacite
	FROM Logement INNER JOIN
        Location ON Logement.Id = Location.logement_ID INNER JOIN
        Commentaire ON Location.Id = Commentaire.location_ID
	WHERE (Commentaire.score > 6)

	--Les biens échangés ayant la meilleure réputation (avis > 6/10)
	--SELECT photo,titre, resum, pays, capacite FROM [Logement, Commentaire]
	--WHERE Commentaire.score > 6