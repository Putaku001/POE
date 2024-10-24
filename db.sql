USE CellPhoneStore;
GO

CREATE TABLE Providers (
    ProviderID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100) NOT NULL,
    Phone VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL
);
GO

CREATE TABLE Phones (
    PhoneID INT PRIMARY KEY IDENTITY(1,1),
    Model VARCHAR(100) NOT NULL,
    Brand VARCHAR(100) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    ProviderID INT NOT NULL,
    FOREIGN KEY (ProviderID) REFERENCES Providers(ProviderID)
);
GO