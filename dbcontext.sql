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

INSERT INTO Users(Username, Hashedpw) VALUES
('test', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')