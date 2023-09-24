CREATE DATABASE  IF NOT EXISTS `inventario` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `inventario`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: inventario
-- ------------------------------------------------------
-- Server version	5.5.29

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `marcas`
--

DROP TABLE IF EXISTS `marcas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `marcas` (
  `nombre` varchar(40) DEFAULT NULL,
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marcas`
--

LOCK TABLES `marcas` WRITE;
/*!40000 ALTER TABLE `marcas` DISABLE KEYS */;
INSERT INTO `marcas` VALUES ('Hosuya'),('Jayaco'),('JP'),('Kitako'),('LPI'),('Miyazuka'),('Tanaka'),('Urawa');
/*!40000 ALTER TABLE `marcas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `productos` (
  `codigo` int(11) NOT NULL,
  `referencia` varchar(20) DEFAULT NULL,
  `descripcion` varchar(60) DEFAULT NULL,
  `unidad` varchar(30) DEFAULT NULL,
  `marca` varchar(30) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `mgp` double DEFAULT NULL,
  `mgm` double DEFAULT NULL,
  `costo` double DEFAULT NULL,
  `itbis` double DEFAULT NULL,
  `ubicacion` varchar(40) DEFAULT NULL,
  `minimo_existencia` int(11) DEFAULT NULL,
  `fecha` varchar(15) DEFAULT NULL,
  `nota` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1000,'45120-001-00','Banda de freno C70','UD','Osaka',5,38.92,30.77,32,18,'N/E',5,'13/11/13','Uso: 110/CG-125'),(1001,'14521','Valvula escape GB5','UD','Jayaco',39,28.26,18.47,76,18,'T2-B1',5,'22/11/13','-'),(1002,'14511-GN5-00','Valvula adminsion GN5','UD','Jayaco',5,26.37,19.97,78,18,'T2-B1',5,'16/11/13','-'),(1003,'H087741-STD','Anilla 087 STD','Juego','Tanaka',38,40.53,32.42,63,18,'N/E',5,'23/11/13','Uso:  C70 /Econo power'),(1004,'13011-126-00','Anilla GB5 STD CH','Juego','Miyazuka',27,46.51,38.28,34,18,'N/E',5,'8/11/13','Para motor CDI 70/CDI 90'),(1005,'58100-23430','Cable freno AX100','UD','Hosuya',20,34.17,26.42,53,18,'T2-B6',5,'16/11/13','Uso: AX100'),(1006,'53800-098-00','Catalina delantera C70','UD','Tanaka',35,32.35,21.94,23,18,'T2-B6',6,'16/11/13','Uso: C70/CDI70/CDI90'),(1007,'YTX4','Bateria sellada 12v 4h','UD','LPI',13,30.01,24.83,430,18,'T4-B1',5,'16/11/13','Uso: Pasola Jog/CDI70/90'),(1008,'4011A-001-20','Rayos gruesos  traseros C70','Juego','JP',50,36.75,28.13,67.32,18,'T3-B6',10,'20/11/13','Uso: C70/CDI70/CDI90');
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `recursos`
--

DROP TABLE IF EXISTS `recursos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `recursos` (
  `unidad` varchar(30) DEFAULT NULL,
  `marca` varchar(40) DEFAULT NULL,
  `ubicacion` varchar(60) DEFAULT NULL,
  UNIQUE KEY `unidad` (`unidad`),
  UNIQUE KEY `marca` (`marca`),
  UNIQUE KEY `ubicacion` (`ubicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recursos`
--

LOCK TABLES `recursos` WRITE;
/*!40000 ALTER TABLE `recursos` DISABLE KEYS */;
INSERT INTO `recursos` VALUES ('UD','Generica','Renglon 1, Fila 1'),(NULL,'AA',NULL),('Paquete',NULL,NULL);
/*!40000 ALTER TABLE `recursos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ubicaciones`
--

DROP TABLE IF EXISTS `ubicaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ubicaciones` (
  `nombre` varchar(40) DEFAULT NULL,
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ubicaciones`
--

LOCK TABLES `ubicaciones` WRITE;
/*!40000 ALTER TABLE `ubicaciones` DISABLE KEYS */;
INSERT INTO `ubicaciones` VALUES ('T1-B1'),('T2-B6'),('T3-B6'),('T4-B1');
/*!40000 ALTER TABLE `ubicaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unidades`
--

DROP TABLE IF EXISTS `unidades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `unidades` (
  `nombre` varchar(30) DEFAULT NULL,
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unidades`
--

LOCK TABLES `unidades` WRITE;
/*!40000 ALTER TABLE `unidades` DISABLE KEYS */;
INSERT INTO `unidades` VALUES ('Juego'),('N/E'),('UD');
/*!40000 ALTER TABLE `unidades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `password` varchar(15) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `administrador` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1000,'Pedro','1234','809-2903456',1),(1001,'Maria','1234','8092904567',0);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'inventario'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-11-23  0:29:03
