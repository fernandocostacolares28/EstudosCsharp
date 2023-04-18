namespace teste
{
    partial class F_ListBox
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
            lbx_carros = new ListBox();
            label1 = new Label();
            tb_carro = new TextBox();
            btn_add = new Button();
            btn_remove = new Button();
            btn_obterElemento = new Button();
            SuspendLayout();
            // 
            // lbx_carros
            // 
            lbx_carros.FormattingEnabled = true;
            lbx_carros.ItemHeight = 15;
            lbx_carros.Location = new Point(12, 12);
            lbx_carros.Name = "lbx_carros";
            lbx_carros.Size = new Size(120, 139);
            lbx_carros.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 12);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Carro";
            // 
            // tb_carro
            // 
            tb_carro.Location = new Point(150, 30);
            tb_carro.Name = "tb_carro";
            tb_carro.Size = new Size(100, 23);
            tb_carro.TabIndex = 2;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(150, 59);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(100, 23);
            btn_add.TabIndex = 3;
            btn_add.Text = "Adicionar";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_remove
            // 
            btn_remove.Location = new Point(150, 88);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(100, 23);
            btn_remove.TabIndex = 4;
            btn_remove.Text = "Remover";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_obterElemento
            // 
            btn_obterElemento.Location = new Point(150, 117);
            btn_obterElemento.Name = "btn_obterElemento";
            btn_obterElemento.Size = new Size(100, 23);
            btn_obterElemento.TabIndex = 5;
            btn_obterElemento.Text = "Obter";
            btn_obterElemento.UseVisualStyleBackColor = true;
            btn_obterElemento.Click += btn_obterElemento_Click;
            // 
            // F_ListBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(337, 284);
            Controls.Add(btn_obterElemento);
            Controls.Add(btn_remove);
            Controls.Add(btn_add);
            Controls.Add(tb_carro);
            Controls.Add(label1);
            Controls.Add(lbx_carros);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "F_ListBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListBox";
            Load += F_ListBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbx_carros;
        private Label label1;
        private TextBox tb_carro;
        private Button btn_add;
        private Button btn_remove;
        private Button btn_obterElemento;
    }
}