--SUBSTAMMDATEN --------------------------------------------------------------------------
CREATE TABLE Pruefeinheiten (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Bezeichnung NVARCHAR(50) NOT NULL,   
    Symbol NVARCHAR(10)           
);

CREATE TABLE Pruefmerkmale (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Pruefmethode NVARCHAR(50) NOT NULL, 
	Verknuepfung NVARCHAR(100), 
    Anweisungen NVARCHAR(255), 
);

CREATE TABLE LCMTypen (
    Id INT PRIMARY KEY IDENTITY(1,1),
    TypBeschreibung NVARCHAR(100) NOT NULL,  
	BemerkungIntern NVARCHAR(100),
	PruefeinheitId INT FOREIGN KEY REFERENCES Pruefeinheiten(Id),
	PruefmethodeId INT FOREIGN KEY REFERENCES Pruefmerkmale(Id)
);

--STAMMDATEN --------------------------------------------------------------------------
CREATE TABLE Wartungsaufgaben (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Code NVARCHAR(20) NOT NULL,       
    Bezeichnung NVARCHAR(80) NOT NULL,
	Dateianhaenge NVARCHAR(100),
    LCMTypID INT FOREIGN KEY REFERENCES LCMTypen(Id)  
);

CREATE TABLE Pruefmittel (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Code NVARCHAR(30) NOT NULL, 
    Bezeichnung NVARCHAR(80) NOT NULL,  
	Garantie INT,
	Herstelldatum DATETIME,
	Kaufdatum DATETIME,
	AlterJahre INT,
	Preis FLOAT,
	Verwendung NVARCHAR(80),
	MessbereichVon FLOAT,
	MessbereichBis FLOAT,
    PruefmerkmalID INT FOREIGN KEY REFERENCES Pruefmerkmale(Id),  
    PruefeinheitID INT FOREIGN KEY REFERENCES Pruefeinheiten(Id), 
	NaechsterPrueftermin DATETIME 
);

CREATE TABLE Anlagen (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Code NVARCHAR(30) NOT NULL,       
    Bezeichnung NVARCHAR(80) NOT NULL,
	Herstelldatum DATETIME,
	Kaufdatum DATETIME,
	Preis Float,
	AlterJahre INT,
	Garantie INT,
    Anlagenart NVARCHAR(50)          
);

CREATE TABLE Pruefplan (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Intervall1 INT,
	IntervallTyp1 NVARCHAR(30),
	Intervall2 INT,
	IntervallTyp2 NVARCHAR(30),
	WartungsaufgabeId INT FOREIGN KEY REFERENCES Wartungsaufgaben(Id) 
);


CREATE TABLE Wartungsaufgabe_Anlage ( 
	Id INT PRIMARY KEY IDENTITY(1,1),
	WartungsaufgabeId INT FOREIGN KEY REFERENCES Wartungsaufgaben(Id),
	AnlageId INT FOREIGN KEY REFERENCES Anlagen(Id)
);

CREATE TABLE Wartungsaufgabe_Pruefmittel ( 
	Id INT PRIMARY KEY IDENTITY(1,1),
	WartungsaufgabeId INT FOREIGN KEY REFERENCES Wartungsaufgaben(Id),
	PruefmittelId INT FOREIGN KEY REFERENCES Pruefmittel(Id)
);