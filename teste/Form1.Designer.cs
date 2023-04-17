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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 32);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(14, 56);
            tb_nome.Margin = new Padding(3, 4, 3, 4);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(245, 27);
            tb_nome.TabIndex = 1;
            // 
            // btn_Salvar
            // 
            btn_Salvar.Location = new Point(266, 55);
            btn_Salvar.Margin = new Padding(3, 4, 3, 4);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(86, 31);
            btn_Salvar.TabIndex = 2;
            btn_Salvar.Text = "Salvar";
            btn_Salvar.UseVisualStyleBackColor = true;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // tb_listaNomes
            // 
            tb_listaNomes.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tb_listaNomes.Location = new Point(14, 93);
            tb_listaNomes.Margin = new Padding(3, 4, 3, 4);
            tb_listaNomes.Multiline = true;
            tb_listaNomes.Name = "tb_listaNomes";
            tb_listaNomes.ReadOnly = true;
            tb_listaNomes.Size = new Size(338, 397);
            tb_listaNomes.TabIndex = 3;
            // 
            // btn_mostrarLista
            // 
            btn_mostrarLista.Location = new Point(14, 555);
            btn_mostrarLista.Margin = new Padding(3, 4, 3, 4);
            btn_mostrarLista.Name = "btn_mostrarLista";
            btn_mostrarLista.Size = new Size(338, 31);
            btn_mostrarLista.TabIndex = 4;
            btn_mostrarLista.Text = "Lista";
            btn_mostrarLista.UseVisualStyleBackColor = true;
            btn_mostrarLista.Click += btn_mostrarLista_Click;
            // 
            // btn_LimparLista
            // 
            btn_LimparLista.Location = new Point(14, 520);
            btn_LimparLista.Margin = new Padding(3, 4, 3, 4);
            btn_LimparLista.Name = "btn_LimparLista";
            btn_LimparLista.Size = new Size(338, 31);
            btn_LimparLista.TabIndex = 5;
            btn_LimparLista.Text = "Limpar";
            btn_LimparLista.UseVisualStyleBackColor = true;
            btn_LimparLista.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { componentesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(368, 30);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            componentesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkBoxToolStripMenuItem, checkListBoxToolStripMenuItem, componentesToolStripMenuItem1, dateTimePickerToolStripMenuItem, linkLinkLabelToolStripMenuItem });
            componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            componentesToolStripMenuItem.Size = new Size(115, 24);
            componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkBoxToolStripMenuItem
            // 
            checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            checkBoxToolStripMenuItem.Size = new Size(224, 26);
            checkBoxToolStripMenuItem.Text = "Check Box";
            checkBoxToolStripMenuItem.Click += checkBoxToolStripMenuItem_Click;
            // 
            // checkListBoxToolStripMenuItem
            // 
            checkListBoxToolStripMenuItem.Name = "checkListBoxToolStripMenuItem";
            checkListBoxToolStripMenuItem.Size = new Size(224, 26);
            checkListBoxToolStripMenuItem.Text = "Checked List Box";
            checkListBoxToolStripMenuItem.Click += checkListBoxToolStripMenuItem_Click;
            // 
            // componentesToolStripMenuItem1
            // 
            componentesToolStripMenuItem1.Name = "componentesToolStripMenuItem1";
            componentesToolStripMenuItem1.Size = new Size(224, 26);
            componentesToolStripMenuItem1.Text = "Combo Box";
            componentesToolStripMenuItem1.Click += componentesToolStripMenuItem1_Click;
            // 
            // dateTimePickerToolStripMenuItem
            // 
            dateTimePickerToolStripMenuItem.Name = "dateTimePickerToolStripMenuItem";
            dateTimePickerToolStripMenuItem.Size = new Size(224, 26);
            dateTimePickerToolStripMenuItem.Text = "Date Time Picker";
            dateTimePickerToolStripMenuItem.Click += dateTimePickerToolStripMenuItem_Click;
            // 
            // linkLinkLabelToolStripMenuItem
            // 
            linkLinkLabelToolStripMenuItem.Name = "linkLinkLabelToolStripMenuItem";
            linkLinkLabelToolStripMenuItem.Size = new Size(224, 26);
            linkLinkLabelToolStripMenuItem.Text = "Link\\LinkLabel";
            linkLinkLabelToolStripMenuItem.Click += linkLinkLabelToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(368, 601);
            Controls.Add(btn_LimparLista);
            Controls.Add(btn_mostrarLista);
            Controls.Add(tb_listaNomes);
            Controls.Add(btn_Salvar);
            Controls.Add(tb_nome);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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
    }
}