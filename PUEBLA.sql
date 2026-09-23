--SERVIDOR DE PUEBLA
DROP TABLE Sucursales CASCADE CONSTRAINT;
DROP TABLE Clientes CASCADE CONSTRAINT;
DROP TABLE Empleados CASCADE CONSTRAINT;
DROP TABLE Cuenta CASCADE CONSTRAINT;
DROP TABLE Transacciones CASCADE CONSTRAINT;
DROP TABLE Prestamo CASCADE CONSTRAINT;
DROP materialized view clientes_puebla_vm;
DROP materialized view cuenta_puebla_vm;
DROP materialized view EstadoCuentaPuebla;
DROP PROCEDURE insertarcliente;
DROP PROCEDURE DepositarDinero;
DROP PROCEDURE RetirarDinero;
Drop PROCEDURE SolicitarCredito;
DROP PROCEDURE eliminarCliente;
DROP PROCEDURE DarDeBajaCuenta;
DROP PROCEDURE VerificarPrestamo;
DROP PROCEDURE VerEstadoCuenta;
DROP PROCEDURE VerSaldo;
DROP PROCEDURE ActualizarCliente;
DROP PROCEDURE DarDeAltaCuenta;
DROP PROCEDURE ActualizarCuenta;
DROP PROCEDURE TransferirDinero;
DROP PROCEDURE ReporteMovimientosMes;
DROP DATABASE LINK ServerCDMX;


create table Sucursales(
    Id number GENERATED always as identity NOT NULL PRIMARY KEY,
    Nombre varchar2(255) not null,
    Direccion varchar2(255) not null,
    Telefono varchar2(255) not null,
    Correo varchar2(255) not null,
    Ciudad varchar2(255) not null,
    Pais varchar2(255) not null
);

INSERT INTO Sucursales(Nombre,Direccion,Telefono,Correo,Ciudad,Pais) VALUES ('Suc Zona Industrial', 'Libre Puebla-Tehuacan col Zona Industrial','800 021 2345','bancozonaind@gmail.com','Puebla','Mexico');
INSERT INTO Sucursales(Nombre,Direccion,Telefono,Correo,Ciudad,Pais) VALUES ('Suc Defensores', 'Libre Puebla-Tehuacan col Zona Industrial','800 333 1945','sucdefensores@gmail.com','Puebla','Mexico');
INSERT INTO Sucursales(Nombre,Direccion,Telefono,Correo,Ciudad,Pais) VALUES ('Suc Blvrd Atlixco', 'Libre Puebla-Tehuacan col Zona Industrial','800 111 1145','sucatlixco@gmail.com','Puebla','Mexico');
INSERT INTO Sucursales(Nombre,Direccion,Telefono,Correo,Ciudad,Pais) VALUES ('Suc Blvrd Xonacatepec', 'Libre Puebla-Tehuacan col Zona Industrial','800 555 1245','sucxonacatepec@gmail.com','Puebla','Mexico');
INSERT INTO Sucursales(Nombre,Direccion,Telefono,Correo,Ciudad,Pais) VALUES ('Sucursal Nueva Zona', 'Libre Puebla-Tehuacan col Zona Industrial','800 000 2852','nuevazona@gmail.com','Puebla','Mexico');

INSERT INTO Sucursales(Nombre,Direccion,Telefono,Correo,Ciudad,Pais) VALUES ('Suc Lagos Moreno', 'AV HIDALGO','800 021 2345','gvuvgvgd@gmail.com','CDMX','Mexico');
INSERT INTO Sucursales(Nombre,Direccion,Telefono,Correo,Ciudad,Pais) VALUES ('Suc Zacatecas', 'AV JUAREZ','800 333 1945','ggygygy@gmail.com','CDMX','Mexico');
INSERT INTO Sucursales(Nombre,Direccion,Telefono,Correo,Ciudad,Pais) VALUES ('Suc Blvrd Altaria', 'Blvrd Zacatecas','800 111 1145','gvfcdddee@gmail.com','CDMX','Mexico');
INSERT INTO Sucursales(Nombre,Direccion,Telefono,Correo,Ciudad,Pais) VALUES ('Suc Blvrd Guadalupe', 'AV AMERICAS','800 555 1245','vvggtgf@gmail.com','CDMX','Mexico');
INSERT INTO Sucursales(Nombre,Direccion,Telefono,Correo,Ciudad,Pais) VALUES ('Sucursal Convencion', 'COLEGIO MILITAR','800 000 2852','miikij@gmail.com','CDMX','Mexico');

create table Clientes(
    Id number GENERATED always as identity NOT NULL PRIMARY KEY,
    Nombre varchar2(255) not null,
    Apellido varchar2(255) not null,
    FechaNacimiento date not null,
    Telefono varchar2(15) not null,
    RFC varchar2(13) not null,
    Ciudad varchar2(255) not null,
    CP varchar2(255) not null,
    Calle varchar2(255) not null,
    Numero varchar2(255) not null,
    IdSucursal number not null,
    constraint fk_sucursal_cliente foreign key(IdSucursal)
    references Sucursales(Id) ON DELETE CASCADE
);

INSERT INTO Clientes (Nombre,Apellido,FechaNacimiento,Telefono,RFC,Ciudad,CP,Calle,Numero,IdSucursal) VALUES ('Enrrique', 'Juarez Ramirez','12/04/1981','2225897456','GOMJ800523HZ1','Puebla','72000','Centro','2pon',1);
INSERT INTO Clientes (Nombre,Apellido,FechaNacimiento,Telefono,RFC,Ciudad,CP,Calle,Numero,IdSucursal) VALUES ('Marisol', 'Carreon Mora','02/12/1982','2225897456','GOMJ800523HZ1','Puebla','72014','San Pablo','5A',2);
INSERT INTO Clientes (Nombre,Apellido,FechaNacimiento,Telefono,RFC,Ciudad,CP,Calle,Numero,IdSucursal) VALUES ('Jesus', 'Dolores Hernadez','08/08/1983','2225897456','GOMJ800523HZ1','Puebla','72030','San Felipe','6B',5);
INSERT INTO Clientes (Nombre,Apellido,FechaNacimiento,Telefono,RFC,Ciudad,CP,Calle,Numero,IdSucursal) VALUES ('Carlos', 'Fuentes Lopez','15/11/1981','2225897456','GOMJ800523HZ1','Puebla','72089','Barrio de San Antonio','2pon',3);
INSERT INTO Clientes (Nombre,Apellido,FechaNacimiento,Telefono,RFC,Ciudad,CP,Calle,Numero,IdSucursal) VALUES ('Karen', 'Coca Flores','21/10/1982','2225897456','GOMJ800523HZ1','Puebla','72290','San Francisco','2pon',4);

INSERT INTO Clientes (Nombre,Apellido,FechaNacimiento,Telefono,RFC,Ciudad,CP,Calle,Numero,IdSucursal) VALUES ('Marisela', 'Juarez Ramol','12/04/1981','2225897456','GOMJ800523HZ1','CDMX','01011','Alvaro Obregon','2pon',6);
INSERT INTO Clientes (Nombre,Apellido,FechaNacimiento,Telefono,RFC,Ciudad,CP,Calle,Numero,IdSucursal) VALUES ('Marcos', 'Castillo Melchor','02/12/1982','2225897456','GOMJ800523HZ1','CDMX','01010','Col Florida','5A',7);
INSERT INTO Clientes (Nombre,Apellido,FechaNacimiento,Telefono,RFC,Ciudad,CP,Calle,Numero,IdSucursal) VALUES ('Luz', 'Dolores Mora','08/08/1983','2225897456','GOMJ800523HZ1','CDMX','01020','San Hidalgo','6B',8);
INSERT INTO Clientes (Nombre,Apellido,FechaNacimiento,Telefono,RFC,Ciudad,CP,Calle,Numero,IdSucursal) VALUES ('Mariel', 'Carreon Morales','15/11/1981','2225897456','GOMJ800523HZ1','CDMX','01060','Barrio Cove','2pon',9);
INSERT INTO Clientes (Nombre,Apellido,FechaNacimiento,Telefono,RFC,Ciudad,CP,Calle,Numero,IdSucursal) VALUES ('Jose', 'Flores Torres','21/10/1982','2225897456','GOMJ800523HZ1','CDMX','01100','Acueducto','2pon',10);


