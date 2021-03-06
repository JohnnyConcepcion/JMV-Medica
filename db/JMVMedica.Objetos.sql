USE master;
GO

CREATE DATABASE JMVMedica;

GO

USE JMVMedica;

CREATE TABLE Ubicaciones(
	UbicacionId INT PRIMARY KEY IDENTITY(1,1),
	Descripcion VARCHAR(50) NOT NULL,
	Estante VARCHAR(5) NOT NULL,
	Tramo SMALLINT NOT NULL,
	Celda SMALLINT NOT NULL,
	Estado BIT NOT NULL DEFAULT(1)
);

CREATE TABLE Marcas(
	MarcaId INT PRIMARY KEY IDENTITY(1,1),
	Descripcion VARCHAR(50) NOT NULL,
	Estado BIT NOT NULL DEFAULT(1)
);

CREATE TABLE TipoFarmacos(
	TipoFarmacoId INT PRIMARY KEY IDENTITY(1,1),
	Descripcion VARCHAR(50) NOT NULL,
	Estado BIT NOT NULL
);

CREATE TABLE Medicos(
	MedicoId INT PRIMARY KEY IDENTITY(1,1),
	Nombre VARCHAR(50) NOT NULL,
	Cedula CHAR(11) NOT NULL,
	TandaLabor TINYINT NOT NULL,
	Especialidad VARCHAR(100),
	Estado BIT NOT NULL DEFAULT(1)
);

CREATE TABLE Pacientes(
	PacienteId INT PRIMARY KEY IDENTITY(1,1),
	Nombre VARCHAR(50) NOT NULL,
	Cedula CHAR(11) NOT NULL,
	Carnet VARCHAR(15) NOT NULL,
	TipoPaciente TINYINT NOT NULL,
	Estado BIT NOT NULL DEFAULT(1)
);

CREATE TABLE Medicamentos(
	MedicamentoId INT PRIMARY KEY IDENTITY(1,1),
	Descripcion VARCHAR(100),
	TipoFarmacoId INT NOT NULL,
	MarcaId INT NOT NULL,
	UbicacionId INT NOT NULL,
	Dosis VARCHAR(100) NOT NULL,
	Estado BIT NOT NULL DEFAULT(1)
);

CREATE TABLE Visitas(
	VisitaId INT PRIMARY KEY IDENTITY(1,1),
	MedicoId INT NOT NULL,
	PacienteId INT NOT NULL,
	MedicamentoId INT NOT NULL,
	FechaVisita DATETIME NOT NULL DEFAULT(GETDATE()),
	Sintomas TEXT NOT NULL,
	Recomendaciones TEXT NOT NULL,
	Estado BIT NOT NULL
);

GO
ALTER TABLE Medicamentos
ADD CONSTRAINT FK_Med_TipoFarmaco
FOREIGN KEY(TipoFarmacoId)
REFERENCES TipoFarmacos(TipoFarmacoId);

ALTER TABLE Medicamentos
ADD CONSTRAINT FK_Med_Marca
FOREIGN KEY (MarcaId)
REFERENCES Marcas(MarcaId);

ALTER TABLE Medicamentos
ADD CONSTRAINT FK_Med_Ubi
FOREIGN KEY (UbicacionId)
REFERENCES  Ubicaciones(UbicacionId);

ALTER TABLE Visitas
ADD CONSTRAINT FK_Vis_Medico
FOREIGN KEY (MedicoId)
REFERENCES Medicos (MedicoId);

ALTER TABLE Visitas
ADD CONSTRAINT FK_Vis_PacienteId
FOREIGN KEY (PacienteId)
REFERENCES Pacientes (PacienteId);

ALTER TABLE Visitas
ADD CONSTRAINT FK_Vis_MedicamentoId
FOREIGN KEY (MedicamentoId)
REFERENCES Medicamentos (MedicamentoId);

CREATE UNIQUE INDEX IX_Cedula ON Medicos (Cedula);
CREATE UNIQUE INDEX IX_Cedula ON Pacientes (Cedula);
