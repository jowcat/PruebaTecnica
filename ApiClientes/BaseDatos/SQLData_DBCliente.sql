-- Creando la Base de Datos
CREATE DATABASE DBClientes;
GO
-- Accediendo a la Base de Datos
USE DBClientes;
GO
-- Creando la Tabla 
CREATE TABLE Clientes (
    IdCliente INT IDENTITY(1,1) PRIMARY KEY,
    Identificacion NVARCHAR(50) NOT NULL UNIQUE,
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    Email NVARCHAR(200) NULL,
    FechaCreacion DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    FechaActualizacion DATETIME2 NULL
);
GO
-- Creando el SP o Procedimiento Almacenado
CREATE PROCEDURE sp_GetClienteByIdentificacion
    @Identificacion NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP (1)
        IdCliente,
        Identificacion,
        Nombre,
        Apellido,
        Email,
        FechaCreacion,
        FechaActualizacion
    FROM Clientes
    WHERE Identificacion = @Identificacion;
END
GO