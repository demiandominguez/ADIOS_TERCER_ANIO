-------------------------------------------------------------
--SCRIPT DE BORRADO - HAY QUE AGREGAR CADA COSA QUE SE CREE--
-------------------------------------------------------------

USE GD1C2016
DROP TABLE [ADIOS_TERCER_ANIO].[RolUsuario];
DROP TABLE [ADIOS_TERCER_ANIO].[FuncionalidadRol];
DROP TABLE [ADIOS_TERCER_ANIO].[Funcionalidad];
DROP TABLE [ADIOS_TERCER_ANIO].[Rol];
DROP TABLE [ADIOS_TERCER_ANIO].[Persona];
DROP TABLE [ADIOS_TERCER_ANIO].[Empresa];
DROP TABLE [ADIOS_TERCER_ANIO].[TipoDocumento];
DROP TABLE [ADIOS_TERCER_ANIO].[Localidad];
DROP TABLE [ADIOS_TERCER_ANIO].[Respuesta];
DROP TABLE [ADIOS_TERCER_ANIO].[Pregunta];
DROP TABLE [ADIOS_TERCER_ANIO].[Calificacion];
DROP TABLE [ADIOS_TERCER_ANIO].[Oferta];
DROP TABLE [ADIOS_TERCER_ANIO].[Item];
DROP TABLE [ADIOS_TERCER_ANIO].[Compra];
DROP TABLE [ADIOS_TERCER_ANIO].[Factura];
DROP TABLE [ADIOS_TERCER_ANIO].[FormaDePago];
DROP TABLE [ADIOS_TERCER_ANIO].[TipoPublicacion];
DROP TABLE [ADIOS_TERCER_ANIO].[Publicacion];
DROP TABLE [ADIOS_TERCER_ANIO].[Rubro];
DROP TABLE [ADIOS_TERCER_ANIO].[Envio];
DROP TABLE [ADIOS_TERCER_ANIO].[Estado];
DROP TABLE [ADIOS_TERCER_ANIO].[Visibilidad];
DROP TABLE [ADIOS_TERCER_ANIO].[Usuario];
DROP PROCEDURE ADIOS_TERCER_ANIO.generarUsuario;
DROP PROCEDURE ADIOS_TERCER_ANIO.migrarEmpresas;
DROP PROCEDURE ADIOS_TERCER_ANIO.migrarPersonas;
DROP PROCEDURE ADIOS_TERCER_ANIO.migrarVisibilidades;
DROP PROCEDURE ADIOS_TERCER_ANIO.migrarRubros;
DROP PROCEDURE ADIOS_TERCER_ANIO.migrarCalificaciones;
DROP PROCEDURE ADIOS_TERCER_ANIO.migrarPublicaciones;
DROP PROCEDURE ADIOS_TERCER_ANIO.migrarItems;
DROP PROCEDURE ADIOS_TERCER_ANIO.migrarFacturas;
DROP PROCEDURE ADIOS_TERCER_ANIO.migrarCompras;
DROP PROCEDURE ADIOS_TERCER_ANIO.migrarOfertas;
DROP PROCEDURE ADIOS_TERCER_ANIO.verHistoricoComprasUsuario;
DROP PROCEDURE ADIOS_TERCER_ANIO.verHistoricoOfertasUsuario;
DROP PROCEDURE ADIOS_TERCER_ANIO.calcularCalificacionPromedio;
DROP PROCEDURE ADIOS_TERCER_ANIO.obtenerCompras;
DROP PROCEDURE ADIOS_TERCER_ANIO.cargarCalificacion;
DROP PROCEDURE ADIOS_TERCER_ANIO.login;
DROP PROCEDURE ADIOS_TERCER_ANIO.calificar;
DROP PROCEDURE ADIOS_TERCER_ANIO.AgregarRol;
DROP PROCEDURE ADIOS_TERCER_ANIO.modificarFuncionalidadesRol;
DROP PROCEDURE ADIOS_TERCER_ANIO.AgregarEmpresa;
DROP PROCEDURE ADIOS_TERCER_ANIO.AgregarPersona;
DROP PROCEDURE ADIOS_TERCER_ANIO.AgregarUsuario;
DROP PROCEDURE ADIOS_TERCER_ANIO.AgregarRolUsuario;
DROP PROCEDURE ADIOS_TERCER_ANIO.AgregarPublicacion;
DROP PROCEDURE ADIOS_TERCER_ANIO.AgregarVisibilidad;
DROP PROCEDURE ADIOS_TERCER_ANIO.ModificarEmpresa;
DROP PROCEDURE ADIOS_TERCER_ANIO.ModificarPersona;
DROP PROCEDURE ADIOS_TERCER_ANIO.ModificarUsuario;
DROP PROCEDURE ADIOS_TERCER_ANIO.ModificarRol;
DROP PROCEDURE ADIOS_TERCER_ANIO.modificarPassword;
DROP PROCEDURE ADIOS_TERCER_ANIO.validarPassword;
DROP PROCEDURE ADIOS_TERCER_ANIO.EditarPublicacion;
DROP PROCEDURE ADIOS_TERCER_ANIO.PausarPublicacion;
DROP PROCEDURE ADIOS_TERCER_ANIO.ActivarPublicacion;
DROP PROCEDURE ADIOS_TERCER_ANIO.FinalizarPublicacion;
DROP PROCEDURE ADIOS_TERCER_ANIO.obtenerTipoDeCompraConNPuntaje;
DROP PROCEDURE ADIOS_TERCER_ANIO.cargarUltimasCalificaciones;
DROP PROCEDURE ADIOS_TERCER_ANIO.obtenerPublicacionesPaginaN;
DROP PROCEDURE ADIOS_TERCER_ANIO.obtenerFacturasPaginaN;
DROP PROCEDURE ADIOS_TERCER_ANIO.AgregarVisibilidad;
DROP PROCEDURE ADIOS_TERCER_ANIO.ModificarVisibilidad;
DROP PROCEDURE ADIOS_TERCER_ANIO.FacturarEmpresa;
DROP PROCEDURE ADIOS_TERCER_ANIO.FinalizarSubasta;
DROP PROCEDURE ADIOS_TERCER_ANIO.FinalizarComprasInmediatas;
DROP PROCEDURE ADIOS_TERCER_ANIO.vendedoresConMasProductosNoVendidos;
DROP PROCEDURE ADIOS_TERCER_ANIO.clientesConMasComprasPorFechaYRubro;
DROP FUNCTION ADIOS_TERCER_ANIO.funcObtenerIdDeCuit;
DROP FUNCTION ADIOS_TERCER_ANIO.funcObtenerIdDeDNI;
DROP FUNCTION ADIOS_TERCER_ANIO.funcObtenerIdPublicacionDesdeCodigoVIejo;
DROP FUNCTION ADIOS_TERCER_ANIO.funcConvertirCalificacion;
DROP SCHEMA ADIOS_TERCER_ANIO;
