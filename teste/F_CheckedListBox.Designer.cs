namespace teste
{
    partial class F_CheckedListBox
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
            this.clb_transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_mostrarSelec = new System.Windows.Forms.Button();
            this.btn_limparLista = new System.Windows.Forms.Button();
            this.btn_resetLista = new System.Windows.Forms.Button();
            this.btn_novoTransporte = new System.Windows.Forms.Button();
            this.tb_novoTransporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_transportes
            // 
            this.clb_transportes.FormattingEnabled = true;
            this.clb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Onibus",
            "Trem"});
            this.clb_transportes.Location = new System.Drawing.Point(12, 12);
            this.clb_transportes.Name = "clb_transportes";
            this.clb_transportes.Size = new System.Drawing.Size(120, 166);
            this.clb_transportes.TabIndex = 0;
            // 
            // btn_mostrarSelec
            // 
            this.btn_mostrarSelec.Location = new System.Drawing.Point(150, 12);
            this.btn_mostrarSelec.Name = "btn_mostrarSelec";
            this.btn_mostrarSelec.Size = new System.Drawing.Size(191, 23);
            this.btn_mostrarSelec.TabIndex = 1;
            this.btn_mostrarSelec.Text = "Mostrar Selecionados";
            this.btn_mostrarSelec.UseVisualStyleBackColor = true;
            this.btn_mostrarSelec.Click += new System.EventHandler(this.btn_mostrarSelec_Click);
            // 
            // btn_limparLista
            // 
            this.btn_limparLista.Location = new System.Drawing.Point(150, 41);
            this.btn_limparLista.Name = "btn_limparLista";
            this.btn_limparLista.Size = new System.Drawing.Size(191, 23);
            this.btn_limparLista.TabIndex = 2;
            this.btn_limparLista.Text = "Limpar Lista";
            this.btn_limparLista.UseVisualStyleBackColor = true;
            this.btn_limparLista.Click += new System.EventHandler(this.btn_limparLista_Click);
            // 
            // btn_resetLista
            // 
            this.btn_resetLista.Location = new System.Drawing.Point(150, 70);
            this.btn_resetLista.Name = "btn_resetLista";
            this.btn_resetLista.Size = new System.Drawing.Size(191, 23);
            this.btn_resetLista.TabIndex = 3;
            this.btn_resetLista.Text = "Resetar Lista";
            this.btn_resetLista.UseVisualStyleBackColor = true;
            this.btn_resetLista.Click += new System.EventHandler(this.btn_resetLista_Click);
            // 
            // btn_novoTransporte
            // 
            this.btn_novoTransporte.Location = new System.Drawing.Point(12, 233);
            this.btn_novoTransporte.Name = "btn_novoTransporte";
            this.btn_novoTransporte.Size = new System.Drawing.Size(120, 23);
            this.btn_novoTransporte.TabIndex = 4;
            this.btn_novoTransporte.Text = "Salvar";
            this.btn_novoTransporte.UseVisualStyleBackColor = true;
            this.btn_novoTransporte.Click += new System.EventHandler(this.btn_novoTransporte_Click);
            // 
            // tb_novoTransporte
            // 
            this.tb_novoTransporte.Location = new System.Drawing.Point(12, 204);
            this.tb_novoTransporte.Name = "tb_novoTransporte";
            this.tb_novoTransporte.Size = new System.Drawing.Size(120, 23);
            this.tb_novoTransporte.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um Transporte";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(353, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_novoTransporte);
            this.Controls.Add(this.btn_novoTransporte);
            this.Controls.Add(this.btn_resetLista);
            this.Controls.Add(this.btn_limparLista);
            this.Controls.Add(this.btn_mostrarSelec);
            this.Controls.Add(this.clb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checked List Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox clb_transportes;
        private Button btn_mostrarSelec;
        private Button btn_limparLista;
        private Button btn_resetLista;
        private Button btn_novoTransporte;
        private TextBox tb_novoTransporte;
        private Label label1;
    }
}