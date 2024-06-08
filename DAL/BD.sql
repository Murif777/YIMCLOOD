CREATE TABLE Usuarios (
    Correo_Electronico VARCHAR(50) PRIMARY KEY NOT NULL,
    Clave VARCHAR(20) NOT NULL,
    Ced_Miembro VARCHAR(20)UNIQUE,
	FOREIGN KEY (Ced_Miembro) REFERENCES Miembros(Cedula)
);
CREATE TABLE Productos (
    Referencia VARCHAR(50) PRIMARY KEY NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(255) NOT NULL,
    Valor INT NOT NULL,
    Cantidad INT,
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
    Tipo_Membresia VARCHAR(20),
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

CREATE TABLE Facturas_Membresias(
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Fecha_Factura DATE,
    Correo_Usuario VARCHAR(50),
    FOREIGN KEY (Correo_Usuario) REFERENCES membresias_usuarios(Correo_Usuario)
);

CREATE TABLE Factura (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Cedula_Miembro VARCHAR(50),
    Fecha_Factura DATE,
    FOREIGN KEY (Cedula_Miembro) REFERENCES Miembros(cedula)
);

CREATE TABLE Facturas_Productos (
    Id_Factura INT,
    Referencia_Producto VARCHAR(50),
    Cantidad INT,
    PRIMARY KEY (Id_Factura, Referencia_Producto),
    FOREIGN KEY (Id_Factura) REFERENCES Factura(Id),
    FOREIGN KEY (Referencia_Producto) REFERENCES Productos(Referencia)
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
	Musculo NVARCHAR (100) NOT NULL,
    Nombre NVARCHAR(100) PRIMARY KEY,   
    Descripcion NVARCHAR(255) NULL,
    Duracion TIME NULL,
    Repeticiones INT NULL,
    Series INT NULL,
    Categoria_Nombre NVARCHAR(100) NOT NULL,
	CONSTRAINT fk_categoria FOREIGN KEY (Categoria_Nombre) REFERENCES Categorias_Ejercicio(Nombre),
    CONSTRAINT fk_musculo FOREIGN KEY (Musculo) REFERENCES Musculo_Ejercicio(Nombre)
);