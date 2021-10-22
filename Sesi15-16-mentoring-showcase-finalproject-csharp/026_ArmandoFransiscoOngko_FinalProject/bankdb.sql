/*
SQLyog Community v13.1.7 (64 bit)
MySQL - 10.4.21-MariaDB : Database - bankdb
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`bankdb` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `bankdb`;

/*Table structure for table `__efmigrationshistory` */

DROP TABLE IF EXISTS `__efmigrationshistory`;

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `__efmigrationshistory` */

insert  into `__efmigrationshistory`(`MigrationId`,`ProductVersion`) values 
('20211021081837_Addig authentication to our Api','5.0.11'),
('20211021092056_Added refresh tokens table','5.0.11');

/*Table structure for table `aspnetroleclaims` */

DROP TABLE IF EXISTS `aspnetroleclaims`;

CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RoleId` varchar(85) NOT NULL,
  `ClaimType` text DEFAULT NULL,
  `ClaimValue` text DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `aspnetroleclaims` */

/*Table structure for table `aspnetroles` */

DROP TABLE IF EXISTS `aspnetroles`;

CREATE TABLE `aspnetroles` (
  `Id` varchar(85) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(85) DEFAULT NULL,
  `ConcurrencyStamp` text DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `RoleNameIndex` (`NormalizedName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `aspnetroles` */

/*Table structure for table `aspnetuserclaims` */

DROP TABLE IF EXISTS `aspnetuserclaims`;

CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` varchar(85) NOT NULL,
  `ClaimType` text DEFAULT NULL,
  `ClaimValue` text DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetUserClaims_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `aspnetuserclaims` */

/*Table structure for table `aspnetuserlogins` */

DROP TABLE IF EXISTS `aspnetuserlogins`;

CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(85) NOT NULL,
  `ProviderKey` varchar(85) NOT NULL,
  `ProviderDisplayName` text DEFAULT NULL,
  `UserId` varchar(85) NOT NULL,
  PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  KEY `IX_AspNetUserLogins_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `aspnetuserlogins` */

/*Table structure for table `aspnetuserroles` */

DROP TABLE IF EXISTS `aspnetuserroles`;

CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(85) NOT NULL,
  `RoleId` varchar(85) NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`),
  KEY `IX_AspNetUserRoles_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `aspnetuserroles` */

/*Table structure for table `aspnetusers` */

DROP TABLE IF EXISTS `aspnetusers`;

