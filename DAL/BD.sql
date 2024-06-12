-- Lista en ORDEN de creacion
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
CREATE TABLE Usuarios (
    Correo_Electronico VARCHAR(50) PRIMARY KEY NOT NULL,
    Clave VARCHAR(20) NOT NULL,
    Ced_Miembro VARCHAR(20) UNIQUE,
    Ced_Entrenador VARCHAR(20) UNIQUE,
    FOREIGN KEY (Ced_Miembro) REFERENCES Miembros(Cedula),
    FOREIGN KEY (Ced_Entrenador) REFERENCES Entrenadores(Cedula)
);
CREATE TABLE Membresias (
    Nombre VARCHAR(20) PRIMARY KEY NOT NULL,
    Descripcion VARCHAR(255) NOT NULL,
    Valor INT NOT NULL,
    Duracion INT NOT NULL, -- Duración en días
    Ced_Entrenador VARCHAR(50) NULL,
    FOREIGN KEY (Ced_Entrenador) REFERENCES Entrenadores(Cedula) ON DELETE CASCADE
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
    FOREIGN KEY (Nombre_Membresia) REFERENCES Membresias(Nombre) ON DELETE CASCADE
);
CREATE TABLE Productos (
    Referencia VARCHAR(50) PRIMARY KEY NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(255) NOT NULL,
    Valor INT NOT NULL,
    Cantidad_Disponible INT,
    Foto LONGBLOB NULL
);
CREATE TABLE Facturas (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Cedula_Miembro VARCHAR(50),
    Fecha_Factura DATE,
    Precio_Total DOUBLE,
    FOREIGN KEY (Cedula_Miembro) REFERENCES Miembros(Cedula) ON DELETE CASCADE
);
CREATE TABLE Facturas_Productos (
    Id_Factura INT,
    Referencia_Producto VARCHAR(50),
    Cantidad INT,
    Precio_Total DOUBLE,
    PRIMARY KEY (Id_Factura, Referencia_Producto),
    FOREIGN KEY (Id_Factura) REFERENCES Facturas(Id) ON DELETE CASCADE,
    FOREIGN KEY (Referencia_Producto) REFERENCES Productos(Referencia) ON DELETE CASCADE
);
CREATE TABLE Registros (
    Id INT AUTO_INCREMENT PRIMARY KEY,
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
    Foto LONGBLOB
);
CREATE TABLE Ejercicios (
    Nombre VARCHAR(50) PRIMARY  KEY,   
    Descripcion VARCHAR(100) NULL,
    Duracion TIME NULL,
    Repeticiones INT NULL,
    Series INT NULL,
	Musculo VARCHAR (50) NOT NULL,
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
    FOREIGN KEY (Id_Rutina) REFERENCES Rutinas(Id) ON DELETE CASCADE, -- Habilitar eliminación en cascada
    FOREIGN KEY (Ejercicio_Nombre) REFERENCES Ejercicios(Nombre)
);
CREATE TABLE Rutinas_Miembro (
    Id_Rutina INT,
    Miembro_Cedula VARCHAR(50),
    PRIMARY KEY (Id_Rutina, Miembro_Cedula),
    FOREIGN KEY (Id_Rutina) REFERENCES Rutinas(Id) ON DELETE CASCADE, -- Habilitar eliminación en cascada
    FOREIGN KEY (Miembro_Cedula) REFERENCES Miembros(Cedula)
);
CREATE TABLE Historial (
    Cedula_Miembro VARCHAR(50),
    Fecha DATE,
    Registro_Id INT,
    FOREIGN KEY (Cedula_Miembro) REFERENCES Miembros(Cedula) ON DELETE CASCADE,
    FOREIGN KEY (Registro_Id) REFERENCES Registros(Id) ON DELETE CASCADE
);
-- ----------------------------------RUTINAS PREESTABLECIDAD INSERTS
INSERT INTO Rutinas (Nombre, Descripcion, EsPredefinida) VALUES ('Rutina de Iniciación', 'Rutina para principiantes diseñada para desarrollar fuerza y resistencia básica.', TRUE);
INSERT INTO Rutinas (Nombre, Descripcion, EsPredefinida) VALUES ('Rutina de Pérdida de Peso', 'Rutina diseñada para quemar calorías y perder peso mediante ejercicios cardiovasculares y de resistencia.', TRUE);
INSERT INTO Rutinas (Nombre, Descripcion, EsPredefinida) VALUES ('Rutina de Musculación', 'Rutina enfocada en el desarrollo muscular mediante ejercicios de fuerza y hipertrofia.', TRUE);
INSERT INTO Rutinas (Nombre, Descripcion, EsPredefinida) VALUES ('Rutina de Definición', 'Rutina diseñada para tonificar los músculos y eliminar grasa corporal para lograr una apariencia más definida.', TRUE);
INSERT INTO Rutinas (Nombre, Descripcion, EsPredefinida) VALUES ('Rutina de Entrenamiento Funcional', 'Rutina que incorpora movimientos naturales del cuerpo para mejorar la fuerza, la flexibilidad y el equilibrio.', TRUE);
INSERT INTO Rutinas (Nombre, Descripcion, EsPredefinida) VALUES ('Rutina de Yoga', 'Rutina de yoga para mejorar la flexibilidad, reducir el estrés y promover el bienestar general.', TRUE);
INSERT INTO Rutinas (Nombre, Descripcion, EsPredefinida) VALUES ('Rutina de CrossFit', 'Rutina de alta intensidad que combina diferentes modalidades de entrenamiento para mejorar la resistencia y la fuerza.', TRUE);
INSERT INTO Rutinas (Nombre, Descripcion, EsPredefinida) VALUES ('Rutina de Pilates', 'Rutina que se centra en el fortalecimiento del núcleo, la flexibilidad y la alineación corporal.', TRUE);
INSERT INTO Rutinas (Nombre, Descripcion, EsPredefinida) VALUES ('Rutina de Calistenia', 'Rutina que utiliza el peso corporal como resistencia para desarrollar fuerza y ​​flexibilidad.', TRUE);
INSERT INTO Rutinas (Nombre, Descripcion, EsPredefinida) VALUES ('Rutina de Carrera', 'Programa de entrenamiento diseñado para mejorar la resistencia y la velocidad en la carrera.', TRUE);


