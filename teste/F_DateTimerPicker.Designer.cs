namespace teste
{
    partial class F_DateTimerPicker
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
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.btn_obterData = new System.Windows.Forms.Button();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.tb_mes = new System.Windows.Forms.TextBox();
            this.tb_dia = new System.Windows.Forms.TextBox();
            this.btn_setarData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(12, 36);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(312, 23);
            this.dtp_data.TabIndex = 0;
            // 
            // btn_obterData
            // 
            this.btn_obterData.Location = new System.Drawing.Point(330, 36);
            this.btn_obterData.Name = "btn_obterData";
            this.btn_obterData.Size = new System.Drawing.Size(178, 23);
            this.btn_obterData.TabIndex = 1;
            this.btn_obterData.Text = "Obter Data";
            this.btn_obterData.UseVisualStyleBackColor = true;
            this.btn_obterData.Click += new System.EventHandler(this.btn_obterData_Click);
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(12, 65);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(312, 23);
            this.tb_data.TabIndex = 2;
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(224, 94);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(100, 23);
            this.tb_ano.TabIndex = 3;
            // 
            // tb_mes
            // 
            this.tb_mes.Location = new System.Drawing.Point(118, 94);
            this.tb_mes.Name = "tb_mes";
            this.tb_mes.Size = new System.Drawing.Size(100, 23);
            this.tb_mes.TabIndex = 4;
            // 
            // tb_dia
            // 
            this.tb_dia.Location = new System.Drawing.Point(12, 94);
            this.tb_dia.Name = "tb_dia";
            this.tb_dia.Size = new System.Drawing.Size(100, 23);
            this.tb_dia.TabIndex = 5;
            // 
            // btn_setarData
            // 
            this.btn_setarData.Location = new System.Drawing.Point(330, 94);
            this.btn_setarData.Name = "btn_setarData";
            this.btn_setarData.Size = new System.Drawing.Size(178, 23);
            this.btn_setarData.TabIndex = 9;
            this.btn_setarData.Text = "Setar Data";
            this.btn_setarData.UseVisualStyleBackColor = true;
            this.btn_setarData.Click += new System.EventHandler(this.btn_setarData_Click);
            // 
            // F_DateTimerPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.btn_setarData);
            this.Controls.Add(this.tb_dia);
            this.Controls.Add(this.tb_mes);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.btn_obterData);
            this.Controls.Add(this.dtp_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_DateTimerPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateTimerPicker";
            this.Load += new System.EventHandler(this.F_DateTimerPicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtp_data;
        private Button btn_obterData;
        private TextBox tb_data;
        private TextBox tb_ano;
        private TextBox tb_mes;
        private TextBox tb_dia;
        private Button btn_setarData;
    }
}