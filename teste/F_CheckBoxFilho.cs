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
    public partial class F_CheckBoxFilho : Form
    {
        public F_CheckBox fcb;
        public F_CheckBoxFilho()
        {
            InitializeComponent();
            fcb = Application.OpenForms["F_CheckBox"] as F_CheckBox;
            cb_Carro.Checked = fcb.cb_Carro.Checked;
            cb_Aviao.Checked = fcb.cb_Aviao.Checked;
            cb_Navio.Checked = fcb.cb_Navio.Checked;
            cb_Onibus.Checked = fcb.cb_Onibus.Checked;
        }
    }
}
