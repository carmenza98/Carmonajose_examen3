CREATE TABLE Viajeros (
    ID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(100),
    Apellido VARCHAR(100),
    Pasaporte VARCHAR(20) UNIQUE,
    FechaNacimiento DATE,
    Nacionalidad VARCHAR(50)
);

CREATE TABLE Paises (
    ID INT PRIMARY KEY IDENTITY,
    NombrePais VARCHAR(100) UNIQUE
);

CREATE TABLE Entradas (
    ID INT PRIMARY KEY IDENTITY,
    ViajeroID INT,
    FechaEntrada DATE,
    LugarEntrada VARCHAR(100),
    FOREIGN KEY (ViajeroID) REFERENCES Viajeros(ID)
);

CREATE TABLE Salidas (
    ID INT PRIMARY KEY IDENTITY,
    ViajeroID INT,
    FechaSalida DATE,
    LugarSalida VARCHAR(100),
    FOREIGN KEY (ViajeroID) REFERENCES Viajeros(ID)
);

CREATE TABLE Usuarios (
    ID INT PRIMARY KEY IDENTITY,
    Usuario VARCHAR(50) UNIQUE,
    Password VARCHAR(50),
    Rol VARCHAR(50)
);

