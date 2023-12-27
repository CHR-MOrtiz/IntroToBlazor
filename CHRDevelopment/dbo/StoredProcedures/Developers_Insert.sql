CREATE PROCEDURE [dbo].[Developers_Insert]

	@FirstName NVARCHAR (50),
	@LastName NVARCHAR(50),
	@Title NVARCHAR(50),
	@City NVARCHAR(50)
AS
	BEGIN
		DECLARE @initialCount int = (SELECT COUNT(*) FROM dbo.Developers)
		INSERT INTO dbo.Developers(FirstName, LastName, Title, City, IsActive)
		VALUES( @FirstName, @LastName, @Title, @City, 0);
	END

	IF(@initialCount < (SELECT COUNT(*) FROM dbo.Developers))
	BEGIN
		DECLARE @developerId VARCHAR(255) = (SELECT TOP 1 Id FROM dbo.Developers ORDER BY Id DESC);
		INSERT INTO dbo.EmailAddress(DeveloperID)
		VALUES(@developerId);
	END
GO;