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
	##FOREIGN KEY (Tipo_Membresia) REFERENCES Membresias(Nombre),
);
CREATE TABLE Entrenadores (
    Cedula VARCHAR(20) PRIMARY KEY,
    Nombre VARCHAR(20) NOT NULL,
    Apellido VARCHAR(20) NOT NULL,
    Telefono VARCHAR(20) NOT NULL,
    Sexo VARCHAR(10) NOT NULL,
    Correo_Electronico VARCHAR(50) UNIQUE NOT NULL,
    Fecha_Nacimiento DATE NOT NULL,
    Tipo_Membresia VARCHAR(20) NULL,
    Foto LONGBLOB NULL
);
CREATE TABLE Categorias_Ejercicio (
    Nombre NVARCHAR(100) PRIMARY KEY,
    Descripcion NVARCHAR(255) NULL
);
CREATE TABLE Ejercicios (
    Nombre NVARCHAR(100) PRIMARY KEY,
    Descripcion NVARCHAR(255) NULL,
    Duracion TIME NULL,
    Repeticiones INT NULL,
    Categoria_Nombre NVARCHAR(100) NOT NULL,
    FOREIGN KEY (Categoria_Nombre) REFERENCES Categorias_Ejercicio(Nombre)
);