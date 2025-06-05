-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : dim. 01 juin 2025 à 15:06
-- Version du serveur : 5.7.40
-- Version de PHP : 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : mediatec
--

-- --------------------------------------------------------

--
-- Structure de la table absence
--

DROP TABLE IF EXISTS absence;
CREATE TABLE IF NOT EXISTS absence (
  idpersonnel int(11) NOT NULL,
  datedebut datetime NOT NULL,
  datefin datetime DEFAULT NULL,
  idmotif int(11) NOT NULL,
  PRIMARY KEY (idpersonnel,datedebut),
  KEY idmotif (idmotif)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table absence
--

INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES
(1, '2025-01-22 00:00:00', '2025-01-24 00:00:00', 1),
(1, '2025-02-14 00:00:00', '2025-02-17 00:00:00', 2),
(1, '2025-03-04 00:00:00', '2025-03-06 00:00:00', 3),
(1, '2025-04-06 00:00:00', '2025-04-09 00:00:00', 4),
(1, '2025-04-12 00:00:00', '2025-04-14 00:00:00', 4),
(2, '2025-01-12 00:00:00', '2025-01-16 00:00:00', 1),
(2, '2025-03-01 00:00:00', '2025-03-04 00:00:00', 3),
(2, '2025-03-12 00:00:00', '2025-03-14 00:00:00', 3),
(2, '2025-03-18 00:00:00', '2025-03-21 00:00:00', 3),
(2, '2025-04-02 00:00:00', '2025-04-06 00:00:00', 4),
(3, '2025-01-10 00:00:00', '2025-01-15 00:00:00', 1),
(3, '2025-01-19 00:00:00', '2025-01-21 00:00:00', 1),
(3, '2025-01-27 00:00:00', '2025-01-30 00:00:00', 1),
(3, '2025-02-10 00:00:00', '2025-02-12 00:00:00', 2),
(3, '2025-03-09 00:00:00', '2025-03-12 00:00:00', 3),
(4, '2025-02-17 00:00:00', '2025-02-21 00:00:00', 2),
(4, '2025-02-28 00:00:00', '2025-03-03 00:00:00', 2),
(4, '2025-04-05 00:00:00', '2025-04-08 00:00:00', 4),
(4, '2025-04-08 00:00:00', '2025-04-10 00:00:00', 4),
(4, '2025-05-30 00:00:00', '2025-05-31 00:00:00', 3),
(5, '2025-01-09 00:00:00', '2025-01-10 00:00:00', 1),
(5, '2025-01-19 00:00:00', '2025-01-22 00:00:00', 1),
(5, '2025-02-02 00:00:00', '2025-02-06 00:00:00', 2),
(5, '2025-04-12 00:00:00', '2025-04-14 00:00:00', 3),
(5, '2025-04-13 00:00:00', '2025-04-15 00:00:00', 4),
(6, '2025-01-06 00:00:00', '2025-01-08 00:00:00', 1),
(6, '2025-02-09 00:00:00', '2025-02-13 00:00:00', 2),
(6, '2025-02-12 00:00:00', '2025-02-16 00:00:00', 2),
(6, '2025-04-01 00:00:00', '2025-04-07 00:00:00', 4),
(6, '2025-04-04 00:00:00', '2025-04-06 00:00:00', 4),
(7, '2025-01-20 00:00:00', '2025-01-23 00:00:00', 1),
(7, '2025-01-31 00:00:00', '2025-02-03 00:00:00', 1),
(7, '2025-02-05 00:00:00', '2025-02-08 00:00:00', 2),
(7, '2025-03-20 00:00:00', '2025-03-23 00:00:00', 3),
(7, '2025-03-22 00:00:00', '2025-03-25 00:00:00', 3),
(8, '2025-02-22 00:00:00', '2025-02-25 00:00:00', 2),
(8, '2025-03-01 00:00:00', '2025-03-05 00:00:00', 3),
(8, '2025-03-05 00:00:00', '2025-03-08 00:00:00', 3),
(8, '2025-03-07 00:00:00', '2025-03-09 00:00:00', 3),
(8, '2025-03-14 00:00:00', '2025-03-18 00:00:00', 3),
(9, '2025-01-11 00:00:00', '2025-01-14 00:00:00', 1),
(9, '2025-01-29 00:00:00', '2025-02-02 00:00:00', 1),
(9, '2025-02-25 00:00:00', '2025-03-01 00:00:00', 2),
(9, '2025-03-27 00:00:00', '2025-03-30 00:00:00', 3),
(9, '2025-04-17 00:00:00', '2025-04-21 00:00:00', 4),
(10, '2025-01-15 00:00:00', '2025-01-19 00:00:00', 3),
(10, '2025-02-04 00:00:00', '2025-02-06 00:00:00', 2),
(10, '2025-02-07 00:00:00', '2025-02-10 00:00:00', 2),
(10, '2025-04-10 00:00:00', '2025-04-15 00:00:00', 4),
(10, '2025-04-14 00:00:00', '2025-04-18 00:00:00', 4),
(10, '2025-05-31 00:00:00', '2025-05-31 00:00:00', 1),
(13, '2025-05-06 00:00:00', '2025-05-07 00:00:00', 1);

-- --------------------------------------------------------

--
-- Structure de la table motif
--

DROP TABLE IF EXISTS motif;
CREATE TABLE IF NOT EXISTS motif (
  idmotif int(11) NOT NULL AUTO_INCREMENT,
  libelle varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (idmotif)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table motif
--

INSERT INTO motif (idmotif, libelle) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table personnel
--

DROP TABLE IF EXISTS personnel;
CREATE TABLE IF NOT EXISTS personnel (
  idpersonnel int(11) NOT NULL AUTO_INCREMENT,
  nom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  prenom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  tel varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  mail varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  idservice int(11) NOT NULL,
  PRIMARY KEY (idpersonnel),
  KEY idservice (idservice)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table personnel
--

INSERT INTO personnel (idpersonnel, nom, prenom, tel, mail, idservice) VALUES
(1, 'Shay', 'Cline', '1-802-133-6663', 'quisque.ornare@aol.couk', 1),
(2, 'Sharon ', 'Bradshaw', '(373) 545-0677', 'aliquam.tincidunt@google.com', 2),
(3, 'Reuben', 'Lopez', '(397) 548-4112', 'diam@icloud.com', 3),
(4, 'Aimee', 'Crosby', '(648) 603-5531', 'dolor.quisque.tincidunt@outlook.org', 0),
(5, 'Charlotte', 'Lawson', '1-162-368-3433', 'odio.nam@hotmail.couk', 1),
(6, 'Reece', ' Whitley', '(398) 285-2173', 'libero@icloud.org', 3),
(7, 'Audrey', ' Kemp', '(428) 721-9278', 'nam.interdum@yahoo.ca', 0),
(8, 'Duncan', ' Mcintosh', '1-409-157-6366', 'tristique.pharetra.quisque@yahoo.couk', 2),
(9, 'Fay', ' Whitley', '1-392-398-5953', 'volutpat@yahoo.edu', 3),
(10, 'Dante', ' Massey', '1-516-377-6212', 'fermentum.risus@aol.com', 3),
(13, 'sahar', 'jan', '1100220033', 'jan@mail.com', 2);

-- --------------------------------------------------------

--
-- Structure de la table responsable
--

DROP TABLE IF EXISTS responsable;
CREATE TABLE IF NOT EXISTS responsable (
  login varchar(64) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  pwd varchar(64) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table responsable
--

INSERT INTO responsable (login, pwd) VALUES
('admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918');

-- --------------------------------------------------------

--
-- Structure de la table service
--

DROP TABLE IF EXISTS service;
CREATE TABLE IF NOT EXISTS service (
  idservice int(11) NOT NULL AUTO_INCREMENT,
  nom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (idservice)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table service
--

INSERT INTO service (idservice, nom) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
