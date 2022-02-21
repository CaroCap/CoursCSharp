CREATE VIEW [dbo].[GroupByCountry]
(id, photo, titre, resum, pays, capacite)
	AS SELECT Logement.Id, Logement.photo, Logement.titre, Logement.resum, Logement.pays, Logement.capacite
	FROM [Logement]
	ORDER BY [pays] OFFSET 0 ROWS


	--GROUP BY [pays]
	--ORDER BY COUNT(Logement.Id) OFFSET 0;


-- Les biens groupés par pays
--	SELECT column_name(s)
--	FROM table_name
--	WHERE condition
--	GROUP BY column_name(s)
--	ORDER BY column_name(s);