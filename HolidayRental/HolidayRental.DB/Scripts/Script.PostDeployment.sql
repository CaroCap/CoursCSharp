--/*
--Post-Deployment Script Template							
----------------------------------------------------------------------------------------
-- This file contains SQL statements that will be appended to the build script.		
-- Use SQLCMD syntax to include a file in the post-deployment script.			
-- Example:      :r .\myfile.sql								
-- Use SQLCMD syntax to reference a variable in the post-deployment script.		
-- Example:      :setvar TableName MyTable							
--               SELECT * FROM [$(TableName)]					
----------------------------------------------------------------------------------------
--*/

--INSERT INTO [TypeOption] ([type]) 
--                        VALUES ('Salle de bain'),
--                                ('WC'),
--                                ('Jardin'),
--                                ('Piscine'),
--                                ('Machine à laver'),
--                                ('Internet'),
--                                ('Animaux admis')


--INSERT INTO [User] ([nom], [prenom], [email], [pays], [tel], [password]) 
--                                        VALUES ('Cap','Caroline', 'c.cap@interface3.be', 'Belgique', '0473300830', 'Test1234='),
--                                            ('Decarpentrie','Alexi', 'a.decarpentrie@interface3.be', 'Belgique', '0473300830', 'Test1234='),
--                                            ('Deletaille','Christine', 'c.deletaille@hotmail.com', 'Belgique', '0478926613', 'Test1234='),
--                                            ('Cap','Pierre', 'p.cap@interface3.be', 'Belgique', '0475369366', 'Test1234=');


--INSERT INTO [Logement] ([titre], [resum], [description], [pays], [ville], [rue], [numero], [CP], [photo], [capacite], [assurance], [user_ID]) 
--                                        VALUES ('Jolie Maison Bleue','Jolie petite maison en bord de mer', 'bla blabl bla TEST', 'Italie', 'La Spezia', 'Via Lunara', '6', 'SP1190', 'italie.png', 4, 1, 3),
--                                                ('Chouette appart','Appartement bien situé à Bruxelles', 'TEST bla blabl bla TEST TEST', 'Belgique', 'Bruxelles', 'rue Marconi', '56', '1190', 'imarconi.png', 2, 0, 1),
--                                                ('Villa Grandiose','Grande Villa avec piscine', 'TEST BLABLABLA bla blabl bla TEST', 'Italie', 'Florence', 'Via de Rome', '18', 'FI1190', 'florence.jpg', 8, 1, 1);


--INSERT INTO [Location] ([user_ID], [logement_ID], [dateDebut], [dateFin], [valide]) 
--                                        VALUES (2, 1, '2021-12-15', '2021-12-15', 1),
--                                                (4, 3, '2022-12-14', '2023-12-26', 1),
--                                                (1, 1, '2022-12-15', '2023-12-27', 1),
--                                                (1, 3, '2022-08-15', '2023-08-27', 1),
--                                                (2, 2, '2023-01-15', '2023-01-30', 1),
--                                                (3, 2, '2023-12-15', '2023-12-27', 1),
--                                                (4, 1, '2023-03-10', '2023-03-15', 1),
--                                                (4, 1, '2022-11-02', '2023-11-08', 0);


--INSERT INTO [Option] ([logement_ID], [typeOption_ID], [nombre]) 
--                                        VALUES (1, 1, 2),
--                                                (1, 2, 3),
--                                                (1, 3, 1),
--                                                (1, 4, 1),
--                                                (1, 5, 1),
--                                                (1, 6, 1),
--                                                (1, 7, 0),
--                                                (2, 1, 1),
--                                                (2, 2, 1),
--                                                (2, 3, 0),
--                                                (2, 4, 0),
--                                                (2, 5, 1),
--                                                (2, 6, 1),
--                                                (2, 7, 1),
--                                                (3, 1, 3),
--                                                (3, 2, 2),
--                                                (3, 3, 1),
--                                                (3, 4, 2),
--                                                (3, 5, 2);

--INSERT INTO [Commentaire] ([location_ID], [comm], [score], [dateCommentaire], [valide]) 
--                                        VALUES (1, 'blabloablabla com com com', 8, '2021-12-15', 1),
--                                                (1, 'TEST COM blabloablabla com com com', 6);


---- On peut utiliser les procédures stockées pour insérer un film
----EXEC SP_Film_Insert @titre='Jurassic Park', @date='1993-06-16'