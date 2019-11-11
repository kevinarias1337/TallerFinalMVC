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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menuread_Click(object sender, EventArgs e)
        {
            Read read = new Read();
            read.Show();
            this.Hide();
        }

        private void Menureadcreate_Click(object sender, EventArgs e)
        {
            ReadCreate readCreate = new ReadCreate();
            readCreate.Show();
            this.Hide();
        }

        private void Menureadcreatedelete_Click(object sender, EventArgs e)
        {
            ReadCreateDelete readCreateDelete = new ReadCreateDelete();
            readCreateDelete.Show();
            this.Hide();
        }

        private void Menucrud_Click(object sender, EventArgs e)
        {
            ReadCreateDeleteUpdate readCreateDeleteUpdate = new ReadCreateDeleteUpdate();
            readCreateDeleteUpdate.Show();
            this.Hide();
        }
    }
}
