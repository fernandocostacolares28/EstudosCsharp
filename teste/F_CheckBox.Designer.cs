namespace teste
{
    partial class F_CheckBox
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
            this.cb_Carro = new System.Windows.Forms.CheckBox();
            this.cb_Aviao = new System.Windows.Forms.CheckBox();
            this.cb_Navio = new System.Windows.Forms.CheckBox();
            this.cb_Onibus = new System.Windows.Forms.CheckBox();
            this.btn_Transportes = new System.Windows.Forms.Button();
            this.btn_Form = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Carro
            // 
            this.cb_Carro.AutoSize = true;
            this.cb_Carro.Location = new System.Drawing.Point(12, 12);
            this.cb_Carro.Name = "cb_Carro";
            this.cb_Carro.Size = new System.Drawing.Size(55, 19);
            this.cb_Carro.TabIndex = 0;
            this.cb_Carro.Text = "Carro";
            this.cb_Carro.UseVisualStyleBackColor = true;
            this.cb_Carro.CheckedChanged += new System.EventHandler(this.cb_Carro_CheckedChanged);
            // 
            // cb_Aviao
            // 
            this.cb_Aviao.AutoSize = true;
            this.cb_Aviao.Location = new System.Drawing.Point(12, 37);
            this.cb_Aviao.Name = "cb_Aviao";
            this.cb_Aviao.Size = new System.Drawing.Size(56, 19);
            this.cb_Aviao.TabIndex = 1;
            this.cb_Aviao.Text = "Avião";
            this.cb_Aviao.UseVisualStyleBackColor = true;
            this.cb_Aviao.CheckedChanged += new System.EventHandler(this.cb_Aviao_CheckedChanged);
            // 
            // cb_Navio
            // 
            this.cb_Navio.AutoSize = true;
            this.cb_Navio.Location = new System.Drawing.Point(12, 62);
            this.cb_Navio.Name = "cb_Navio";
            this.cb_Navio.Size = new System.Drawing.Size(57, 19);
            this.cb_Navio.TabIndex = 2;
            this.cb_Navio.Text = "Navio";
            this.cb_Navio.UseVisualStyleBackColor = true;
            this.cb_Navio.CheckedChanged += new System.EventHandler(this.cb_Navio_CheckedChanged);
            // 
            // cb_Onibus
            // 
            this.cb_Onibus.AutoSize = true;
            this.cb_Onibus.Location = new System.Drawing.Point(12, 87);
            this.cb_Onibus.Name = "cb_Onibus";
            this.cb_Onibus.Size = new System.Drawing.Size(64, 19);
            this.cb_Onibus.TabIndex = 3;
            this.cb_Onibus.Text = "Onibus";
            this.cb_Onibus.UseVisualStyleBackColor = true;
            this.cb_Onibus.CheckedChanged += new System.EventHandler(this.cb_Onibus_CheckedChanged);
            // 
            // btn_Transportes
            // 
            this.btn_Transportes.Location = new System.Drawing.Point(164, 12);
            this.btn_Transportes.Name = "btn_Transportes";
            this.btn_Transportes.Size = new System.Drawing.Size(171, 23);
            this.btn_Transportes.TabIndex = 4;
            this.btn_Transportes.Text = "Transportes";
            this.btn_Transportes.UseVisualStyleBackColor = true;
            this.btn_Transportes.Click += new System.EventHandler(this.btn_Transportes_Click);
            // 
            // btn_Form
            // 
            this.btn_Form.Location = new System.Drawing.Point(164, 53);
            this.btn_Form.Name = "btn_Form";
            this.btn_Form.Size = new System.Drawing.Size(171, 23);
            this.btn_Form.TabIndex = 5;
            this.btn_Form.Text = "Form";
            this.btn_Form.UseVisualStyleBackColor = true;
            this.btn_Form.Click += new System.EventHandler(this.btn_Form_Click);
            // 
            // F_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.btn_Form);
            this.Controls.Add(this.btn_Transportes);
            this.Controls.Add(this.cb_Onibus);
            this.Controls.Add(this.cb_Navio);
            this.Controls.Add(this.cb_Aviao);
            this.Controls.Add(this.cb_Carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_Transportes;
        public CheckBox cb_Carro;
        public CheckBox cb_Aviao;
        public CheckBox cb_Navio;
        public CheckBox cb_Onibus;
        private Button btn_Form;
    }
}