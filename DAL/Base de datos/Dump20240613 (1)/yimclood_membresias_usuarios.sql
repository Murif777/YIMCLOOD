-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: yimclood
-- ------------------------------------------------------
-- Server version	8.0.37

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `membresias_usuarios`
--

DROP TABLE IF EXISTS `membresias_usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `membresias_usuarios` (
  `Correo_Usuario` varchar(50) NOT NULL,
  `Nombre_Membresia` varchar(20) NOT NULL,
  `Estado` varchar(20) NOT NULL,
  `Fecha_Inicio` date NOT NULL,
  `Fecha_Final` date NOT NULL,
  `Saldo_Debe` int NOT NULL,
  `Pagado` tinyint(1) NOT NULL,
  `Duracion_Acumulada` int NOT NULL,
  `Tiempo_Restante` int NOT NULL,
  PRIMARY KEY (`Correo_Usuario`),
  KEY `Nombre_Membresia` (`Nombre_Membresia`),
  CONSTRAINT `membresias_usuarios_ibfk_1` FOREIGN KEY (`Correo_Usuario`) REFERENCES `usuarios` (`Correo_Electronico`),
  CONSTRAINT `membresias_usuarios_ibfk_2` FOREIGN KEY (`Nombre_Membresia`) REFERENCES `membresias` (`Nombre`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `membresias_usuarios`
--

LOCK TABLES `membresias_usuarios` WRITE;
/*!40000 ALTER TABLE `membresias_usuarios` DISABLE KEYS */;
INSERT INTO `membresias_usuarios` VALUES ('fa@gmail.com','NORMAL','Activo','2024-06-13','2024-07-13',0,1,0,30),('farid@prueba.com','NORMAL','Activo','2024-06-13','2024-07-13',0,1,0,29),('faridmuriel777@gmail.com','NORMAL','Activo','2024-06-12','2024-07-12',0,1,0,28),('miembro@gmail.com','NORMAL','Activo','2024-06-13','2024-07-13',0,1,0,30),('prueba@gmail.com','NORMAL','Activo','2024-06-13','2024-07-13',0,1,0,29),('pruebasp@gmail.com','NORMAL','Activo','2024-06-13','2024-07-13',0,1,0,30),('qeq@gmail.com','NORMAL','Activo','2024-06-13','2024-07-13',0,1,0,30);
/*!40000 ALTER TABLE `membresias_usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-06-13 17:43:59
