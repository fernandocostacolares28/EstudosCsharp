using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace teste
{
    public partial class F_CheckBox : Form
    {
        List<CheckBox> checkBoxes = new List<CheckBox>();
        public F_CheckBox()
        {
            InitializeComponent();
            checkBoxes.Add(cb_Carro);
            checkBoxes.Add(cb_Aviao);
            checkBoxes.Add(cb_Navio);
            checkBoxes.Add(cb_Onibus);
            
        }

        private void btn_Transportes_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach(CheckBox checkBox in checkBoxes)
            {
                if(checkBox.Checked)
                {
                    txt += checkBox.Text + "\r\n";
                }
            }
            MessageBox.Show(txt);
        }

        private void cb_Carro_CheckedChanged(object sender, EventArgs e)
        {
            //CheckBox clickedCheckBox = (CheckBox)sender;
            //if (clickedCheckBox.Checked) 
            //{
            //    foreach(CheckBox checkBox in checkBoxes)
            //    {
            //        if(checkBox != clickedCheckBox && checkBox.Checked)
            //        {
            //            cb_Carro.Checked = false;
            //        }
            //    }
            
            
            //}
            //CheckBox clickedCheckBox = (CheckBox)sender;
            
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox is CheckBox && checkBox != sender)
                {
                    ((CheckBox)checkBox).Checked = false;
                }
            }


            

        }

        private void cb_Aviao_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckBox = (CheckBox)sender;
            //if (clickedCheckBox.Checked)
            //{
            //    foreach (CheckBox checkBox in checkBoxes)
            //    {
            //        if (checkBox != clickedCheckBox && checkBox.Checked)
            //        {
            //            cb_Carro.Checked = false;
            //        }
            //    }


            //}
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox is CheckBox && checkBox != sender)
                {
                    ((CheckBox)checkBox).Checked = false;
                }
            }

        }

        private void cb_Navio_CheckedChanged(object sender, EventArgs e)
        {
            //CheckBox clickedCheckBox = (CheckBox)sender;
            //if (clickedCheckBox.Checked)
            //{
            //    foreach (CheckBox checkBox in checkBoxes)
            //    {
            //        if (checkBox != clickedCheckBox && checkBox.Checked)
            //        {
            //            cb_Carro.Checked = false;
            //        }
            //    }


            //}
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox is CheckBox && checkBox != sender)
                {
                    ((CheckBox)checkBox).Checked = false;
                }
            }

        }

        private void cb_Onibus_CheckedChanged(object sender, EventArgs e)
        {
            //CheckBox clickedCheckBox = (CheckBox)sender;
            //if (clickedCheckBox.Checked)
            //{
            //    foreach (CheckBox checkBox in checkBoxes)
            //    {
            //        if (checkBox != clickedCheckBox && checkBox.Checked)
            //        {
            //            cb_Carro.Checked = false;
            //        }
            //    }


            //}
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox is CheckBox && checkBox != sender)
                {
                    ((CheckBox)checkBox).Checked = false;
                }
            }

        }

        private void btn_Form_Click(object sender, EventArgs e)
        {
            F_CheckBoxFilho f_CheckBoxFilho = new F_CheckBoxFilho();
            f_CheckBoxFilho.ShowDialog();
        }
    }
}
