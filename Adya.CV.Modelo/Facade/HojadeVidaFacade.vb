Imports Adya.CV.Modelo.BL
Imports System.ComponentModel

Namespace HojadeVidaFacade

  <DataObject(True)>
  Public Class Facades

#Region "Usuarios"

    Public Function ListarUsuarios() As List(Of Usuarios)
      Try
        Dim bl As New UsuariosBL
        Return bl.ListarUsuarios
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarUsuarioxId(ByVal usuarioid As Integer) As Usuarios
      Try
        Dim bl As New UsuariosBL
        Return bl.ConsultarUsuarioxId(usuarioid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarUsuario(ByVal usuario As Usuarios, ByVal menuseleccionados As List(Of Menu))
      Try
        Dim bl As New UsuariosBL
        bl.GuardarUsuario(usuario, menuseleccionados)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarUsuario(ByVal usuario As Usuarios, ByVal menuseleccionados As List(Of Menu))
      Try
        Dim bl As New UsuariosBL
        bl.ActualizarUsuario(usuario, menuseleccionados)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarUsuario(ByVal usuarioId As Integer)
      Try
        Dim bl As New UsuariosBL
        bl.EliminarUsuario(usuarioId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Function ConsultarUsuarioxUsuarioyContrasena(ByVal usuario As String, ByVal contrasena As String) As Usuarios
      Try
        Dim bl As New UsuariosBL
        Return bl.ConsultarUsuarioxUsuarioyContrasena(usuario, contrasena)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function


#End Region

#Region "Actividades"

    Public Function ListarActividades() As List(Of Actividades)
      Try
        Dim bl As New ActividadesBL
        Return bl.ListarActividades
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarActividadxId(ByVal Actividadid As Integer) As Actividades
      Try
        Dim bl As New ActividadesBL
        Return bl.ConsultarActividadxId(Actividadid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarActividad(ByVal Actividad As Actividades)
      Try
        Dim bl As New ActividadesBL
        bl.GuardarActividad(Actividad)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarActividad(ByVal Actividad As Actividades)
      Try
        Dim bl As New ActividadesBL
        bl.ActualizarActividad(Actividad)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarActividad(ByVal ActividadId As Integer)
      Try
        Dim bl As New ActividadesBL
        bl.EliminarActividad(ActividadId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

#End Region

#Region "ActividadesxHojadeVida"

    Public Function ListarActividadesxHojadeVida() As List(Of ActividadesxHojadeVida)
      Try
        Dim bl As New ActividadesxHojadeVidaBL
        Return bl.ListarActividadesxHojadeVida
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarActividadxHojadeVidaxId(ByVal ActividadxHojadeVidaid As Integer) As ActividadesxHojadeVida
      Try
        Dim bl As New ActividadesxHojadeVidaBL
        Return bl.ConsultarActividadxHojadeVidaxId(ActividadxHojadeVidaid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarActividadxHojadeVida(ByVal ActividadxHojadeVida As ActividadesxHojadeVida)
      Try
        Dim bl As New ActividadesxHojadeVidaBL
        bl.GuardarActividadxHojadeVida(ActividadxHojadeVida)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarActividadxHojadeVida(ByVal ActividadxHojadeVida As ActividadesxHojadeVida)
      Try
        Dim bl As New ActividadesxHojadeVidaBL
        bl.ActualizarActividadxHojadeVida(ActividadxHojadeVida)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarActividadxHojadeVida(ByVal ActividadxHojadeVidaId As Integer)
      Try
        Dim bl As New ActividadesxHojadeVidaBL
        bl.EliminarActividadxHojadeVida(ActividadxHojadeVidaId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

#End Region

#Region "Areas"

    Public Function ListarAreas() As List(Of Areas)
      Try
        Dim bl As New AreasBL
        Return bl.ListarAreas
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarAreaxId(ByVal Areaid As Integer) As Areas
      Try
        Dim bl As New AreasBL
        Return bl.ConsultarAreaxId(Areaid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarArea(ByVal Area As Areas)
      Try
        Dim bl As New AreasBL
        bl.GuardarArea(Area)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarArea(ByVal Area As Areas)
      Try
        Dim bl As New AreasBL
        bl.ActualizarArea(Area)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarArea(ByVal AreaId As Integer)
      Try
        Dim bl As New AreasBL
        bl.EliminarArea(AreaId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

#End Region

#Region "Cargos"

    Public Function ListarCargos() As List(Of Cargos)
      Try
        Dim bl As New CargosBL
        Return bl.ListarCargos
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarCargoxId(ByVal Cargoid As Integer) As Cargos
      Try
        Dim bl As New CargosBL
        Return bl.ConsultarCargoxId(Cargoid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarCargo(ByVal Cargo As Cargos)
      Try
        Dim bl As New CargosBL
        bl.GuardarCargo(Cargo)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarCargo(ByVal Cargo As Cargos)
      Try
        Dim bl As New CargosBL
        bl.ActualizarCargo(Cargo)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarCargo(ByVal CargoId As Integer)
      Try
        Dim bl As New CargosBL
        bl.EliminarCargo(CargoId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

#End Region

#Region "Ciudades"

    Public Function ListarCiudades() As List(Of Ciudades)
      Try
        Dim bl As New CiudadesBL
        Return bl.ListarCiudades
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarCiudadxId(ByVal Ciudadid As Integer) As Ciudades
      Try
        Dim bl As New CiudadesBL
        Return bl.ConsultarCiudadxId(Ciudadid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarCiudad(ByVal Ciudad As Ciudades)
      Try
        Dim bl As New CiudadesBL
        bl.GuardarCiudad(Ciudad)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarCiudad(ByVal Ciudad As Ciudades)
      Try
        Dim bl As New CiudadesBL
        bl.ActualizarCiudad(Ciudad)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarCiudad(ByVal CiudadId As Integer)
      Try
        Dim bl As New CiudadesBL
        bl.EliminarCiudad(CiudadId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

#End Region

#Region "Conocimientos"

    Public Function ListarConocimientos() As List(Of Conocimientos)
      Try
        Dim bl As New ConocimientosBL
        Return bl.ListarConocimientos
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarConocimientoxId(ByVal Conocimientoid As Integer) As Conocimientos
      Try
        Dim bl As New ConocimientosBL
        Return bl.ConsultarConocimientoxId(Conocimientoid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarConocimiento(ByVal Conocimiento As Conocimientos)
      Try
        Dim bl As New ConocimientosBL
        bl.GuardarConocimiento(Conocimiento)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarConocimiento(ByVal Conocimiento As Conocimientos)
      Try
        Dim bl As New ConocimientosBL
        bl.ActualizarConocimiento(Conocimiento)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarConocimiento(ByVal ConocimientoId As Integer)
      Try
        Dim bl As New ConocimientosBL
        bl.EliminarConocimiento(ConocimientoId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

#End Region

#Region "Educaciones"

    Public Function ListarEducaciones() As List(Of Educaciones)
      Try
        Dim bl As New EducacionesBL
        Return bl.ListarEducaciones
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarEducacionxId(ByVal Educacionid As Integer) As Educaciones
      Try
        Dim bl As New EducacionesBL
        Return bl.ConsultarEducacionxId(Educacionid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarEducacion(ByVal Educacion As Educaciones)
      Try
        Dim bl As New EducacionesBL
        bl.GuardarEducacion(Educacion)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarEducacion(ByVal Educacion As Educaciones)
      Try
        Dim bl As New EducacionesBL
        bl.ActualizarEducacion(Educacion)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarEducacion(ByVal EducacionId As Integer)
      Try
        Dim bl As New EducacionesBL
        bl.EliminarEducacion(EducacionId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

#End Region

#Region "EstudioActuales"

    Public Function ListarEstudioActuales() As List(Of EstudioActuales)
      Try
        Dim bl As New EstudioActualesBL
        Return bl.ListarEstudioActuales
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarEstudioActualxId(ByVal EstudioActualid As Integer) As EstudioActuales
      Try
        Dim bl As New EstudioActualesBL
        Return bl.ConsultarEstudioActualxId(EstudioActualid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarEstudioActual(ByVal EstudioActual As EstudioActuales)
      Try
        Dim bl As New EstudioActualesBL
        bl.GuardarEstudioActual(EstudioActual)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarEstudioActual(ByVal EstudioActual As EstudioActuales)
      Try
        Dim bl As New EstudioActualesBL
        bl.ActualizarEstudioActual(EstudioActual)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarEstudioActual(ByVal EstudioActualId As Integer)
      Try
        Dim bl As New EstudioActualesBL
        bl.EliminarEstudioActual(EstudioActualId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

#End Region

#Region "Profesiones"

    Public Function ListarProfesiones() As List(Of Profesiones)
      Try
        Dim bl As New ProfesionesBL
        Return bl.ListarProfesiones
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarProfesionxId(ByVal Profesionid As Integer) As Profesiones
      Try
        Dim bl As New ProfesionesBL
        Return bl.ConsultarProfesionxId(Profesionid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarProfesion(ByVal Profesion As Profesiones)
      Try
        Dim bl As New ProfesionesBL
        bl.GuardarProfesion(Profesion)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarProfesion(ByVal Profesion As Profesiones)
      Try
        Dim bl As New ProfesionesBL
        bl.ActualizarProfesion(Profesion)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarProfesion(ByVal ProfesionId As Integer)
      Try
        Dim bl As New ProfesionesBL
        bl.EliminarProfesion(ProfesionId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

#End Region

#Region "Nacionalidades"

    Public Function ListarNacionalidades() As List(Of Nacionalidades)
      Try
        Dim bl As New NacionalidadesBL
        Return bl.ListarNacionalidades
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarNacionalidadxId(ByVal Nacionalidadid As Integer) As Nacionalidades
      Try
        Dim bl As New NacionalidadesBL
        Return bl.ConsultarNacionalidadxId(Nacionalidadid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarNacionalidad(ByVal Nacionalidad As Nacionalidades)
      Try
        Dim bl As New NacionalidadesBL
        bl.GuardarNacionalidad(Nacionalidad)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarNacionalidad(ByVal Nacionalidad As Nacionalidades)
      Try
        Dim bl As New NacionalidadesBL
        bl.ActualizarNacionalidad(Nacionalidad)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarNacionalidad(ByVal NacionalidadId As Integer)
      Try
        Dim bl As New NacionalidadesBL
        bl.EliminarNacionalidad(NacionalidadId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

#End Region

#Region "SeguridadesSociales"

    Public Function ListarSeguridadesSociales() As List(Of SeguridadesSociales)
      Try
        Dim bl As New SeguridadesSocialesBL
        Return bl.ListarSeguridadesSociales
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarSeguridadesSocialxId(ByVal SeguridadesSocialid As Integer) As SeguridadesSociales
      Try
        Dim bl As New SeguridadesSocialesBL
        Return bl.ConsultarSeguridadesSocialxId(SeguridadesSocialid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarSeguridadesSocial(ByVal SeguridadesSocial As SeguridadesSociales)
      Try
        Dim bl As New SeguridadesSocialesBL
        bl.GuardarSeguridadesSocial(SeguridadesSocial)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarSeguridadesSocial(ByVal SeguridadesSocial As SeguridadesSociales)
      Try
        Dim bl As New SeguridadesSocialesBL
        bl.ActualizarSeguridadesSocial(SeguridadesSocial)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarSeguridadesSocial(ByVal SeguridadesSocialId As Integer)
      Try
        Dim bl As New SeguridadesSocialesBL
        bl.EliminarSeguridadesSocial(SeguridadesSocialId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

#End Region

#Region "InformacionFamiliares"

    Public Function ListarInformacionFamiliares() As List(Of InformacionFamiliares)
      Try
        Dim bl As New InformacionFamiliaresBL
        Return bl.ListarInformacionFamiliares
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarInformacionFamiliarxId(ByVal InformacionFamiliarid As Integer) As InformacionFamiliares
      Try
        Dim bl As New InformacionFamiliaresBL
        Return bl.ConsultarInformacionFamiliarxId(InformacionFamiliarid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarInformacionFamiliar(ByVal InformacionFamiliar As InformacionFamiliares)
      Try
        Dim bl As New InformacionFamiliaresBL
        bl.GuardarInformacionFamiliar(InformacionFamiliar)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarInformacionFamiliar(ByVal InformacionFamiliar As InformacionFamiliares)
      Try
        Dim bl As New InformacionFamiliaresBL
        bl.ActualizarInformacionFamiliar(InformacionFamiliar)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarInformacionFamiliar(ByVal InformacionFamiliarId As Integer)
      Try
        Dim bl As New InformacionFamiliaresBL
        bl.EliminarInformacionFamiliar(InformacionFamiliarId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

#End Region

#Region "ReferenciaPersonales"

    Public Function ListarReferenciaPersonales() As List(Of ReferenciaPersonales)
      Try
        Dim bl As New ReferenciaPersonalesBL
        Return bl.ListarReferenciaPersonales
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarReferenciaPersonalxId(ByVal ReferenciaPersonalid As Integer) As ReferenciaPersonales
      Try
        Dim bl As New ReferenciaPersonalesBL
        Return bl.ConsultarReferenciaPersonalxId(ReferenciaPersonalid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarReferenciaPersonal(ByVal ReferenciaPersonal As ReferenciaPersonales)
      Try
        Dim bl As New ReferenciaPersonalesBL
        bl.GuardarReferenciaPersonal(ReferenciaPersonal)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarReferenciaPersonal(ByVal ReferenciaPersonal As ReferenciaPersonales)
      Try
        Dim bl As New ReferenciaPersonalesBL
        bl.ActualizarReferenciaPersonal(ReferenciaPersonal)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarReferenciaPersonal(ByVal ReferenciaPersonalId As Integer)
      Try
        Dim bl As New ReferenciaPersonalesBL
        bl.EliminarReferenciaPersonal(ReferenciaPersonalId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

#End Region

#Region "ExperienciaLaborales"

    Public Function ListarExperienciaLaborales() As List(Of ExperienciaLaborales)
      Try
        Dim bl As New ExperienciaLaboralesBL
        Return bl.ListarExperienciaLaborales
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarExperienciaLaboralxId(ByVal ExperienciaLaboralid As Integer) As ExperienciaLaborales
      Try
        Dim bl As New ExperienciaLaboralesBL
        Return bl.ConsultarExperienciaLaboralxId(ExperienciaLaboralid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarExperienciaLaboral(ByVal ExperienciaLaboral As ExperienciaLaborales)
      Try
        Dim bl As New ExperienciaLaboralesBL
        bl.GuardarExperienciaLaboral(ExperienciaLaboral)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarExperienciaLaboral(ByVal ExperienciaLaboral As ExperienciaLaborales)
      Try
        Dim bl As New ExperienciaLaboralesBL
        bl.ActualizarExperienciaLaboral(ExperienciaLaboral)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarExperienciaLaboral(ByVal ExperienciaLaboralId As Integer)
      Try
        Dim bl As New ExperienciaLaboralesBL
        bl.EliminarExperienciaLaboral(ExperienciaLaboralId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

#End Region

#Region "AreasxHojadeVida"

    Public Function ListarAreasxHojadeVida() As List(Of AreasxHojadeVida)
      Try
        Dim bl As New AreasxHojadeVidaBL
        Return bl.ListarAreasxHojadeVida
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarAreaxHojadeVidaxId(ByVal AreaxHojadeVidaid As Integer) As AreasxHojadeVida
      Try
        Dim bl As New AreasxHojadeVidaBL
        Return bl.ConsultarAreaxHojadeVidaxId(AreaxHojadeVidaid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarAreaxHojadeVida(ByVal AreaxHojadeVida As AreasxHojadeVida)
      Try
        Dim bl As New AreasxHojadeVidaBL
        bl.GuardarAreaxHojadeVida(AreaxHojadeVida)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarAreaxHojadeVida(ByVal AreaxHojadeVida As AreasxHojadeVida)
      Try
        Dim bl As New AreasxHojadeVidaBL
        bl.ActualizarAreaxHojadeVida(AreaxHojadeVida)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarAreaxHojadeVida(ByVal AreaxHojadeVidaId As Integer)
      Try
        Dim bl As New AreasxHojadeVidaBL
        bl.EliminarAreaxHojadeVida(AreaxHojadeVidaId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

#End Region

#Region "MenusxUsuario"

    Public Function ListarMenusxUsuario() As List(Of MenusxUsuario)
      Try
        Dim bl As New MenusxUsuarioBL
        Return bl.ListarMenusxUsuario
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarMenuxUsuarioxId(ByVal MenuxUsuarioid As Integer) As MenusxUsuario
      Try
        Dim bl As New MenusxUsuarioBL
        Return bl.ConsultarMenuxUsuarioxId(MenuxUsuarioid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarMenuxUsuario(ByVal MenuxUsuario As MenusxUsuario)
      Try
        Dim bl As New MenusxUsuarioBL
        bl.GuardarMenuxUsuario(MenuxUsuario)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarMenuxUsuario(ByVal MenuxUsuario As MenusxUsuario)
      Try
        Dim bl As New MenusxUsuarioBL
        bl.ActualizarMenuxUsuario(MenuxUsuario)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarMenuxUsuario(ByVal MenuxUsuarioId As Integer)
      Try
        Dim bl As New MenusxUsuarioBL
        bl.EliminarMenuxUsuario(MenuxUsuarioId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Function ListarMenusxUsuarioXUsuarioId(ByVal usuarioId As Integer) As List(Of MenusxUsuario)
      Try
        Dim bl As New MenusxUsuarioBL
        Return bl.ListarMenusxUsuarioXUsuarioId(usuarioId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function
    Public Function AutorizacionMenu(ByVal usuarioId As Integer) As List(Of MenusxUsuario)
      Try
        Dim bl As New MenusxUsuarioBL
        Return bl.AutorizacionMenu(usuarioId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function


#End Region

#Region "Menus"

    Public Function ListarMenus() As List(Of Menus)
      Try
        Dim bl As New MenusBL
        Return bl.ListarMenus
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarMenuxId(ByVal Menuid As Integer) As Menus
      Try
        Dim bl As New MenusBL
        Return bl.ConsultarMenuxId(Menuid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarMenu(ByVal Menu As Menus)
      Try
        Dim bl As New MenusBL
        bl.GuardarMenu(Menu)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarMenu(ByVal Menu As Menus)
      Try
        Dim bl As New MenusBL
        bl.ActualizarMenu(Menu)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarMenu(ByVal MenuId As Integer)
      Try
        Dim bl As New MenusBL
        bl.EliminarMenu(MenuId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Function ConsultarMenuxNombre(ByVal nombre As String) As Menus
      Try
        Dim bl As New MenusBL
        Return bl.ConsultarMenuxNombre(nombre)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

#End Region

#Region "HojadeVidas"

    Public Function ListarHojadeVidas() As List(Of HojadeVidas)
      Try
        Dim bl As New HojadeVidasbl
        Return bl.ListarHojadeVidas
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarHojadeVidaxId(ByVal HojadeVidaid As Integer) As HojadeVidas
      Try
        Dim bl As New HojadeVidasbl
        Return bl.ConsultarHojadeVidaxId(HojadeVidaid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarHojadeVida(ByVal HojadeVida As HojadeVidas)
      Try
        Dim bl As New HojadeVidasbl
        bl.GuardarHojadeVida(HojadeVida)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarHojadeVida(ByVal HojadeVida As HojadeVidas)
      Try
        Dim bl As New HojadeVidasbl
        bl.ActualizarHojadeVida(HojadeVida)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarHojadeVida(ByVal HojadeVidaId As Integer)
      Try
        Dim bl As New HojadeVidasbl
        bl.EliminarHojadeVida(HojadeVidaId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

#End Region

  End Class

End Namespace

