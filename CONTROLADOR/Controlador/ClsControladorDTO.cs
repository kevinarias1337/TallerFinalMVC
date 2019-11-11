using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADOR.Controlador
{
   public class ClsControladorDTO
    {
        private int idproducto;
        private string nombreproducto;
        private int precio;
        private string departamento;

        public void setIdproducto(int valor)
        {
            this.idproducto = valor;
        }
        public int getIdproducto()
        {
            return this.idproducto;
        }
        public void setNombreproducto(string valor)
        {
            this.nombreproducto = valor;
        }
        public string getNombreproducto()
        {
            return this.nombreproducto;
        }
        public void setPrecio(int valor)
        {
            this.precio = valor;
        }
        public int getPrecio()
        {
            return this.precio;
        }
        public void setDepartamento(string valor)
        {
            this.departamento = valor;
        }
        public string getDepartamento()
        {
            return this.departamento;
        }
    }
}
