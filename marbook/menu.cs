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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo1.jpg");
            this.BackgroundImage = img;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            frm_R_usuario Registro_usuario= new frm_R_usuario();  
            Registro_usuario.Show();
        }

        private void btn_Libros_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Registro_Libro Registro_libro = new frm_Registro_Libro();
            Registro_libro.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prestamos prestamos = new Prestamos();
            prestamos.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
