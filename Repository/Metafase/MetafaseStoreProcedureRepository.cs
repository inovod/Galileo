using Repository.Metafase.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

using System.Data.Common;
using System.Reflection;
using System.Linq;
using System.Threading.Tasks;
using Repository.Metafase.DTO;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;

namespace Repository.Metafase
{
    public class MetafaseStoreProcedureRepository  : IMetafaseStoreProcedureRepository
    {
        protected Domain.Metafase.Model.Metafase _metafaseContext;

        public MetafaseStoreProcedureRepository(Domain.Metafase.Model.Metafase ctx) => _metafaseContext = ctx;

        public async Task<List<CanalRepository_Dto>> Pr2r0NewCanal()
        {
            List<CanalRepository_Dto> retorno = new List<CanalRepository_Dto>();
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_canal";

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    retorno = MapperStoreProcedure.MapToList<CanalRepository_Dto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retorno.ToList());
        }


        public async Task<List<CadenaRepository_Dto>> Pr2r0NewCadena(int cdcadena)
        {

            List<CadenaRepository_Dto> retorno = new List<CadenaRepository_Dto>();
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_cadena";
            cmd.Parameters.Add(new SqlParameter("@CD_CANAL", SqlDbType.Int) { Value = cdcadena });

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    retorno = MapperStoreProcedure.MapToList<CadenaRepository_Dto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retorno.ToList());

        }

        public async Task<List<EnsenaRepository_Dto>> Pr2r0NewEnsena(int cdcadena)
        {
            List<EnsenaRepository_Dto> retorno = new List<EnsenaRepository_Dto>();
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_ensena";
            cmd.Parameters.Add(new SqlParameter("@CD_CADENA", SqlDbType.Int) { Value = cdcadena });

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    retorno = MapperStoreProcedure.MapToList<EnsenaRepository_Dto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retorno.ToList());
        }

        public async Task<List<EnsenaRepository_Dto>> Pr2r0NewEnsenaMultipe(string cdcadena)
        {
            List<EnsenaRepository_Dto> retorno = new List<EnsenaRepository_Dto>();
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_ensena_multiple";
            cmd.Parameters.Add(new SqlParameter("@CD_cadena", SqlDbType.NVarChar) { Value = cdcadena });

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    retorno = MapperStoreProcedure.MapToList<EnsenaRepository_Dto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retorno.ToList());
        }

        public async Task<List<ProvinciaRepository_Dto>> Pr2r0NewProvincia()
        {

            List<ProvinciaRepository_Dto> retorno = new List<ProvinciaRepository_Dto>();
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_provincia";

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    retorno = MapperStoreProcedure.MapToList<ProvinciaRepository_Dto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retorno.ToList());

        }


        public async Task<List<MunicipioRepository_Dto>> Pr2r0NewMunicipio(string cdprovincia)
        {
            List<MunicipioRepository_Dto> retorno = new List<MunicipioRepository_Dto>();
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_municipio";
            cmd.Parameters.Add(new SqlParameter("@cd_prov", SqlDbType.NVarChar) { Value = cdprovincia });

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    retorno = MapperStoreProcedure.MapToList<MunicipioRepository_Dto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retorno.ToList());
        }


        public async Task<List<SectorRepository_Dto>> Pr2r0NewSector()
        {

            List<SectorRepository_Dto> retorno = new List<SectorRepository_Dto>();
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_sector";

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    retorno = MapperStoreProcedure.MapToList<SectorRepository_Dto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retorno.ToList());

        }

        public async Task<List<ClienteRepository_Dto>> Pr2r0NewCliente()
        {
            List<ClienteRepository_Dto> retorno = new List<ClienteRepository_Dto>();
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_cliente";
            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    retorno = MapperStoreProcedure.MapToList<ClienteRepository_Dto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retorno.ToList());
        }

        public async Task<List<VendedorRepository_Dto>> Pr2r0NewVendedor(int cdcliente)
        {
            List<VendedorRepository_Dto> retorno = new List<VendedorRepository_Dto>();
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_vendedor";
            cmd.Parameters.Add(new SqlParameter("@CD_CLIENTE", SqlDbType.Int) { Value = cdcliente });

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    retorno = MapperStoreProcedure.MapToList<VendedorRepository_Dto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retorno.ToList());
        }

        public async Task<List<FamiliaRepository_Dto>> Pr2r0NewFamilia(string cdsector)
        {
            List<FamiliaRepository_Dto> retorno = new List<FamiliaRepository_Dto>();
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_familia";
            cmd.Parameters.Add(new SqlParameter("@cd_sector", SqlDbType.NVarChar) { Value = cdsector });

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    retorno = MapperStoreProcedure.MapToList<FamiliaRepository_Dto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retorno.ToList());
        }

        public async Task<List<CategoriaRepository_Dto>> Pr2r0NewCategoria(string cdsector, string cdfamilia)
        {
            List<CategoriaRepository_Dto> retorno = new List<CategoriaRepository_Dto>();
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_categoria";
            cmd.Parameters.Add(new SqlParameter("@cd_sector", SqlDbType.NVarChar) { Value = cdsector });
            cmd.Parameters.Add(new SqlParameter("@cd_familia", SqlDbType.NVarChar) { Value = cdfamilia });

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    retorno = MapperStoreProcedure.MapToList<CategoriaRepository_Dto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retorno.ToList());
        }

        public async Task<List<SegmentoRepository_Dto>> Pr2r0NewSegmento(string cdsector, string cdfamilia,string cdcategorias)
        {
            List<SegmentoRepository_Dto> retorno = new List<SegmentoRepository_Dto>();
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_segmento";
            cmd.Parameters.Add(new SqlParameter("@cd_sector", SqlDbType.NVarChar) { Value = cdsector });
            cmd.Parameters.Add(new SqlParameter("@cd_familia", SqlDbType.NVarChar) { Value = cdfamilia });
            cmd.Parameters.Add(new SqlParameter("@cd_categoria", SqlDbType.NVarChar) { Value = cdcategorias });

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    retorno = MapperStoreProcedure.MapToList<SegmentoRepository_Dto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retorno.ToList());
        }

        public async Task<List<ClusterRepository_Dto>> Pr2r0NewCluster(string cdensena, string cdcadena)
        {
            List<ClusterRepository_Dto> retorno = new List<ClusterRepository_Dto>();
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_cluster";
            cmd.Parameters.Add(new SqlParameter("@cd_ensena", SqlDbType.NVarChar) { Value = cdensena });
            cmd.Parameters.Add(new SqlParameter("@cd_cadena", SqlDbType.NVarChar) { Value = cdcadena });

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    retorno = MapperStoreProcedure.MapToList<ClusterRepository_Dto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retorno.ToList());
        }

        public async Task<List<RutaRepository_Dto>> Pr2r0NewRuta(int cdcliente, int idvendedor , bool rutasbaja)
        {
            List<RutaRepository_Dto> retorno = new List<RutaRepository_Dto>();
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_ruta";
            cmd.Parameters.Add(new SqlParameter("@CD_CLIENTE", SqlDbType.Int) { Value = cdcliente });
            cmd.Parameters.Add(new SqlParameter("@CD_EMPLEADO", SqlDbType.Int) { Value = idvendedor });

            if (rutasbaja)
                cmd.Parameters.Add(new SqlParameter("@BAJAS", SqlDbType.Int) { Value = 1 });

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    retorno = MapperStoreProcedure.MapToList<RutaRepository_Dto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retorno.ToList());
        }

        public async Task<List<CuestionarioRepository_Dto>> Pr2r0NewCuestionario(string fechaIni, string fechaFin, int cdcliente)
        {
            List<CuestionarioRepository_Dto> retorno = new List<CuestionarioRepository_Dto>();
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_cuestionarios";
            cmd.Parameters.Add(new SqlParameter("@CLIENTE", SqlDbType.Int) { Value = cdcliente });
            if( !string.IsNullOrEmpty(fechaIni))
            {
                DateTime dfechaIn = DateTime.Parse(fechaIni);
                cmd.Parameters.Add(new SqlParameter("@FECHA_INI", SqlDbType.DateTime) { Value = dfechaIn });
            }

            if (!string.IsNullOrEmpty(fechaFin))
            {
                DateTime dfechaIn = DateTime.Parse(fechaFin);
                cmd.Parameters.Add(new SqlParameter("@FECHA_FIN", SqlDbType.DateTime) { Value = dfechaIn });
            }
            /*cmd.Parameters.Add(new SqlParameter("@FECHA_INI", SqlDbType.DateTime) { Value = fechaIni });
            cmd.Parameters.Add(new SqlParameter("@FECHA_FIN", SqlDbType.DateTime) { Value = fechaFin });*/

           

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    retorno = MapperStoreProcedure.MapToList<CuestionarioRepository_Dto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retorno.ToList());
        }



        public async Task<string> Pr2r0AsignarConfigTienda(AsignarConfigTiendaRespository_Dto dto)
        {
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_AsignarConfigTienda";
            cmd.Parameters.Add(new SqlParameter("@cd_canal", SqlDbType.Int) { Value = dto.CD_CANAL });
            cmd.Parameters.Add(new SqlParameter("@cd_cadena", SqlDbType.Int) { Value = dto.CD_CADENA });
            cmd.Parameters.Add(new SqlParameter("@cd_ensena", SqlDbType.NVarChar) { Value = dto.CD_ENSENA });
            cmd.Parameters.Add(new SqlParameter("@cd_provincia", SqlDbType.NVarChar) { Value = dto.CD_PROVINCIA });
            cmd.Parameters.Add(new SqlParameter("@cd_municipio", SqlDbType.NVarChar) { Value = dto.CD_MUNICIPIO });
            cmd.Parameters.Add(new SqlParameter("@cd_cluster", SqlDbType.Int) { Value = dto.CD_CLUSTER });
            cmd.Parameters.Add(new SqlParameter("@cd_sector", SqlDbType.NVarChar) { Value = dto.CD_SECTOR });
            cmd.Parameters.Add(new SqlParameter("@cd_familia", SqlDbType.NVarChar) { Value = dto.CD_FAMILIA });
            cmd.Parameters.Add(new SqlParameter("@cd_categoria", SqlDbType.NVarChar) { Value = dto.CD_CATEGORIA });
            cmd.Parameters.Add(new SqlParameter("@cd_segmento", SqlDbType.NVarChar) { Value = dto.CD_SEGMENTO });

            int resultado = 0;

            SqlParameter pvNewId = new SqlParameter();
            pvNewId.ParameterName = "@error";
            pvNewId.DbType = DbType.String;
            pvNewId.Direction = ParameterDirection.Output;
            pvNewId.Size = 255;
            //cmd.Parameters.Add(pvNewId);


            SqlParameter pvReturnValue = new SqlParameter();
            pvReturnValue.ParameterName = "@return_value";
            pvReturnValue.DbType = DbType.Int16;
            pvReturnValue.Direction = ParameterDirection.ReturnValue;
            //cmd.Parameters.Add(pvReturnValue);

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                resultado = await cmd.ExecuteNonQueryAsync();
                //retorno = pvReturnValue.Value.ToString();

            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
           
            return await Task.Run(() => resultado.ToString());
        }

        public async Task<string> Pr2r0CrearRuta(DuplicarRutasRepository_Dto dto)
        {
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_crearRuta";
            cmd.Parameters.Add(new SqlParameter("@cd_ruta", SqlDbType.NVarChar) { Value = dto.CD_Ruta });
            cmd.Parameters.Add(new SqlParameter("@cd_cliente", SqlDbType.Int) { Value = dto.CD_Cliente });
            cmd.Parameters.Add(new SqlParameter("@cd_vendedor", SqlDbType.NVarChar) { Value = dto.CD_Vendedor });
            
            int resultado = 0;

            SqlParameter pvNewId = new SqlParameter();
            pvNewId.ParameterName = "@error";
            pvNewId.DbType = DbType.String;
            pvNewId.Direction = ParameterDirection.Output;
            pvNewId.Size = 255;
            //cmd.Parameters.Add(pvNewId);


            SqlParameter pvReturnValue = new SqlParameter();
            pvReturnValue.ParameterName = "@return_value";
            pvReturnValue.DbType = DbType.Int16;
            pvReturnValue.Direction = ParameterDirection.ReturnValue;
            //cmd.Parameters.Add(pvReturnValue);

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                resultado = await cmd.ExecuteNonQueryAsync();
                //retorno = pvReturnValue.Value.ToString();

            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }

            return await Task.Run(() => resultado.ToString());
        }

        public async Task<string> Pr2r0CambiarNombreRuta(SetRutaRepository_Dto dto)
        {
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_cambiarNombreRuta";
            cmd.Parameters.Add(new SqlParameter("@CD_RUTA", SqlDbType.Int) { Value = dto.IdRuta });
            cmd.Parameters.Add(new SqlParameter("@DS_RUTA", SqlDbType.NVarChar) { Value = dto.Descripcion });

            int resultado = 0;

            SqlParameter pvNewId = new SqlParameter();
            pvNewId.ParameterName = "@error";
            pvNewId.DbType = DbType.String;
            pvNewId.Direction = ParameterDirection.Output;
            pvNewId.Size = 255;
            //cmd.Parameters.Add(pvNewId);


            SqlParameter pvReturnValue = new SqlParameter();
            pvReturnValue.ParameterName = "@return_value";
            pvReturnValue.DbType = DbType.Int16;
            pvReturnValue.Direction = ParameterDirection.ReturnValue;
            //cmd.Parameters.Add(pvReturnValue);

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                resultado = await cmd.ExecuteNonQueryAsync();
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }

            return await Task.Run(() => resultado.ToString());
        }

        public async Task<string> Pr2rDuplicarSurtidos(DuplicarSurtidoRepository_Dto dto)
        {
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_duplicar_surtidos";
            cmd.Parameters.Add(new SqlParameter("@SURTIDO", SqlDbType.Int) { Value = dto.ID_SURTIDO });
            cmd.Parameters.Add(new SqlParameter("@cliente", SqlDbType.Int) { Value = dto.ID_CLIENTE });
            cmd.Parameters.Add(new SqlParameter("@ENSEÑAS", SqlDbType.NVarChar) { Value = dto.ENSENA });
            int resultado = 0;

            SqlParameter pvNewId = new SqlParameter();
            pvNewId.ParameterName = "@error";
            pvNewId.DbType = DbType.String;
            pvNewId.Direction = ParameterDirection.Output;
            pvNewId.Size = 255;
            //cmd.Parameters.Add(pvNewId);


            SqlParameter pvReturnValue = new SqlParameter();
            pvReturnValue.ParameterName = "@return_value";
            pvReturnValue.DbType = DbType.Int16;
            pvReturnValue.Direction = ParameterDirection.ReturnValue;
            //cmd.Parameters.Add(pvReturnValue);

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                resultado = await cmd.ExecuteNonQueryAsync();
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }

            return await Task.Run(() => resultado.ToString());
        }

        public async Task<string> BajaSurtidos(SurtidoItemBorrarRespository_Dto dto)
        {
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_surtidos_baja";
            cmd.Parameters.Add(new SqlParameter("@surtidos", SqlDbType.NVarChar) { Value = dto.idsurtidos });
            cmd.Parameters.Add(new SqlParameter("@fechaBaja", SqlDbType.DateTime) { Value = dto.fechaBaja });
            int resultado = 0;

            SqlParameter pvNewId = new SqlParameter();
            pvNewId.ParameterName = "@error";
            pvNewId.DbType = DbType.String;
            pvNewId.Direction = ParameterDirection.Output;
            pvNewId.Size = 255;
            //cmd.Parameters.Add(pvNewId);


            SqlParameter pvReturnValue = new SqlParameter();
            pvReturnValue.ParameterName = "@return_value";
            pvReturnValue.DbType = DbType.Int16;
            pvReturnValue.Direction = ParameterDirection.ReturnValue;
            //cmd.Parameters.Add(pvReturnValue);

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                resultado = await cmd.ExecuteNonQueryAsync();
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }

            return await Task.Run(() => resultado.ToString());
        }
        public async Task<string> BajaCuestionarios(CuestionarioItemBorrarRepository_Dto dto)
        {
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_cuestionarios_baja";
            cmd.Parameters.Add(new SqlParameter("@cuestionarios", SqlDbType.NVarChar) { Value = dto.idcuestionarios });
            cmd.Parameters.Add(new SqlParameter("@fechaBaja", SqlDbType.DateTime) { Value = dto.fechaBaja });
            int resultado = 0;

            SqlParameter pvNewId = new SqlParameter();
            pvNewId.ParameterName = "@error";
            pvNewId.DbType = DbType.String;
            pvNewId.Direction = ParameterDirection.Output;
            pvNewId.Size = 255;
            //cmd.Parameters.Add(pvNewId);


            SqlParameter pvReturnValue = new SqlParameter();
            pvReturnValue.ParameterName = "@return_value";
            pvReturnValue.DbType = DbType.Int16;
            pvReturnValue.Direction = ParameterDirection.ReturnValue;
            //cmd.Parameters.Add(pvReturnValue);

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                resultado = await cmd.ExecuteNonQueryAsync();
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }

            return await Task.Run(() => resultado.ToString());
        }

        public async Task<List<SurtidoRepository_Dto>> Pr2r0NewSurtido(SurtidoFiltroRepository_Dto request)
        {
            List<SurtidoRepository_Dto> retorno = new List<SurtidoRepository_Dto>();
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_surtido";
            cmd.Parameters.Add(new SqlParameter("CLIENTE", SqlDbType.Int) { Value = request.CD_Cliente });

            if (!string.IsNullOrEmpty(request.FechaDesde))
            {
                DateTime dfechaIn = DateTime.Parse(request.FechaDesde);
                cmd.Parameters.Add(new SqlParameter("@INICIO", SqlDbType.DateTime) { Value = dfechaIn });
            }

            if (!string.IsNullOrEmpty(request.FechaHasta))
            {
                DateTime dfechaIn = DateTime.Parse(request.FechaHasta);
                cmd.Parameters.Add(new SqlParameter("@FIN", SqlDbType.DateTime) { Value = dfechaIn });
            }
            cmd.Parameters.Add(new SqlParameter("@CADENA", SqlDbType.Int) { Value = request.Candena });
            cmd.Parameters.Add(new SqlParameter("@ENSENA", SqlDbType.NVarChar) { Value = request.Ensena });

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    retorno = MapperStoreProcedure.MapToList<SurtidoRepository_Dto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retorno.ToList());
        }


        public async Task<List<TiendasRepository_Dto>> Pr2r0NewTiendas(string cdcliente, string cdvendedor)
        {
            List<TiendasRepository_Dto> retorno = new List<TiendasRepository_Dto>();
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_tiendas";
            cmd.Parameters.Add(new SqlParameter("@cd_cliente", SqlDbType.NVarChar) { Value = cdcliente });
            cmd.Parameters.Add(new SqlParameter("@cd_vendedor", SqlDbType.NVarChar) { Value = cdvendedor });

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    retorno = MapperStoreProcedure.MapToList<TiendasRepository_Dto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retorno.ToList());
        }

        public async Task<List<VisitaRepository_Dto>> Pr2r0NewVisitas(VistasFilterRepository_Dto request)
        {
            List<VisitaRepository_Dto> retorno = new List<VisitaRepository_Dto>();
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_visitas";
            if (request.cdcliente > 0)
                cmd.Parameters.Add(new SqlParameter("@CD_CLIENTE", SqlDbType.Int) { Value = request.cdcliente });
            if(request.cdvendedor > 0)
                cmd.Parameters.Add(new SqlParameter("@CD_VENDEDOR", SqlDbType.Int) { Value = request.cdvendedor });
            if (request.cdtienda > 0)
                cmd.Parameters.Add(new SqlParameter("@CD_TIENDA", SqlDbType.Int) { Value = request.cdtienda });
            if (request.cdcadena > 0)
                cmd.Parameters.Add(new SqlParameter("@CD_CADENA", SqlDbType.Int) { Value = request.cdcadena });
            if (request.cdensena > 0)
                cmd.Parameters.Add(new SqlParameter("@CD_ENSENA", SqlDbType.Int) { Value = request.cdensena });
            if (request.fechainicio != DateTime.MinValue)
                cmd.Parameters.Add(new SqlParameter("@FECHAINICIO", SqlDbType.DateTime) { Value = request.fechainicio });
            if (request.fechafin != DateTime.MinValue)
                cmd.Parameters.Add(new SqlParameter("@FECHAFIN", SqlDbType.DateTime) { Value = request.fechafin });


            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    retorno = MapperStoreProcedure.MapToList<VisitaRepository_Dto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retorno.ToList());
        }

        public async Task<List<VisitaRespuestaRepository_Dto>> Pr2r0NewVisitaSelByTipo(VisitaFiltroByTipoRepository_Dto request)
        {
            List<VisitaRespuestaRepository_Dto> retorno = new List<VisitaRespuestaRepository_Dto>();
            DbCommand cmd = _metafaseContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "2r0_new_VIST_SelByTipo";
            if (request.Visita != Guid.Empty)
                cmd.Parameters.Add(new SqlParameter("@VISITA", SqlDbType.UniqueIdentifier) { Value = request.Visita });
            if (request.IdTipo >= 0)
                cmd.Parameters.Add(new SqlParameter("@TIPO", SqlDbType.Int) { Value = request.IdTipo });
            if (!string.IsNullOrEmpty(request.Cadena))
                cmd.Parameters.Add(new SqlParameter("@CADENA", SqlDbType.VarChar) { Value = request.Cadena });
            else
                cmd.Parameters.Add(new SqlParameter("@CADENA", SqlDbType.VarChar) { Value = string.Empty });

            cmd.Parameters.Add(new SqlParameter("@SURTIDO", SqlDbType.Bit) { Value = request.Surtido });
          


            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                await cmd.Connection.OpenAsync();
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    retorno = MapperStoreProcedure.MapToList<VisitaRespuestaRepository_Dto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retorno.ToList());
        }
    }
    public static class MapperStoreProcedure
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static List<T> MapToList<T>(this DbDataReader dr)
        {
            var objList = new List<T>();
            var props = typeof(T).GetRuntimeProperties();
            var colMapping = dr.GetColumnSchema()
              .Where(x => props.Any(y => y.Name.ToLower() == x.ColumnName.ToLower()))
              .ToDictionary(key => key.ColumnName.ToLower());

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    T obj = Activator.CreateInstance<T>();
                    foreach (var prop in props)
                    {
                        var val =
                          dr.GetValue(colMapping[prop.Name.ToLower()].ColumnOrdinal.Value);
                        prop.SetValue(obj, val == DBNull.Value ? null : val);
                    }
                    objList.Add(obj);
                }
            }
            return objList;
        }

    }
  
}
