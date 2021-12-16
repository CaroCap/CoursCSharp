CREATE TABLE [dbo].[Cinema]
(
--Colonne ID de type INT qui ne peut pas être nulle qui s'autoincrémente possible d'ajouter (1,1) après IDENTITY pour dire que l'autoincrémentation commence à 1 et s'incrémente de 1
-- et c'est une Clé Primaire mais pour être plus propre, on met l'info dans les contraintes 
	[Id] INT NOT NULL IDENTITY,
	[Nom] NVARCHAR(64) NOT NULL,
	[Ville] NVARCHAR(64) NOT NULL,
	--On ajoute des contraintes pour que la Primary Key sur ID ait bien un nom
	CONSTRAINT PK_Cinema PRIMARY KEY ([Id])
)
