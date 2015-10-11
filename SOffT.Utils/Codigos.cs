/*  
    Codigos.cs

    Author:
    Hernan Vivani <hernan@vivani.com.ar> - http://hvivani.com.ar

    Copyright © SOffT 2010 - http://www.sofft.com.ar

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.Configuration;

namespace Sofft.Utils 
{
    /// <summary>Valores fijos utilizados por los proyectos.</summary>
    static public class Codigos {

		/// <summary>
		/// Recupera la cadena de Conexión definida en App.config
		/// Atención: Debe existir una Key "CadenaConexion"
		/// </summary>
        ///
		public static string stringConnection = ConfigurationManager.AppSettings["CadenaConexion"];

        #region CODIGOS de ACCION

		/// <summary>
		/// Determina si el Código de Acción (id interno) pasado corresponde a un Dador.
		/// En caso contrario esta relacionado con un Local.
		/// </summary>
		/// <param name="idCodigoAccion">ID interno del codigo accion.</param>
		public static bool codigoAccionDeDador(int idCodigoAccion) {
			switch (idCodigoAccion) {
				case 1:
				case 2:
				case 3:
				case 201:
					return true;

				default:
					return false;
			}
        }

        /// <summary>
        /// Concepto de Código de Acción INGRESO
        /// </summary>
        public const string codigosAccionConceptoIng = "ING";
        /// <summary>
        /// Concepto de Código de Acción EGRESO
        /// </summary>
        public const string codigosAccionConceptoEgr = "EGR";

        /// <summary>
        /// Tipo de Stock Comercialización
        /// </summary>
        public const string tipoStockCom = "C";
        /// <summary>
        /// Tipo de Stock Devolución
        /// </summary>
        public const string tipoStockDev = "D";

        /// <summary>ID Codigo Accion: 14</summary>
        public const int caEgresoAClientes = 14;

        /// <summary>
        /// Codigos numericos correspondientes a los codigos de acción
        /// </summary>
        public const int caIngresoXFactura = 1;
        public const int caBonificaciones = 2;
        public const int caIngresoXRemito = 3;
        public const int caIngresoXTransferencia = 4 ;
        public const int caConsumoInterno = 5;
        public const int caRoturas = 6;
        public const int caInutilizacionXRobo = 7;
        public const int caEgresoADevoluciones = 8;
        public const int caEgresoXTransferencia = 14;
        public const int caLecturaDeVentas = 15;
        public const int caLecturaDePicking = 16;
        public const int caGuardaDevolucionesClientes = 65;
        public const int caRelevamientoPosiciones = 66;
        public const int caTransferenciasEntrePosiciones = 67;
        public const int caGuarda = 77;
        public const int caReposicionVentas = 78;
        public const int caInventarioBultos = 88;
        public const int caInventarioUnidades = 99;
        public const int caDevolucionClientes = 107;
        public const int caDevolucionAlProv = 108;
        public const int caBasurero = 109;
        public const int caIngresoXTransferenciaDevo = 110;
        public const int caEgresoXTransferenciaDevo = 111;
        public const int caABMArticulos = 202;
        public const int caCapturaUnitaria = 255;

        #endregion


        #region Codigos validación en Lee_Inven

        public const byte validaCorrecto = 0;
        public const byte validaExcedeCantPedida = 1;
        public const byte validaNoPerteneceNotaPed = 2;
        public const byte validaNoExiteProveedor = 3;
        public const byte validaNoExisteArticulo = 4;
        public const byte validaNoExisteArtiProv = 5;
        public const byte validaDatosVariosInvalidos = 6;
        public const byte validaExcedeGuarda = 7;
        public const byte validaRestaGuardar = 8;
        public const byte validaOCCumplidaRecepcion = 9;

        #endregion


        public const string opcionTODOS      = "TODOS";
        public const string ordenamientoASC  = "ASC";
        public const string ordenamientoDESC = "DESC";

        public const string tipoComprobanteRto = "Rto";

        /// <summary>
        /// ID Condicion de Venta - Contado (1)
        /// </summary>
        public const short IdCondVtaContado = 1;

        public const int IdVendedorSinDefinir = 0;
        public const string IdZonaMdP = "1";
        public const string IdDadorSinDefinir = "0";


		/// <summary>
		/// Retorna la parte del Código correspondiente al Dador desde el Código de Artículo.
		/// Atención: quita los ceros a la izquierda.
		/// </summary>
        /// <param name="codigoArticulo">Código de Artículo (incluye al dador)</param>
		/// <returns>string Codigo Dador</returns>
		public static string codigoDador(string codigoArticulo) {
			return codigoArticulo.Trim().Length > 5 ? 
				codigoArticulo.Trim().Substring(codigoArticulo.Trim().Length - 5, 5).TrimStart('0') : string.Empty;
		}


        #region App.CONFIG Claves

        public const string appConfigEmpresa = "Empresa";
        public static string Empresa
        {
            get
            {
                return ConfigurationManager.AppSettings[appConfigEmpresa];
            }
        }

        public const string appConfigCUIT = "Cuit";
		public const string appConfigIdLocalLogin = "IdLocalLogin";
		public const string appConfigUsaColector = "UsaColector";
        

        #endregion


        #region SYS CONFIG Claves

		public const string sysConfigUsaDador = "usaDador";
        public const string sysConfigUsaSubRubros = "usaSubRubros";
		public const string sysConfigOrigenImportacion = "origenimportacion";
        public const string sysConfigConSiper = "siper";

		public const string sysConfigGeneraConsolidadoPorLocales = "generaConsolidadoLocales";
        public const string sysConfigEliminaArticulosPedidosSinExistencia = "poneexisacero";
        public const string sysConfigEliminaPedidosSinStock = "eliminarPedidosSinExistencia";

        public const string sysConfigMuestraCalculoNecesidadPrevConsolidado = "muestraFormulaNecPrevConsolid";
        public const string sysConfigGrabaHistoricoNecesidad = "grabaHistoricoNecesidad";
		public const string sysConfigUsaPromVtaEnFormula = "usaPromVtaEnFormula";
        public const string sysConfigPorcentajeRedondeoBulto = "porcentajeRedondeoBulto";
        public const string sysConfigDiasGuardaFormula = "mantieneHistoriaFormula";
		public const string sysConfigUsaVtaDiariaEnFormula = "usaVtaDiariaEnFormula";
        public const string sysConfigConsideraArtSinExisEnDeposito = "consideraArtSinExisEnDeposito";
        public const string sysConfigConsolidadoSoloDePedidosManuales = "consolidadoSoloPedidosManuales";
        public const string sysConfigIncorporaPedidosManuales = "incorporaPedidosManuales";
        public const string sysConfigMostrarPedidosManuales = "mostrarPedidosManuales";
        public const string sysConfigNombreArchivoPedidosManuales = "nombreArchivoPedidosForzados";        

        public const string sysConfigImportacionExistencias = "impoexistencias";
        public const string sysConfigDestinoExportacion = "destinoExportacion";
		public const string sysConfigConsideraLoteEnCC = "consideraLoteEnCC";
        public const string sysConfigExijeMotivoEnCC = "exijeMotivoEnCC";
        public const string sysConfigImprimeA4 = "imprimeA4";
		public const string sysConfigGrabaReportesCC = "grabaReportesCierreCC";

        public const string sysConfigDirectorioInterfaces = "directorioInterfaces";
        public const string sysConfigNombreArchivoExportDistrib = "nombreArchivoExportDistrib";
        public const string sysConfigIncluyeNumeroDeDistrib = "incluyeNumeroDeDistrib";
        public const string sysConfigIncluyeNumeroDeEmpresa = "incluyeNumeroDeEmpresa";

        // Nombre archivos de interfaces de entrada
        public const string sysNombreArchivoDevoClientes = "nombreArchivoDevoClientes";
        public const string sysNombreArchivoZonas = "nombreArchivoZonas";
        public const string sysNombreArchivoVendedores = "nombreArchivoVendedores";



        // Conciliación de facturas
        public const string sysConfigImporteDifMaxConciFac = "importedifmax";
        public const string sysConfigPorceDifMaxConciFac = "porcedifmax";

        public const string sysConfigValidaArticuloNota = "validanotapedido";
        public const string sysConfigConcatenaNavePosicion = "concatenanaveposicion";

        // Programa impresión de etiquetas
        public const string sysConfigProgramaImpreEtiquetas = "programaImpreEtic";
        public const string sysConfigArchivoEtiquetas = "archivoEtiquetas";

        // Guarda, numero de recepción a partir del cual la guarda lo considera
        public const string sysConfigNumRecepParaGuarda = "desdeNumeroRecep";

        #endregion


        #region ETAPAS Claves

		/// <summary>Etapa: 0000</summary>
		public const string etapaNotaPedidoAbierta      = "0000";
		/// <summary>Etapa: 0100</summary>
		public const string etapaNotaPedidoCerrada      = "0100";
		/// <summary>Etapa: 0200</summary>
		public const string etapaConsolidadoAbierto     = "0200";
		/// <summary>Etapa: 0201</summary>
		public const string etapaImpresoYConsolidando   = "0201";
		/// <summary>Etapa: 0202</summary>
		public const string etapaDeclarandoDiferencias1 = "0202";
		/// <summary>Etapa: 0300</summary>
		public const string etapaPickingAbierto         = "0300";
		/// <summary>Etapa: 0301</summary>
		public const string etapaImpresoYPickeando      = "0301";
		/// <summary>Etapa: 0302</summary>
		public const string etapaDeclarandoDiferencias2 = "0302";
		/// <summary>Etapa: 0303</summary>
		public const string etapaEnCalidadCertificada   = "0303";
		/// <summary>Etapa: 0400</summary>
		public const string etapaDisponibleParaExportar = "0400";
		/// <summary>Etapa: 0500</summary>
		public const string etapaExportada = "0500";

        #endregion


        #region Niveles de Usuarios

        public const int UsuarioNivelTotal = 1;
        public const int UsuarioNivelRecepcion = 2;
        public const int UsuarioNivelGuarda = 3;
        public const int UsuarioNivelConsulta = 4;
        public const int UsuarioNivelAdministrativo = 5;
        public const int UsuarioNivelDespacho = 6;

        #endregion


        #region ID Origen Pedidos

        /// <summary>
        /// ID Origen Pedido Sistema/Necesidad (1)
        /// </summary>
        public const short IdOrigenPedidoSistema = 1;
        /// <summary>
        /// ID Origen Pedido Local (2)
        /// </summary>
        public const short IdOrigenPedidoLocal = 2;
        /// <summary>
        /// ID Origen Pedido Comprador (3)
        /// </summary>
        public const short IdOrigenPedidoComprador = 3;
        /// <summary>
        /// ID Origen Pedido Cliente (4)
        /// </summary>
        public const short IdOrigenPedidoCliente = 4;

        #endregion


        /// <summary>
        /// Tipos de consulta para el form de consulta de Recepciones por comprobante frmConsuRecPorComprobante 
        /// 1=Consulta total de una recepción, 
        /// 2=Consulta de una recepción un comprobante, 
        /// 3=Consulta todas las recepciones del comprobante 
        /// </summary>
        public const int TipoConsultaRXTotal = 1;
        public const int TipoConsultaRXComproRx = 2;
        public const int TipoConsultaRXComproTotal = 3;


		#region MENSAJES del SISTEMA

		/// <summary>
		/// Mensaje de Error a mostrar cuando falla una carga de datos.
		/// Concatenar el mensaje de la Excepcion capturada.
		/// </summary>
		public static string MsgCargarError = "Se produjo un Error al cargar los datos.\n\n";

		/// <summary>
		/// Mensaje de Error a mostrar cuando falla una búsqueda de datos.
		/// Concatenar el mensaje de la Excepcion capturada.
		/// </summary>
		public static string MsgBuscarError = "Se produjo un Error al buscar los datos.\n\n";

		/// <summary>
		/// Mensaje de Aviso a mostrar luego de un error al exportar a Excel.
		/// </summary>
		public static string MsgExportExcelError = "Se produjo un Error al exportar los datos a Excel.\n\n";

		/// <summary>
		/// Mensaje de Error a mostrar cuando falla la grabación de datos.
		/// Concatenar el mensaje de la Excepcion capturada.
		/// </summary>
		public static string MsgGrabarError = "Se produjo un Error al grabar los datos.\n\n";

		/// <summary>
		/// Mensaje de Aviso a mostrar luego de una grabación exitosa.
		/// </summary>
		public static string MsgGrabarOK = "¡Los datos se grabaron correctamente!";

		#endregion


    }
}