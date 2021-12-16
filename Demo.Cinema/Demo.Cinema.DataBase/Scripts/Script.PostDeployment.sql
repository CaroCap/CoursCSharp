/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO [Cinema] ([Nom], [Ville]) VALUES ('Kinepolis','Bruxelles'),
                                            ('Kinepolis','Braine-l''Alleud'),
                                            ('Kinepolis','Liège'),
                                            ('Pathé Cinéma','Charleroi'),
                                            ('Eldorado','Namur'),
                                            ('UGC Toison d''Or','Bruxelles')

-- On peut utiliser les procédures stockées pour insérer un film
EXEC SP_Film_Insert @titre='Jurassic Park', @date='1993-06-16'
EXEC SP_Film_Insert @titre='Ghostbuster', @date='2021-12-01'
EXEC SP_Film_Insert @titre='Ghostbuster', @date='1984-01-01'
EXEC SP_Film_Insert @titre='Judy n''est pas là', @date='2021-12-15'
EXEC SP_Film_Insert @titre='Spiderman', @date='2021-12-15'
EXEC SP_Film_Insert @titre='Burn after reading', @date='2008-12-10'

INSERT INTO [Diffusion] ([DateDiffusion],[Cinema_Id],[Film_Id]) VALUES ('2021-12-15 11:00:00',1,5),
                                                                        ('2021-12-15 12:00:00',1,6),
                                                                        ('2021-12-16 12:30:00',1,4),
                                                                        ('2021-12-16 14:30:00',1,3),
                                                                        ('2021-12-16 20:30:00',1,4),
                                                                        ('2021-12-16 12:45:00',1,1),
                                                                        ('2021-12-16 12:30:00',2,4),
                                                                        ('2021-12-16 18:50:00',2,3),
                                                                        ('2021-12-16 12:30:00',2,2),
                                                                        ('2021-12-16 10:30:00',2,1),
                                                                        ('2021-12-16 12:30:00',3,1),
                                                                        ('2021-12-16 12:45:00',3,2),
                                                                        ('2021-12-16 11:30:00',3,3),
                                                                        ('2021-12-16 12:30:00',4,4),
                                                                        ('2021-12-16 12:45:00',4,5),
                                                                        ('2021-12-16 21:30:00',5,6),
                                                                        ('2021-12-16 20:30:00',5,6),
                                                                        ('2021-12-16 12:30:00',5,5),
                                                                        ('2021-12-16 22:30:00',6,4),
                                                                        ('2021-12-16 16:30:00',6,3),
                                                                        ('2021-12-16 13:30:00',6,2)
