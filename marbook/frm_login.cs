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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo1.jpg");
            this.BackgroundImage = img;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_Usuario.Text == "admin" && txt_Contraseña.Text == "1234") {
                this.Hide();
                menu Menu = new menu();
                Menu.Show();

            }
            else
            {
                this.DialogResult = DialogResult.OK;
                txt_Usuario.Clear();
                txt_Contraseña.Clear();               
       
            }
            
        }

        
    }
}
