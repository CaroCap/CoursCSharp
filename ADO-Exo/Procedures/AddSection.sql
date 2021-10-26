CREATE PROCEDURE [dbo].[AddSection]
	@SectionId int,
	@SectionName VARCHAR(50)
AS
BEGIN
	INSERT INTO Section
	VALUES (@SectionId, @SectionName)
END