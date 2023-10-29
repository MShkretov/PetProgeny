USE master;
GO

IF DB_ID(N'PetProgeny') IS NOT NULL
    DROP DATABASE PetProgeny;

CREATE DATABASE PetProgeny;
GO

USE PetProgeny;
GO

CREATE TABLE Users
(
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(255) NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL
);

CREATE TABLE Animals
(
    AnimalID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Type NVARCHAR(50) NOT NULL,
    Breed NVARCHAR(50),
    Color NVARCHAR(50),
    DateOfBirth DATE,
    Gender NVARCHAR(10) CHECK (Gender IN ('Male', 'Female')),
    ParentID INT
);

INSERT INTO Animals (Name, Type, Breed, Color, DateOfBirth, Gender)
VALUES
    ('Max', 'Dog', 'Golden Retriever', 'Golden', '2019-04-10', 'Male'),
    ('Lucy', 'Dog', 'Labrador Retriever', 'Black', '2018-09-15', 'Female'),
    ('Buddy', 'Dog', 'Bulldog', 'Brown', '2020-01-20', 'Male'),
    ('Daisy', 'Dog', 'Poodle', 'White', '2019-07-05', 'Female'),
    ('Bailey', 'Dog', 'Dachshund', 'Red', '2021-03-22', 'Male');

INSERT INTO Animals (Name, Type, Color, DateOfBirth, Gender, ParentID)
VALUES
    ('Rocky', 'Dog', 'Golden', '2022-06-30', 'Male', 1),   
    ('Luna', 'Dog', 'Black', '2023-01-12', 'Female', 2),   
    ('Coco', 'Dog', 'Brown', '2022-11-11', 'Male', 3),     
    ('Molly', 'Dog', 'White', '2022-08-17', 'Female', 4),  
    ('Leo', 'Dog', 'Red', '2023-04-07', 'Male', 5),
    ('Charlie', 'Dog', 'Black', '2022-12-18', 'Male', 2);