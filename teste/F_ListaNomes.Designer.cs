namespace teste
{
    partial class F_ListaNomes
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
            this.tb_ListaNomesForm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_ListaNomesForm
            // 
            this.tb_ListaNomesForm.Location = new System.Drawing.Point(12, 12);
            this.tb_ListaNomesForm.Multiline = true;
            this.tb_ListaNomesForm.Name = "tb_ListaNomesForm";
            this.tb_ListaNomesForm.ReadOnly = true;
            this.tb_ListaNomesForm.Size = new System.Drawing.Size(383, 377);
            this.tb_ListaNomesForm.TabIndex = 0;
            // 
            // F_ListaNomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(409, 399);
            this.Controls.Add(this.tb_ListaNomesForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_ListaNomes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Nomes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_ListaNomesForm;
    }
}