-- --------------------------------- EJERCICIOS PREESTABLECIDOS
-- Rutina de Iniciación
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Sentadillas', 'Ejercicio para piernas y glúteos', '00:01:00', 15, 3, 'Piernas', 'Fuerza', NULL);
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Flexiones', 'Ejercicio para pecho y tríceps', '00:01:00', 10, 3, 'Pecho', 'Fuerza', NULL);
-- Rutina de Pérdida de Peso
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Burpees', 'Ejercicio cardiovascular completo', '00:01:00', 12, 3, 'Cuerpo entero', 'Cardio', NULL);
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Saltos de Tijera', 'Ejercicio cardiovascular', '00:01:00', 30, 3, 'Piernas', 'Cardio', NULL);
-- Rutina de Musculación
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Press de Banca', 'Ejercicio para pecho', '00:01:00', 8, 4, 'Pecho', 'Fuerza', NULL);
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Remo con Barra', 'Ejercicio para espalda', '00:01:00', 8, 4, 'Espalda', 'Fuerza', NULL);
-- Rutina de Definición
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Abdominales', 'Ejercicio para el abdomen', '00:01:00', 20, 3, 'Abdominales', 'Fuerza', NULL);
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Mountain Climbers', 'Ejercicio cardiovascular para abdomen', '00:01:00', 15, 3, 'Abdominales', 'Cardio', NULL);
-- Rutina de Entrenamiento Funcional
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Kettlebell Swings', 'Ejercicio para fuerza y cardio', '00:01:00', 15, 3, 'Cuerpo entero', 'Funcional', NULL);
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Box Jumps', 'Ejercicio de salto en caja', '00:01:00', 10, 3, 'Piernas', 'Funcional', NULL);
-- Rutina de Yoga
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Saludo al Sol', 'Secuencia de yoga para calentar', '00:05:00', NULL, NULL, 'Cuerpo entero', 'Flexibilidad', NULL);
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Postura del Árbol', 'Postura de equilibrio', '00:01:00', NULL, NULL, 'Piernas', 'Flexibilidad', NULL);
-- Rutina de CrossFit
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Thrusters', 'Ejercicio de levantamiento y empuje', '00:01:00', 10, 3, 'Cuerpo entero', 'Fuerza', NULL);
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Pull-ups', 'Ejercicio de tracción', '00:01:00', 10, 3, 'Espalda', 'Fuerza', NULL);
-- Rutina de Pilates
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Puente de Glúteos', 'Ejercicio para glúteos y core', '00:01:00', 12, 3, 'Glúteos', 'Flexibilidad', NULL);
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Hundred', 'Ejercicio de respiración y core', '00:01:00', 100, 1, 'Core', 'Flexibilidad', NULL);
-- Rutina de Calistenia
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Pull-ups 2', 'Ejercicio de tracción con peso corporal', '00:01:00', 10, 3, 'Espalda', 'Fuerza', NULL);
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Dips', 'Ejercicio para tríceps con peso corporal', '00:01:00', 10, 3, 'Tríceps', 'Fuerza', NULL);
-- Rutina de Carrera
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Sprints', 'Carrera de alta velocidad', '00:01:00', 5, 3, 'Piernas', 'Cardio', NULL);
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Running', 'Carrera a ritmo constante', '00:10:00', 1, 1, 'Piernas', 'Cardio', NULL);
-- Ejercicio para Hombros
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Press Militar', 'Ejercicio para hombros', '00:01:00', 12, 3, 'Hombros', 'Fuerza', NULL);
-- Ejercicio para Bíceps
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Curl de Bíceps', 'Ejercicio para bíceps', '00:01:00', 15, 3, 'Bíceps', 'Fuerza', NULL);
-- Ejercicio para Antebrazos
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Curl de Antebrazos', 'Ejercicio para antebrazos', '00:01:00', 20, 3, 'Antebrazos', 'Fuerza', NULL);
-- Ejercicio para Pantorrillas
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Elevación de Talones', 'Ejercicio para pantorrillas', '00:01:00', 20, 3, 'Pantorrillas', 'Fuerza', NULL);
-- Ejercicio adicional para Glúteos
INSERT INTO Ejercicios (Nombre, Descripcion, Duracion, Repeticiones, Series, Musculo, Categoria, Foto) 
VALUES ('Hip Thrust', 'Ejercicio para glúteos', '00:01:00', 12, 3, 'Glúteos', 'Fuerza', NULL);

