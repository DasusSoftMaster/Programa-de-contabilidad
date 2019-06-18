using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Inicio : Form
    {
        int c = 0;
        public Inicio()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        { 

            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Asegúrese de ingresar el Usuario");
                textBox1.Focus();
            }
            else if (textBox2.Text.Trim()=="")
            {
                MessageBox.Show("Asegúrese de ingresar la Contraseña");
                textBox2.Focus();
            }
            else
            {
                MessageBox.Show(">Bienvenido<");
                Principal f = new Principal();
                f.Show();
                this.Hide();

               
            }
            c = c + 1;
            if (c == 3)
            {
                MessageBox.Show("ERROR");
                c = 0;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
          {
              this.Close();

          }
      
        private void btnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("ESTA SEGURO DE SALIR", "◄ AVISO ►", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.unlock;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {           
            pictureBox2.BackgroundImage = Properties.Resources._lock;
        }

       
}
    }

