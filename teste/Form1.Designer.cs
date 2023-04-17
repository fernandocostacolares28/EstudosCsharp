namespace teste
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.tb_listaNomes = new System.Windows.Forms.TextBox();
            this.btn_mostrarLista = new System.Windows.Forms.Button();
            this.btn_LimparLista = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(12, 42);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(215, 23);
            this.tb_nome.TabIndex = 1;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(233, 41);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 2;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // tb_listaNomes
            // 
            this.tb_listaNomes.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_listaNomes.Location = new System.Drawing.Point(12, 70);
            this.tb_listaNomes.Multiline = true;
            this.tb_listaNomes.Name = "tb_listaNomes";
            this.tb_listaNomes.ReadOnly = true;
            this.tb_listaNomes.Size = new System.Drawing.Size(296, 299);
            this.tb_listaNomes.TabIndex = 3;
            // 
            // btn_mostrarLista
            // 
            this.btn_mostrarLista.Location = new System.Drawing.Point(12, 416);
            this.btn_mostrarLista.Name = "btn_mostrarLista";
            this.btn_mostrarLista.Size = new System.Drawing.Size(296, 23);
            this.btn_mostrarLista.TabIndex = 4;
            this.btn_mostrarLista.Text = "Lista";
            this.btn_mostrarLista.UseVisualStyleBackColor = true;
            this.btn_mostrarLista.Click += new System.EventHandler(this.btn_mostrarLista_Click);
            // 
            // btn_LimparLista
            // 
            this.btn_LimparLista.Location = new System.Drawing.Point(12, 390);
            this.btn_LimparLista.Name = "btn_LimparLista";
            this.btn_LimparLista.Size = new System.Drawing.Size(296, 23);
            this.btn_LimparLista.TabIndex = 5;
            this.btn_LimparLista.Text = "Limpar";
            this.btn_LimparLista.UseVisualStyleBackColor = true;
            this.btn_LimparLista.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(322, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem,
            this.checkListBoxToolStripMenuItem,
            this.componentesToolStripMenuItem1,
            this.dateTimePickerToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkBoxToolStripMenuItem.Text = "Check Box";
            this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.checkBoxToolStripMenuItem_Click);
            // 
            // checkListBoxToolStripMenuItem
            // 
            this.checkListBoxToolStripMenuItem.Name = "checkListBoxToolStripMenuItem";
            this.checkListBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkListBoxToolStripMenuItem.Text = "Checked List Box";
            this.checkListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkListBoxToolStripMenuItem_Click);
            // 
            // componentesToolStripMenuItem1
            // 
            this.componentesToolStripMenuItem1.Name = "componentesToolStripMenuItem1";
            this.componentesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.componentesToolStripMenuItem1.Text = "Combo Box";
            this.componentesToolStripMenuItem1.Click += new System.EventHandler(this.componentesToolStripMenuItem1_Click);
            // 
            // dateTimePickerToolStripMenuItem
            // 
            this.dateTimePickerToolStripMenuItem.Name = "dateTimePickerToolStripMenuItem";
            this.dateTimePickerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dateTimePickerToolStripMenuItem.Text = "Date Time Picker";
            this.dateTimePickerToolStripMenuItem.Click += new System.EventHandler(this.dateTimePickerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(322, 451);
            this.Controls.Add(this.btn_LimparLista);
            this.Controls.Add(this.btn_mostrarLista);
            this.Controls.Add(this.tb_listaNomes);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_nome;
        private Button btn_Salvar;
        private TextBox tb_listaNomes;
        private Button btn_mostrarLista;
        private Button btn_LimparLista;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem componentesToolStripMenuItem;
        private ToolStripMenuItem checkBoxToolStripMenuItem;
        private ToolStripMenuItem checkListBoxToolStripMenuItem;
        private ToolStripMenuItem componentesToolStripMenuItem1;
        private ToolStripMenuItem dateTimePickerToolStripMenuItem;
    }
}