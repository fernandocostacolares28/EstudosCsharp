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
    public partial class F_ListaNomes : Form
    {
        public F_ListaNomes(String v)
        {
            InitializeComponent();
            tb_ListaNomesForm.Text = v;

        }
    }
}
