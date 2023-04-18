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
            lb_calculadora = new LinkLabel();
            lb_multiplos = new LinkLabel();
            SuspendLayout();
            // 
            // lb_linkRepositorio
            // 
            lb_linkRepositorio.AutoSize = true;
            lb_linkRepositorio.LinkBehavior = LinkBehavior.HoverUnderline;
            lb_linkRepositorio.Location = new Point(115, 52);
            lb_linkRepositorio.Name = "lb_linkRepositorio";
            lb_linkRepositorio.Size = new Size(67, 15);
            lb_linkRepositorio.TabIndex = 0;
            lb_linkRepositorio.TabStop = true;
            lb_linkRepositorio.Text = "Repositório";
            lb_linkRepositorio.LinkClicked += lb_linkRepositorio_LinkClicked;
            // 
            // lb_calculadora
            // 
            lb_calculadora.AutoSize = true;
            lb_calculadora.Location = new Point(244, 52);
            lb_calculadora.Name = "lb_calculadora";
            lb_calculadora.Size = new Size(70, 15);
            lb_calculadora.TabIndex = 1;
            lb_calculadora.TabStop = true;
            lb_calculadora.Text = "Calculadora";
            lb_calculadora.LinkClicked += lb_calculadora_LinkClicked;
            // 
            // lb_multiplos
            // 
            lb_multiplos.AutoSize = true;
            lb_multiplos.LinkVisited = true;
            lb_multiplos.Location = new Point(184, 128);
            lb_multiplos.Name = "lb_multiplos";
            lb_multiplos.Size = new Size(57, 15);
            lb_multiplos.TabIndex = 2;
            lb_multiplos.TabStop = true;
            lb_multiplos.Text = "Multiplos";
            lb_multiplos.LinkClicked += lb_multiplos_LinkClicked;
            // 
            // F_LinkLabel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_multiplos);
            Controls.Add(lb_calculadora);
            Controls.Add(lb_linkRepositorio);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "F_LinkLabel";
            Text = "LinkLabel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lb_linkRepositorio;
        private LinkLabel lb_calculadora;
        private LinkLabel lb_multiplos;
    }
}