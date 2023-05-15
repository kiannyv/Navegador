using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    public partial class Form2 : Form
    {

        List<string> Favoritos = new List<string>();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            wbNavegador.GoBack();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            wbNavegador.GoForward();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            wbNavegador.Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            wbNavegador.GoHome();
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            wbNavegador.Navigate(txtURL.Text);
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            Favoritos.Add(wbNavegador.Url.ToString());
            actualizarComb();
        }

        private void actualizarComb()
        {
            foreach(string direccion in Favoritos)
            {
                cbFavoritos.Items.Add(direccion);
            }
        }

        private void cbFavoritos_Click(object sender, EventArgs e)
        {
           
        }

        private void cbFavoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            wbNavegador.Navigate(cbFavoritos.SelectedIndex.ToString());
        }

        private void txtURL_Click(object sender, EventArgs e)
        {

        }
    }
}
