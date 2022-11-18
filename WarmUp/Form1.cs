using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarmUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ok(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("Faltan datos");
            }
            else
            {
                if (Regex.IsMatch(txtPwd.Text, "/^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[$@$!%*?&])([A-Za-z\\d$@$!%*?&]|[^ ]){8,15}$/;"))
                {
                    MessageBox.Show("La contraseña ha sido validada");
                }
                else
                {
                    MessageBox.Show("Datos erroneos");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
