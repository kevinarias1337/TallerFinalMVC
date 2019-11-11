using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR.Controlador;


namespace TallerFinal
{
    public partial class ReadCreate : Form
    {
        public ReadCreate()
        {
            InitializeComponent();
        }
        ClsControladorDTO clsControladorDTO = null;
        ClsControladorDAO clsControladorDAO = null;
        DataTable Dtt = null;

        public void MostrarInventario()
        {
            clsControladorDTO = new ClsControladorDTO();
            clsControladorDAO = new ClsControladorDAO(clsControladorDTO);
            Dtt = new DataTable();
            Dtt = clsControladorDAO.MostrarInventario();

            if (Dtt.Rows.Count > 0)
            {
                dbinventario1.DataSource = Dtt;
            }
            else
            {
                MessageBox.Show("No hay registros.");
            }
        }

        private void Atraspng_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }

        private void Btnmostrar_Click(object sender, EventArgs e)
        {
            MostrarInventario();
        }

        public void Guardar()
        {
            clsControladorDTO = new ClsControladorDTO();
            clsControladorDTO.setNombreproducto(txtnombreproducto.Text);
            clsControladorDTO.setPrecio(Convert.ToInt16(txtprecio.Text));
            clsControladorDTO.setDepartamento(txtdepartamento.Text);
            clsControladorDAO = new ClsControladorDAO(clsControladorDTO);

            clsControladorDAO.GuardarRegistro();
            MessageBox.Show("Registro guardado correctamente.");
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            if (txtnombreproducto.Text.Trim() == "" || txtdepartamento.Text.Trim()=="" || txtprecio.Text.Trim()=="")
            {
                MessageBox.Show("Asegurese de que todos los campos esten llenos para poder guardar los registros.");
            }
            else
            {
                Guardar();
                MostrarInventario();
                txtnombreproducto.Clear();
                txtprecio.Clear();
                txtdepartamento.Clear();
                txtnombreproducto.Focus();
            }
        }
    }
}
