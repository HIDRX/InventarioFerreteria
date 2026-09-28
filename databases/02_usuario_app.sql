-- =============================================================
-- Archivo  : database/02_usuario_app.sql
-- Propósito: crear el usuario que usará la aplicación.
-- =============================================================

CREATE USER IF NOT EXISTS 'ferre_app'@'localhost'
    IDENTIFIED BY 'Ferre2026*';

GRANT SELECT, INSERT, UPDATE, DELETE
    ON ferreteria_db.*
    TO 'ferre_app'@'localhost';

FLUSH PRIVILEGES;

-- Verificación
SHOW GRANTS FOR 'ferre_app'@'localhost';