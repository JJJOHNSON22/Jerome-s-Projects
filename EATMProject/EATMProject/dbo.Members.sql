CREATE TABLE [dbo].[Table]
(
	[MemberID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NCHAR(10) NOT NULL, 
    [LastName] NCHAR(10) NOT NULL, 
    [PhoneNumber] NCHAR(10) NOT NULL, 
    [UserName] NCHAR(10) NOT NULL, 
    [PassWord] NCHAR(10) NOT NULL
)
