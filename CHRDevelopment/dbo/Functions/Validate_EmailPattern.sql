CREATE FUNCTION [dbo].[Validate_EmailPattern]
(
	@email VARCHAR(255)
)
RETURNS BIT
AS
BEGIN
	--DECLARE @EmailPattern NVARCHAR(255) = '^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$'
	DECLARE @emailPattern NVARCHAR(255) = '%_@%_.__%'
	IF @email LIKE @emailPattern
		BEGIN
		    RETURN 1;
		END
	ELSE
		BEGIN
		    RETURN 0;
		END
	RETURN 0;
END

