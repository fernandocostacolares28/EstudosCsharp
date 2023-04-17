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
            lb_linkRepositorio.Links.Add(0, 0, "https://github.com/fernandocostacolares28/EstudosCsharp");
        }
    }
}
