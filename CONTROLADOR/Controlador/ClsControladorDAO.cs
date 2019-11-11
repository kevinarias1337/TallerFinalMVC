using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using System.Data.SqlClient;
using System.Data;

namespace CONTROLADOR.Controlador
{
    public class ClsControladorDAO
    {
        ClsDatos clsDatos = null;
        ClsControladorDTO clsControladorDTO = null;
        DataTable listarDatos = null;

        public ClsControladorDAO(ClsControladorDTO clsControladorDTO)
        {
            this.clsControladorDTO=clsControladorDTO;
        }
        public DataTable MostrarInventario()
        {
            listarDatos = new DataTable();
            try
            {
                clsDatos = new ClsDatos();
                SqlParameter[] parametros;

                if (this.clsControladorDTO == null)
                {
                    parametros = new SqlParameter[4];
                    parametros[0] = new SqlParameter();
                    parametros[0].ParameterName = "@idproducto";
                    parametros[0].SqlDbType = SqlDbType.Int;
                    parametros[0].SqlValue = clsControladorDTO.getIdproducto();
                    parametros[1] = new SqlParameter();
                    parametros[1].ParameterName = "@nombreproducto";
                    parametros[1].SqlDbType = SqlDbType.VarChar;
                    parametros[1].Size = 50;
                    parametros[1].SqlValue = clsControladorDTO.getNombreproducto();
                    parametros[2] = new SqlParameter();
                    parametros[2].ParameterName = "@precio";
                    parametros[2].SqlDbType = SqlDbType.Int;
                    parametros[2].SqlValue = clsControladorDTO.getPrecio();
                    parametros[3] = new SqlParameter();
                    parametros[3].ParameterName = "@departamento";
                    parametros[3].SqlDbType = SqlDbType.VarChar;
                    parametros[3].Size = 50;
                    parametros[3].SqlValue = clsControladorDTO.getDepartamento();
                }
                else
                {
                    parametros = null;
                }
                listarDatos = clsDatos.RetornaTable(parametros,"spMostrarInventario");
            }
            catch (Exception exception)
            {
               throw new Exception(exception.Message);
            }
            return listarDatos;
        }

        public void GuardarRegistro()
        {
            try
            {
                clsDatos = new ClsDatos();
                SqlParameter[] parametros = new SqlParameter[3];
                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@nombreproducto";
                parametros[0].SqlDbType = SqlDbType.VarChar;
                parametros[0].Size = 50;
                parametros[0].SqlValue = clsControladorDTO.getNombreproducto();
                parametros[1] = new SqlParameter();
                parametros[1].ParameterName = "@precio";
                parametros[1].SqlDbType = SqlDbType.Int;
                parametros[1].SqlValue = clsControladorDTO.getPrecio();
                parametros[2] = new SqlParameter();
                parametros[2].ParameterName = "@departamento";
                parametros[2].SqlDbType = SqlDbType.VarChar;
                parametros[2].Size = 50;
                parametros[2].SqlValue = clsControladorDTO.getDepartamento();

                clsDatos.EjecutarSP(parametros,"spGuardar");
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public void EliminarRegistro()
        {
            try
            {
                clsDatos = new ClsDatos();
                SqlParameter[] parametros = new SqlParameter[1];
                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@idproducto";
                parametros[0].SqlDbType = SqlDbType.Int;
                parametros[0].SqlValue = clsControladorDTO.getIdproducto();

                clsDatos.EjecutarSP(parametros, "spEliminar");
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public void ActualizarRegistro()
        {
            try
            {
                clsDatos = new ClsDatos();
                SqlParameter[] parametros = new SqlParameter[4];
                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@idproducto";
                parametros[0].SqlDbType = SqlDbType.Int;
                parametros[0].SqlValue = clsControladorDTO.getIdproducto();
                parametros[1] = new SqlParameter();
                parametros[1].ParameterName = "@nombreproducto";
                parametros[1].SqlDbType = SqlDbType.VarChar;
                parametros[1].Size = 50;
                parametros[1].SqlValue = clsControladorDTO.getNombreproducto();
                parametros[2] = new SqlParameter();
                parametros[2].ParameterName = "@precio";
                parametros[2].SqlValue = SqlDbType.Int;
                parametros[2].SqlValue = clsControladorDTO.getPrecio();
                parametros[3] = new SqlParameter();
                parametros[3].ParameterName = "@departamento";
                parametros[3].SqlDbType = SqlDbType.VarChar;
                parametros[3].Size = 50;
                parametros[3].SqlValue = clsControladorDTO.getDepartamento();
                clsDatos.EjecutarSP(parametros,"spActualizar");
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
