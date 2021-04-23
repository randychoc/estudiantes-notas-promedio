CREATE DATABASE IF NOT EXISTS ejercicio3;
USE ejercicio3;
--
-- Base de datos: `ejercicio3`
--
-- Estructura de tabla para la tabla `estudiantes`
--
CREATE TABLE `estudiantes` (
  `carnet` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `direccion` varchar(50) NOT NULL,
  `genero` varchar(1) NOT NULL,
  `fecha_nacimiento` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
--
-- Volcado de datos para la tabla `estudiantes`
--
INSERT INTO `estudiantes` (`carnet`, `nombre`, `direccion`, `genero`, `fecha_nacimiento`) VALUES
(1, 'Alexis', 'Zona 6, Guatemala', 'M', '1995-01-05'),
(2, 'Rudy', 'Zona 4, Guatemala', 'M', '1995-04-15'),
(3, 'Miguel', 'Zona 1, Guatemala', 'M', '1990-04-06'),
(4, 'Valerie', 'Zona 9, Guatemala', 'F', '1992-04-06'),
(5, 'Josselyn', 'Zona 10, Guatemala', 'F', '1998-12-12'),
(6, 'Alejandra', 'Zona 2, Guatemala', 'F', '1997-11-11');
--
-- Indices de la tabla `estudiantes`
--
ALTER TABLE `estudiantes`
  ADD PRIMARY KEY (`carnet`);
--
-- AUTO_INCREMENT de la tabla `estudiantes`
--
ALTER TABLE `estudiantes`
  MODIFY `carnet` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;