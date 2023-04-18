namespace teste
{
    partial class F_ListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "0", "Mouse", "200", "R$ 20.99" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "1", "Teclado", "199", "R$ 30.00" }, -1);
            lv_produtos = new ListView();
            col_id = new ColumnHeader();
            col_produto = new ColumnHeader();
            col_qtd = new ColumnHeader();
            col_preco = new ColumnHeader();
            tb_id = new TextBox();
            tb_produto = new TextBox();
            tb_qtd = new TextBox();
            tb_preco = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_addProduto = new Button();
            btn_removeProduto = new Button();
            btn_Obter = new Button();
            SuspendLayout();
            // 
            // lv_produtos
            // 
            lv_produtos.Columns.AddRange(new ColumnHeader[] { col_id, col_produto, col_qtd, col_preco });
            lv_produtos.FullRowSelect = true;
            lv_produtos.GridLines = true;
            lv_produtos.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            lv_produtos.Location = new Point(28, 12);
            lv_produtos.MultiSelect = false;
            lv_produtos.Name = "lv_produtos";
            lv_produtos.Size = new Size(324, 116);
            lv_produtos.TabIndex = 0;
            lv_produtos.UseCompatibleStateImageBehavior = false;
            lv_produtos.View = View.Details;
            // 
            // col_id
            // 
            col_id.Text = "ID";
            col_id.Width = 80;
            // 
            // col_produto
            // 
            col_produto.Text = "Produto";
            col_produto.Width = 80;
            // 
            // col_qtd
            // 
            col_qtd.Text = "Quantidade";
            col_qtd.Width = 80;
            // 
            // col_preco
            // 
            col_preco.Text = "Preço";
            col_preco.Width = 80;
            // 
            // tb_id
            // 
            tb_id.Location = new Point(26, 161);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(36, 23);
            tb_id.TabIndex = 1;
            // 
            // tb_produto
            // 
            tb_produto.Location = new Point(68, 161);
            tb_produto.Name = "tb_produto";
            tb_produto.Size = new Size(136, 23);
            tb_produto.TabIndex = 2;
            // 
            // tb_qtd
            // 
            tb_qtd.Location = new Point(210, 161);
            tb_qtd.Name = "tb_qtd";
            tb_qtd.Size = new Size(68, 23);
            tb_qtd.TabIndex = 3;
            // 
            // tb_preco
            // 
            tb_preco.Location = new Point(284, 161);
            tb_preco.Name = "tb_preco";
            tb_preco.Size = new Size(68, 23);
            tb_preco.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 143);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 143);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 6;
            label2.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 143);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 7;
            label3.Text = "Quantidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(284, 143);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 8;
            label4.Text = "Preço";
            // 
            // btn_addProduto
            // 
            btn_addProduto.Location = new Point(26, 190);
            btn_addProduto.Name = "btn_addProduto";
            btn_addProduto.Size = new Size(75, 23);
            btn_addProduto.TabIndex = 9;
            btn_addProduto.Text = "ADD";
            btn_addProduto.UseVisualStyleBackColor = true;
            btn_addProduto.Click += btn_addProduto_Click;
            // 
            // btn_removeProduto
            // 
            btn_removeProduto.Location = new Point(107, 190);
            btn_removeProduto.Name = "btn_removeProduto";
            btn_removeProduto.Size = new Size(75, 23);
            btn_removeProduto.TabIndex = 11;
            btn_removeProduto.Text = "Remove";
            btn_removeProduto.UseVisualStyleBackColor = true;
            btn_removeProduto.Click += btn_removeProduto_Click;
            // 
            // btn_Obter
            // 
            btn_Obter.Location = new Point(188, 190);
            btn_Obter.Name = "btn_Obter";
            btn_Obter.Size = new Size(75, 23);
            btn_Obter.TabIndex = 12;
            btn_Obter.Text = "Obter";
            btn_Obter.UseVisualStyleBackColor = true;
            btn_Obter.Click += btn_Obter_Click;
            // 
            // F_ListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(383, 363);
            Controls.Add(btn_Obter);
            Controls.Add(btn_removeProduto);
            Controls.Add(btn_addProduto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_preco);
            Controls.Add(tb_qtd);
            Controls.Add(tb_produto);
            Controls.Add(tb_id);
            Controls.Add(lv_produtos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "F_ListView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListView";
            Load += F_ListView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lv_produtos;
        private ColumnHeader col_id;
        private ColumnHeader col_produto;
        private ColumnHeader col_qtd;
        private ColumnHeader col_preco;
        private TextBox tb_id;
        private TextBox tb_produto;
        private TextBox tb_qtd;
        private TextBox tb_preco;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_addProduto;
        private Button btn_removeProduto;
        private Button btn_Obter;
    }
}