namespace teste
{
    partial class F_ComboBox
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
            this.cb_ItemCb = new System.Windows.Forms.ComboBox();
            this.tb_ItemCb = new System.Windows.Forms.TextBox();
            this.btn_adicionarItemCb = new System.Windows.Forms.Button();
            this.btn_vizualizarElementoCb = new System.Windows.Forms.Button();
            this.btn_resetarCb = new System.Windows.Forms.Button();
            this.btn_limparCb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_ItemCb
            // 
            this.cb_ItemCb.FormattingEnabled = true;
            this.cb_ItemCb.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Onibus",
            "Trem"});
            this.cb_ItemCb.Location = new System.Drawing.Point(12, 12);
            this.cb_ItemCb.Name = "cb_ItemCb";
            this.cb_ItemCb.Size = new System.Drawing.Size(179, 23);
            this.cb_ItemCb.TabIndex = 0;
            // 
            // tb_ItemCb
            // 
            this.tb_ItemCb.Location = new System.Drawing.Point(204, 12);
            this.tb_ItemCb.Name = "tb_ItemCb";
            this.tb_ItemCb.Size = new System.Drawing.Size(179, 23);
            this.tb_ItemCb.TabIndex = 1;
            // 
            // btn_adicionarItemCb
            // 
            this.btn_adicionarItemCb.Location = new System.Drawing.Point(204, 41);
            this.btn_adicionarItemCb.Name = "btn_adicionarItemCb";
            this.btn_adicionarItemCb.Size = new System.Drawing.Size(179, 23);
            this.btn_adicionarItemCb.TabIndex = 2;
            this.btn_adicionarItemCb.Text = "Salvar";
            this.btn_adicionarItemCb.UseVisualStyleBackColor = true;
            this.btn_adicionarItemCb.Click += new System.EventHandler(this.btn_adicionarItemCb_Click);
            // 
            // btn_vizualizarElementoCb
            // 
            this.btn_vizualizarElementoCb.Location = new System.Drawing.Point(204, 70);
            this.btn_vizualizarElementoCb.Name = "btn_vizualizarElementoCb";
            this.btn_vizualizarElementoCb.Size = new System.Drawing.Size(179, 23);
            this.btn_vizualizarElementoCb.TabIndex = 3;
            this.btn_vizualizarElementoCb.Text = "Vizualizar Elemento";
            this.btn_vizualizarElementoCb.UseVisualStyleBackColor = true;
            this.btn_vizualizarElementoCb.Click += new System.EventHandler(this.btn_vizualizarElementoCb_Click);
            // 
            // btn_resetarCb
            // 
            this.btn_resetarCb.Location = new System.Drawing.Point(204, 99);
            this.btn_resetarCb.Name = "btn_resetarCb";
            this.btn_resetarCb.Size = new System.Drawing.Size(179, 23);
            this.btn_resetarCb.TabIndex = 4;
            this.btn_resetarCb.Text = "Resetar ComboBox";
            this.btn_resetarCb.UseVisualStyleBackColor = true;
            this.btn_resetarCb.Click += new System.EventHandler(this.btn_resetarCb_Click);
            // 
            // btn_limparCb
            // 
            this.btn_limparCb.Location = new System.Drawing.Point(204, 128);
            this.btn_limparCb.Name = "btn_limparCb";
            this.btn_limparCb.Size = new System.Drawing.Size(179, 23);
            this.btn_limparCb.TabIndex = 5;
            this.btn_limparCb.Text = "Limpar";
            this.btn_limparCb.UseVisualStyleBackColor = true;
            this.btn_limparCb.Click += new System.EventHandler(this.btn_limparCb_Click);
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(395, 258);
            this.Controls.Add(this.btn_limparCb);
            this.Controls.Add(this.btn_resetarCb);
            this.Controls.Add(this.btn_vizualizarElementoCb);
            this.Controls.Add(this.btn_adicionarItemCb);
            this.Controls.Add(this.tb_ItemCb);
            this.Controls.Add(this.cb_ItemCb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox";
            this.Load += new System.EventHandler(this.F_ComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cb_ItemCb;
        private TextBox tb_ItemCb;
        private Button btn_adicionarItemCb;
        private Button btn_vizualizarElementoCb;
        private Button btn_resetarCb;
        private Button btn_limparCb;
    }
}