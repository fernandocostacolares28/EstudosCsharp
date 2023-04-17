namespace teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text == "")
            {
                MessageBox.Show("Campo nome vazio");
                tb_nome.Focus();
                return;
            }
            tb_listaNomes.Text += tb_nome.Text + "\r\n";
            tb_nome.Clear();
            tb_nome.Focus();
        }

        private void btn_mostrarLista_Click(object sender, EventArgs e)
        {
            F_ListaNomes f_ListaNomes = new F_ListaNomes(tb_listaNomes.Text);
            f_ListaNomes.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_listaNomes.Clear();
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox= new F_CheckBox();
            f_CheckBox.ShowDialog();
        }

        private void checkListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox= new F_CheckedListBox();
            f_CheckedListBox.ShowDialog();
        }

        private void componentesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_ComboBox f_ComboBox = new F_ComboBox();
            f_ComboBox.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimerPicker f_DateTimerPicker = new F_DateTimerPicker();
            f_DateTimerPicker.ShowDialog();
        }
    }
}