-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.4.6-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             10.1.0.5464
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Volcando estructura para tabla mydb.apuestas
CREATE TABLE IF NOT EXISTS `apuestas` (
  `idApuestas` int(11) NOT NULL,
  `Dinero_apostado` int(11) DEFAULT NULL,
  `Cuota` int(11) DEFAULT NULL,
  `Mercado_apuesta` int(11) DEFAULT NULL,
  `Tipo_apuesta` int(11) DEFAULT NULL,
  `idMercado` int(11) NOT NULL,
  `Dni` char(9) NOT NULL,
  PRIMARY KEY (`idApuestas`),
  KEY `mercado` (`idMercado`),
  KEY `hace` (`Dni`),
  CONSTRAINT `hace` FOREIGN KEY (`Dni`) REFERENCES `usuario` (`Dni`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `mercado` FOREIGN KEY (`idMercado`) REFERENCES `mercado` (`idMercado`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla mydb.apuestas: ~0 rows (aproximadamente)
DELETE FROM `apuestas`;
/*!40000 ALTER TABLE `apuestas` DISABLE KEYS */;
/*!40000 ALTER TABLE `apuestas` ENABLE KEYS */;

-- Volcando estructura para tabla mydb.cuenta
CREATE TABLE IF NOT EXISTS `cuenta` (
  `Dni` char(9) NOT NULL,
  `Saldo_actual` int(11) DEFAULT NULL,
  `Nombre_banco` varchar(45) DEFAULT NULL,
  `Num_tarjeta_vinculada` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Dni`),
  CONSTRAINT `tiene` FOREIGN KEY (`Dni`) REFERENCES `usuario` (`Dni`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla mydb.cuenta: ~0 rows (aproximadamente)
DELETE FROM `cuenta`;
/*!40000 ALTER TABLE `cuenta` DISABLE KEYS */;
/*!40000 ALTER TABLE `cuenta` ENABLE KEYS */;

-- Volcando estructura para tabla mydb.mercado
CREATE TABLE IF NOT EXISTS `mercado` (
  `idMercado` int(11) NOT NULL,
  `Cuota_over` varchar(45) DEFAULT NULL,
  `Cuota_under` varchar(45) DEFAULT NULL,
  `Dinero_over` varchar(45) DEFAULT NULL,
  `Dinero_under` varchar(45) DEFAULT NULL,
  `idPartido` int(11) NOT NULL,
  PRIMARY KEY (`idMercado`,`idPartido`),
  CONSTRAINT `organiza` FOREIGN KEY (`idMercado`) REFERENCES `partido` (`idPartido`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla mydb.mercado: ~0 rows (aproximadamente)
DELETE FROM `mercado`;
/*!40000 ALTER TABLE `mercado` DISABLE KEYS */;
/*!40000 ALTER TABLE `mercado` ENABLE KEYS */;

-- Volcando estructura para tabla mydb.partido
CREATE TABLE IF NOT EXISTS `partido` (
  `idPartido` int(11) NOT NULL,
  `Equipo_Local` varchar(45) DEFAULT NULL,
  `Equipo_visitante` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idPartido`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla mydb.partmydbido: ~0 rows (aproximadamente)
DELETE FROM `partido`;
/*!40000 ALTER TABLE `partido` DISABLE KEYS */;
/*!40000 ALTER TABLE `partido` ENABLE KEYS */;

-- Volcando estructura para tabla mydb.usuario
CREATE TABLE IF NOT EXISTS `usuario` (
  `Email` int(11) DEFAULT NULL,
  `Dni` char(9) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Apellido` varchar(45) DEFAULT NULL,
  `Edad` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Dni`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla mydb.usuario: ~0 rows (aproximadamente)
DELETE FROM `usuario`;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
