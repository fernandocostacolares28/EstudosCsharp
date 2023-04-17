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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_mostrarSelec_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach(string checkedintems in clb_transportes.CheckedItems)
            {
                txt += checkedintems + "\r\n";
            }
            MessageBox.Show(txt);
        }

        private void btn_limparLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        private void btn_resetLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
            clb_transportes.Items.Add("Carro", false);
            clb_transportes.Items.Add("Avião", false);
            clb_transportes.Items.Add("Navio", false);
            clb_transportes.Items.Add("Onibus", false);
            clb_transportes.Items.Add("Trem", false);
        }

        private void btn_novoTransporte_Click(object sender, EventArgs e)
        {
            
            if (tb_novoTransporte.Text == "")
            {
                MessageBox.Show("Digite o novo transporte");
                return;
            }
            clb_transportes.Items.Add(tb_novoTransporte.Text, false);
            tb_novoTransporte.Clear();
            tb_novoTransporte.Focus();
        }
    }
}
