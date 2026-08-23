--========================================
-- Script de creacion de tabla y vistas para
-- la app de proyecto financiero
-- Creado por [Maksim Iulamanov]
-- Fecha de creacion [2026-07-17]
--========================================

-- Creamos la base de datos FinanzasDB
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'FinanzasDB')
BEGIN
    CREATE DATABASE FinanzasDB;
END;
GO

USE FinanzasDB;
GO

-- 1. Tabla Transacciones
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Transacciones')
BEGIN
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
END
GO

-- 2. Tabla Limites
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Limites')
BEGIN
    CREATE TABLE Limites (
        Categoria NVARCHAR(100) PRIMARY KEY,
        Limite DECIMAL(18, 2) NOT NULL,
        FechaModificacion DATETIME DEFAULT GETDATE()
    );
END
GO

-- 3. Tabla MetasAhorro
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'MetasAhorro')
BEGIN
    CREATE TABLE MetasAhorro (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Concepto NVARCHAR(100) NOT NULL,
        MontoObjetivo DECIMAL(18,2) NOT NULL,
        Completada BIT DEFAULT 0 NOT NULL,
        FechaCreacion DATETIME DEFAULT GETDATE()
    );
END
GO

-- 4. Tabla GastosProgramados
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'GastosProgramados')
BEGIN
    CREATE TABLE GastosProgramados (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        NombreGasto VARCHAR(100) NOT NULL,
        CantidadGasto DECIMAL(18,2) NOT NULL,
        FechaGasto DATE NOT NULL,
        Repetible BIT DEFAULT 0 NOT NULL,
        RepetibleTipo VARCHAR(20) NOT NULL,
        Completado BIT DEFAULT 0 NOT NULL,
        FechaCreacion DATETIME DEFAULT GETDATE()
    );
END
GO

-- 5. Tabla Categorias
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Categorias')
BEGIN
    CREATE TABLE Categorias (
        CategoriaID INT IDENTITY(1,1) PRIMARY KEY,
        CategoriaNombre VARCHAR(100) NOT NULL,
        Concepto VARCHAR(300),
        FechaCreacion DATETIME DEFAULT GETDATE()
    );
END
GO

-- 6. Vistas (CREATE OR ALTER VIEW sí está soportado nativamente en versiones recientes)
CREATE OR ALTER VIEW vw_datagrid1 AS
    SELECT 
        Fecha_Operacion, Concepto, Categoria, Importe, Saldo
    FROM Transacciones;