create table Empleados(
    Id number GENERATED always as identity NOT NULL PRIMARY KEY,
    Nombre varchar2(225) not null,
    Apellido varchar2(255) not null,
    Puesto varchar2(255) not null,
    RFC varchar2(13) not null,
    Salario number(12,2) not null,
    Direccion varchar2(255) not null,
    Horario varchar2(255) not null,
    Telefono varchar2(15) not null,
    FechaNacimiento date not null,
    Depto varchar2(255) not null,
    Email varchar2(255) not null,
    Ciudad varchar2(255) not null,
    IdSucursales number not null,
    constraint fk_sucursales_empleados foreign key(IdSucursales)
    references Sucursales(Id) ON DELETE CASCADE
);


INSERT INTO Empleados (Nombre,Apellido,Puesto,RFC,Salario,Direccion,Horario,Telefono,FechaNacimiento,Depto,Email,Ciudad,IdSucursales) VALUES('Marcos','Carrion Juarez','Supervisor de Contabilidad','FGRY80010JUL4', 10000,'Andador heriberto jara', '7- 5','2221649745','12/11/2001','Contable','gygiygy@gmail.com','Puebla',2);
INSERT INTO Empleados (Nombre,Apellido,Puesto,RFC,Salario,Direccion,Horario,Telefono,FechaNacimiento,Depto,Email,Ciudad,IdSucursales) VALUES('Mariana','Carmona Mora','Atencion a clientes','AGUY80010JUL4', 6000,'Andador heriberto jara', '7- 5','2221649745','12/11/2001','Contable','vbfgh@gmail.com','Puebla',1);
INSERT INTO Empleados (Nombre,Apellido,Puesto,RFC,Salario,Direccion,Horario,Telefono,FechaNacimiento,Depto,Email,Ciudad,IdSucursales) VALUES('Mercedes','Flores Torres','Cajero','TYUI80010JUL4', 5000,'Andador heriberto jara', '7- 5','2221649745','12/11/2001','Contable','cvvcfgd@gmail.com','Puebla',3);
INSERT INTO Empleados (Nombre,Apellido,Puesto,RFC,Salario,Direccion,Horario,Telefono,FechaNacimiento,Depto,Email,Ciudad,IdSucursales) VALUES('Aldo','Carreon Ramirez','Gerente','IUNG80010JUL4', 11000,'Andador heriberto jara', '7- 5','2221649745','12/11/2001','Contable','rgterg@gmail.com','Puebla',4);
INSERT INTO Empleados (Nombre,Apellido,Puesto,RFC,Salario,Direccion,Horario,Telefono,FechaNacimiento,Depto,Email,Ciudad,IdSucursales) VALUES('David','Altamirano Muinguia','Caja','UYTR80010JUL4', 5000,'Andador heriberto jara', '7- 5','2221649745','12/11/2001','Contable','iyyt@gmail.com','Puebla',5);

INSERT INTO Empleados (Nombre,Apellido,Puesto,RFC,Salario,Direccion,Horario,Telefono,FechaNacimiento,Depto,Email,Ciudad,IdSucursales) VALUES('Maria','Huerta Luna','Supervisor de Contabilidad','DFGY80010JUL4', 10000,'Andador heriberto jara', '7- 5','2221649745','12/11/2001','Contable','gygiygy@gmail.com','CDMX',6);
INSERT INTO Empleados (Nombre,Apellido,Puesto,RFC,Salario,Direccion,Horario,Telefono,FechaNacimiento,Depto,Email,Ciudad,IdSucursales) VALUES('Lupita','Romero Romles','Atencion a clientes','YHGR80010JUL4', 6000,'Andador heriberto jara', '7- 5','2221649745','12/11/2001','Contable','vbfgh@gmail.com','CDMX',7);
INSERT INTO Empleados (Nombre,Apellido,Puesto,RFC,Salario,Direccion,Horario,Telefono,FechaNacimiento,Depto,Email,Ciudad,IdSucursales) VALUES('Marcos','Lopez Perez','Cajero','GGVF80010JUL4', 5000,'Andador heriberto jara', '7- 5','2221649745','12/11/2001','Contable','cvvcfgd@gmail.com','CDMX',8);
INSERT INTO Empleados (Nombre,Apellido,Puesto,RFC,Salario,Direccion,Horario,Telefono,FechaNacimiento,Depto,Email,Ciudad,IdSucursales) VALUES('Carlos','Carreon Duran','Gerente','GTRE80010JUL4', 11000,'Andador heriberto jara', '7- 5','2221649745','12/11/2001','Contable','rgterg@gmail.com','CDMX',9);
INSERT INTO Empleados (Nombre,Apellido,Puesto,RFC,Salario,Direccion,Horario,Telefono,FechaNacimiento,Depto,Email,Ciudad,IdSucursales) VALUES('Emmanuel','Luna Esquina','Caja','QWES80010JUL4', 5000,'Andador heriberto jara', '7- 5','2221649745','12/11/2001','Contable','iyyt@gmail.com','CDMX',10);

create table Cuenta(
    Id number GENERATED always as identity NOT NULL PRIMARY KEY,
    Tipo varchar2(255) not null,
    Saldo number(12,2) not null,
    NTarjeta varchar(255) not null,
    Ciudad varchar2(255) not null,
    IdCliente number not null,
    constraint fk_cliente_cuenta foreign key(IdCliente)
    references Clientes(Id) ON DELETE CASCADE
);

INSERT INTO Cuenta(Tipo,Saldo,NTarjeta,Ciudad,IdCliente) VALUES('Cuenta de cheques','40000', '4532111187654321','Puebla',1);
INSERT INTO Cuenta(Tipo,Saldo,NTarjeta,Ciudad,IdCliente) VALUES('Cuenta de Credito','50000', '8974111187654321','Puebla',2);
INSERT INTO Cuenta(Tipo,Saldo,NTarjeta,Ciudad,IdCliente) VALUES('Cuenta de Debito','60000', '1236111187654321','Puebla',3);
INSERT INTO Cuenta(Tipo,Saldo,NTarjeta,Ciudad,IdCliente) VALUES('Cuenta de Ahorros','20000', '1234111187654321','Puebla',4);
INSERT INTO Cuenta(Tipo,Saldo,NTarjeta,Ciudad,IdCliente) VALUES('Cuenta de cheques','10000', '1111111187654321','Puebla',5);

