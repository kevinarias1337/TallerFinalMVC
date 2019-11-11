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
    public partial class Read : Form
    {
        ClsControladorDTO clsControladorDTO = null;
        ClsControladorDAO clsControladorDAO = null;
        DataTable Dtt = null;


        public Read()
        {
            InitializeComponent();
        }

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

        private void Button1_Click(object sender, EventArgs e)
        {
            MostrarInventario();
            button1.Enabled = false;
        }

        private void Atraspng_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
            
        }

    }
}
