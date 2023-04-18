using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class F_ListBox : Form
    {
        List<string> listaCarros = new List<string>();
        public F_ListBox()
        {
            InitializeComponent();
            listaCarros.Add("Fusca");
            listaCarros.Add("Corsa");
            listaCarros.Add("Uno");

            lbx_carros.DataSource = listaCarros;
        }

        private void F_ListBox_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_carro.Text == "")
            {
                MessageBox.Show("Digite um modelo de carro para adicionar!!");
                tb_carro.Focus();
                return;
            }
            listaCarros.Add(tb_carro.Text);
            autorizaListaCarros(lbx_carros, listaCarros);
            tb_carro.Clear();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            listaCarros.RemoveAt(lbx_carros.SelectedIndex);
            autorizaListaCarros(lbx_carros, listaCarros);
        }

        private void btn_obterElemento_Click(object sender, EventArgs e)
        {
            tb_carro.Text = listaCarros[lbx_carros.SelectedIndex];
        }

        public void autorizaListaCarros(ListBox lbx, List<String> lista)
        {
            lbx.DataSource = null;
            lbx.DataSource = lista;
        }
    }
}
