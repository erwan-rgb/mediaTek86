-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3308
-- Généré le : jeu. 05 juin 2025 à 08:47
-- Version du serveur : 9.1.0
-- Version de PHP : 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(1, '2025-06-01 08:00:00', '2025-06-10 18:00:00', 1),
(2, '2025-05-15 09:00:00', '2025-05-20 17:00:00', 2),
(3, '2025-04-10 08:30:00', '2025-04-12 18:30:00', 3),
(4, '2025-03-01 07:45:00', '2025-06-01 19:00:00', 4),
(5, '2025-07-05 08:15:00', '2025-07-15 17:45:00', 1),
(6, '2025-08-20 09:30:00', '2025-08-25 18:00:00', 2),
(7, '2025-09-10 08:00:00', '2025-09-12 18:00:00', 3),
(8, '2025-10-01 07:30:00', '2025-12-01 19:30:00', 4),
(9, '2025-11-05 08:45:00', '2025-11-15 17:15:00', 1),
(10, '2025-12-20 09:00:00', '2025-12-25 18:30:00', 2),
(1, '2025-06-15 08:00:00', '2025-06-20 18:00:00', 3),
(2, '2025-05-25 09:00:00', '2025-05-30 17:00:00', 4),
(3, '2025-04-15 08:30:00', '2025-04-17 18:30:00', 1),
(4, '2025-03-10 07:45:00', '2025-06-10 19:00:00', 2),
(5, '2025-07-10 08:15:00', '2025-07-20 17:45:00', 3),
(6, '2025-08-25 09:30:00', '2025-08-30 18:00:00', 4),
(7, '2025-09-15 08:00:00', '2025-09-17 18:00:00', 1),
(8, '2025-10-05 07:30:00', '2025-12-05 19:30:00', 2),
(9, '2025-11-10 08:45:00', '2025-11-20 17:15:00', 3),
(10, '2025-12-25 09:00:00', '2025-12-30 18:30:00', 4),
(1, '2025-06-21 08:00:00', '2025-06-25 18:00:00', 1),
(2, '2025-05-31 09:00:00', '2025-06-05 17:00:00', 2),
(3, '2025-04-18 08:30:00', '2025-04-20 18:30:00', 3),
(4, '2025-03-15 07:45:00', '2025-06-15 19:00:00', 4),
(5, '2025-07-21 08:15:00', '2025-07-25 17:45:00', 1),
(6, '2025-08-31 09:30:00', '2025-09-05 18:00:00', 2),
(7, '2025-09-18 08:00:00', '2025-09-20 18:00:00', 3),
(8, '2025-10-10 07:30:00', '2025-12-10 19:30:00', 4),
(9, '2025-11-21 08:45:00', '2025-11-25 17:15:00', 1),
(10, '2025-12-31 09:00:00', '2026-01-05 18:30:00', 2),
(1, '2025-06-26 08:00:00', '2025-06-30 18:00:00', 3),
(2, '2025-06-06 09:00:00', '2025-06-10 17:00:00', 4),
(3, '2025-04-21 08:30:00', '2025-04-23 18:30:00', 1),
(4, '2025-03-20 07:45:00', '2025-06-20 19:00:00', 2),
(5, '2025-07-26 08:15:00', '2025-07-30 17:45:00', 3),
(6, '2025-09-06 09:30:00', '2025-09-10 18:00:00', 4),
(7, '2025-09-21 08:00:00', '2025-09-23 18:00:00', 1),
(8, '2025-10-15 07:30:00', '2025-12-15 19:30:00', 2),
(9, '2025-11-26 08:45:00', '2025-11-30 17:15:00', 3),
(10, '2026-01-06 09:00:00', '2026-01-10 18:30:00', 4);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Dupont', 'Jean', '0612345678', 'jean.dupont@email.com', 1),
(2, 'Martin', 'Sophie', '0623456789', 'sophie.martin@email.com', 2),
(3, 'Leroy', 'Paul', '0634567890', 'paul.leroy@email.com', 3),
(4, 'Bernard', 'Claire', '0645678901', 'claire.bernard@email.com', 1),
(5, 'Rousseau', 'Thomas', '0656789012', 'thomas.rousseau@email.com', 2),
(6, 'Morel', 'Julie', '0667890123', 'julie.morel@email.com', 3),
(7, 'Fournier', 'Nicolas', '0678901234', 'nicolas.fournier@email.com', 1),
(8, 'Girard', 'Emma', '0689012345', 'emma.girard@email.com', 2),
(9, 'Blanc', 'Lucas', '0690123456', 'lucas.blanc@email.com', 3),
(10, 'Gauthier', 'Alice', '0701234567', 'alice.gauthier@email.com', 1);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `pwd` varchar(64) COLLATE utf8mb3_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('mediaTek86', '3e296ab5e8a9c95df44c8839a3c42e3fb4614f25eedcdd5211b621b8b9f9f198');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
