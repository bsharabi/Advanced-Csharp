USE task;
CREATE TABLE Author(

id     int identity (1,1) NOT NULL PRIMARY KEY,

AuthorName 	nvarchar(50) NOT NULL UNIQUE ,

AuthorAge	int,

AuthorImage nvarchar(255)

);


CREATE TABLE Book(

id     int identity (1,1) NOT NULL PRIMARY KEY,

BookName 	nvarchar(50) NOT NULL UNIQUE,

Price	decimal,

AuthorId int 

FOREIGN KEY ("AuthorId") REFERENCES Author(id)
);




INSERT INTO [dbo].[Author]
           ([AuthorName]
           ,[AuthorAge]
           ,[AuthorImage])
VALUES ('boaz',23,'https://24.media.tumblr.com/tumblr_lrd7olQSxF1qm2jvyo1_500.jpg');

--""