INSERT INTO Cuenta(Tipo,Saldo,NTarjeta,Ciudad,IdCliente) VALUES('Cuenta de cheques','40000', '12252111187654321','CDMX',6);
INSERT INTO Cuenta(Tipo,Saldo,NTarjeta,Ciudad,IdCliente) VALUES('Cuenta de Credito','50000', '7895111187654321','CDMX',7);
INSERT INTO Cuenta(Tipo,Saldo,NTarjeta,Ciudad,IdCliente) VALUES('Cuenta de Debito','60000', '6542111187654321','CDMX',8);
INSERT INTO Cuenta(Tipo,Saldo,NTarjeta,Ciudad,IdCliente) VALUES('Cuenta de Ahorros','20000', '4432111187654321','CDMX',9);
INSERT INTO Cuenta(Tipo,Saldo,NTarjeta,Ciudad,IdCliente) VALUES('Cuenta de cheques','10000', '6655111187654321','CDMX',10);


create table Transacciones(
    Id number GENERATED always as identity NOT NULL PRIMARY KEY,
    Monto number(12,2) not null,
    Concepto varchar2(255) not null,
    Fecha date not null,
    Hora varchar2(255) not null,
    Autorizacion varchar2(255) not null,
    Ciudad varchar2(255) not null,
    IdCuenta number not null,--Cuenta Origen
    constraint fk_cuenta_transaccion foreign key(IdCuenta)
    references Cuenta(Id) ON DELETE CASCADE
    );

INSERT INTO Transacciones(Monto,Concepto,Fecha,Hora,Autorizacion,Ciudad,IdCuenta) VALUES ('2000', 'Pago servicio', '13/10/2024','11:00','11:58','Puebla',1);
INSERT INTO Transacciones(Monto,Concepto,Fecha,Hora,Autorizacion,Ciudad,IdCuenta) VALUES ('3000', 'Pago Incripccion', '14/10/2024','10:55','11:00','Puebla', 1);
INSERT INTO Transacciones(Monto,Concepto,Fecha,Hora,Autorizacion,Ciudad,IdCuenta) VALUES ('1000', 'Pago Renta', '15/10/2024','10:50','10:58', 'Puebla',1);
INSERT INTO Transacciones(Monto,Concepto,Fecha,Hora,Autorizacion,Ciudad,IdCuenta) VALUES ('2000', 'Pago Prestado', '16/10/2024','7:50','07:58', 'Puebla',1);
INSERT INTO Transacciones(Monto,Concepto,Fecha,Hora,Autorizacion,Ciudad,IdCuenta) VALUES ('1000', 'Pago Escuela', '17/10/2024','05:50','05:58', 'Puebla',1);
INSERT INTO Transacciones(Monto,Concepto,Fecha,Hora,Autorizacion,Ciudad,IdCuenta) VALUES ('3000', 'Pago Ropa', '18/10/2024','12:50','12:58', 'Puebla',1);

INSERT INTO Transacciones(Monto,Concepto,Fecha,Hora,Autorizacion,Ciudad,IdCuenta) VALUES ('2000', 'Pago altas', '13/10/2024','11:00','11:58','CDMX', 6);
INSERT INTO Transacciones(Monto,Concepto,Fecha,Hora,Autorizacion,Ciudad,IdCuenta) VALUES ('3000', 'Pago Luz', '14/10/2024','10:55','11:00','CDMX', 6);
INSERT INTO Transacciones(Monto,Concepto,Fecha,Hora,Autorizacion,Ciudad,IdCuenta) VALUES ('1000', 'Pago Gasto', '15/10/2024','10:50','10:58','CDMX', 10);
INSERT INTO Transacciones(Monto,Concepto,Fecha,Hora,Autorizacion,Ciudad,IdCuenta) VALUES ('2000', 'Pago Ahorro', '16/10/2024','7:50','07:58','CDMX', 7);
INSERT INTO Transacciones(Monto,Concepto,Fecha,Hora,Autorizacion,Ciudad,IdCuenta) VALUES ('1000', 'Pago Clase', '17/10/2024','05:50','05:58','CDMX', 8);
INSERT INTO Transacciones(Monto,Concepto,Fecha,Hora,Autorizacion,Ciudad,IdCuenta) VALUES ('3000', 'Pago Ropa', '18/10/2024','12:50','12:58','CDMX', 9);


create table Prestamo(
    Id number GENERATED always as identity NOT NULL PRIMARY KEY,
    Plazo date not null,
    Interes varchar2(4) not null,
    Monto number(12,2) not null,
    FechaLimite date not null,
    Ciudad varchar2(255) not null,
    IdCliente number not null,
    constraint fk_cliente_prestamo foreign key(IdCliente)
    references Clientes(Id) ON DELETE CASCADE
);

INSERT INTO Prestamo(Plazo,Interes,Monto,FechaLimite,Ciudad,IdCliente) VALUES ('13/12/2024','5%','3000', '16/12/2024','Puebla' ,1);
INSERT INTO Prestamo(Plazo,Interes,Monto,FechaLimite,Ciudad,IdCliente) VALUES ('14/12/2024','5%','4000', '16/12/2024','Puebla' , 2);
INSERT INTO Prestamo(Plazo,Interes,Monto,FechaLimite,Ciudad,IdCliente) VALUES ('15/12/2024','5%','5000', '16/12/2024','Puebla' , 3);
INSERT INTO Prestamo(Plazo,Interes,Monto,FechaLimite,Ciudad,IdCliente) VALUES ('11/12/2024','5%','6000', '16/12/2024','Puebla' , 1);
INSERT INTO Prestamo(Plazo,Interes,Monto,FechaLimite,Ciudad,IdCliente) VALUES ('10/12/2024','5%','3000', '16/12/2024','Puebla' , 2);

INSERT INTO Prestamo(Plazo,Interes,Monto,FechaLimite,Ciudad,IdCliente) VALUES ('11/12/2024','5%','3000', '17/12/2024','CDMX', 5);
INSERT INTO Prestamo(Plazo,Interes,Monto,FechaLimite,Ciudad,IdCliente) VALUES ('13/12/2024','5%','4000', '17/12/2024','CDMX', 6);
INSERT INTO Prestamo(Plazo,Interes,Monto,FechaLimite,Ciudad,IdCliente) VALUES ('08/12/2024','5%','5000', '17/12/2024','CDMX', 7);
INSERT INTO Prestamo(Plazo,Interes,Monto,FechaLimite,Ciudad,IdCliente) VALUES ('07/12/2024','5%','6000', '17/12/2024','CDMX', 8);
INSERT INTO Prestamo(Plazo,Interes,Monto,FechaLimite,Ciudad,IdCliente) VALUES ('05/12/2024','5%','3000', '17/12/2024','CDMX', 9);



--Fragmentacion Horizontal (registros)
--Fracmentacion ENTIDAD clientes en lugar de crear una fragmentacion con una tabal se va a realizar una vista normalizada que nos va a ayudar a que esta se va a ir actualizando
--Vista materializada para Puebla
-- Vistas Materializadas de Clientes (Fragmentación Horizontal)
CREATE MATERIALIZED VIEW clientes_puebla_vm AS
SELECT * FROM Clientes WHERE Ciudad = 'Puebla';

-- Log único para Clientes
CREATE MATERIALIZED VIEW LOG ON Clientes
WITH ROWID, PRIMARY KEY, SEQUENCE (Ciudad, Nombre, Telefono, RFC)
INCLUDING NEW VALUES;

-- Vistas Materializadas de Cuenta (Fragmentación Horizontal)
CREATE MATERIALIZED VIEW cuenta_puebla_vm AS
SELECT * FROM Cuenta WHERE Ciudad = 'Puebla';

-- Log único para Cuenta
CREATE MATERIALIZED VIEW LOG ON Cuenta
WITH ROWID, PRIMARY KEY, SEQUENCE (Ciudad, Tipo, Saldo, NTarjeta, IdCliente)
INCLUDING NEW VALUES;


