USE Lobos_DB
GO

SELECT m.cp, M.municipio, P.PARTIDO, PR.PROVINCIA, PA.PAIS FROM Municipios AS M
FULL JOIN Partidos AS P 
ON M.IDPARTIDO=P.IDPARTIDO
FULL JOIN Provincias AS PR
ON P.IDPROVINCIA=PR.IdProvincia
FULL JOIN Paises AS PA
ON PR.IdPais=PA.IdPais
GO

SELECT * FROM ADMINISTRATIVOS
SELECT * FROM ESPECIALIDADES
SELECT * FROM ESPECIALIDADXPROF
SELECT * FROM EVOLUCIONES
SELECT * FROM HISTORIACLINICA
SELECT * FROM Municipios
SELECT * FROM PACIENTES
SELECT * FROM Paises
SELECT * FROM Partidos
SELECT * FROM Personas
SELECT * FROM PROFESIONALES
SELECT * FROM Provincias
SELECT * FROM RAZONESSOCIALES
SELECT * FROM TURNOS
GO

go
update Personas set numero=4459,idmunicipio=1