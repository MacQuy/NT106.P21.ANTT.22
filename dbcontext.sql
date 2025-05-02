CREATE DATABASE ChessGame
USE ChessGame

CREATE TABLE Users
(
    ID INT IDENTITY(1, 1) PRIMARY KEY,
    Username NVARCHAR(10),
    Hashedpw VARCHAR(255),
    Img VARBINARY(MAX),
    Win INT,
    Draw INT,
    Lose INT
)

CREATE TABLE RoomMatch
(
    ID INT IDENTITY(1, 1) PRIMARY KEY,
    ChessMove NVARCHAR(MAX)
)

CREATE TABLE UserMatch
(
    UserID INT,
    RoomID INT,
    FOREIGN KEY (UserID) REFERENCES Users(ID),
    FOREIGN KEY (RoomID) REFERENCES RoomMatch(ID)
)

SELECT * FROM Users