if not exists (select 1 from dbo.developers)
BEGIN
	insert into dbo.Developers(FirstName, LastName, Title, City)
		values
		('Matt', 'Weiss', 'Lead Developer', 'Souix Fall'),
		('Dennis', 'Winkley', 'Senior Developer', 'Souix Fall'),
		('Cassidy', 'Hodgin', 'Senior Developer', 'Souix Fall'),
		('Ron', 'Vander Wal', 'Senior Developer', 'Souix Fall'),
		('Ryan', 'Quasney', ' DevOps', 'Rapid City'),
		('Gian', 'Villaronte', 'Junior Developer', 'Calabarzon'),
		('Mateo', 'Ortiz', 'Developer', 'Orlando');
END

if not exists (select 1 from dbo.EmailAddress)
BEGIN
	insert into dbo.EmailAddress(DeveloperID, Email)
		values
		(1,'matt.weiss@chrsolutions.com'),
		(2,'dennis.winkley@chrsolutions.com'),
		(3,'cassidy.hodgin@chrsolutions.com'),
		(4,'ron.vanderwal@chrsolutions.com'),
		(5,'ryan.quasney@chrsolutions.com'),
		(6,'gian.villaronte@chrsolutions.com'),
		(7,'mateo.ortiz@chrsolutions.com');
END

