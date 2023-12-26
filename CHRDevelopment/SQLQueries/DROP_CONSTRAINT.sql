declare @Id int

set @Id = 7

BEGIN
		Alter table dbo.EmailAddress DROP CONSTRAINT FK_Developer;
		delete from dbo.Developers
		where Id =@Id;
	END