
USE yimclood;
-- Crear tablas nuevamente con ON DELETE CASCADE
CREATE TABLE Miembros (
    Cedula VARCHAR(20) PRIMARY KEY,
    Nombre VARCHAR(20) NOT NULL,
    Apellido VARCHAR(20) NOT NULL,
    Telefono VARCHAR(20) NOT NULL,
    Sexo VARCHAR(10) NOT NULL,
    Fecha_Nacimiento DATE NOT NULL,
    Correo_Electronico VARCHAR(50) UNIQUE NOT NULL,
    Peso INT NOT NULL DEFAULT 0,
    Estatura INT NOT NULL DEFAULT 0,
    Foto LONGBLOB NULL
);

CREATE TABLE Entrenadores (
    Cedula VARCHAR(20) PRIMARY KEY,
    Nombre VARCHAR(20) NOT NULL,
    Apellido VARCHAR(20) NOT NULL,
    Telefono VARCHAR(20) NOT NULL,
    Sexo VARCHAR(10) NOT NULL,
    Correo_Electronico VARCHAR(50) UNIQUE NOT NULL,
    Fecha_Nacimiento DATE NOT NULL,
    Foto LONGBLOB NULL
);

CREATE TABLE Usuarios (
    Correo_Electronico VARCHAR(50) PRIMARY KEY NOT NULL,
    Clave VARCHAR(20) NOT NULL,
    Ced_Miembro VARCHAR(20) UNIQUE,
    Ced_Entrenador VARCHAR(20) UNIQUE,
    FOREIGN KEY (Ced_Miembro) REFERENCES Miembros(Cedula) ON DELETE CASCADE,
    FOREIGN KEY (Ced_Entrenador) REFERENCES Entrenadores(Cedula) ON DELETE CASCADE
);

CREATE TABLE Factura (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Cedula_Miembro VARCHAR(20),
    Fecha_Factura DATE,
    FOREIGN KEY (Cedula_Miembro) REFERENCES Miembros(Cedula) ON DELETE CASCADE
);

CREATE TABLE Membresias (
    Nombre VARCHAR(20) PRIMARY KEY NOT NULL,
    Descripcion VARCHAR(255) NOT NULL,
    Valor INT NOT NULL,
    Duracion INT NOT NULL, -- Duración en días
    Ced_Entrenador VARCHAR(20) NULL,
    FOREIGN KEY (Ced_Entrenador) REFERENCES Entrenadores(Cedula) ON DELETE SET NULL
);

CREATE TABLE Facturas_Productos (
    Id_Factura INT,
    Referencia_Producto VARCHAR(20),
    Cantidad INT,
    PRIMARY KEY (Id_Factura, Referencia_Producto),
    FOREIGN KEY (Id_Factura) REFERENCES Factura(Id) ON DELETE CASCADE,
    FOREIGN KEY (Referencia_Producto) REFERENCES Productos(Referencia) ON DELETE CASCADE
);

CREATE TABLE Membresias_Usuarios (
    Correo_Usuario VARCHAR(50) PRIMARY KEY NOT NULL,
    Nombre_Membresia VARCHAR(20) NOT NULL,
    Estado VARCHAR(20) NOT NULL,
    Fecha_Inicio DATE NOT NULL,
    Fecha_Final DATE NOT NULL,
    Saldo_Debe INT NOT NULL,
    Pagado BOOL NOT NULL,
    Duracion_Acumulada INT NOT NULL,
    Tiempo_Restante INT NOT NULL,
    FOREIGN KEY (Correo_Usuario) REFERENCES Usuarios(Correo_Electronico) ON DELETE CASCADE,
    FOREIGN KEY (Nombre_Membresia) REFERENCES Membresias(Nombre) ON DELETE CASCADE
);

CREATE TABLE Historiales (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Cedula_Miembro VARCHAR(20),
    Dia_De_La_Semana ENUM('Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'),
    Registro_Id INT,
    FOREIGN KEY (Cedula_Miembro) REFERENCES Miembros(Cedula) ON DELETE CASCADE,
    FOREIGN KEY (Registro_Id) REFERENCES Registros(Id) ON DELETE CASCADE
);

CREATE TABLE Registros (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Miembro_Cedula VARCHAR(20),
    Fecha DATE,
    Peso DOUBLE,
    Hombros DOUBLE,
    Pecho DOUBLE,
    AntebrazoIzquierdo DOUBLE,
    AntebrazoDerecho DOUBLE,
    BrazoIzquierdo DOUBLE,
    BrazoDerecho DOUBLE,
    Cintura DOUBLE,
    Cadera DOUBLE,
    PiernaIzquierda DOUBLE,
    PiernaDerecha DOUBLE,
    GemeloIzquierdo DOUBLE,
    GemeloDerecho DOUBLE,
    Altura DOUBLE,
    Foto LONGBLOB,
    FOREIGN KEY (Miembro_Cedula) REFERENCES Miembros(Cedula) ON DELETE CASCADE
);
CREATE TABLE Productos (
    Referencia VARCHAR(20) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(255) NOT NULL,
    Valor varchar(10) NOT NULL,
    Cantidad varchar(10) NOT NULL,
    Foto LONGBLOB NULL
);
select * from Miembros;
select * from Productos;
select * from Entrenadores;
select * from Usuarios;
select * from Membresias_Usuarios;
select * from Factura;

-- Eliminar tablas existentes
DROP TABLE IF EXISTS Factura;
DROP TABLE IF EXISTS Membresias;
DROP TABLE IF EXISTS Facturas_Productos;
DROP TABLE IF EXISTS Membresias_Usuarios;
DROP TABLE IF EXISTS Historiales;
DROP TABLE IF EXISTS Registros;
DROP TABLE IF EXISTS Usuarios;
DROP TABLE IF EXISTS Entrenadores;
DROP TABLE IF EXISTS Miembros;
DROP TABLE IF exists Productos;

DELETE FROM Miembros WHERE Cedula = "234";
UPDATE Miembros SET 
    Nombre = 'Juan',
    Apellido = 'Pérez',
    Telefono = '555-1234',
    Sexo = 'M',
    Fecha_Nacimiento = '1990-05-15',
    Correo_Electronico = 'juan.perez@example.com',
    Foto = 'juan_perez.jpg' 
WHERE Cedula = '234';
