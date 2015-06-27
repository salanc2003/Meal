DROP DATABASE IF EXISTS MealOrder;

CREATE DATABASE MealOrder CHARACTER SET big5;

USE MealOrder;

DROP TABLE IF EXISTS `MealKind`;

CREATE TABLE `MealKind` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` char(35) NOT NULL DEFAULT '',
  `RestaurantID` char(35) NOT NULL DEFAULT '',
  PRIMARY KEY (`ID`)
);

DROP TABLE IF EXISTS `Meal`;

CREATE TABLE `Meal` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` char(35) NOT NULL DEFAULT '',
  `Description` char(35) NOT NULL DEFAULT '',
  `MealKindID` int(11) NOT NULL DEFAULT 0,
  `Price` int(11) NOT NULL DEFAULT 99999,
  PRIMARY KEY (`ID`),
  FOREIGN KEY (MealKindID) REFERENCES MealKind (ID)
);

DROP TABLE IF EXISTS `OrderMeal`;

CREATE TABLE `OrderMeal`(
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `RestaurantID` int(11) NOT NULL DEFAULT 0,
  `Kind` ENUM('Here', 'ToGo', 'CallOut') NOT NULL,
  `TableNum` SMALLINT(5) UNSIGNED NOT NULL,
  `CustomID` int(11) DEFAULT 0,
  `PeopleNum` SMALLINT(5) UNSIGNED NOT NULL DEFAULT 1,
  `OrderTime` DATETIME DEFAULT CURRENT_TIMESTAMP,
  `PayTime` DATETIME,
  `Comment` VARCHAR(200),
  PRIMARY KEY (`ID`)
);

DROP TABLE IF EXISTS `OrderMealDetail`;

CREATE TABLE `OrderMealDetail`(
  `ID` int(11),
  `MealID` int(11) NOT NULL,
  `Amount` SMALLINT(5) NOT NULL DEFAULT 1,
  `ExtraMealID`int(11) DEFAULT 0,
  PRIMARY KEY (`ID`)
);

DROP TABLE IF EXISTS `ExtraMeal`;

CREATE TABLE `ExtraMeal`(
  `ID` int(11),
  `MealID` int(11) NOT NULL,
  `Price`int(11) DEFAULT 99999,
  PRIMARY KEY (`ID`)
);

DROP TABLE IF EXISTS `Restaurant`;

CREATE TABLE `Restaurant`(
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` char(35) NOT NULL DEFAULT '',
  `Telephone` varchar(12) NOT NULL DEFAULT '', 
  `Adrs` varchar(60) NOT NULL DEFAULT '',
  `URL` varchar(60) NOT NULL DEFAULT '',
  `GroupID` int(11) NOT NULL,
  PRIMARY KEY (`ID`)
);

DROP TABLE IF EXISTS `GROUP`;

CREATE TABLE `GROUP`(
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` char(35) NOT NULL DEFAULT '',
  PRIMARY KEY (`ID`)
);

DROP TABLE IF EXISTS `CUSTOMER`;

CREATE TABLE `CUSTOMER`(
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` char(35) NOT NULL DEFAULT '',
  `Gender` enum('Male','Female'),
  `Birthday` date,
  `Telephone` varchar(12) DEFAULT '', 
  `Adrs` varchar(60) NOT NULL DEFAULT '',
  `CreateTime` datetime NOT NULL DEFAULT NOW(),
  PRIMARY KEY (`ID`)
);








