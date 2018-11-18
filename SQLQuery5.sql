USE Lobos_DB
GO

SET DATEFORMAT DMY
GO

SELECT * FROM ADMINISTRATIVOS
SELECT * FROM CARGOS
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
SELECT * FROM UNIVERSIDADES
SELECT * FROM SEXO
GO

--PARA DEVOLVER EL ID
--SELECT CAST(scope_identity() AS int)

--CONSULTA CARGOS
alter view VW_CARGOS as select top 1000 c.IdCargo, c.Cargo from Cargos as c where c.Estado=1 order by c.Cargo asc
GO
--CONSULTA MUNICIPIOS
SELECT M.IdMunicipio, M.cp, M.municipio, P.PARTIDO, PR.PROVINCIA, PA.PAIS, PA.IdPais, PA.NacionalidadM, PA.NacionalidadF FROM Municipios AS M FULL JOIN Partidos AS P ON M.IDPARTIDO=P.IDPARTIDO FULL JOIN Provincias AS PR ON P.IDPROVINCIA=PR.IdProvincia FULL JOIN Paises AS PA ON PR.IdPais=PA.IdPais
GO
--VISTA MUNICIPIOS
ALTER VIEW VW_MUNICIPIOS AS SELECT TOP 1000 M.IDMUNICIPIO, '('+M.CP+') '+M.Municipio+' - '+P.PARTIDO+' - '+PR.PROVINCIA AS 'MUNICIPIOS' FROM Municipios AS M inner join PARTIDOS AS P ON M.IDPARTIDO=P.IDPARTIDO inner join PROVINCIAS AS PR ON P.IDPROVINCIA=PR.IDPROVINCIA where m.Estado=1 ORDER BY M.Municipio ASC, PR.Provincia ASC, P.Partido ASC, M.CP ASC
GO
--VISTA PARTIDOS
ALTER VIEW VW_PARTIDOS AS SELECT TOP 1000 P.IDPARTIDO, P.PARTIDO + ' - ' + PR.PROVINCIA + ' - ' + PA.PAIS AS 'PARTIDOS' FROM Partidos AS P inner join Provincias AS PR ON P.IdProvincia=PR.IdProvincia inner join Paises AS PA ON PR.IdPais=PA.IdPais where p.Estado=1 ORDER BY P.Partido ASC
go
--VISTA PROVINCIAS
ALTER VIEW VW_PROVINCIAS AS SELECT TOP 1000 P.IDPROVINCIA, P.PROVINCIA + ' - ' + PA.PAIS AS 'PROVINCIAS' FROM Provincias AS P inner join Paises AS PA ON P.IdPais=PA.IdPais where p.Estado=1 ORDER BY P.Provincia ASC
GO
--VISTA NACIONALIDAD
ALTER VIEW VW_NACIONALIDAD AS SELECT top 1000 P.IDPAIS, P.NACIONALIDAD FROM Paises AS P where p.Estado=1 ORDER BY NACIONALIDAD ASC
go
--VISTA RAZON SOCIAL
alter view VW_RAZONSOCIAL as select top 1000 idrazonsocial, RazonSocialPlan + ' [' + CUIT + ']' as 'Nombre' from RazonesSociales where Estado=1 order by RazonSocialPlan asc
go
--VISTA ESPECIALIDADES MEDICAS
alter view VW_ESPECIALIDADES_MEDICAS as select top 100 IdEspecialidad, Especialidad from Especialidades where Estado=1 order by Especialidad asc
go
--RECUPERAR PACIENTES Y BORRAR RASTROS
update Pacientes set Estado=1, FechaBaja=null, IdAdminBaja=null
GO
SELECT * FROM PACIENTES
GO
--RECUPERAR HISTORIAS CLINICAS Y BORRAR RASTROS
update HistoriaClinica set Estado=1, FechaBaja=null, IdAdmBaja=null
GO
--RECUPERAR PERSONAS Y BORRAR RASTROS
update Personas set Estado=1, FechaBaja=null, IdAdminBaja=null
GO
SELECT P.IDPERSONA AS ID, P.DNI, P.APELLIDO+', '+P.NOMBRE AS 'APELLIDO Y NOMBRE', P.IDSEXO, P.FechaNac AS 'FECHA NACIMIENTO', PA.NacionalidadM, PA.NacionalidadF, P.Calle, P.Numero, P.Piso, P.Depto, M.MUNICIPIO, P.TelCelular, P.TelFijo, P.FechaAlta, P.IdAdminAlta, P.FechaModif, P.IdAdminModif, P.FechaBaja, P. IdAdminBaja, P.Estado FROM Personas AS P inner join Municipios AS M ON P.IDMUNICIPIO=M.IDMUNICIPIO inner join Paises AS PA ON P.IdNacionalidad=PA.IdPais
GO






update Pacientes set FechaModif=GETDATE(), IdAdminModif=1, IdAdminBaja, FechaBaja Estado=1 where IdPaciente=27
go

SELECT * FROM ESPECIALIDADES
go
SELECT * FROM ESPECIALIDADXPROF
GO
