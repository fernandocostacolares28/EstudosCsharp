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
            label1 = new Label();
            tb_nome = new TextBox();
            btn_Salvar = new Button();
            tb_listaNomes = new TextBox();
            btn_mostrarLista = new Button();
            btn_LimparLista = new Button();
            menuStrip1 = new MenuStrip();
            componentesToolStripMenuItem = new ToolStripMenuItem();
            checkBoxToolStripMenuItem = new ToolStripMenuItem();
            checkListBoxToolStripMenuItem = new ToolStripMenuItem();
            componentesToolStripMenuItem1 = new ToolStripMenuItem();
            dateTimePickerToolStripMenuItem = new ToolStripMenuItem();
            linkLinkLabelToolStripMenuItem = new ToolStripMenuItem();
            listBoxToolStripMenuItem = new ToolStripMenuItem();
            nãoSeiToolStripMenuItem = new ToolStripMenuItem();
            listViewToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(12, 42);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(215, 23);
            tb_nome.TabIndex = 1;
            // 
            // btn_Salvar
            // 
            btn_Salvar.Location = new Point(233, 41);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(75, 23);
            btn_Salvar.TabIndex = 2;
            btn_Salvar.Text = "Salvar";
            btn_Salvar.UseVisualStyleBackColor = true;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // tb_listaNomes
            // 
            tb_listaNomes.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tb_listaNomes.Location = new Point(12, 70);
            tb_listaNomes.Multiline = true;
            tb_listaNomes.Name = "tb_listaNomes";
            tb_listaNomes.ReadOnly = true;
            tb_listaNomes.Size = new Size(296, 299);
            tb_listaNomes.TabIndex = 3;
            // 
            // btn_mostrarLista
            // 
            btn_mostrarLista.Location = new Point(12, 416);
            btn_mostrarLista.Name = "btn_mostrarLista";
            btn_mostrarLista.Size = new Size(296, 23);
            btn_mostrarLista.TabIndex = 4;
            btn_mostrarLista.Text = "Lista";
            btn_mostrarLista.UseVisualStyleBackColor = true;
            btn_mostrarLista.Click += btn_mostrarLista_Click;
            // 
            // btn_LimparLista
            // 
            btn_LimparLista.Location = new Point(12, 390);
            btn_LimparLista.Name = "btn_LimparLista";
            btn_LimparLista.Size = new Size(296, 23);
            btn_LimparLista.TabIndex = 5;
            btn_LimparLista.Text = "Limpar";
            btn_LimparLista.UseVisualStyleBackColor = true;
            btn_LimparLista.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { componentesToolStripMenuItem, nãoSeiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(322, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            componentesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkBoxToolStripMenuItem, checkListBoxToolStripMenuItem, componentesToolStripMenuItem1, dateTimePickerToolStripMenuItem, linkLinkLabelToolStripMenuItem, listBoxToolStripMenuItem, listViewToolStripMenuItem });
            componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            componentesToolStripMenuItem.Size = new Size(94, 20);
            componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkBoxToolStripMenuItem
            // 
            checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            checkBoxToolStripMenuItem.Size = new Size(180, 22);
            checkBoxToolStripMenuItem.Text = "Check Box";
            checkBoxToolStripMenuItem.Click += checkBoxToolStripMenuItem_Click;
            // 
            // checkListBoxToolStripMenuItem
            // 
            checkListBoxToolStripMenuItem.Name = "checkListBoxToolStripMenuItem";
            checkListBoxToolStripMenuItem.Size = new Size(180, 22);
            checkListBoxToolStripMenuItem.Text = "Checked List Box";
            checkListBoxToolStripMenuItem.Click += checkListBoxToolStripMenuItem_Click;
            // 
            // componentesToolStripMenuItem1
            // 
            componentesToolStripMenuItem1.Name = "componentesToolStripMenuItem1";
            componentesToolStripMenuItem1.Size = new Size(180, 22);
            componentesToolStripMenuItem1.Text = "Combo Box";
            componentesToolStripMenuItem1.Click += componentesToolStripMenuItem1_Click;
            // 
            // dateTimePickerToolStripMenuItem
            // 
            dateTimePickerToolStripMenuItem.Name = "dateTimePickerToolStripMenuItem";
            dateTimePickerToolStripMenuItem.Size = new Size(180, 22);
            dateTimePickerToolStripMenuItem.Text = "Date Time Picker";
            dateTimePickerToolStripMenuItem.Click += dateTimePickerToolStripMenuItem_Click;
            // 
            // linkLinkLabelToolStripMenuItem
            // 
            linkLinkLabelToolStripMenuItem.Name = "linkLinkLabelToolStripMenuItem";
            linkLinkLabelToolStripMenuItem.Size = new Size(180, 22);
            linkLinkLabelToolStripMenuItem.Text = "Link\\LinkLabel";
            linkLinkLabelToolStripMenuItem.Click += linkLinkLabelToolStripMenuItem_Click;
            // 
            // listBoxToolStripMenuItem
            // 
            listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            listBoxToolStripMenuItem.Size = new Size(180, 22);
            listBoxToolStripMenuItem.Text = "List Box";
            listBoxToolStripMenuItem.Click += listBoxToolStripMenuItem_Click;
            // 
            // nãoSeiToolStripMenuItem
            // 
            nãoSeiToolStripMenuItem.Name = "nãoSeiToolStripMenuItem";
            nãoSeiToolStripMenuItem.Size = new Size(59, 20);
            nãoSeiToolStripMenuItem.Text = "Não Sei";
            // 
            // listViewToolStripMenuItem
            // 
            listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            listViewToolStripMenuItem.Size = new Size(180, 22);
            listViewToolStripMenuItem.Text = "List View";
            listViewToolStripMenuItem.Click += listViewToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(322, 451);
            Controls.Add(btn_LimparLista);
            Controls.Add(btn_mostrarLista);
            Controls.Add(tb_listaNomes);
            Controls.Add(btn_Salvar);
            Controls.Add(tb_nome);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private ToolStripMenuItem linkLinkLabelToolStripMenuItem;
        private ToolStripMenuItem listBoxToolStripMenuItem;
        private ToolStripMenuItem nãoSeiToolStripMenuItem;
        private ToolStripMenuItem listViewToolStripMenuItem;
    }
}