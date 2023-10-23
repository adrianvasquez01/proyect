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
    public partial class frm_Registro_Libro : Form
    {
        public frm_Registro_Libro()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo1.jpg");
            this.BackgroundImage = img;
        }

        private void frm_Registro_Libro_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu Menu = new menu();
            Menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
