CREATE PROCEDURE [dbo].[AddStudent]
	@FirstName VARCHAR(50),
	@LastName VARCHAR(50),
	@BirthDate DATETIME2,
	@YearResult INT,
	@SectionId INT,
	@Active BIT

AS
BEGIN
	INSERT INTO Student

	VALUES (@FirstName, @LastName, @BirthDate, @YearResult, @SectionId, @Active)
END