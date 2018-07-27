CREATE TABLE [dbo].[Reservation]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [BookISBN] INT NULL FOREIGN KEY ([BookISBN])     
    REFERENCES Book (ISBN)   , 
    [StudentId] INT NULL FOREIGN KEY ([StudentId])     
    REFERENCES Student (Id)   , 
    [Doyoureserve] BINARY(50) NULL, 
    [Date] NCHAR(10) NULL
)
