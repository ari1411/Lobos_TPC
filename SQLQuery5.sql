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

update Personas set FechaNac='20/08/1990' where IdPersona=1
GO

--CONSULTA MUNICIPIOS
SELECT M.IdMunicipio, M.cp, M.municipio, P.PARTIDO, PR.PROVINCIA, PA.PAIS, PA.IdPais, PA.NacionalidadM, PA.NacionalidadF FROM Municipios AS M FULL JOIN Partidos AS P ON M.IDPARTIDO=P.IDPARTIDO FULL JOIN Provincias AS PR ON P.IDPROVINCIA=PR.IdProvincia FULL JOIN Paises AS PA ON PR.IdPais=PA.IdPais
GO
ALTER VIEW VW_MUNICIPIOS AS SELECT TOP 1000 M.IDMUNICIPIO, '('+M.CP+') '+M.Municipio+' - '+P.PARTIDO+' - '+PR.PROVINCIA AS 'MUNICIPIOS' FROM Municipios AS M LEFT JOIN PARTIDOS AS P ON M.IDPARTIDO=P.IDPARTIDO LEFT JOIN PROVINCIAS AS PR ON P.IDPROVINCIA=PR.IDPROVINCIA ORDER BY 'MUNICIPIOS' ASC
GO
--VISTA PARTIDOS
ALTER VIEW VW_PARTIDOS AS SELECT TOP 1000 P.IDPARTIDO, P.PARTIDO + ' - ' + PR.PROVINCIA + ' - ' + PA.PAIS AS 'PARTIDOS' FROM Partidos AS P LEFT JOIN Provincias AS PR ON P.IdProvincia=PR.IdProvincia LEFT JOIN Paises AS PA ON PR.IdPais=PA.IdPais ORDER BY 'PARTIDOS' ASC
go
--VISTA PROVINCIAS
ALTER VIEW VW_PROVINCIAS AS SELECT TOP 1000 P.IDPROVINCIA, P.PROVINCIA + ' - ' + PA.PAIS AS 'PROVINCIAS' FROM Provincias AS P LEFT JOIN Paises AS PA ON P.IdPais=PA.IdPais ORDER BY 'PROVINCIAS' ASC
GO

SELECT * FROM Provincias



GO
CREATE VIEW VW_NACIONALIDAD AS SELECT top 1000 P.IDPAIS, P.NACIONALIDAD FROM Paises AS P ORDER BY NACIONALIDAD ASC
go
--CONSULTA PARA VER INFO PERSONAS
SELECT P.IDPERSONA AS ID, P.DNI, P.APELLIDO+', '+P.NOMBRE AS 'APELLIDO Y NOMBRE', P.IDSEXO, P.FechaNac AS 'FECHA NACIMIENTO', PA.NacionalidadM, PA.NacionalidadF, P.Calle, P.Numero, P.Piso, P.Depto, M.MUNICIPIO, P.TelCelular, P.TelFijo, P.FechaAlta, P.IdAdminAlta, P.FechaModif, P.IdAdminModif, P.FechaBaja, P. IdAdminBaja, P.Estado FROM Personas AS P LEFT JOIN Municipios AS M ON P.IDMUNICIPIO=M.IDMUNICIPIO LEFT JOIN Administrativos AS A ON P.IdPersona=A.IDPERSONA LEFT JOIN Paises AS PA ON P.IdNacionalidad=PA.IdPais
GO

--CONSULTA PERSONAS c#
SELECT P.IDPERSONA, P.DNI, P.APELLIDO, P.NOMBRE, P.SEXO, P.FechaNac, PA.NacionalidadM, PA.NacionalidadF, P.Calle, P.Numero, P.Piso, P.Depto,PART.Partido, M.MUNICIPIO, M.CP, P.TelCelular, P.TelFijo, P.Mail, P.FechaAlta, P.IdAdminAlta, P.FechaModif, P.IdAdminModif, P.FechaBaja, P. IdAdminBaja, P.Estado FROM Personas AS P LEFT JOIN Municipios AS M ON P.IDMUNICIPIO=M.IDMUNICIPIO LEFT JOIN Administrativos AS A ON P.IdPersona=A.IDPERSONA LEFT JOIN Paises AS PA ON P.IdNacionalidad=PA.IdPais LEFT JOIN Partidos AS PART ON M.IdPartido=PART.IdPartido WHERE P.Estado=1
GO


select * from Partidos

INSERT INTO Municipios (Municipio, CP, IdPartido, Estado) VALUES (1)


"INSERT INTO Personas (DNI, APELLIDO, NOMBRE, IDSEXO, FECHANAC, IDNACIONALIDAD, CALLE, NUMERO, IDMUNICIPIO, PISO, DEPTO, TELCELULAR, TELFIJO, MAIL, FECHAALTA, IDADMINALTA, FECHAMODIF, IDADMINMODIF, ESTADO) 
               values (10000001,'APELLIDO','NOMBRE',0,'2018/09/20',1,'CALLE',123,10,GETDATE(),1,GETDATE(),1,1)"
go

Select P.IdPersona, P.DNI, P.Apellido, P.Nombre, S.Sexo, P.FechaNac, PA.NacionalidadM, PA.NacionalidadF, P.Calle, P.Numero, P.Piso, P.Depto,Part.Partido, M.Municipio, M.CP, P.TelCelular, P.TelFijo, P.Mail, P.FechaAlta, P.IdAdminAlta, P.FechaModif, P.IdAdminModif, P.FechaBaja, P. IdAdminBaja, P.Estado, p.IdMunicipio, p.IdNacionalidad, PA.Nacionalidad, P.IDSEXO From Personas as P LEFT JOIN Municipios as M on P.IdMunicipio=M.IdMunicipio LEFT JOIN Administrativos as A on P.IdPersona=A.IdPersona LEFT JOIN Paises as PA on P.IdNacionalidad=PA.IdPais LEFT JOIN Partidos as PART on M.IdPartido=PART.IdPartido LEFT JOIN Sexo as S on P.IdSexo=S.IdSexo where P.Estado=1 and P.DNI like '%%' and P.Apellido like '%%' and P.Nombre like '%%'
go

update Personas set Nombre='MIA',TelCelular=null where IdPersona=28
go

update Personas set dni='12332112', apellido='LOBOS', nombre='MIA ISABELLA', idsexo=3, fechanac='2016/02/10', idnacionalidad=1, calle='SAN LORENZO', numero='4459', idmunicipio=1, piso='5', depto='D', telcelular='1168641585', telfijo='1168497160', mail='FLIA.LOBOS@GMAIL.COM', fechamodif=GETDATE(), IDADMINMODIF=1, ESTADO=1 where IdPersona=28
