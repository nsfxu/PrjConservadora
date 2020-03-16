-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema conservadoravirtual
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema conservadoravirtual
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `conservadoravirtual` DEFAULT CHARACTER SET utf8 ;
USE `conservadoravirtual` ;


-- -----------------------------------------------------
-- Table `conservadoravirtual`.`tbl_usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `conservadoravirtual`.`tbl_usuario` (
  `id_usuario` INT(11) NOT NULL AUTO_INCREMENT,
  `nome_usuario` VARCHAR(45) NOT NULL,
  `email_usuario` VARCHAR(50) NOT NULL,
  `senha_usuario` VARCHAR(45) NOT NULL,
  `tipo_usuario` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_usuario`))
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8;

-- -----------------------------------------------------
-- Table `conservadoravirtual`.`tbl_cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `conservadoravirtual`.`tbl_cliente` (
  `id_cliente` INT(11) NOT NULL AUTO_INCREMENT,
  `nome_cliente` VARCHAR(45) NOT NULL,
  `sobrenome_cliente` VARCHAR(45) NOT NULL,
  `email_cliente` VARCHAR(50) NOT NULL,
  `senha_cliente` VARCHAR(45) NOT NULL,
  `cpf_cliente` VARCHAR(11) NOT NULL,
  PRIMARY KEY (`id_cliente`))
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8;

-- -----------------------------------------------------
-- Table `conservadoravirtual`.`tbl_categoria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `conservadoravirtual`.`tbl_categoria` (
  `id_categoria` INT(11) NOT NULL AUTO_INCREMENT,
  `descricao_categoria` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_categoria`))
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `conservadoravirtual`.`tbl_prestador`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `conservadoravirtual`.`tbl_prestador` (
  `id_prestador` INT(11) NOT NULL AUTO_INCREMENT,
  `nome_prestador` VARCHAR(45) NOT NULL,
  `sobrenome_prestador` VARCHAR(45) NOT NULL,
  `email_prestador` VARCHAR(50) NOT NULL,
  `senha_prestador` VARCHAR(45) NOT NULL,
  `cpf_prestador` VARCHAR(11) NOT NULL,
  `vip_prestador` TINYINT(1) NOT NULL,
  `tbl_categoria_id_categoria` INT(11) NOT NULL,
  PRIMARY KEY (`id_prestador`),
  INDEX `fk_tbl_prestador_tbl_categoria1_idx` (`tbl_categoria_id_categoria` ASC),
  CONSTRAINT `fk_tbl_prestador_tbl_categoria1`
    FOREIGN KEY (`tbl_categoria_id_categoria`)
    REFERENCES `conservadoravirtual`.`tbl_categoria` (`id_categoria`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `conservadoravirtual`.`tbl_avaliacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `conservadoravirtual`.`tbl_avaliacao` (
  `id_avaliacao` INT(11) NOT NULL AUTO_INCREMENT,
  `nota_avaliacao` INT(11) NOT NULL,
  `comentario_avaliacao` VARCHAR(45) NULL DEFAULT NULL,
  `tbl_cliente_id_cliente` INT(11) NOT NULL,
  `tbl_prestador_id_prestador` INT(11) NOT NULL,
  PRIMARY KEY (`id_avaliacao`),
  INDEX `fk_tbl_avaliacao_tbl_cliente1_idx` (`tbl_cliente_id_cliente` ASC),
  INDEX `fk_tbl_avaliacao_tbl_prestador1_idx` (`tbl_prestador_id_prestador` ASC),
  CONSTRAINT `fk_tbl_avaliacao_tbl_cliente1`
    FOREIGN KEY (`tbl_cliente_id_cliente`)
    REFERENCES `conservadoravirtual`.`tbl_cliente` (`id_cliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbl_avaliacao_tbl_prestador1`
    FOREIGN KEY (`tbl_prestador_id_prestador`)
    REFERENCES `conservadoravirtual`.`tbl_prestador` (`id_prestador`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `conservadoravirtual`.`tbl_servicos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `conservadoravirtual`.`tbl_servicos` (
  `id_servico` INT(11) NOT NULL AUTO_INCREMENT,
  `descricao_servico` VARCHAR(45) NOT NULL,
  `valorhora_servico` DOUBLE NOT NULL,
  `valorhoravip_servico` DOUBLE NOT NULL,
  `minimohora_servico` INT(11) NOT NULL,
  `tbl_categoria_id_categoria` INT(11) NOT NULL,
  PRIMARY KEY (`id_servico`),
  INDEX `fk_tbl_servicos_tbl_categoria_idx` (`tbl_categoria_id_categoria` ASC),
  CONSTRAINT `fk_tbl_servicos_tbl_categoria`
    FOREIGN KEY (`tbl_categoria_id_categoria`)
    REFERENCES `conservadoravirtual`.`tbl_categoria` (`id_categoria`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 7
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `conservadoravirtual`.`tbl_os`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `conservadoravirtual`.`tbl_os` (
  `id_os` INT(11) NOT NULL AUTO_INCREMENT,
  `dataabertura_os` DATE NULL DEFAULT NULL,
  `dataservico_os` DATE NULL DEFAULT NULL,
  `cep_os` VARCHAR(8) NULL DEFAULT NULL,
  `numendereco_os` INT(11) NULL DEFAULT NULL,
  `complemento_os` VARCHAR(45) NULL DEFAULT NULL,
  `vip_os` TINYINT(1) NULL DEFAULT NULL,
  `horacontratadas_os` INT(11) NULL DEFAULT NULL,
  `descricao_os` VARCHAR(100) NULL DEFAULT NULL,
  `comentarios_os` VARCHAR(50) NULL DEFAULT NULL,
  `status_os` TINYINT(1) NOT NULL,
  `tbl_servicos_id_servico` INT(11) NOT NULL,
  `tbl_cliente_id_cliente` INT(11) NOT NULL,
  `tbl_prestador_id_prestador` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`id_os`),
  INDEX `fk_tbl_os_tbl_servicos1_idx` (`tbl_servicos_id_servico` ASC),
  INDEX `fk_tbl_os_tbl_cliente1_idx` (`tbl_cliente_id_cliente` ASC),
  INDEX `fk_tbl_os_tbl_prestador1_idx` (`tbl_prestador_id_prestador` ASC),
  CONSTRAINT `fk_tbl_os_tbl_cliente1`
    FOREIGN KEY (`tbl_cliente_id_cliente`)
    REFERENCES `conservadoravirtual`.`tbl_cliente` (`id_cliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbl_os_tbl_prestador1`
    FOREIGN KEY (`tbl_prestador_id_prestador`)
    REFERENCES `conservadoravirtual`.`tbl_prestador` (`id_prestador`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbl_os_tbl_servicos1`
    FOREIGN KEY (`tbl_servicos_id_servico`)
    REFERENCES `conservadoravirtual`.`tbl_servicos` (`id_servico`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8;

-- Codigos --

-- Resumitivo --


-- Melhor Cliente --
SELECT tbl_cliente.nome_cliente AS Cliente, SUM(tbl_avaliacao.nota_avaliacao) AS Nota_Total FROM tbl_cliente
LEFT JOIN tbl_avaliacao ON tbl_avaliacao.tbl_cliente_id_cliente = tbl_cliente.id_cliente
GROUP BY Cliente Order by Nota_Total desc;

-- Melhor prestador --
SELECT tbl_prestador.nome_prestador AS Prestador, SUM(tbl_avaliacao.nota_avaliacao) AS Nota_Total FROM tbl_prestador LEFT JOIN tbl_avaliacao ON tbl_avaliacao.tbl_prestador_id_prestador = tbl_prestador.id_prestador GROUP BY Prestador Order by Nota_Total desc ;

-- Melhor Serviço --
SELECT tbl_servicos.descricao_servico AS Servico, COUNT(tbl_os.tbl_servicos_id_servico) AS Vezes FROM tbl_servicos LEFT JOIN tbl_os ON tbl_os.tbl_servicos_id_servico = tbl_servicos.id_servico GROUP BY Servico Order by Vezes desc;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