-- Vista Materializada de EstadoCuenta (Fragmentación Vertical)
CREATE MATERIALIZED VIEW EstadoCuentaPuebla AS
SELECT 
    C.nombre, C.Telefono, C.RFC,
    C.cp, C.Calle, C.ciudad,
    O.Tipo, O.Saldo, O.NTarjeta, O.Id,
    T.monto, T.concepto, T.Fecha
FROM Clientes C
JOIN Cuenta O ON C.Id = O.IdCliente
JOIN Transacciones T ON O.Id = T.IdCuenta
WHERE C.ciudad = 'Puebla';

-- Logs únicos para cada tabla involucrada en la vista EstadoCuenta
CREATE MATERIALIZED VIEW LOG ON Transacciones
WITH ROWID, PRIMARY KEY, SEQUENCE (Monto, Concepto, Fecha, IdCuenta)
INCLUDING NEW VALUES;




--Procedimiento para dar de alta a un cliente 
SET SERVEROUTPUT ON
DROP PROCEDURE insertarcliente;
CREATE OR REPLACE PROCEDURE insertarCliente(
    Nombre VARCHAR2, 
    Apellido VARCHAR2, 
    FechaNacimiento DATE, 
    Telefono VARCHAR2,
    RFC VARCHAR2, 
    Ciudad VARCHAR2,
    CP VARCHAR2,
    Calle VARCHAR2,
    Numero VARCHAR2,
    IdSucursal NUMBER
) IS
    edad_cliente NUMBER;
BEGIN
    SELECT TRUNC(MONTHS_BETWEEN(SYSDATE, FechaNacimiento) / 12)
    INTO edad_cliente
    FROM dual;
    IF edad_cliente < 18 THEN
        RAISE_APPLICATION_ERROR(-20001, 'El cliente debe ser mayor de 18 años.');
    END IF;
    DBMS_OUTPUT.PUT_LINE('-------- DAR DE ALTA A UN CLIENTE ----------------');
    INSERT INTO Clientes (Nombre, Apellido, FechaNacimiento, Telefono, RFC, Ciudad,CP,Calle,Numero, IdSucursal)
    VALUES (Nombre, Apellido, FechaNacimiento, Telefono, RFC, Ciudad,CP,Calle,Numero, IdSucursal);
    -- Refrescar la vista materializada correspondiente
    IF Ciudad = 'Puebla' THEN
        DBMS_MVIEW.REFRESH('clientes_puebla_vm');
        DBMS_MVIEW.REFRESH('EstadoCuentaPuebla');
    ELSIF Ciudad = 'CDMX' THEN
        DBMS_MVIEW.REFRESH@ServerCDMX('clientes_cdmx_vm');
        DBMS_MVIEW.REFRESH@ServerCDMX('EstadoCuentaCDMX');
    END IF;
    DBMS_OUTPUT.PUT_LINE('Cliente agregado y vistas actualizadas.');
    COMMIT;
END;
/

SHOW ERRORS PROCEDURE insertarCliente;
CALL insertarcliente('Cristian','Juarez Carreto','19/10/2000','2222222222','VBNM123456NJ3','Puebla','72000','Zona Centro','5pon',1);
CALL insertarCliente('Luis Manuel', 'Gomez Florez', '01/01/2007', '2221234567', 'GOMJ070101HZ1','CDMX','72000','Zona Centro','5pon', 2);
SELECT * FROM clientes;

--Procedimiento para Depositar dinero
DROP PROCEDURE DepositarDinero;
CREATE OR REPLACE PROCEDURE DepositarDinero(
    CuentaDestino IN VARCHAR2,
    monto IN NUMBER,
    Ciudad IN VARCHAR2
) IS
    CURSOR Deposito IS
        SELECT saldo
        FROM Cuenta
        WHERE NTarjeta = CuentaDestino
        FOR UPDATE;
    v_saldoN NUMBER;
BEGIN
    -- Abrimos el cursor para obtener el saldo actual
    OPEN Deposito;
    FETCH Deposito INTO v_saldoN;
    
    IF Deposito%FOUND THEN
        -- Sumar el monto al saldo actual
        v_saldoN := v_saldoN + monto; 
        
        -- Actualizar el saldo en la tabla Cuenta
        UPDATE Cuenta
        SET saldo = v_saldoN
        WHERE NTarjeta = CuentaDestino;

        -- Insertar la transacción en la tabla Transacciones
        INSERT INTO Transacciones (Monto, Concepto, Fecha, Hora, Autorizacion, IdCuenta,Ciudad)
        VALUES (
            monto, 
            'Depósito', 
            SYSDATE, 
            TO_CHAR(SYSDATE, 'HH24:MI:SS'), 
            'Autorización123',
            (SELECT Id FROM Cuenta WHERE NTarjeta = CuentaDestino),
            Ciudad
        );

        DBMS_OUTPUT.PUT_LINE('Depósito de ' || monto || ' realizado correctamente a la cuenta ' || CuentaDestino);
        DBMS_MVIEW.REFRESH('EstadoCuenta');
        -- Actualizar la vista materializada en función de la ciudad especificada
        IF Ciudad = 'CDMX' THEN
            DBMS_MVIEW.REFRESH@ServerCDMX('cuenta_cdmx_vm');
            DBMS_MVIEW.REFRESH@ServerCDMX('EstadoCuentaCDMX');
        ELSIF Ciudad = 'Puebla' THEN
            DBMS_MVIEW.REFRESH('cuenta_puebla_vm');
            DBMS_MVIEW.REFRESH('EstadoCuentaPuebla');
        ELSE
            DBMS_OUTPUT.PUT_LINE('La ciudad especificada no es válida para la actualización de vistas.');
        END IF;
    ELSE     
        DBMS_OUTPUT.PUT_LINE('------El número al que quieres depositar no existe------');
    END IF;    
    -- Cerrar el cursor y confirmar la transacción
    CLOSE Deposito;
    COMMIT;
EXCEPTION
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Ocurrió un error: ' || SQLERRM);    
END;
/

SHOW ERRORS PROCEDURE DepositarDinero; 
--Consulta para ver el cambio
SELECT saldo, ntarjeta FROM Cuenta;
SELECT saldo, ntarjeta FROM EstadoCuenta;

DECLARE
    v_CuentaDestino VARCHAR2(16) := '4432111187654321'; 
    v_monto NUMBER := 5000;                              
    v_ciudad VARCHAR2(10) := 'CDMX';                     
BEGIN
    -- Llamamos al procedimiento para depositar dinero
    DepositarDinero(v_CuentaDestino, v_monto, v_ciudad);

    -- Confirmación del resultado
    DBMS_OUTPUT.PUT_LINE('Proceso de depósito completado.');
END;
/

SELECT saldo, ntarjeta FROM Cuenta;
SELECT saldo, ntarjeta FROM EstadoCuenta;

DROP PROCEDURE RetirarDinero;
CREATE OR REPLACE PROCEDURE RetirarDinero(nip IN NUMBER, sacar IN NUMBER, Ciudad IN VARCHAR2) IS
    CURSOR Retiro IS
        SELECT id, saldo, Ciudad
        FROM Cuenta
        WHERE id = nip
        FOR UPDATE;
        
    retirar Retiro%ROWTYPE;
    v_saldo NUMBER;
    
