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
    public partial class EsMayor : Form
    {
        public EsMayor()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button1_Click(object sender, EventArgs e)
        {
            
            int a, b, c, d, f, g, h, j;

            
            if (textBox2.Text == "")
            {
               
                textBox2.Text = 0.ToString();
                
            }
            a = int.Parse(textBox2.Text);
           
            if (textBox5.Text == "")
            {
                textBox5.Text = 0.ToString();
            }
            b = int.Parse(textBox5.Text);
            
            if (textBox7.Text == "")
            {
                textBox7.Text = 0.ToString();
            }
            c = int.Parse(textBox7.Text);
            
            if (textBox9.Text == "")
            {
                textBox9.Text = 0.ToString();
            }
            d = int.Parse(textBox9.Text);
            
            if (textBox11.Text == "")
            {
                textBox11.Text = 0.ToString();
            }
            f = int.Parse(textBox11.Text);
            
            if (textBox13.Text == "")
            {
                textBox13.Text = 0.ToString();
            }
            g = int.Parse(textBox13.Text);
            
            if (textBox17.Text == "")
            {
                textBox17.Text = 0.ToString();
            }
            h = int.Parse(textBox17.Text);
            j = a + b + c + d + f + g + h;
            textBox15.Text = j.ToString();

            
            if (textBox3.Text == "")
            {
                textBox3.Text = 0.ToString();
            }
            a = int.Parse(textBox3.Text);
            
            if (textBox4.Text == "")
            {
                textBox4.Text = 0.ToString();
            }
            b = int.Parse(textBox4.Text);
            
            if (textBox6.Text == "")
            {
                textBox6.Text = 0.ToString();
            }
            c = int.Parse(textBox6.Text);
           
            if (textBox8.Text == "")
            {
                textBox8.Text = 0.ToString();
            }
            d = int.Parse(textBox8.Text);
            
            if (textBox10.Text == "")
            {
                textBox10.Text = 0.ToString();
            }
            f = int.Parse(textBox10.Text);
            
            if (textBox12.Text == "")
            {
                textBox12.Text = 0.ToString();
            }
            g = int.Parse(textBox12.Text);
            
            if (textBox16.Text == "")
            {
                textBox16.Text = 0.ToString();
            }
            h = int.Parse(textBox16.Text);
            j = a + b + c + d + f + g + h;
            textBox14.Text = j.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, c, d, f, g, h, j;

            a = int.Parse(textBox33.Text);
            b = int.Parse(textBox31.Text);
            c = int.Parse(textBox29.Text);
            d = int.Parse(textBox27.Text);
            f = int.Parse(textBox25.Text);
            g = int.Parse(textBox23.Text);
            h = int.Parse(textBox21.Text);
            j = a + b + c + d + f + g + h;
            textBox19.Text = j.ToString();

            a = int.Parse(textBox32.Text);
            b = int.Parse(textBox30.Text);
            c = int.Parse(textBox28.Text);
            d = int.Parse(textBox26.Text);
            f = int.Parse(textBox24.Text);
            g = int.Parse(textBox22.Text);
            h = int.Parse(textBox20.Text);
            j = a + b + c + d + f + g + h;
            textBox18.Text = j.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, c, d, f, g, h, j;

            a = int.Parse(textBox50.Text);
            b = int.Parse(textBox48.Text);
            c = int.Parse(textBox46.Text);
            d = int.Parse(textBox44.Text);
            f = int.Parse(textBox42.Text);
            g = int.Parse(textBox40.Text);
            h = int.Parse(textBox38.Text);
            j = a + b + c + d + f + g + h;
            textBox36.Text = j.ToString();

            a = int.Parse(textBox49.Text);
            b = int.Parse(textBox47.Text);
            c = int.Parse(textBox45.Text);
            d = int.Parse(textBox43.Text);
            f = int.Parse(textBox41.Text);
            g = int.Parse(textBox39.Text);
            h = int.Parse(textBox37.Text);
            j = a + b + c + d + f + g + h;
            textBox35.Text = j.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
           // this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a, b, c, d, f, g, h, j;

            a = int.Parse(textBox89.Text);
            b = int.Parse(textBox91.Text);
            c = int.Parse(textBox93.Text);
            d = int.Parse(textBox95.Text);
            f = int.Parse(textBox97.Text);
            g = int.Parse(textBox99.Text);
            h = int.Parse(textBox101.Text);
            j = a + b + c + d + f + g + h;
            textBox15.Text = j.ToString();
            a = int.Parse(textBox88.Text);
            b = int.Parse(textBox90.Text);
            c = int.Parse(textBox92.Text);
            d = int.Parse(textBox94.Text);
            f = int.Parse(textBox96.Text);
            g = int.Parse(textBox98.Text);
            h = int.Parse(textBox100.Text);
            j = a + b + c + d + f + g + h;
            textBox14.Text = j.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a, b, c, d, f, g, h, j;

            a = int.Parse(textBox72.Text);
            b = int.Parse(textBox74.Text);
            c = int.Parse(textBox76.Text);
            d = int.Parse(textBox78.Text);
            f = int.Parse(textBox80.Text);
            g = int.Parse(textBox82.Text);
            h = int.Parse(textBox84.Text);
            j = a + b + c + d + f + g + h;
            textBox70.Text = j.ToString();
            a = int.Parse(textBox71.Text);
            b = int.Parse(textBox73.Text);
            c = int.Parse(textBox75.Text);
            d = int.Parse(textBox77.Text);
            f = int.Parse(textBox79.Text);
            g = int.Parse(textBox81.Text);
            h = int.Parse(textBox83.Text);
            j = a + b + c + d + f + g + h;
            textBox69.Text = j.ToString();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a, b, c, d, f, g, h, j;

            a = int.Parse(textBox55.Text);
            b = int.Parse(textBox57.Text);
            c = int.Parse(textBox59.Text);
            d = int.Parse(textBox61.Text);
            f = int.Parse(textBox63.Text);
            g = int.Parse(textBox65.Text);
            h = int.Parse(textBox67.Text);
            j = a + b + c + d + f + g + h;
            textBox53.Text = j.ToString();
            a = int.Parse(textBox54.Text);
            b = int.Parse(textBox56.Text);
            c = int.Parse(textBox58.Text);
            d = int.Parse(textBox60.Text);
            f = int.Parse(textBox62.Text);
            g = int.Parse(textBox64.Text);
            h = int.Parse(textBox66.Text);
            j = a + b + c + d + f + g + h;
            textBox52.Text = j.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a, b, c, d, f, g, h, j;

            a = int.Parse(textBox140.Text);
            b = int.Parse(textBox142.Text);
            c = int.Parse(textBox144.Text);
            d = int.Parse(textBox146.Text);
            f = int.Parse(textBox148.Text);
            g = int.Parse(textBox150.Text);
            h = int.Parse(textBox152.Text);
            j = a + b + c + d + f + g + h;
            textBox138.Text = j.ToString();

            a = int.Parse(textBox139.Text);
            b = int.Parse(textBox141.Text);
            c = int.Parse(textBox143.Text);
            d = int.Parse(textBox145.Text);
            f = int.Parse(textBox147.Text);
            g = int.Parse(textBox149.Text);
            h = int.Parse(textBox151.Text);
            j = a + b + c + d + f + g + h;
            textBox137.Text = j.ToString();
        }

        private void balanzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Balanza en = new Balanza();
            en.textCu1.Text = textBox1.Text;
            en.textBox2.Text = textBox34.Text;
            en.textBox3.Text = textBox51.Text;
            en.textBox4.Text = textBox102.Text;


            en.textBox26.Text = textBox15.Text;
            en.textBox39.Text = textBox14.Text;
            en.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EsMayor es = new EsMayor();
            es.Show();
        }
    }
    }


