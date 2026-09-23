--Entrar Borrando 
DROP DATABASE LINK ServerCentral;
DROP MATERIALIZED VIEW clientes_cdmx_vm;
DROP MATERIALIZED VIEW cuenta_cdmx_vm;
DROP MATERIALIZED VIEW EstadoCuentaCDMX;


--LINK PARA PUEBLA
CREATE DATABASE LINK ServerCentral CONNECT TO usuario_remoto IDENTIFIED BY "TU_PASSWORD_AQUI" using '(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=IP_SERVIDOR_REMOTO)(PORT=1521)) (CONNECT_DATA=(sid=orcl)))';
--VM CLIENTES
CREATE MATERIALIZED VIEW clientes_cdmx_vm AS
SELECT * FROM Clientes@ServerCentral WHERE Ciudad = 'CDMX';
--VM EMPLEADOS
CREATE MATERIALIZED VIEW cuenta_cdmx_vm AS
SELECT * FROM Cuenta@ServerCentral WHERE Ciudad = 'CDMX';
--VM Estado de Cuenta
CREATE MATERIALIZED VIEW EstadoCuentaCDMX AS
SELECT 
    C.nombre, C.Telefono, C.RFC,
    C.cp, C.Calle, C.ciudad,
    O.Tipo, O.Saldo, O.NTarjeta, O.Id,
    T.monto, T.concepto, T.Fecha
FROM Clientes C
JOIN Cuenta O ON C.Id = O.IdCliente
JOIN Transacciones T ON O.Id = T.IdCuenta
WHERE C.ciudad = 'CDMX';




