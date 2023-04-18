using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
        }

        private void F_LinkLabel_Load(object sender, EventArgs e)
        {

        }

        private void lb_linkRepositorio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Program Files/Google/Chrome/Application/chrome.exe", "https://github.com/fernandocostacolares28/EstudosCsharp");
        }

        private void lb_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void lb_multiplos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
