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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void F_ComboBox_Load(object sender, EventArgs e)
        {

        }

        private void btn_adicionarItemCb_Click(object sender, EventArgs e)
        {
            cb_ItemCb.Items.Add(tb_ItemCb.Text);
        }

        private void btn_vizualizarElementoCb_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_ItemCb.Text);
        }

        private void btn_resetarCb_Click(object sender, EventArgs e)
        {
            cb_ItemCb.Items.Clear();
            cb_ItemCb.Items.Add("Carro");
            cb_ItemCb.Items.Add("Avião");
            cb_ItemCb.Items.Add("Navio");
            cb_ItemCb.Items.Add("Onibus");
            cb_ItemCb.Items.Add("Trem");
        }

        private void btn_limparCb_Click(object sender, EventArgs e)
        {
            cb_ItemCb.Items.Clear();
        }
    }
}
