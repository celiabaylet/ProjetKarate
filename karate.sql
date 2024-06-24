-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 24 jan. 2024 à 08:11
-- Version du serveur : 8.2.0
-- Version de PHP : 8.2.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `karate`
--

-- --------------------------------------------------------

--
-- Structure de la table `club`
--

DROP TABLE IF EXISTS `club`;
CREATE TABLE IF NOT EXISTS `club` (
  `NUM_CLUB` int NOT NULL,
  `NOM_CLUB` varchar(50) NOT NULL,
  `ADR_RUE_CLUB` varchar(50) NOT NULL,
  `CODE_POST_CLUB` varchar(50) NOT NULL,
  `ADR_VILLE_CLUB` varchar(50) NOT NULL,
  PRIMARY KEY (`NUM_CLUB`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `competition`
--

DROP TABLE IF EXISTS `competition`;
CREATE TABLE IF NOT EXISTS `competition` (
  `NUM_COMPETITION` int NOT NULL,
  `NUM_CLUB` int NOT NULL,
  `DATE_COMPETITION` date NOT NULL,
  PRIMARY KEY (`NUM_COMPETITION`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `entraineur`
--

DROP TABLE IF EXISTS `entraineur`;
CREATE TABLE IF NOT EXISTS `entraineur` (
  `NUM_ENTRAINEUR` int NOT NULL,
  `NUM_CLUB` int NOT NULL,
  `NOM_ENTRAINEUR` varchar(50) NOT NULL,
  `PRENOM_ENTRAINEUR` varchar(50) NOT NULL,
  PRIMARY KEY (`NUM_ENTRAINEUR`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `inscription`
--

DROP TABLE IF EXISTS `inscription`;
CREATE TABLE IF NOT EXISTS `inscription` (
  `NUM_COMPETITION` int NOT NULL,
  `NUM_LICENCE` varchar(50) NOT NULL,
  `NOTE_GLOBALE` decimal(4,2) NOT NULL,
  PRIMARY KEY (`NUM_COMPETITION`,`NUM_LICENCE`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `juge`
--

DROP TABLE IF EXISTS `juge`;
CREATE TABLE IF NOT EXISTS `juge` (
  `NUM_COMPETITION` int NOT NULL,
  `NUM_ENTRAINEUR` int NOT NULL,
  `NUM_JURY` int NOT NULL,
  PRIMARY KEY (`NUM_COMPETITION`,`NUM_ENTRAINEUR`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `membre`
--

DROP TABLE IF EXISTS `membre`;
CREATE TABLE IF NOT EXISTS `membre` (
  `NUM_LICENCE` varchar(50) NOT NULL,
  `NUM_CLUB` int NOT NULL,
  `NOM_MEMBRE` varchar(50) NOT NULL,
  `PRENOM_MEMBRE` varchar(50) NOT NULL,
  `DATE_NAISSANCE` date NOT NULL,
  `ADR_RUE_MEMBRE` varchar(50) NOT NULL,
  `CODE_POST_MEMBRE` varchar(5) NOT NULL,
  `ADR_VILLE_MEMBRE` varchar(50) NOT NULL,
  PRIMARY KEY (`NUM_LICENCE`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `note`
--

DROP TABLE IF EXISTS `note`;
CREATE TABLE IF NOT EXISTS `note` (
  `NUM_COMPETITION` int NOT NULL,
  `NUM_LICENCE` varchar(50) NOT NULL,
  `NUM_ENTRAINEUR` int NOT NULL,
  `NOTE` decimal(4,2) NOT NULL,
  PRIMARY KEY (`NUM_COMPETITION`,`NUM_LICENCE`,`NUM_ENTRAINEUR`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
