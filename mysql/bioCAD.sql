-- MySQL Script generated by MySQL Workbench
-- Tue Apr  3 19:51:09 2018
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema bioCAD
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `bioCAD` ;

-- -----------------------------------------------------
-- Schema bioCAD
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `bioCAD` DEFAULT CHARACTER SET utf8 ;
USE `bioCAD` ;

-- -----------------------------------------------------
-- Table `bioCAD`.`user`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bioCAD`.`user` ;

CREATE TABLE IF NOT EXISTS `bioCAD`.`user` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `account` VARCHAR(64) NOT NULL,
  `email` VARCHAR(128) NOT NULL,
  `password` VARCHAR(32) NOT NULL,
  `role` INT NOT NULL DEFAULT 0,
  `create_time` DATETIME NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  UNIQUE INDEX `account_UNIQUE` (`account` ASC),
  UNIQUE INDEX `email_UNIQUE` (`email` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bioCAD`.`user_settings`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bioCAD`.`user_settings` ;

CREATE TABLE IF NOT EXISTS `bioCAD`.`user_settings` (
  `user_id` INT NOT NULL,
  `email_notify.login` INT NOT NULL DEFAULT 1,
  `email_notify.security` INT NOT NULL DEFAULT 1,
  `email_notify.task.start` INT NOT NULL DEFAULT 1,
  `email_notify.task.success` INT NOT NULL DEFAULT 1,
  `email_notify.task.error` INT NOT NULL DEFAULT 1,
  `update_time` DATETIME NOT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE INDEX `user_id_UNIQUE` (`user_id` ASC))
ENGINE = InnoDB
COMMENT = '1: boolean TRUE\n0: boolean FALSE';


-- -----------------------------------------------------
-- Table `bioCAD`.`project`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bioCAD`.`project` ;

CREATE TABLE IF NOT EXISTS `bioCAD`.`project` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `user_id` INT NOT NULL,
  `name` VARCHAR(64) NULL,
  `description` TINYTEXT NULL,
  `type` INT NOT NULL DEFAULT -1,
  `workspace` VARCHAR(256) NOT NULL,
  `create_time` DATETIME NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bioCAD`.`user_activity`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bioCAD`.`user_activity` ;

CREATE TABLE IF NOT EXISTS `bioCAD`.`user_activity` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `user_id` INT NOT NULL,
  `ip` VARCHAR(45) NOT NULL,
  `api` VARCHAR(128) NOT NULL COMMENT 'web api',
  `method` VARCHAR(16) NOT NULL COMMENT 'GET/POST/PUT/DELETE, etc',
  `status_code` INT NOT NULL DEFAULT 200 COMMENT '200: api call success\n500: api call throw exception\n403: access denied\n404: app not found',
  `time` DATETIME NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC))
ENGINE = InnoDB
COMMENT = 'Statistics';


-- -----------------------------------------------------
-- Table `bioCAD`.`exception`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bioCAD`.`exception` ;

CREATE TABLE IF NOT EXISTS `bioCAD`.`exception` (
  `id` INT NOT NULL COMMENT 'user_activity id for code 500',
  `expression` LONGTEXT NOT NULL,
  `stack_trace` LONGTEXT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bioCAD`.`task`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bioCAD`.`task` ;

CREATE TABLE IF NOT EXISTS `bioCAD`.`task` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `user_id` INT NOT NULL,
  `project_id` INT NOT NULL,
  `title` VARCHAR(128) NOT NULL,
  `note` TINYTEXT NULL,
  `create_time` DATETIME NOT NULL,
  `status` INT NOT NULL,
  `parameters` LONGTEXT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bioCAD`.`data_files`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bioCAD`.`data_files` ;

CREATE TABLE IF NOT EXISTS `bioCAD`.`data_files` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(128) NOT NULL,
  `uri` VARCHAR(256) NOT NULL,
  `create_time` DATETIME NOT NULL,
  `user_id` INT NOT NULL,
  `description` MEDIUMTEXT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