CREATE TABLE `aspnetusers` (
  `Id` varchar(85) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(85) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(85) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` text DEFAULT NULL,
  `SecurityStamp` text DEFAULT NULL,
  `ConcurrencyStamp` text DEFAULT NULL,
  `PhoneNumber` text DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` timestamp NULL DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  KEY `EmailIndex` (`NormalizedEmail`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `aspnetusers` */

insert  into `aspnetusers`(`Id`,`UserName`,`NormalizedUserName`,`Email`,`NormalizedEmail`,`EmailConfirmed`,`PasswordHash`,`SecurityStamp`,`ConcurrencyStamp`,`PhoneNumber`,`PhoneNumberConfirmed`,`TwoFactorEnabled`,`LockoutEnd`,`LockoutEnabled`,`AccessFailedCount`) values 
('58e9c5c7-7eb1-47f8-a56e-fa37925b26e2','armando','ARMANDO','armando@example.com','ARMANDO@EXAMPLE.COM',0,'AQAAAAEAACcQAAAAED+5KjMe6mi8LB3lis+46IyfiqITXc07ljvnIv2YYZn9ewHvE0h70SmqoH9DOP47gA==','TIBKKD7G4CPBGNW5W3ZMWGJJBDCVSZTH','80b47280-6386-437f-b3fc-079f44d6ae91',NULL,0,0,NULL,1,0),
('66e63c8b-94bd-4eb6-8478-4324e746ec61','yew','YEW','yew@example.com','YEW@EXAMPLE.COM',0,'AQAAAAEAACcQAAAAEOFWHfH79IpoEFHRsbwGU33O61F++eC2f/MTVRiu4WiakdAN6QtFpw+uQvxvzDWsUg==','XIUVWVJZFONVLI6YZ2QCO67WNVMMIMFT','433e54b1-6313-44ce-b8b1-e6a0cc838df0',NULL,0,0,NULL,1,0);

/*Table structure for table `aspnetusertokens` */

DROP TABLE IF EXISTS `aspnetusertokens`;

CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(85) NOT NULL,
  `LoginProvider` varchar(85) NOT NULL,
  `Name` varchar(85) NOT NULL,
  `Value` text DEFAULT NULL,
  PRIMARY KEY (`UserId`,`LoginProvider`,`Name`),
  CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `aspnetusertokens` */

/*Table structure for table `payments` */

DROP TABLE IF EXISTS `payments`;

CREATE TABLE `payments` (
  `PaymentDetailId` int(11) NOT NULL AUTO_INCREMENT,
  `CardOwnerName` text DEFAULT NULL,
  `CardNumber` text DEFAULT NULL,
  `ExpirationDate` text DEFAULT NULL,
  `SecurityCode` text DEFAULT NULL,
  PRIMARY KEY (`PaymentDetailId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `payments` */

insert  into `payments`(`PaymentDetailId`,`CardOwnerName`,`CardNumber`,`ExpirationDate`,`SecurityCode`) values 
(1,'Armando Frans','1234567890','2025-12-31','12345');

/*Table structure for table `refreshtokens` */

DROP TABLE IF EXISTS `refreshtokens`;

CREATE TABLE `refreshtokens` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` varchar(85) DEFAULT NULL,
  `Token` text DEFAULT NULL,
  `JwtId` text DEFAULT NULL,
  `IsUsed` tinyint(1) NOT NULL,
  `IsRevorked` tinyint(1) NOT NULL,
  `AddedDate` datetime NOT NULL,
  `ExpiryDate` datetime NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_RefreshTokens_UserId` (`UserId`),
  CONSTRAINT `FK_RefreshTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

/*Data for the table `refreshtokens` */

insert  into `refreshtokens`(`Id`,`UserId`,`Token`,`JwtId`,`IsUsed`,`IsRevorked`,`AddedDate`,`ExpiryDate`) values 
(1,'58e9c5c7-7eb1-47f8-a56e-fa37925b26e2','XWC5NVUSTF0D1018PZQ1KDX7Q7PNG1K66OMf77e7c0b-a5a2-4704-ae5f-efc5a8495786','64fe261c-baed-4932-99c5-8e47162da156',0,0,'2021-10-21 10:04:30','2022-04-21 10:04:30'),
(2,'58e9c5c7-7eb1-47f8-a56e-fa37925b26e2','55BRNLCV67UHYQ07TUO345XA63MNSLT7MJN742c8268-f4a1-4ccb-9da2-cd791c23be79','44d46b7c-ebf8-4a0e-aed2-832aa4e7d5c5',0,0,'2021-10-21 10:06:13','2022-04-21 10:06:13'),
(3,'58e9c5c7-7eb1-47f8-a56e-fa37925b26e2','P8C0TDLSVRI6VWY1TBSPXBMAGAC6728CZDJ6ae1ee4e-9cdf-4971-9143-26fd92331ddb','0ba19a48-4742-4447-8dab-96224d55ad0c',0,0,'2021-10-21 10:07:34','2022-04-21 10:07:34'),
(4,'66e63c8b-94bd-4eb6-8478-4324e746ec61','FOA5RRFJUXCIVDEAGHHHXGK1DBO1HT3HJR60059605c-8962-41d6-a479-5066a231a6e0','be281ccf-96a5-496a-8aa7-adf6a9a000f6',0,0,'2021-10-21 11:35:48','2022-04-21 11:35:48'),
(5,'66e63c8b-94bd-4eb6-8478-4324e746ec61','6C1DNI1F3D9AUC4XGGAKB1O9BZSL1BXLDQG140d5f00-59bd-4108-b617-d874e635c809','df93b95c-c11e-420c-8815-075d31933c09',0,0,'2021-10-21 11:36:13','2022-04-21 11:36:13'),
(6,'66e63c8b-94bd-4eb6-8478-4324e746ec61','BI3M66UZMG08D2UHFS1INAZWEAQU30BESTU49974c41-6911-4d87-b1d8-ca1022343bea','bcf0dad2-07e0-427c-bbfb-967a252cda7e',0,0,'2021-10-21 11:39:41','2022-04-21 11:39:41'),
(7,'66e63c8b-94bd-4eb6-8478-4324e746ec61','LDNLLZRYHQ6W4NXGI4SOAFUV9HRHO0DAWNNd31ee458-66fb-472d-b25f-e82a221a1b0c','75b1df96-94bd-463e-8f7b-d00a22689552',0,0,'2021-10-21 11:46:28','2022-04-21 11:46:28');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
