USE [CHRDevelopmentDB]


--DECLARE @EmailPattern NVARCHAR(255) = '^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$'
DECLARE @EmailPattern NVARCHAR(255) = '%_@%_.__%'
DECLARE @EmailToValidate NVARCHAR(255) = 'example@email.com'

IF @EmailToValidate LIKE @EmailPattern
BEGIN
    PRINT 'Valid Email Address'
END
ELSE
BEGIN
    PRINT 'Invalid Email Address'
END
