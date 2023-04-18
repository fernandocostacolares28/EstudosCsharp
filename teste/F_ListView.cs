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
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }

        private void F_ListView_Load(object sender, EventArgs e)
        {

        }

        private void btn_addProduto_Click(object sender, EventArgs e)
        {
            if (tb_id.Text == "")
            {
                MessageBox.Show("ID não pode ser vazio");
                return;
            }
            string[] pr = new string[4];
            pr[0] = tb_id.Text;
            pr[1] = tb_produto.Text;
            pr[2] = tb_qtd.Text;
            pr[3] = "R$ " + tb_preco.Text;

            ListViewItem item = new ListViewItem(pr);
            lv_produtos.Items.Add(item);
            limpar();

        }

        private void limpar()
        {
            tb_id.Clear();
            tb_produto.Clear();
            tb_preco.Clear();
            tb_qtd.Clear();
        }

        private void btn_removeProduto_Click(object sender, EventArgs e)
        {
            lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]);
        }

        private void btn_Obter_Click(object sender, EventArgs e)
        {
            tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            tb_qtd.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
        }

    }
}
