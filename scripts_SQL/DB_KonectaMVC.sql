CREATE DATABASE KonectaMVC
GO 
USE KonectaMVC
go
CREATE TABLE Empleado 
(
ID NUMERIC PRIMARY KEY,
FECHA_INGRESO DATE,
NOMBRE VARCHAR(50),
SALARIO NUMERIC
)
GO
CREATE TABLE Solicitud
(
ID INT IDENTITY PRIMARY KEY,
CODIGO VARCHAR(50),
DESCRIPCION VARCHAR(50),
RESUMEN VARCHAR(50),
ID_EMPLEADO NUMERIC,
CONSTRAINT FK_EMPLEADO FOREIGN KEY (ID_EMPLEADO) REFERENCES Empleado(ID)
);
GO