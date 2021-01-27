using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Enums
{
    public enum OperationEnum
    {
        #region Outh
        LoginGalileo = 1,
        ResetPassword = 2,
        Refresh = 3,
        #endregion
        #region Maestros
        GetCadena = 4 ,
        GetCanales = 5,
        GetCategorias = 6,
        GetCluster = 7,
        GetEnsena  = 8,
        GetEnsenaMultiple = 9,
        GetFamilia = 10 ,
        GetMunicipio = 11 ,
        GetProvincia = 12 ,
        GetSector = 13,
        GetCliente = 14,
        GetVendedores = 15,
        GetTiendas = 16,
        GetSegmento = 17,
        GetTipoRespuesta = 28,
        #endregion
        #region Cluster
        AsignarConfiguracionTienda = 18,
        #endregion
        #region Cuestionario
        BorrarCuestionario = 19,
        GetCuestionario = 20,
        #endregion
        #region Rutas
        GetRutas = 21,
        DuplicarRutas = 22,
        ModificarRutas = 23,
        #endregion
        #region Surtido 
        GetSurtido = 24,
        DuplicarSurtido = 25,
        #endregion
        #region Visitas
        GetVisita = 26,
        GetRespuestasVisita = 27,
        SetVisita = 28 ,
        AddVisita = 29
        #endregion


    }
}
