CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [fullname] CHAR(20) NOT NULL, 
    [username] VARCHAR(50) NOT NULL, 
    [password] VARCHAR(50) NOT NULL, 
    [question] VARCHAR(50) NOT NULL, 
    [answer] VARCHAR(50) NOT NULL
)
