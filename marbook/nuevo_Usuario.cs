using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marbook
{
    public partial class nuevo_Usuario : Form
    {
        public nuevo_Usuario()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_R_usuario usuario = new frm_R_usuario();
            usuario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
