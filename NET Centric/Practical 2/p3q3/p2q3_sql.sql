CREATE DATABASE PracticalDB;

USE PracticalDB;

CREATE TABLE tbl_registration (
    id INT PRIMARY KEY IDENTITY(1,1),
    username NVARCHAR(50),
    password NVARCHAR(50),
    repassword NVARCHAR(50),
    gender NVARCHAR(10),
    course NVARCHAR(50),
    country NVARCHAR(50)
);
