-- Récupérer les biens disponibles entre deux dates

CREATE PROCEDURE [dbo].[SP_dispoLogement]
	@dateBegin date,
	@dateEnd date
AS SELECT Logement.Id, Logement.photo, Logement.titre, Logement.resum, Logement.pays, Logement.capacite
	FROM Logement INNER JOIN
        Location ON Logement.Id = Location.logement_ID
	WHERE ( @dateBegin > Location.dateFin) 
		OR ( @dateBegin < Location.dateDebut AND @dateEnd < Location.dateDebut )
RETURN 0
