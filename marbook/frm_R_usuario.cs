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
    public partial class frm_R_usuario : Form
    {
        public frm_R_usuario()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo1.jpg");
            this.BackgroundImage = img;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu Menu = new menu();
            Menu.Show();
        }

        private void btnGuardar(object sender, EventArgs e)
        {
            MessageBox.Show("EL USUARIO HA SIDO GUARDADO CORRECTAMENTE");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Hide();
            nuevo_Usuario Nuevo_usuario = new nuevo_Usuario();
            Nuevo_usuario.Show();
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu Menu = new menu();
            Menu.Show();
        }
    }
}
