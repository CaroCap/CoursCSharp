/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

SET IDENTITY_INSERT [Actor] ON 
/*Je t'autorise à donner toi même des ID*/
INSERT INTO [Actor] (Id, Nom) VALUES
(1, 'Leonardo Dicaprio'),
(2, 'Georges Cloney'),
(3, 'Brad Pitt'),
(4, 'Halle Berry'),
(5, 'Kate Winslet'),
(6, 'Macaulay Culkin'),
(7, 'Alain Chabat'),
(8, 'Scarlett Johanson'),
(9,'Will Smith'),
(10, 'Julia Roberts'),
(11, 'Raul Bova'),
(12, 'Tom Hanks'),
(13, 'Jennifer Anniston')
SET IDENTITY_INSERT [Actor] OFF

INSERT INTO [Film] (Titre, YearRealisation, idActor) VALUES
('Inception', 2010, 1),
('Ocean Eleven',2001,2),
('Legende d''Automne', 1994, 3),
('Forest Gump',1994,12),
('Kaamelott', 2021, 7)

