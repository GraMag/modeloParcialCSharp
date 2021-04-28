using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial;

namespace FrmTest
{
    public partial class FormTest : Form
    {
        List<Publicacion> biblioteca = new List<Publicacion>();
    
        public FormTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            biblioteca.Add(p1);
            biblioteca.Add(p2);
            biblioteca.Add(p3);
            biblioteca.Add(p4);
            biblioteca.Add(p5);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if(biblioteca != null && vendedor != null && lstStock.SelectedItem != null)
            {
                foreach (Publicacion publi in biblioteca)
                {
                    if (lstStock.SelectedItem.ToString().Equals(publi.ToString()))
                    {
                        MessageBox.Show(vendedor + publi ? publi.Informacion() : "Sin stock", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            } else {
                MessageBox.Show("Ha sucedido un error", "Oh no!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            if(vendedor != null)
            {
                rtbInformes.Text = vendedor.InformeDeVentas();
            } else {
                MessageBox.Show("Ha sucedido un error", "Oh no!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult restult = MessageBox.Show("Esta seguro que desea cerrar?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (restult == DialogResult.OK)
            {
                this.Close();
            }
        }

    }
}
