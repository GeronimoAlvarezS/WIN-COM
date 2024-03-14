using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCom
{
    public partial class frmApp : Form
    {
        public frmApp()
        {
            InitializeComponent();
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            wmpVideo.URL = @"C:\\Users\\geron\\OneDrive\\Documentos\\HERRAMIENTAS DE PROGRAMACIÓN 2\\WinCom\\bin\\Debug\\AlcolirykoZ & Armando Hernandez - El Remate (Prod. El Arkeólogo).mp4";
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            apPdf.src = "C:\\Users\\geron\\OneDrive\\Documentos\\HERRAMIENTAS DE PROGRAMACIÓN 2\\WinCom\\bin\\Debug\\BASES DE DATOS TALLER.pdf";

            {

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            wbBuscador.Navigate("https://www.google.com/?hl=es");
        }

        private void wbBuscador_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Navegación Completada");
        }

        private void frmApp_Load(object sender, EventArgs e)
        {

        }
    }
}
