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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (pbcargando.Value<100)
            {
                pbcargando.Value++;
                label1.Text = "Cargando "+pbcargando.Value.ToString()+"%";
            }
            else
            {
                timer2.Stop();
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
        }
    }
}
