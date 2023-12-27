CREATE VIEW [dbo].[Developers_WithNoEmails]
	AS
	SELECT d.Id, d.FirstName, d.LastName, d.Title, em.Email FROM [EmailAddress] AS em
	JOIN [Developers] AS d ON em.DeveloperID = d.Id
	WHERE em.Email is null or em.Email ='';
