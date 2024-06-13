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
-- Table structure for table `rutinas`
--

DROP TABLE IF EXISTS `rutinas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rutinas` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Descripcion` varchar(255) NOT NULL,
  `EsPredefinida` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rutinas`
--

LOCK TABLES `rutinas` WRITE;
/*!40000 ALTER TABLE `rutinas` DISABLE KEYS */;
INSERT INTO `rutinas` VALUES (1,'Rutina de Iniciación','Rutina para principiantes diseñada para desarrollar fuerza y resistencia básica.',1),(2,'Rutina de Pérdida de Peso','Rutina diseñada para quemar calorías y perder peso mediante ejercicios cardiovasculares y de resistencia.',1),(3,'Rutina de Musculación','Rutina enfocada en el desarrollo muscular mediante ejercicios de fuerza y hipertrofia.',1),(4,'Rutina de Definición','Rutina diseñada para tonificar los músculos y eliminar grasa corporal para lograr una apariencia más definida.',1),(5,'Rutina de Entrenamiento Funcional','Rutina que incorpora movimientos naturales del cuerpo para mejorar la fuerza, la flexibilidad y el equilibrio.',1),(6,'Rutina de Yoga','Rutina de yoga para mejorar la flexibilidad, reducir el estrés y promover el bienestar general.',1),(7,'Rutina de CrossFit','Rutina de alta intensidad que combina diferentes modalidades de entrenamiento para mejorar la resistencia y la fuerza.',1),(8,'Rutina de Pilates','Rutina que se centra en el fortalecimiento del núcleo, la flexibilidad y la alineación corporal.',1),(9,'Rutina de Calistenia','Rutina que utiliza el peso corporal como resistencia para desarrollar fuerza y ​​flexibilidad.',1),(10,'Rutina de Carrera','Programa de entrenamiento diseñado para mejorar la resistencia y la velocidad en la carrera.',1);
/*!40000 ALTER TABLE `rutinas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-06-13 17:43:58
