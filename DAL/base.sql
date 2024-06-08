
CREATE TABLE Factura (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Cedula_Miembro VARCHAR(50),
    Fecha_Factura DATE,
    FOREIGN KEY (Cedula_Miembro) REFERENCES Miembros(cedula)
);
CREATE TABLE Membresias	 (
    Nombre VARCHAR(20) PRIMARY KEY NOT NULL,
    Descripcion VARCHAR(255) NOT NULL,
    Valor INT NOT NULL,
    Duracion INT NOT NULL, -- Duración en días
    Ced_Entrenador VARCHAR(50) NULL,
    FOREIGN KEY (Ced_Entrenador) REFERENCES Entrenadores(Cedula)
);
CREATE TABLE Facturas_Productos (
    Id_Factura INT,
    Referencia_Producto VARCHAR(50),
    Cantidad INT,
    PRIMARY KEY (Id_Factura, Referencia_Producto),
    FOREIGN KEY (Id_Factura) REFERENCES Factura(Id),
    FOREIGN KEY (Referencia_Producto) REFERENCES Productos(Referencia)
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
    FOREIGN KEY (Correo_Usuario) REFERENCES Usuarios(Correo_Electronico),
    FOREIGN KEY (Nombre_Membresia) REFERENCES Membresias(Nombre)
);
select * from miembros;
CREATE TABLE Historiales (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Cedula_Miembro VARCHAR(50),
    Dia_De_La_Semana ENUM('Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'),
    Registro_Id INT,
    FOREIGN KEY (Cedula_Miembro) REFERENCES Miembros(cedula),
    FOREIGN KEY (Registro_Id) REFERENCES Registros(Id)
);
CREATE TABLE Registros (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Miembro_Cedula VARCHAR(50),
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
    FOREIGN KEY (Miembro_Cedula) REFERENCES Miembros(cedula)
);
CREATE TABLE Usuarios (
    Correo_Electronico VARCHAR(50) PRIMARY KEY NOT NULL,
    Clave VARCHAR(20) NOT NULL,
    Ced_Miembro VARCHAR(20)UNIQUE,
    Ced_Entrenador VARCHAR(20)UNIQUE,
	FOREIGN KEY (Ced_Miembro) REFERENCES Miembros(Cedula),
    FOREIGN KEY (Ced_Entrenador) REFERENCES entrenadores(Cedula)
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
DELETE FROM miembros;	
SELECT 
    mu.Correo_Usuario,
    mu.Nombre_Membresia,
    mu.Estado,
    mu.Fecha_Inicio,
    mu.Fecha_Final,
    mu.Saldo_Debe,
    mu.Pagado,
    mu.Duracion_Acumulada,
    mu.Tiempo_Restante,
    u.Clave,
    u.Ced_Miembro,
    u.Ced_Entrenador,
    m.Descripcion,
    m.Valor,
    m.Duracion,
    m.Ced_Entrenador AS MembresiaCedEntrenador,
    e.Cedula AS EntrenadorCedula,
    e.Nombre AS EntrenadorNombre,
    e.Apellido AS EntrenadorApellido,
    e.Telefono AS EntrenadorTelefono,
    e.Sexo AS EntrenadorSexo,
    e.Correo_Electronico AS EntrenadorCorreoElectronico,
    e.Fecha_Nacimiento AS EntrenadorFechaNacimiento,
    e.Foto AS EntrenadorFoto,
    mi.Cedula AS MiembroCedula,
    mi.Nombre AS MiembroNombre,
    mi.Apellido AS MiembroApellido,
    mi.Telefono AS MiembroTelefono,
    mi.Sexo AS MiembroSexo,
    mi.Fecha_Nacimiento AS MiembroFechaNacimiento,
    mi.Correo_Electronico AS MiembroCorreoElectronico,
    mi.Peso AS MiembroPeso,
    mi.Estatura AS MiembroEstatura,
    mi.Foto AS MiembroFoto
FROM Membresias_Usuarios mu
JOIN Usuarios u ON mu.Correo_Usuario = u.Correo_Electronico
JOIN Membresias m ON mu.Nombre_Membresia = m.Nombre
LEFT JOIN Entrenadores e ON m.Ced_Entrenador = e.Cedula
LEFT JOIN Miembros mi ON u.Ced_Miembro = mi.Cedula

SELECT 
    mu.Correo_Usuario,
    mu.Nombre_Membresia,
    mu.Estado,
    mu.Fecha_Inicio,
    mu.Fecha_Final,
    mu.Saldo_Debe,
    mu.Pagado,
    mu.Duracion_Acumulada,
    mu.Tiempo_Restante,
    u.Clave,
    m.Cedula AS MiembroCedula,
    m.Nombre AS MiembroNombre,
    m.Apellido AS MiembroApellido,
    m.Telefono AS MiembroTelefono,
    m.Sexo AS MiembroSexo,
    m.Fecha_Nacimiento AS MiembroFechaNacimiento,
    m.Correo_Electronico AS MiembroCorreoElectronico,
    m.Peso AS MiembroPeso,
    m.Estatura AS MiembroEstatura,
    m.Foto AS MiembroFoto,
    mem.Nombre AS MembresiaNombre,
    mem.Descripcion AS MembresiaDescripcion,
    mem.Valor AS MembresiaValor,
    mem.Duracion AS MembresiaDuracion
FROM Membresias_Usuarios mu
JOIN Usuarios u ON mu.Correo_Usuario = u.Correo_Electronico
JOIN Miembros m ON u.Ced_Miembro = m.Cedula
JOIN Membresias mem ON mu.Nombre_Membresia = mem.Nombre