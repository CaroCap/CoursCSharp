CREATE VIEW [dbo].[LastLogementAdded]
(id, photo, titre, resum, pays, capacite)
	AS SELECT TOP 5 id, photo, titre, resum, pays, capacite FROM [Logement] ORDER BY id DESC

--	Les 5 derniers biens ajoutés en échanges
--	Le résultat de la recherche sera présenté sous forme d’une liste reprenant :
--- La photo 
--- Le titre
--- La description courte
--- Le pays
--- Le nombre de personne