BEGIN
    OPEN Retiro;
    FETCH Retiro INTO retirar;
    IF Retiro%FOUND THEN
        IF retirar.saldo >= sacar THEN
            v_saldo := retirar.saldo - sacar; 
            UPDATE Cuenta
            SET saldo = v_saldo
            WHERE id = nip;
            INSERT INTO Transacciones(Monto, Concepto, Fecha, Hora, Autorizacion, IdCuenta,Ciudad)
            VALUES (sacar, 'Retiro', SYSDATE, TO_CHAR(SYSDATE, 'HH24:MI:SS'), 'Autorización456', retirar.id,Ciudad);
            DBMS_OUTPUT.PUT_LINE('Retiro de ' || sacar || ' realizado correctamente, saldo en cuenta ' || v_saldo);
            -- Actualizar la vista materializada en función de la ciudad especificada
            IF Ciudad = 'CDMX' THEN
                DBMS_MVIEW.REFRESH@ServerCDMX('cuenta_cdmx_vm');
                DBMS_MVIEW.REFRESH@ServerCDMX('EstadoCuentaCDMX');
            ELSIF Ciudad = 'Puebla' THEN
                DBMS_MVIEW.REFRESH('cuenta_puebla_vm');
                DBMS_MVIEW.REFRESH('EstadoCuentaPuebla');
            END IF;
        ELSE     
        DBMS_OUTPUT.PUT_LINE('------Saldo Ingresado sobrepasa el saldo en la cuenta------');
        END IF;
    ELSE
        DBMS_OUTPUT.PUT_LINE('------El nip ingresado no existe ------');
    END IF;
    CLOSE Retiro;
    COMMIT;
EXCEPTION
    WHEN OTHERS THEN
        ROLLBACK;
        DBMS_OUTPUT.PUT_LINE('Ocurrió un error: ' || SQLERRM);    
END;
/

SHOW ERRORS PROCEDURE RetirarDinero;
--CONSULTA ANTES 
SELECT id, saldo FROM Cuenta;
SELECT saldo, ntarjeta FROM EstadoCuenta;
SELECT  * FROM cuenta_puebla_vm WHERE id = 1;
DECLARE
    v_nip NUMBER; 
    v_sacar NUMBER;
    v_ciudad VARCHAR2(20);
BEGIN
    v_nip := 1; 
    v_sacar := 1000;
    v_ciudad := 'Puebla';
    RetirarDinero(v_nip, v_sacar,v_ciudad);
END;
/


--CONSULTA DESPUES
SELECT id, saldo, ntarjeta FROM Cuenta;
SELECT id,saldo, ntarjeta FROM EstadoCuenta;
SELECT  id, saldo, ntarjeta FROM cuenta_puebla_vm WHERE id = 1;

--Procedimiento para solicitud de un Credito
DROP PROCEDURE SolicitarCredito;
CREATE OR REPLACE PROCEDURE SolicitarCredito(
    p_IdCliente IN NUMBER,
    p_Monto IN NUMBER,
    p_Plazo IN DATE,
    p_Interes IN VARCHAR2,
    p_FechaLimite IN DATE,
    p_ciudad IN VARCHAR2
) IS
    v_Aprobado BOOLEAN := FALSE;
    v_Existe NUMBER := 0;
    v_Limite NUMBER := 12000;
BEGIN
    SELECT COUNT(*) INTO v_Existe--Verifica si es cliente del banco
    FROM Clientes
    WHERE Id = p_IdCliente;

    IF v_Existe = 0 THEN
        DBMS_OUTPUT.PUT_LINE('El cliente no existe.');
        RETURN;
    END IF;

    IF p_Monto > v_Limite THEN
        DBMS_OUTPUT.PUT_LINE('El monto solicitado excede el límite permitido.');
        RETURN;
    END IF;

    --Inserta en la Entidad PrestamoPuebla
    INSERT INTO Prestamo (Plazo, Interes, Monto, FechaLimite,Ciudad ,IdCliente)
    VALUES (p_Plazo, p_Interes, p_Monto, p_FechaLimite,p_ciudad ,p_IdCliente);

    v_Aprobado := TRUE;
    
    IF v_Aprobado THEN
        DBMS_OUTPUT.PUT_LINE('Crédito aprobado con ID: ' || p_IdCliente);
    ELSE
        DBMS_OUTPUT.PUT_LINE('Credito Denegado');
    END IF;
    COMMIT;
EXCEPTION
    WHEN OTHERS THEN
        ROLLBACK;
        DBMS_OUTPUT.PUT_LINE('Ocurrió un error: ' || SQLERRM);
END SolicitarCredito;
/


SHOW ERRORS PROCEDURE SolicitarCredito;
SELECT * FROM Prestamo where IdCliente = 1;

BEGIN
    SolicitarCredito(1, 3000, '15/12/2024', '5%','16/12/2024','Puebla');
END;
/
SELECT * FROM Prestamo where IdCliente = 1;



--PROCEDIMIENTO PARA ELIMINAR UN CLIENTE
SET SERVEROUTPUT ON;
DROP PROCEDURE eliminarcliente;
CREATE OR REPLACE PROCEDURE eliminarCliente (
    vid IN NUMBER
)
IS
    cliente_existente NUMBER;
    vCiudad VARCHAR2(50);
BEGIN
    -- Verificar si el cliente existe y obtener su ciudad
    SELECT COUNT(*), MAX(Ciudad) INTO cliente_existente, vCiudad
    FROM Clientes
    WHERE Id = vid;

    IF cliente_existente > 0 THEN
        -- Eliminar el cliente (ON DELETE CASCADE se encargará de eliminar registros relacionados)
        DELETE FROM Clientes WHERE Id = vid;
        DBMS_OUTPUT.PUT_LINE('Cliente con ID ' || vid || ' eliminado correctamente.');
        -- Actualizar la vista materializada específica por ciudad
        IF vCiudad = 'Puebla' THEN
            DBMS_MVIEW.REFRESH('clientes_puebla_vm');
            DBMS_MVIEW.REFRESH('EstadoCuentaPuebla');
        ELSIF vCiudad = 'CDMX' THEN
            DBMS_MVIEW.REFRESH@ServerCDMX('Clientes_cdmx_vm');
            DBMS_MVIEW.REFRESH@ServerCDMX('EstadoCuentaCDMX');
        END IF;
    ELSE
        DBMS_OUTPUT.PUT_LINE('Cliente con ID ' || vid || ' no encontrado.');
    END IF;
    COMMIT;

EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE = -2292 THEN
            DBMS_OUTPUT.PUT_LINE('No se puede eliminar el cliente con ID ' || vid || ' debido a registros relacionados.');
        ELSE
            DBMS_OUTPUT.PUT_LINE('Ocurrió un error inesperado: ' || SQLERRM);
        END IF;
END;
/


BEGIN
    eliminarCliente(7);
END;
/
 

SELECT ID, NOMBRE FROM CLIENTES;

--DAR DE BAJA UNA CUENTA
DROP PROCEDURE DarDeBajaCuenta;
CREATE OR REPLACE PROCEDURE DarDeBajaCuenta (
    vid IN NUMBER
)
IS
    vCiudad VARCHAR2(50);
BEGIN
    -- Verificar si la cuenta existe y obtener su ciudad
    BEGIN
        SELECT Ciudad INTO vCiudad
        FROM Cuenta
        WHERE Id = vid;
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            DBMS_OUTPUT.PUT_LINE('Cuenta con ID ' || vid || ' no encontrada.');
            RETURN;
    END;

    -- Eliminar cuenta (ON DELETE CASCADE se encargará de registros relacionados)
    DELETE FROM Cuenta WHERE Id = vid;
    DBMS_OUTPUT.PUT_LINE('Cuenta con ID ' || vid || ' eliminada correctamente.');
    -- Actualizar la vista materializada específica por ciudad
    IF vCiudad = 'Puebla' THEN
        DBMS_MVIEW.REFRESH('cuenta_puebla_vm');
        DBMS_MVIEW.REFRESH('EstadoCuentaPuebla');
    ELSIF vCiudad = 'CDMX' THEN
        DBMS_MVIEW.REFRESH@ServerCDMX('cuenta_cdmx_vm');
        DBMS_MVIEW.REFRESH@ServerCDMX('EstadoCuentaCDMX');
    END IF;

    COMMIT;

EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE = -2292 THEN
            DBMS_OUTPUT.PUT_LINE('No se puede eliminar la cuenta con ID ' || vid || ' debido a registros relacionados.');
        ELSE
            DBMS_OUTPUT.PUT_LINE('Ocurrió un error inesperado: ' || SQLERRM);
        END IF;
END;
/



BEGIN
    DarDeBajaCuenta(7);
END;
/
SELECT ID FROM CUENTA;

--Procedimiento que va VERIFICAR SI EL CLIENTE TIENE UN PRESTAMO ACTIVO
CREATE OR REPLACE PROCEDURE VerificarPrestamo(
    vid IN NUMBER,          
    interes OUT VARCHAR2    
) 
IS
    CURSOR encontrarCliente IS 
        SELECT 
            c.Nombre AS nombre_cliente,
            c.id,
            NVL(p.Plazo, TO_DATE('01/01/1900', 'DD/MM/YYYY')) AS Plazo,
            NVL(p.FechaLimite, TO_DATE('01/01/1900', 'DD/MM/YYYY')) AS FechaLimite,
            NVL(p.Monto, 0) AS Monto,
            NVL(p.Interes, 0) AS Interes
        FROM 
            Clientes c
            JOIN Prestamo p ON c.Id = p.IdCliente
        WHERE 
            c.Id = vid;  -- Filtrar por el ID del cliente proporcionado

    vreg encontrarCliente%ROWTYPE;
BEGIN
    -- Inicializar la salida
    interes := '';
    
    -- Abrir el cursor
    OPEN encontrarCliente;
    
    -- Recuperar los datos del cliente con préstamo
    FETCH encontrarCliente INTO vreg;

    -- Verificar si se encontraron registros
    IF encontrarCliente%FOUND THEN
        -- Construir el resultado con los detalles encontrados
        interes := 'NOMBRE: ' || vreg.nombre_cliente || 
                   ' | PLAZO: ' || TO_CHAR(vreg.Plazo, 'DD/MM/YYYY') ||
                   ' | FECHA LIMITE: ' || TO_CHAR(vreg.FechaLimite, 'DD/MM/YYYY') ||
                   ' | MONTO: ' || TO_CHAR(vreg.Monto, '999G999G990D00') ||
                   ' | INTERES: ' || vreg.Interes;
    ELSE
        -- En caso de no encontrar registros
        interes := 'No se encontró información del cliente con ID ' || vid;
    END IF;

    -- Cerrar el cursor
    CLOSE encontrarCliente;
    Commit;
END;
/

SET SERVEROUTPUT ON;
BEGIN
    DECLARE
        v_interes VARCHAR2(4000);
    BEGIN
        VerificarPrestamo(5, v_interes);
        DBMS_OUTPUT.PUT_LINE(v_interes);
    END;
END;
/


--Procedimiento almacendo de Estado Cuenta
DROP PROCEDURE VerEstadoCuenta; 
CREATE OR REPLACE PROCEDURE VerEstadoCuenta(
    vnumerotarjeta IN VARCHAR2,
    informacion OUT VARCHAR2
) 
IS
    CURSOR encontrarCliente IS 
        SELECT 
            C.nombre, C.telefono, C.rfc,
            C.cp, C.calle, C.ciudad,
            O.tipo, O.saldo, O.NTarjeta, O.Id,
            T.monto, T.concepto, T.fecha
        FROM Clientes C
        JOIN Cuenta O ON C.Id = O.IdCliente
        JOIN Transacciones T ON O.Id = T.IdCuenta
        WHERE O.NTarjeta = vnumerotarjeta;

    vreg encontrarCliente%ROWTYPE;
BEGIN
    -- Inicializar la salida
    informacion := '';
    
    -- Abrir el cursor
    OPEN encontrarCliente;
    
    -- Recuperar el primer registro
    FETCH encontrarCliente INTO vreg;

    -- Verificar si se encontraron registros
    IF encontrarCliente%FOUND THEN
        informacion := 'NOMBRE: ' || vreg.nombre || 
                       ' | TELEFONO: ' || vreg.telefono ||
                       ' | RFC: ' || vreg.rfc ||
                       ' | CP: ' || vreg.cp ||
                       ' | CALLE: ' || vreg.calle ||
                       ' | CIUDAD: ' || vreg.ciudad ||
                       ' | TIPO CUENTA: ' || vreg.tipo ||
                       ' | SALDO EXISTENTE: ' || vreg.saldo ||
                       ' | MONTO TRANSFERENCIA: ' || vreg.monto ||
                       ' | CONCEPTOS: ' || vreg.concepto ||
                       ' | FECHA MOVIMIENTOS: ' || TO_CHAR(vreg.fecha, 'DD-MON-YYYY');
    ELSE
        -- En caso de no encontrar registros
        informacion := 'No se encontró información del cliente con Número de Tarjeta ' || vnumerotarjeta;
    END IF;

    -- Cerrar el cursor
    CLOSE encontrarCliente;
END;
/


SET SERVEROUTPUT ON;
BEGIN
    VerEstadoCuenta('4532111187654321');
END;
/

--PROEDIMIENTO PARA SABER EL SALDO DISPONIBLE QUE TIENE EN SU CUENTA
CREATE OR REPLACE PROCEDURE VerSaldo(
    vnumerotarjeta IN VARCHAR2
) 
IS
    informacion VARCHAR2(4000);
    CURSOR encontrarCliente IS 
        SELECT saldo,ntarjeta 
        FROM cuenta
        WHERE NTarjeta = vnumerotarjeta;

    vreg encontrarCliente%ROWTYPE;
BEGIN
    -- Inicializar la salida
    informacion := '';
    
    -- Abrir el cursor
    OPEN encontrarCliente;
    
    -- Recuperar el primer registro
    FETCH encontrarCliente INTO vreg;

    -- Verificar si se encontraron registros
    IF encontrarCliente%FOUND THEN
        informacion := 'Numero Tajeta: ' || vreg.ntarjeta || 
                       ' | Saldo En La Cuenta: ' || TO_CHAR(vreg.saldo);
    ELSE
        -- En caso de no encontrar registros
        informacion := 'No se encontró información del cliente con Número de Tarjeta ' || vnumerotarjeta;
    END IF;

    -- Imprimir la información
    DBMS_OUTPUT.PUT_LINE(informacion);

    -- Cerrar el cursor
    CLOSE encontrarCliente;
    Commit;
EXCEPTION
    WHEN OTHERS THEN
        -- Capturar errores inesperados
        DBMS_OUTPUT.PUT_LINE('Ocurrió un error: ' || SQLERRM);
END;
/


SHOW ERRORS PROCEDURE VerSaldo;
SET SERVEROUTPUT ON;
BEGIN
    VerSaldo('4532111187654321');
END;
/

/* CLIENTE - Cambios
Debe permitir modificar la información de un cliente que ya existe en la base de datos, actualizando vistas
materializadas en función de la ciudad del cliente. Utiliza tabla de clientes y sucursales. */