-- --------------------------------------------Inserts para la tabla Rutinas_Ejercicios
-- Relaciones para Rutina de Iniciación
INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) VALUES (1, 'Sentadillas');
INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) VALUES (1, 'Flexiones');

-- Relaciones para Rutina de Pérdida de Peso
INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) VALUES (2, 'Burpees');
INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) VALUES (2, 'Saltos de Tijera');

-- Relaciones para Rutina de Musculación
INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) VALUES (3, 'Press de Banca');
INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) VALUES (3, 'Remo con Barra');

-- Relaciones para Rutina de Definición
INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) VALUES (4, 'Abdominales');
INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) VALUES (4, 'Mountain Climbers');

-- Relaciones para Rutina de Entrenamiento Funcional
INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) VALUES (5, 'Kettlebell Swings');
INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) VALUES (5, 'Box Jumps');

-- Relaciones para Rutina de Yoga
INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) VALUES (6, 'Saludo al Sol');
INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) VALUES (6, 'Postura del Árbol');

-- Relaciones para Rutina de CrossFit
INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) VALUES (7, 'Thrusters');
INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) VALUES (7, 'Pull-ups');

-- Relaciones para Rutina de Pilates
INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) VALUES (8, 'Puente de Glúteos');
INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) VALUES (8, 'Hundred');

-- Relaciones para Rutina de Calistenia
INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) VALUES (9, 'Pull-ups');
INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) VALUES (9, 'Dips');

-- Relaciones para Rutina de Carrera
INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) VALUES (10, 'Sprints');
INSERT INTO Rutinas_Ejercicios (Id_Rutina, Ejercicio_Nombre) VALUES (10, 'Running');


-- --------------------------------DROP para todas las tablas
-- Eliminar filas de las tablas secundarias
DELETE FROM Rutinas_Ejercicios;
DELETE FROM Rutinas_Miembro;
DELETE FROM Facturas_Productos;
DELETE FROM Historial;
DELETE FROM Membresias_Usuarios;
DELETE FROM Registros;

-- Eliminar filas de las tablas principales
DELETE FROM Rutinas;
DELETE FROM Facturas;
DELETE FROM Usuarios;
DELETE FROM Productos;
DELETE FROM Membresias;
DELETE FROM Ejercicios;
DELETE FROM Miembros;
DELETE FROM rutinas_ejercicios;
DELETE FROM rutinas_miembro;


DROP TABLE IF EXISTS Usuarios;
DROP TABLE IF EXISTS Productos;
DROP TABLE IF EXISTS Membresias;
DROP TABLE IF EXISTS Membresias_Usuarios;
DROP TABLE IF EXISTS Miembros;
DROP TABLE IF EXISTS Entrenadores;
DROP TABLE IF EXISTS Facturas_Productos;
DROP TABLE IF EXISTS Facturas;
DROP TABLE IF EXISTS Historial;
DROP TABLE IF EXISTS Registros;
DROP TABLE IF EXISTS Ejercicios;
DROP TABLE IF EXISTS Rutinas;
DROP TABLE IF EXISTS Rutinas_Ejercicios;
DROP TABLE IF EXISTS Rutinas_Miembro;

SELECT r.Id AS RutinaId, r.Nombre AS RutinaNombre, r.Descripcion AS RutinaDescripcion,
  re.Ejercicio_Nombre AS EjercicioNombre, e.Descripcion AS EjercicioDescripcion, e.Duracion AS EjercicioDuracion,
  e.Repeticiones AS EjercicioRepeticiones, e.Series AS EjercicioSeries, e.Musculo AS EjercicioMusculo,
  e.Categoria AS EjercicioCategoria, e.Foto AS EjercicioFoto
FROM Rutinas r
INNER JOIN Rutinas_Ejercicios re ON r.Id = re.Id_Rutina
INNER JOIN Ejercicios e ON re.Ejercicio_Nombre = e.Nombre
WHERE r.EsPredefinida = TRUE;
