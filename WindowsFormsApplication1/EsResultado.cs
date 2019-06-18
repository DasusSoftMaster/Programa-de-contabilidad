using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class EsResultado : Form
    {
        public EsResultado()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Show();
            textBox5.Show();
            textBox9.Show();
            textBox56.Show();
            textBox57.Show();
            textBox58.Show();
            textBox60.Show();
            textBox61.Show();
            int a, b, c;

            a = int.Parse(textBox2.Text);
            b = int.Parse(textBox4.Text);
            c = a + b;
            textBox3.Text = c.ToString();

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox3.Text);
            c = a - b;
            textBox5.Text = c.ToString();

            a = int.Parse(textBox7.Text);
            b = int.Parse(textBox8.Text);
            c = a + b;
            textBox9.Text = c.ToString();

            a = int.Parse(textBox10.Text);
            b = int.Parse(textBox11.Text);
            c = a + b;
            textBox56.Text = c.ToString();

            a = int.Parse(textBox9.Text);
            b = int.Parse(textBox56.Text);
            c = a - b;
            textBox57.Text = c.ToString();

            a = int.Parse(textBox6.Text);
            b = int.Parse(textBox57.Text);
            c = a + b;
            textBox58.Text = c.ToString();

            a = int.Parse(textBox58.Text);
            b = int.Parse(textBox59.Text);
            c = a - b;
            textBox60.Text = c.ToString();

            a = int.Parse(textBox5.Text);
            b = int.Parse(textBox60.Text);
            if (a > b)
            {
                c = a - b;
                textBox61.Text = c.ToString();
                textBox22.Text = "Utilidad Bruta";
            }
            else
            {
                if (b > a)
                {
                    c = b - a;
                    textBox61.Text = c.ToString();
                    textBox22.Text = "Perdida Bruta";
                }
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*int a1, b1, c1, d1, e1, f1, g1;
            a1 = int.Parse(textBox64.Text);
            b1 = int.Parse(textBox63.Text);
            c1 = int.Parse(textBox62.Text);
            d1 = int.Parse(textBox13.Text);
            e1 = int.Parse(textBox12.Text);
            f1 = int.Parse(textBox14.Text);
            g1 = a1 + b1 + c1 + d1 + e1 + f1;
            textBox19.Text = g1.ToString();

            a1 = int.Parse(textBox18.Text);
            b1 = int.Parse(textBox17.Text);
            c1 = int.Parse(textBox16.Text);
            d1 = int.Parse(textBox15.Text);
            e1 = a1 + b1 + c1 + d1;
            textBox20.Text = e1.ToString();

            a1 = int.Parse(textBox19.Text);
            b1 = int.Parse(textBox20.Text);
            c1 = a1 + b1;
            textBox21.Text = c1.ToString();*/
        }



        private void EsResultado_Load(object sender, EventArgs e)
        {

            textBox3.Hide();
            textBox5.Hide();
            textBox9.Hide();
            textBox56.Hide();
            textBox57.Hide();
            textBox58.Hide();
            textBox60.Hide();
            textBox61.Hide();
        }

        private void utlidadOPérdidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Show();
            textBox5.Show();
            textBox9.Show();
            textBox56.Show();
            textBox57.Show();
            textBox58.Show();
            textBox60.Show();
            textBox61.Show();

            if (textBox1.Text=="")
            {
                MessageBox.Show("INGRESE LAS VENTAS");
                textBox1.Text = 0.ToString();
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("INGRESE LAS DEV. SOBRE VENTAS");
                textBox2.Text = 0.ToString();
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("INGRESE LOS DES. SOBRE VENTAS");
                textBox4.Text = 0.ToString();
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("INGRESE EL INVENTARIO INICIAL");
                textBox6.Text = 0.ToString();
            }
            if (textBox7.Text == "")
            {
                MessageBox.Show("INGRESE LAS COMPRAS");
                textBox7.Text = 0.ToString();
            }
            if (textBox8.Text == "")
            {
                MessageBox.Show("INGRESE LOS GASTOS DE COMPRA");
                textBox8.Text = 0.ToString();
            }

            if (textBox10.Text == "")
            {
                MessageBox.Show("INGRESE LAS DEV. SOBRE COMPRAS");
                textBox10.Text = 0.ToString();
            }
            if (textBox11.Text == "")
            {
                MessageBox.Show("INGRESE LOS DES. SOBRE COMPRAS");
                textBox11.Text = 0.ToString();
            }
            if (textBox59.Text == "")
            {
                MessageBox.Show("INGRESE EL INVENTARIO FINAL");
                textBox59.Text = 0.ToString();
            }
            int a, b, c;

            a = int.Parse(textBox2.Text);
            b = int.Parse(textBox4.Text);
            c = a + b;
            textBox3.Text = c.ToString();

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox3.Text);
            c = a - b;
            textBox5.Text = c.ToString();

            a = int.Parse(textBox7.Text);
            b = int.Parse(textBox8.Text);
            c = a + b;
            textBox9.Text = c.ToString();

            a = int.Parse(textBox10.Text);
            b = int.Parse(textBox11.Text);
            c = a + b;
            textBox56.Text = c.ToString();

            a = int.Parse(textBox9.Text);
            b = int.Parse(textBox56.Text);
            c = a - b;
            textBox57.Text = c.ToString();

            a = int.Parse(textBox6.Text);
            b = int.Parse(textBox57.Text);
            c = a + b;
            textBox58.Text = c.ToString();

            a = int.Parse(textBox58.Text);
            b = int.Parse(textBox59.Text);
            c = a - b;
            textBox60.Text = c.ToString();

            a = int.Parse(textBox5.Text);
            b = int.Parse(textBox60.Text);
            if (a > b)
            {
                c = a - b;
                textBox61.Text = c.ToString();
                textBox22.Text = "Utilidad Bruta";
            }
            else
            {
                if (b > a)
                {
                    c = b - a;
                    textBox61.Text = c.ToString();
                    textBox22.Text = "Perdida Bruta";
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox3.Hide();
            textBox5.Hide();
            textBox9.Hide();
            textBox56.Hide();
            textBox57.Hide();
            textBox58.Hide();
            textBox60.Hide();
            textBox61.Hide();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox59.Text = "";

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EsResultado es = new EsResultado();
            es.Show();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //private void EsResultado_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(this.Handle, 0x112, 0xf012, 0);
        //}

        private void menuStrip2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       
    }
}