-- Procedimiento para actualizar la información de un cliente
DROP PROCEDURE ActualizarCliente;
CREATE OR REPLACE PROCEDURE ActualizarCliente(
    p_IdCliente IN NUMBER,
    p_Nombre IN VARCHAR2,
    p_Apellido IN VARCHAR2,
    p_FechaNacimiento IN DATE,
    p_Telefono IN VARCHAR2,
    p_RFC IN VARCHAR2,
    p_Ciudad IN VARCHAR2,
    p_CP IN VARCHAR2,
    p_Calle IN VARCHAR2,
    p_Numero IN VARCHAR2,
    p_IdSucursal IN NUMBER
) IS
    edad_cliente NUMBER;
    ciudad_anterior VARCHAR2(255);
BEGIN
    -- Verificar si el cliente existe
    SELECT COUNT(*), MAX(Ciudad) INTO edad_cliente, ciudad_anterior
    FROM Clientes
    WHERE Id = p_IdCliente;

    IF edad_cliente = 0 THEN
        DBMS_OUTPUT.PUT_LINE('El cliente con ID ' || p_IdCliente || ' no existe.');
        RETURN;
    END IF;

    -- Verificar la mayoría de edad del cliente
    SELECT TRUNC(MONTHS_BETWEEN(SYSDATE, p_FechaNacimiento) / 12)
    INTO edad_cliente
    FROM dual;

    IF edad_cliente < 18 THEN
        RAISE_APPLICATION_ERROR(-20001, 'El cliente debe ser mayor de 18 años.');
    END IF;

    -- Actualizar la información del cliente
    UPDATE Clientes
    SET Nombre = p_Nombre,
        Apellido = p_Apellido,
        FechaNacimiento = p_FechaNacimiento,
        Telefono = p_Telefono,
        RFC = p_RFC,
        Ciudad = p_Ciudad,
        CP = p_CP,
        Calle = p_Calle,
        Numero = p_Numero,
        IdSucursal = p_IdSucursal
    WHERE Id = p_IdCliente;

    DBMS_OUTPUT.PUT_LINE('Cliente actualizado correctamente.');

    -- Refrescar las vistas materializadas correspondientes
    IF ciudad_anterior = 'Puebla' THEN
        DBMS_MVIEW.REFRESH('clientes_puebla_vm');
        DBMS_MVIEW.REFRESH('EstadoCuentaPuebla');
    ELSIF ciudad_anterior = 'CDMX' THEN
        DBMS_MVIEW.REFRESH@ServerCDMX('clientes_cdmx_vm');
        DBMS_MVIEW.REFRESH@ServerCDMX('EstadoCuentaCDMX');
    END IF;

    IF p_Ciudad != ciudad_anterior THEN
        IF p_Ciudad = 'Puebla' THEN
            DBMS_MVIEW.REFRESH('clientes_puebla_vm');
            DBMS_MVIEW.REFRESH('EstadoCuentaPuebla');
        ELSIF p_Ciudad = 'CDMX' THEN
            DBMS_MVIEW.REFRESH@ServerCDMX('clientes_cdmx_vm');
            DBMS_MVIEW.REFRESH@ServerCDMX('EstadoCuentaCDMX');
        END IF;
    END IF;

    COMMIT;
END;
/


DECLARE
    v_IdCliente NUMBER := 1; 
    v_Nombre VARCHAR2(100) := 'Juancarlos';
    v_Apellido VARCHAR2(100) := 'Duran';
    v_FechaNacimiento DATE := TO_DATE('1990-01-01', 'YYYY-MM-DD');
    v_Telefono VARCHAR2(20) := '5551234567';
    v_RFC VARCHAR2(20) := 'JUPR900101HDF';
    v_Ciudad VARCHAR2(100) := 'CDMX';
    v_CP VARCHAR2(10) := '12345';
    v_Calle VARCHAR2(100) := 'Avenida Siempre Viva';
    v_Numero VARCHAR2(10) := '742';
    v_IdSucursal NUMBER := 2; 
BEGIN
    ActualizarCliente(
        p_IdCliente => v_IdCliente,
        p_Nombre => v_Nombre,
        p_Apellido => v_Apellido,
        p_FechaNacimiento => v_FechaNacimiento,
        p_Telefono => v_Telefono,
        p_RFC => v_RFC,
        p_Ciudad => v_Ciudad,
        p_CP => v_CP,
        p_Calle => v_Calle,
        p_Numero => v_Numero,
        p_IdSucursal => v_IdSucursal
    );
END;
/


/* CUENTA - Alta
Debe crear una nueva cuenta para un cliente que ya existe, estando vinculada a través del atributo IdCliente */

-- Procedimiento para dar de alta una nueva cuenta bancaria
DROP PROCEDURE DarDeAltaCuenta;
CREATE OR REPLACE PROCEDURE DarDeAltaCuenta(
    p_Tipo IN VARCHAR2,
    p_Saldo IN NUMBER,
    p_NTarjeta IN VARCHAR2,
    p_Ciudad IN VARCHAR2,
    p_IdCliente IN NUMBER
) IS
    cliente_existente NUMBER;
BEGIN
    -- Verificar si el cliente existe
    SELECT COUNT(*) INTO cliente_existente
    FROM Clientes
    WHERE Id = p_IdCliente;

    IF cliente_existente = 0 THEN
        DBMS_OUTPUT.PUT_LINE('El cliente con ID ' || p_IdCliente || ' no existe.');
        RETURN;
    END IF;

    -- Insertar la nueva cuenta en la tabla Cuenta
    INSERT INTO Cuenta (Tipo, Saldo, NTarjeta, Ciudad, IdCliente)
    VALUES (p_Tipo, p_Saldo, p_NTarjeta, p_Ciudad, p_IdCliente);

    DBMS_OUTPUT.PUT_LINE('Cuenta creada correctamente para el cliente con ID: ' || p_IdCliente);

    -- Actualizar las vistas materializadas correspondientes
    IF p_Ciudad = 'Puebla' THEN
        DBMS_MVIEW.REFRESH('cuenta_puebla_vm');
        DBMS_MVIEW.REFRESH('EstadoCuentaPuebla');
    ELSIF p_Ciudad = 'CDMX' THEN
        DBMS_MVIEW.REFRESH@ServerCDMX('cuenta_cdmx_vm');
        DBMS_MVIEW.REFRESH@ServerCDMX('EstadoCuentaCDMX');
    END IF;

    COMMIT;
END;
/



/*
CUENTA - Cambios
Para actualizar información de una cuenta que ya existe.
*/

-- Procedimiento para actualizar la información de una cuenta existente
DROP PROCEDURE ActualizarCuenta;
CREATE OR REPLACE PROCEDURE ActualizarCuenta(
    p_IdCuenta IN NUMBER,
    p_Tipo IN VARCHAR2,
    p_Saldo IN NUMBER,
    p_NTarjeta IN VARCHAR2,
    p_Ciudad IN VARCHAR2
) IS
    cuenta_existente NUMBER;
    ciudad_anterior VARCHAR2(255);
