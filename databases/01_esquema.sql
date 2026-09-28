-- =============================================================
-- Proyecto : InventarioFerreteria
-- Archivo  : database/01_esquema.sql
-- Motor    : SQL Server / T-SQL (adaptado para evitar errores de sintaxis
-- Propósito: crear la base de datos y sus tablas
-- =============================================================

IF DB_ID(N'ferreteria_db') IS NOT NULL
BEGIN
    ALTER DATABASE ferreteria_db SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE ferreteria_db;
END;

CREATE DATABASE ferreteria_db;
GO

USE ferreteria_db;
GO

-- -------------------------------------------------------------
-- Tabla catálogo: categorias
-- Alimenta el ComboBox cboCategoria del formulario.
-- -------------------------------------------------------------
CREATE TABLE categorias (
    id_categoria  INT          NOT NULL IDENTITY(1,1),
    nombre        NVARCHAR(60) NOT NULL,
    CONSTRAINT pk_categorias PRIMARY KEY (id_categoria),
    CONSTRAINT uq_categorias_nombre UNIQUE (nombre)
);

-- -------------------------------------------------------------
-- Tabla principal: productos
-- Sobre esta tabla se hacen las cuatro operaciones CRUD.
-- -------------------------------------------------------------
CREATE TABLE productos (
    id_producto     INT            NOT NULL IDENTITY(1,1),
    codigo          NVARCHAR(15)   NOT NULL,
    nombre          NVARCHAR(100)  NOT NULL,
    id_categoria    INT            NOT NULL,
    unidad          NVARCHAR(20)   NOT NULL DEFAULT (N'Unidad'),
    precio          DECIMAL(10,2)  NOT NULL,
    existencia      INT            NOT NULL DEFAULT (0),
    activo          BIT            NOT NULL DEFAULT (1),
    fecha_registro  DATETIME2      NOT NULL DEFAULT (GETDATE()),
    CONSTRAINT pk_productos PRIMARY KEY (id_producto),
    CONSTRAINT uq_productos_codigo UNIQUE (codigo),
    CONSTRAINT fk_productos_categorias FOREIGN KEY (id_categoria)
        REFERENCES categorias (id_categoria)
        ON UPDATE CASCADE
        ON DELETE NO ACTION,
    CONSTRAINT chk_productos_precio     CHECK (precio > 0),
    CONSTRAINT chk_productos_existencia CHECK (existencia >= 0)
);

-- Índice para acelerar la búsqueda por nombre
CREATE INDEX ix_productos_nombre ON productos (nombre);
