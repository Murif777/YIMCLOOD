CREATE TABLE Usuarios (
    Correo_Electronico VARCHAR(50) PRIMARY KEY NOT NULL,
    Clave VARCHAR(20) NOT NULL,
    Ced_Miembro VARCHAR(20)UNIQUE,
    Ced_Entrenador VARCHAR(20)UNIQUE,
    FOREIGN KEY (Ced_Miembro) REFERENCES Miembros(Cedula),
    FOREIGN KEY (Ced_Entrenador) REFERENCES entrenadores(Cedula)
);

CREATE TABLE Productos (
    Referencia VARCHAR(50) PRIMARY KEY NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(255) NOT NULL,
    Valor INT NOT NULL,
    Cantidad_Disponible INT,
    Foto LONGBLOB NULL
);	

CREATE TABLE Membresias	 (
    Nombre VARCHAR(20) PRIMARY KEY NOT NULL,
    Descripcion VARCHAR(255) NOT NULL,
    Valor INT NOT NULL,
    Duracion INT NOT NULL, -- Duración en días
    Ced_Entrenador VARCHAR(50) NULL,
    FOREIGN KEY (Ced_Entrenador) REFERENCES Entrenadores(Cedula)
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
CREATE TABLE Facturas_Productos (
    Id_Factura INT,
    Referencia_Producto VARCHAR(50),
    Cantidad INT,
    Precio_Total double,
    PRIMARY KEY (Id_Factura, Referencia_Producto),
    FOREIGN KEY (Id_Factura) REFERENCES Facturas(Id),
    FOREIGN KEY (Referencia_Producto) REFERENCES Productos(Referencia)
);
CREATE TABLE Facturas (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Cedula_Miembro VARCHAR(50),
    Fecha_Factura DATE,
	Precio_Total double,
    FOREIGN KEY (Cedula_Miembro) REFERENCES Miembros(cedula)
);	

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
CREATE TABLE Categorias_Ejercicio (
    Nombre NVARCHAR(100) PRIMARY KEY
);

CREATE TABLE Musculo_Ejercicio (
    Nombre NVARCHAR(100) PRIMARY KEY
);

CREATE TABLE Ejercicios (
    Nombre VARCHAR(20) PRIMARY  KEY,   
    Descripcion VARCHAR(20) NULL,
    Duracion TIME NULL,
    Repeticiones INT NULL,
    Series INT NULL,
	Musculo VARCHAR (20) NOT NULL,
    Categoria VARCHAR(100) NOT NULL,
    Foto LONGBLOB
);
CREATE TABLE Rutinas (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(255) NOT NULL,
    EsPredefinida BOOLEAN NOT NULL DEFAULT FALSE
);
CREATE TABLE Rutinas_Ejercicios (
    Id_Rutina INT,
    Ejercicio_Nombre VARCHAR(50),
    PRIMARY KEY (Id_Rutina, Ejercicio_Nombre),
    FOREIGN KEY (Id_Rutina) REFERENCES Rutinas(Id),
    FOREIGN KEY (Ejercicio_Nombre) REFERENCES Ejercicios(Nombre)
);
CREATE TABLE Rutinas_Miembro (
    Id_Rutina INT,
    Miembro_Cedula VARCHAR(50),
    PRIMARY KEY (Id_Rutina, Miembro_Cedula),
    FOREIGN KEY (Id_Rutina) REFERENCES Rutinas(Id),
    FOREIGN KEY (Miembro_Cedula) REFERENCES Miembros(cedula)
);

SELECT 
    r.Id AS RutinaId, 
    r.Nombre AS RutinaNombre, 
    r.Descripcion AS RutinaDescripcion, 
    re.Ejercicio_Nombre AS EjercicioNombre, 
    e.Descripcion AS EjercicioDescripcion, 
    e.Duracion AS EjercicioDuracion, 
    e.Repeticiones AS EjercicioRepeticiones, 
    e.Series AS EjercicioSeries, 
    e.Musculo AS EjercicioMusculo, 
    e.Categoria AS EjercicioCategoria, 
    e.Foto AS EjercicioFoto 
FROM 
    Rutinas r 
INNER JOIN 
    Rutinas_Ejercicios re ON r.Id = re.Rutina_Id 
INNER JOIN 
    Ejercicios e ON re.Ejercicio_Nombre = e.Nombre;