BEGIN
    -- Verificar si la cuenta existe
    SELECT COUNT(*), MAX(Ciudad) INTO cuenta_existente, ciudad_anterior
    FROM Cuenta
    WHERE Id = p_IdCuenta;

    IF cuenta_existente = 0 THEN
        DBMS_OUTPUT.PUT_LINE('La cuenta con ID ' || p_IdCuenta || ' no existe.');
        RETURN;
    END IF;

    -- Actualizar la información de la cuenta
    UPDATE Cuenta
    SET Tipo = p_Tipo,
        Saldo = p_Saldo,
        NTarjeta = p_NTarjeta,
        Ciudad = p_Ciudad
    WHERE Id = p_IdCuenta;

    DBMS_OUTPUT.PUT_LINE('Cuenta actualizada correctamente.');

    -- Actualizar las vistas materializadas correspondientes
    IF ciudad_anterior = 'Puebla' THEN
        DBMS_MVIEW.REFRESH('cuenta_puebla_vm');
        DBMS_MVIEW.REFRESH('EstadoCuentaPuebla');
    ELSIF ciudad_anterior = 'CDMX' THEN
        DBMS_MVIEW.REFRESH@ServerCDMX('cuenta_cdmx_vm');
        DBMS_MVIEW.REFRESH@ServerCDMX('EstadoCuentaCDMX');
    END IF;

    IF p_Ciudad != ciudad_anterior THEN
        IF p_Ciudad = 'Puebla' THEN
            DBMS_MVIEW.REFRESH('cuenta_puebla_vm');
            DBMS_MVIEW.REFRESH('EstadoCuentaPuebla');
        ELSIF p_Ciudad = 'CDMX' THEN
            DBMS_MVIEW.REFRESH@ServerCDMX('cuenta_cdmx_vm');
            DBMS_MVIEW.REFRESH@ServerCDMX('EstadoCuentaCDMX');
        END IF;
    END IF;

    COMMIT;
END;
/


DECLARE
    v_IdCuenta NUMBER := 1;          
    v_Tipo VARCHAR2(50) := 'Ahorro';
    v_Saldo NUMBER := 7410;         
    v_NTarjeta VARCHAR2(50) := '1234567890123456'; 
    v_Ciudad VARCHAR2(100) := 'Puebla'; 
BEGIN
    -- Llamada al procedimiento
    ActualizarCuenta(
        p_IdCuenta => v_IdCuenta,
        p_Tipo => v_Tipo,
        p_Saldo => v_Saldo,
        p_NTarjeta => v_NTarjeta,
        p_Ciudad => v_Ciudad
    );
END;
/


-- Procedimiento para realizar una transferencia de dinero entre cuentas
DROP PROCEDURE TransferirDinero;
CREATE OR REPLACE PROCEDURE TransferirDinero(
    p_CuentaOrigen IN VARCHAR2,
    p_CuentaDestino IN VARCHAR2,
    p_Monto IN NUMBER,
    p_Ciudad IN VARCHAR2
) IS
    saldo_origen NUMBER;
    saldo_destino NUMBER;
BEGIN
    -- Obtener saldo de la cuenta de origen
    SELECT Saldo INTO saldo_origen
    FROM Cuenta
    WHERE NTarjeta = p_CuentaOrigen
    FOR UPDATE;

    -- Verificar que hay suficiente saldo en la cuenta de origen
    IF saldo_origen < p_Monto THEN
        DBMS_OUTPUT.PUT_LINE('Saldo insuficiente en la cuenta de origen.');
        RETURN;
    END IF;

    -- Obtener saldo de la cuenta de destino
    SELECT Saldo INTO saldo_destino
    FROM Cuenta
    WHERE NTarjeta = p_CuentaDestino
    FOR UPDATE;

    -- Realizar la transferencia
    UPDATE Cuenta
    SET Saldo = Saldo - p_Monto
    WHERE NTarjeta = p_CuentaOrigen;

    UPDATE Cuenta
    SET Saldo = Saldo + p_Monto
    WHERE NTarjeta = p_CuentaDestino;

    -- Registrar la transacción en la tabla Transacciones
    INSERT INTO Transacciones (Monto, Concepto, Fecha, Hora, Autorizacion, IdCuenta, Ciudad)
    VALUES (p_Monto, 'Transferencia', SYSDATE, TO_CHAR(SYSDATE, 'HH24:MI:SS'), 'Transferencia123', (SELECT Id FROM Cuenta WHERE NTarjeta = p_CuentaDestino), p_Ciudad);

    DBMS_OUTPUT.PUT_LINE('Transferencia realizada correctamente.');
    -- Actualizar vistas según la ciudad
    IF p_Ciudad = 'Puebla' THEN
        DBMS_MVIEW.REFRESH('cuenta_puebla_vm');
        DBMS_MVIEW.REFRESH('EstadoCuentaPuebla');
    ELSIF p_Ciudad = 'CDMX' THEN
        DBMS_MVIEW.REFRESH@ServerCDMX('cuenta_cdmx_vm');
        DBMS_MVIEW.REFRESH@ServerCDMX('EstadoCuentaCDMX');
    END IF;

    COMMIT;
END;
/


SHOW ERRORS PROCEDURE TransferirDinero;

-- Ejemplo de llamada al procedimiento
BEGIN
    TransferirDinero(
        '1234567890123456',    -- Número de tarjeta origen
        '8974111187654321',    -- Número de tarjeta destino
        5000,                  -- Monto a transferir
        'Puebla'               -- Ciudad
    );
END;
/





/*
REPORTES - Movimientos del mes

*/


-- Procedimiento para generar un reporte de movimientos del mes actual
DROP PROCEDURE ReporteMovimientosMes;

CREATE OR REPLACE PROCEDURE ReporteMovimientosMes(
    p_NTarjeta IN VARCHAR2,
    p_Informacion OUT CLOB -- Cambiado a CLOB
) IS
    CURSOR MovimientosMes IS
        SELECT 
            T.Monto, T.Concepto, T.Fecha, T.Hora, T.Ciudad
        FROM 
            Transacciones T
        JOIN 
            Cuenta C ON T.IdCuenta = C.Id
        WHERE 
            C.NTarjeta = p_NTarjeta
            AND EXTRACT(MONTH FROM T.Fecha) = EXTRACT(MONTH FROM SYSDATE)
            AND EXTRACT(YEAR FROM T.Fecha) = EXTRACT(YEAR FROM SYSDATE);

    movimiento MovimientosMes%ROWTYPE;
    reporte CLOB; -- Usamos CLOB para manejar el texto largo
BEGIN
    reporte := '--- Reporte de Movimientos del Mes ---' || CHR(10) || 
               'Número de Tarjeta: ' || p_NTarjeta || CHR(10) || CHR(10);

    OPEN MovimientosMes;
    LOOP
        FETCH MovimientosMes INTO movimiento;
        EXIT WHEN MovimientosMes%NOTFOUND;

        reporte := reporte || 'Monto: ' || movimiento.Monto || 
                            ' | Concepto: ' || movimiento.Concepto || 
                            ' | Fecha: ' || TO_CHAR(movimiento.Fecha, 'DD-MON-YYYY') || 
                            ' | Hora: ' || movimiento.Hora || 
                            ' | Ciudad: ' || movimiento.Ciudad || CHR(10);
    END LOOP;

    CLOSE MovimientosMes;

    p_Informacion := reporte;
END;
/



SHOW ERRORS PROCEDURE ReporteMovimientosMes;

-- Ejemplo de llamada al procedimiento
BEGIN
    ReporteMovimientosMes('1234567890123456');
END;
/


--LINK PARA MANTENER ACTUALIZADO LAS VM QUE VIVEN EN PUEBLA
CREATE DATABASE LINK ServerCDMX CONNECT TO usuario_remoto IDENTIFIED BY "TU_PASSWORD_AQUI" using '(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=IP_SERVIDOR_REMOTO)(PORT=1521)) (CONNECT_DATA=(sid=orcl)))';
--Confirmar transaccion
commit;




