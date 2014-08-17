-- MySQL Script generated by MySQL Workbench
-- 06/16/14 13:41:50
-- Model: New Model    Version: 1.0
SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema a4810021_DB
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `a4810021_DB` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `a4810021_DB` ;

-- -----------------------------------------------------
-- Table `a4810021_DB`.`tbm_departamentos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`tbm_departamentos` (
  `idtbm_departamentos` INT NOT NULL,
  `nombre` VARCHAR(45) NULL,
  PRIMARY KEY (`idtbm_departamentos`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`tbm_municipio`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`tbm_municipio` (
  `idtbm_municipio` INT NOT NULL,
  `nombre` VARCHAR(45) NULL,
  `cod_postal` VARCHAR(45) NULL,
  `idtbm_departamentos` INT NOT NULL,
  PRIMARY KEY (`idtbm_municipio`),
  INDEX `fk_tbm_municipio_tbm_departamentos1_idx` (`idtbm_departamentos` ASC),
  CONSTRAINT `fk_tbm_municipio_tbm_departamentos1`
    FOREIGN KEY (`idtbm_departamentos`)
    REFERENCES `a4810021_DB`.`tbm_departamentos` (`idtbm_departamentos`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`tbm_cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`tbm_cliente` (
  `id_cliente` INT NOT NULL AUTO_INCREMENT,
  `nombre_cliente` VARCHAR(70) NULL,
  `direccion_cliente` VARCHAR(100) NULL,
  `idtbm_municipio` INT NOT NULL,
  PRIMARY KEY (`id_cliente`),
  INDEX `fk_tbm_cliente_tbm_municipio1_idx` (`idtbm_municipio` ASC),
  CONSTRAINT `fk_tbm_cliente_tbm_municipio1`
    FOREIGN KEY (`idtbm_municipio`)
    REFERENCES `a4810021_DB`.`tbm_municipio` (`idtbm_municipio`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`tbm_tipotelefono`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`tbm_tipotelefono` (
  `id_tipotelefono` INT NOT NULL AUTO_INCREMENT,
  `tx_tipotelefono` VARCHAR(45) NULL,
  PRIMARY KEY (`id_tipotelefono`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`tbt_dettelefono`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`tbt_dettelefono` (
  `tx_dettelefono` VARCHAR(20) NULL,
  `tbm_cliente_id_cliente` INT NOT NULL,
  `id_tipotelefono` INT NOT NULL,
  INDEX `fk_tbt_dettelefono_tbm_cliente_idx` (`tbm_cliente_id_cliente` ASC),
  INDEX `fk_tbt_dettelefono_tbm_tipotelefono1_idx` (`id_tipotelefono` ASC),
  CONSTRAINT `fk_tbt_dettelefono_tbm_cliente`
    FOREIGN KEY (`tbm_cliente_id_cliente`)
    REFERENCES `a4810021_DB`.`tbm_cliente` (`id_cliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbt_dettelefono_tbm_tipotelefono1`
    FOREIGN KEY (`id_tipotelefono`)
    REFERENCES `a4810021_DB`.`tbm_tipotelefono` (`id_tipotelefono`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`tbm_marcavehiculo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`tbm_marcavehiculo` (
  `id_marcavehiculo` INT NOT NULL AUTO_INCREMENT,
  `tx_marcavehiculo` VARCHAR(45) NULL,
  PRIMARY KEY (`id_marcavehiculo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`tbm_lineavehiculo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`tbm_lineavehiculo` (
  `id_lineavehiculo` INT NOT NULL AUTO_INCREMENT,
  `tx_lineavehiculo` VARCHAR(45) NULL,
  PRIMARY KEY (`id_lineavehiculo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`tbm_cilindraje`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`tbm_cilindraje` (
  `id_cilindraje` INT NOT NULL AUTO_INCREMENT,
  `tx_cilindraje` VARCHAR(45) NULL,
  PRIMARY KEY (`id_cilindraje`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`tbm_motorvehiculo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`tbm_motorvehiculo` (
  `id_motorvehiculo` INT NOT NULL AUTO_INCREMENT,
  `tx_motorvehiculo` VARCHAR(45) NULL,
  PRIMARY KEY (`id_motorvehiculo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`tbm_modelo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`tbm_modelo` (
  `id_modelo` INT NOT NULL AUTO_INCREMENT,
  `tx_modelo` VARCHAR(45) NULL,
  PRIMARY KEY (`id_modelo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`tbm_vehiculo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`tbm_vehiculo` (
  `id_vehiculo` INT NOT NULL AUTO_INCREMENT,
  `id_marcavehiculo` INT NOT NULL,
  `id_lineavehiculo` INT NOT NULL,
  `id_cilindraje` INT NOT NULL,
  `id_motorvehiculo` INT NOT NULL,
  `id_modelo` INT NOT NULL,
  PRIMARY KEY (`id_vehiculo`),
  INDEX `fk_tbm_vehiculo_tbm_marcavehiculo1_idx` (`id_marcavehiculo` ASC),
  INDEX `fk_tbm_vehiculo_tbm_lineavehiculo1_idx` (`id_lineavehiculo` ASC),
  INDEX `fk_tbm_vehiculo_tbm_cilindraje1_idx` (`id_cilindraje` ASC),
  INDEX `fk_tbm_vehiculo_tbm_motorvehiculo1_idx` (`id_motorvehiculo` ASC),
  INDEX `fk_tbm_vehiculo_tbm_modelo1_idx` (`id_modelo` ASC),
  CONSTRAINT `fk_tbm_vehiculo_tbm_marcavehiculo1`
    FOREIGN KEY (`id_marcavehiculo`)
    REFERENCES `a4810021_DB`.`tbm_marcavehiculo` (`id_marcavehiculo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbm_vehiculo_tbm_lineavehiculo1`
    FOREIGN KEY (`id_lineavehiculo`)
    REFERENCES `a4810021_DB`.`tbm_lineavehiculo` (`id_lineavehiculo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbm_vehiculo_tbm_cilindraje1`
    FOREIGN KEY (`id_cilindraje`)
    REFERENCES `a4810021_DB`.`tbm_cilindraje` (`id_cilindraje`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbm_vehiculo_tbm_motorvehiculo1`
    FOREIGN KEY (`id_motorvehiculo`)
    REFERENCES `a4810021_DB`.`tbm_motorvehiculo` (`id_motorvehiculo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbm_vehiculo_tbm_modelo1`
    FOREIGN KEY (`id_modelo`)
    REFERENCES `a4810021_DB`.`tbm_modelo` (`id_modelo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`tbt_detvc`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`tbt_detvc` (
  `id_cliente` INT NOT NULL,
  `id_vehiculo` INT NOT NULL,
  INDEX `fk_tbt_detvehiculocliente_tbm_cliente1_idx` (`id_cliente` ASC),
  INDEX `fk_tbt_detvehiculocliente_tbm_vehiculo1_idx` (`id_vehiculo` ASC),
  CONSTRAINT `fk_tbt_detvehiculocliente_tbm_cliente1`
    FOREIGN KEY (`id_cliente`)
    REFERENCES `a4810021_DB`.`tbm_cliente` (`id_cliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbt_detvehiculocliente_tbm_vehiculo1`
    FOREIGN KEY (`id_vehiculo`)
    REFERENCES `a4810021_DB`.`tbm_vehiculo` (`id_vehiculo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`tbt_servicio`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`tbt_servicio` (
  `id_servicio` INT NOT NULL AUTO_INCREMENT,
  `fecha_servicio` DATE NULL,
  `totalC_servicio` VARCHAR(45) NULL,
  `totalG_servicio` VARCHAR(45) NULL,
  `totalV_servicio` VARCHAR(45) NULL,
  `tbm_cliente_id_cliente` INT NOT NULL,
  PRIMARY KEY (`id_servicio`),
  INDEX `fk_tbt_servicio_tbm_cliente1_idx` (`tbm_cliente_id_cliente` ASC),
  CONSTRAINT `fk_tbt_servicio_tbm_cliente1`
    FOREIGN KEY (`tbm_cliente_id_cliente`)
    REFERENCES `a4810021_DB`.`tbm_cliente` (`id_cliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`tbm_marcaproducto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`tbm_marcaproducto` (
  `id_marcaproducto` INT NOT NULL AUTO_INCREMENT,
  `tx_marcaproducto` VARCHAR(45) NULL,
  PRIMARY KEY (`id_marcaproducto`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`tbm_presentacionproducto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`tbm_presentacionproducto` (
  `id_presentacionproducto` INT NOT NULL AUTO_INCREMENT,
  `tx_presentacionproducto` VARCHAR(45) NULL,
  PRIMARY KEY (`id_presentacionproducto`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`tbm_producto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`tbm_producto` (
  `id_producto` INT NOT NULL AUTO_INCREMENT,
  `co_producto` VARCHAR(45) NULL,
  `tx_producto` VARCHAR(45) NULL,
  `preciocosto_producto` VARCHAR(45) NULL,
  `precioventa_producto` VARCHAR(45) NULL,
  `id_marcaproducto` INT NOT NULL,
  `id_presentacionproducto` INT NOT NULL,
  PRIMARY KEY (`id_producto`),
  INDEX `fk_tbm_producto_tbm_marcaproducto1_idx` (`id_marcaproducto` ASC),
  INDEX `fk_tbm_producto_tbm_presentacionproducto1_idx` (`id_presentacionproducto` ASC),
  CONSTRAINT `fk_tbm_producto_tbm_marcaproducto1`
    FOREIGN KEY (`id_marcaproducto`)
    REFERENCES `a4810021_DB`.`tbm_marcaproducto` (`id_marcaproducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbm_producto_tbm_presentacionproducto1`
    FOREIGN KEY (`id_presentacionproducto`)
    REFERENCES `a4810021_DB`.`tbm_presentacionproducto` (`id_presentacionproducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`tbt_detalleservicio`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`tbt_detalleservicio` (
  `id_servicio` INT NOT NULL,
  `id_producto` INT NOT NULL,
  `cantidad_detalleservicio` INT NULL,
  `pv_detalleservicio` VARCHAR(45) NULL,
  `pc_detalleservicio` VARCHAR(45) NULL,
  INDEX `fk_tbt_detalleservicio_tbt_servicio1_idx` (`id_servicio` ASC),
  INDEX `fk_tbt_detalleservicio_tbm_producto1_idx` (`id_producto` ASC),
  CONSTRAINT `fk_tbt_detalleservicio_tbt_servicio1`
    FOREIGN KEY (`id_servicio`)
    REFERENCES `a4810021_DB`.`tbt_servicio` (`id_servicio`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbt_detalleservicio_tbm_producto1`
    FOREIGN KEY (`id_producto`)
    REFERENCES `a4810021_DB`.`tbm_producto` (`id_producto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`modulos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`modulos` (
  `cod_modulos` INT NOT NULL AUTO_INCREMENT,
  `txmodulos` VARCHAR(45) NULL,
  PRIMARY KEY (`cod_modulos`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`roles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`roles` (
  `cod_roles` INT NOT NULL AUTO_INCREMENT,
  `txrol` VARCHAR(75) NULL,
  `txestadorol` VARCHAR(45) NULL,
  `modulos_cod_modulos` INT NOT NULL,
  PRIMARY KEY (`cod_roles`),
  INDEX `fk_Roles_Modulos1_idx` (`modulos_cod_modulos` ASC),
  CONSTRAINT `fk_Roles_Modulos1`
    FOREIGN KEY (`modulos_cod_modulos`)
    REFERENCES `a4810021_DB`.`modulos` (`cod_modulos`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`usuarios` (
  `cod_usuario` INT NOT NULL AUTO_INCREMENT,
  `nom_usuario` VARCHAR(45) NULL,
  `con_usuario` VARCHAR(45) NULL,
  `es_usuario` VARCHAR(45) NULL,
  `roles_cod_roles` INT NOT NULL,
  `usu_usuario` VARCHAR(45) NULL,
  PRIMARY KEY (`cod_usuario`),
  INDEX `fk_Usuarios_Roles1_idx` (`roles_cod_roles` ASC),
  CONSTRAINT `fk_Usuarios_Roles1`
    FOREIGN KEY (`roles_cod_roles`)
    REFERENCES `a4810021_DB`.`roles` (`cod_roles`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`aplicaciones`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`aplicaciones` (
  `idaplicaciones` INT NOT NULL AUTO_INCREMENT,
  `txaplicacion` VARCHAR(50) NULL,
  `fraplicacion` VARCHAR(60) NULL,
  `modulos_cod_modulos` INT NOT NULL,
  PRIMARY KEY (`idaplicaciones`),
  INDEX `fk_Aplicaciones_Modulos1_idx` (`modulos_cod_modulos` ASC),
  CONSTRAINT `fk_Aplicaciones_Modulos1`
    FOREIGN KEY (`modulos_cod_modulos`)
    REFERENCES `a4810021_DB`.`modulos` (`cod_modulos`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`permisos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`permisos` (
  `cod_permisos` INT NOT NULL AUTO_INCREMENT,
  `boactivo` TINYINT(1) NULL,
  `bonuevo` TINYINT(1) NULL DEFAULT 0,
  `bograbar` TINYINT(1) NULL DEFAULT 0,
  `boeditar` TINYINT(1) NULL DEFAULT 0,
  `bobuscar` TINYINT(1) NULL DEFAULT 0,
  `boborrar` TINYINT(1) NULL DEFAULT 0,
  `boimprimir` TINYINT(1) NULL DEFAULT 0,
  `aplicaciones_idaplicaciones` INT NOT NULL,
  `roles_cod_roles` INT NOT NULL,
  PRIMARY KEY (`cod_permisos`, `aplicaciones_idaplicaciones`, `roles_cod_roles`),
  INDEX `fk_Permisos_Aplicaciones1_idx` (`aplicaciones_idaplicaciones` ASC),
  INDEX `fk_Permisos_Roles1_idx` (`roles_cod_roles` ASC),
  CONSTRAINT `fk_Permisos_Aplicaciones1`
    FOREIGN KEY (`aplicaciones_idaplicaciones`)
    REFERENCES `a4810021_DB`.`aplicaciones` (`idaplicaciones`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Permisos_Roles1`
    FOREIGN KEY (`roles_cod_roles`)
    REFERENCES `a4810021_DB`.`roles` (`cod_roles`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`rol_usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`rol_usuario` (
  `cod_usuario` INT NOT NULL,
  `cod_rol` INT NOT NULL,
  INDEX `fk_Rol-Usuario_Usuarios1_idx` (`cod_usuario` ASC),
  INDEX `fk_Rol-Usuario_Roles1_idx` (`cod_rol` ASC),
  CONSTRAINT `fk_Rol-Usuario_Usuarios1`
    FOREIGN KEY (`cod_usuario`)
    REFERENCES `a4810021_DB`.`usuarios` (`cod_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Rol-Usuario_Roles1`
    FOREIGN KEY (`cod_rol`)
    REFERENCES `a4810021_DB`.`roles` (`cod_roles`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`tbd_usuariosactivos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`tbd_usuariosactivos` (
  `txestado` VARCHAR(50) NULL,
  `cod_usuario` INT NOT NULL,
  INDEX `fk_tbd_usuariosactivos_Usuarios2_idx` (`cod_usuario` ASC),
  CONSTRAINT `fk_tbd_usuariosactivos_Usuarios2`
    FOREIGN KEY (`cod_usuario`)
    REFERENCES `a4810021_DB`.`usuarios` (`cod_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `a4810021_DB`.`tbt_detalle`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `a4810021_DB`.`tbt_detalle` (
  `tx_desarrollo` VARCHAR(5) NULL,
  `tx_interfaz` VARCHAR(5) NULL,
  `aplicaciones_idaplicaciones` INT NOT NULL,
  `tx_pruebas` VARCHAR(45) NULL,
  INDEX `fk_tbt_detalle_aplicaciones1_idx` (`aplicaciones_idaplicaciones` ASC),
  CONSTRAINT `fk_tbt_detalle_aplicaciones1`
    FOREIGN KEY (`aplicaciones_idaplicaciones`)
    REFERENCES `a4810021_DB`.`aplicaciones` (`idaplicaciones`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;