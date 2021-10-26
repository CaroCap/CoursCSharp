CREATE PROCEDURE [dbo].[UpdateStudent]
	@YearResult int,
	@SectionId int,
	@StudentId int
AS
BEGIN
	UPDATE Student
	SET YearResult = @YearResult,
		SectionID = @SectionId
	WHERE Id = @StudentId
END
