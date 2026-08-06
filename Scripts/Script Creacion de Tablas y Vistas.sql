--========================================
-- Script de creacion de tabla y vistas para
-- la app de proyecto financiero
-- Creado por [Maksim Iulamanov]
-- Fecha de creacion [2026-07-17]
--========================================

-- Creamos la tabla de Transacciones
DROP TABLE IF EXISTS Transacciones;
CREATE TABLE Transacciones (
	id INT IDENTITY PRIMARY KEY,
	Fecha_Operacion DATE,
	Fecha_Valor DATE,
	Concepto VARCHAR(300),
	Categoria VARCHAR(100),
	Importe DECIMAL(10,2),
	Saldo DECIMAL(10, 2),
	Divisa VARCHAR(5)
);
GO

-- Creamos la tabla de Presupuestos
DROP TABLE IF EXISTS Limites;
CREATE TABLE Limites (
    Categoria NVARCHAR(100) PRIMARY KEY,
    Limite DECIMAL(18, 2) NOT NULL,
    FechaModificacion DATETIME DEFAULT GETDATE()
);
GO

DROP TABLE IF EXISTS MetasAhorro;
CREATE TABLE MetasAhorro (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Concepto NVARCHAR(100) NOT NULL,
    MontoObjetivo DECIMAL(18,2) NOT NULL,
    Completada BIT DEFAULT 0 NOT NULL,
    FechaCreacion DATETIME DEFAULT GETDATE()
);
GO

INSERT INTO MetasAhorro (Concepto, MontoObjetivo, Completada)
VALUES ('Viaje a Europa', 5000.00, 0);

-- Vista que muestre todos los datos para el dataGridView1
CREATE OR ALTER VIEW vw_datagrid1 
AS
	SELECT Fecha_Operacion, Concepto, Categoria, Importe, Saldo
	FROM Transacciones;
GO

-- Vista que muestro solo el año de operacion
CREATE OR ALTER VIEW vw_Filtro_Años
AS
	SELECT DISTINCT(YEAR(Fecha_Operacion)) Año
	FROM Transacciones
GO

