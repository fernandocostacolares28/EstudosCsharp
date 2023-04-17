namespace teste
{
    partial class F_LinkLabel
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
            lb_linkRepositorio = new LinkLabel();
            SuspendLayout();
            // 
            // lb_linkRepositorio
            // 
            lb_linkRepositorio.AutoSize = true;
            lb_linkRepositorio.Location = new Point(115, 52);
            lb_linkRepositorio.Name = "lb_linkRepositorio";
            lb_linkRepositorio.Size = new Size(67, 15);
            lb_linkRepositorio.TabIndex = 0;
            lb_linkRepositorio.TabStop = true;
            lb_linkRepositorio.Text = "Repositório";
            lb_linkRepositorio.LinkClicked += lb_linkRepositorio_LinkClicked;
            // 
            // F_LinkLabel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_linkRepositorio);
            Name = "F_LinkLabel";
            Text = "LinkLabel";
            Load += F_LinkLabel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lb_linkRepositorio;
    }
}