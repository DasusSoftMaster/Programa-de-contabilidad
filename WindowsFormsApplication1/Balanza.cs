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

    public partial class Balanza : Form
    {

        public Balanza()
        {
            InitializeComponent();
            this.Hide();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void button1_Click(object sender, EventArgs e)
        {
          

                if (textBox26.Text == "")
                {
                    textBox26.Text = Convert.ToString(0);
                }
                if (textBox25.Text == "")
                {
                    textBox25.Text = Convert.ToString(0);
                }
                if (textBox24.Text == "")
                {
                    textBox24.Text = Convert.ToString(0);
                }
                if (textBox23.Text == "")
                {
                    textBox23.Text = Convert.ToString(0);
                }
                if (textBox22.Text == "")
                {
                    textBox22.Text = Convert.ToString(0);
                }
                if (textBox21.Text == "")
                {
                    textBox21.Text = Convert.ToString(0);
                }
                if (textBox20.Text == "")
                {
                    textBox20.Text = Convert.ToString(0);
                }
                if (textBox19.Text == "")
                {
                    textBox19.Text = Convert.ToString(0);
                }
                if (textBox18.Text == "")
                {
                    textBox18.Text = Convert.ToString(0);
                }
                if (textBox17.Text == "")
                {
                    textBox17.Text = Convert.ToString(0);
                }
                if (textBox16.Text == "")
                {
                    textBox16.Text = Convert.ToString(0);
                }
                if (textBox15.Text == "")
                {
                    textBox15.Text = Convert.ToString(0);
                }
                if (textBox14.Text == "")
                {
                    textBox14.Text = Convert.ToString(0);
                }
                if (textBox39.Text == "")
                {
                    textBox39.Text = Convert.ToString(0);
                }
                if (textBox38.Text == "")
                {
                    textBox38.Text = Convert.ToString(0);
                }
                if (textBox37.Text == "")
                {
                    textBox37.Text = Convert.ToString(0);
                }
                if (textBox36.Text == "")
                {
                    textBox36.Text = Convert.ToString(0);
                }
                if (textBox35.Text == "")
                {
                    textBox35.Text = Convert.ToString(0);
                }
                if (textBox34.Text == "")
                {
                    textBox34.Text = Convert.ToString(0);
                }
                if (textBox33.Text == "")
                {
                    textBox33.Text = Convert.ToString(0);
                }
                if (textBox32.Text == "")
                {
                    textBox32.Text = Convert.ToString(0);
                }
                if (textBox31.Text == "")
                {
                    textBox31.Text = Convert.ToString(0);
                }
                if (textBox30.Text == "")
                {
                    textBox30.Text = Convert.ToString(0);
                }
                if (textBox29.Text == "")
                {
                    textBox29.Text = Convert.ToString(0);
                }
                if (textBox28.Text == "")
                {
                    textBox28.Text = Convert.ToString(0);
                }
                if (textBox27.Text == "")
                {
                    textBox27.Text = Convert.ToString(0);
                }

                int a, b, c;
                a = int.Parse(textBox26.Text);
                b = int.Parse(textBox39.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox52.Text = c.ToString();
                    textBox65.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox52.Text = c.ToString();
                    textBox65.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox65.Text = c.ToString();
                    textBox52.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox52.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox65.Text = c.ToString();
                            }
                        }

                    }

                }

                a = int.Parse(textBox25.Text);
                b = int.Parse(textBox38.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox51.Text = c.ToString();
                    textBox64.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox51.Text = c.ToString();
                    textBox64.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox51.Text = Convert.ToString(0);
                    textBox64.Text = c.ToString();
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox51.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox64.Text = c.ToString();
                            }
                        }

                    }

                }

                a = int.Parse(textBox24.Text);
                b = int.Parse(textBox37.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox50.Text = c.ToString();
                    textBox63.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox50.Text = c.ToString();
                    textBox63.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox63.Text = c.ToString();
                    textBox50.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox50.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox63.Text = c.ToString();
                            }
                        }

                    }

                }

                a = int.Parse(textBox23.Text);
                b = int.Parse(textBox36.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox49.Text = c.ToString();
                    textBox62.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox49.Text = c.ToString();
                    textBox62.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox62.Text = c.ToString();
                    textBox49.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox49.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox62.Text = c.ToString();
                            }
                        }

                    }

                }

                a = int.Parse(textBox22.Text);
                b = int.Parse(textBox35.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox48.Text = c.ToString();
                    textBox61.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox48.Text = c.ToString();
                    textBox61.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox61.Text = c.ToString();
                    textBox48.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox48.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox61.Text = c.ToString();
                            }
                        }

                    }

                }

                a = int.Parse(textBox21.Text);
                b = int.Parse(textBox34.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox47.Text = c.ToString();
                    textBox60.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox47.Text = c.ToString();
                    textBox60.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox60.Text = c.ToString();
                    textBox47.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox49.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox60.Text = c.ToString();
                            }
                        }

                    }

                }
                a = int.Parse(textBox20.Text);
                b = int.Parse(textBox33.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox46.Text = c.ToString();
                    textBox59.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox46.Text = c.ToString();
                    textBox59.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox59.Text = c.ToString();
                    textBox46.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox48.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox59.Text = c.ToString();
                            }
                        }

                    }

                }

                a = int.Parse(textBox19.Text);
                b = int.Parse(textBox32.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox45.Text = c.ToString();
                    textBox58.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox45.Text = c.ToString();
                    textBox58.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox58.Text = c.ToString();
                    textBox45.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox49.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox58.Text = c.ToString();
                            }
                        }

                    }

                }


                a = int.Parse(textBox18.Text);
                b = int.Parse(textBox31.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox44.Text = c.ToString();
                    textBox57.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox44.Text = c.ToString();
                    textBox57.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox57.Text = c.ToString();
                    textBox44.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox48.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox57.Text = c.ToString();
                            }
                        }

                    }

                }
                a = int.Parse(textBox17.Text);
                b = int.Parse(textBox30.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox43.Text = c.ToString();
                    textBox56.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox43.Text = c.ToString();
                    textBox56.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox56.Text = c.ToString();
                    textBox43.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox47.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox56.Text = c.ToString();
                            }
                        }

                    }

                }

                a = int.Parse(textBox16.Text);
                b = int.Parse(textBox29.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox42.Text = c.ToString();
                    textBox55.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox42.Text = c.ToString();
                    textBox55.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox55.Text = c.ToString();
                    textBox42.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox46.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox55.Text = c.ToString();
                            }
                        }

                    }

                }
                a = int.Parse(textBox15.Text);
                b = int.Parse(textBox28.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox41.Text = c.ToString();
                    textBox54.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox41.Text = c.ToString();
                    textBox54.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox54.Text = c.ToString();
                    textBox41.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox41.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox54.Text = c.ToString();
                            }
                        }

                    }

                }
                a = int.Parse(textBox14.Text);
                b = int.Parse(textBox27.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox40.Text = c.ToString();
                    textBox53.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox40.Text = c.ToString();
                    textBox53.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox53.Text = c.ToString();
                    textBox40.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox40.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox53.Text = c.ToString();
                            }
                        }

                    }

                }

            }
            
        

        private void button2_Click(object sender, EventArgs e)
        {

            int a, b, c, d, p, f, g, h, i, j, k, l, m, res;

            a = Convert.ToInt32(textBox26.Text);
            b = Convert.ToInt32(textBox25.Text);
            c = Convert.ToInt32(textBox24.Text);
            d = Convert.ToInt32(textBox23.Text);
            p = Convert.ToInt32(textBox22.Text);
            f = Convert.ToInt32(textBox21.Text);
            g = Convert.ToInt32(textBox20.Text);
            h = Convert.ToInt32(textBox19.Text);
            i = Convert.ToInt32(textBox18.Text);
            j = Convert.ToInt32(textBox17.Text);
            k = Convert.ToInt32(textBox16.Text);
            l = Convert.ToInt32(textBox15.Text);
            m = Convert.ToInt32(textBox14.Text);
            res = a + b + c + d + p + f + g + h + i + j + k + l + m;
            textBox71.Text = res.ToString();


            a = Convert.ToInt32(textBox39.Text);
            b = Convert.ToInt32(textBox38.Text);
            c = Convert.ToInt32(textBox37.Text);
            d = Convert.ToInt32(textBox36.Text);
            p = Convert.ToInt32(textBox35.Text);
            f = Convert.ToInt32(textBox34.Text);
            g = Convert.ToInt32(textBox33.Text);
            h = Convert.ToInt32(textBox32.Text);
            i = Convert.ToInt32(textBox31.Text);
            j = Convert.ToInt32(textBox30.Text);
            k = Convert.ToInt32(textBox29.Text);
            l = Convert.ToInt32(textBox28.Text);
            m = Convert.ToInt32(textBox27.Text);
            res = a + b + c + d + p + f + g + h + i + j + k + l + m;
            textBox70.Text = res.ToString();


            a = Convert.ToInt32(textBox52.Text);
            b = Convert.ToInt32(textBox51.Text);
            c = Convert.ToInt32(textBox50.Text);
            d = Convert.ToInt32(textBox49.Text);
            p = Convert.ToInt32(textBox48.Text);
            f = Convert.ToInt32(textBox47.Text);
            g = Convert.ToInt32(textBox46.Text);
            h = Convert.ToInt32(textBox45.Text);
            i = Convert.ToInt32(textBox44.Text);
            j = Convert.ToInt32(textBox43.Text);
            k = Convert.ToInt32(textBox42.Text);
            l = Convert.ToInt32(textBox41.Text);
            m = Convert.ToInt32(textBox40.Text);
            res = a + b + c + d + p + f + g + h + i + j + k + l + m;
            textBox69.Text = res.ToString();


            a = Convert.ToInt32(textBox65.Text);
            b = Convert.ToInt32(textBox64.Text);
            c = Convert.ToInt32(textBox63.Text);
            d = Convert.ToInt32(textBox62.Text);
            p = Convert.ToInt32(textBox61.Text);
            f = Convert.ToInt32(textBox60.Text);
            g = Convert.ToInt32(textBox59.Text);
            h = Convert.ToInt32(textBox58.Text);
            i = Convert.ToInt32(textBox57.Text);
            j = Convert.ToInt32(textBox56.Text);
            k = Convert.ToInt32(textBox55.Text);
            l = Convert.ToInt32(textBox54.Text);
            m = Convert.ToInt32(textBox53.Text);
            res = a + b + c + d + p + f + g + h + i + j + k + l + m;
            textBox68.Text = res.ToString();
        }

        private void Balanza_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void mostrarBotonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void utlidadOPérdidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {


                if (textBox26.Text == "")
                {
                    textBox26.Text = Convert.ToString(0);
                }
                if (textBox25.Text == "")
                {
                    textBox25.Text = Convert.ToString(0);
                }
                if (textBox24.Text == "")
                {
                    textBox24.Text = Convert.ToString(0);
                }
                if (textBox23.Text == "")
                {
                    textBox23.Text = Convert.ToString(0);
                }
                if (textBox22.Text == "")
                {
                    textBox22.Text = Convert.ToString(0);
                }
                if (textBox21.Text == "")
                {
                    textBox21.Text = Convert.ToString(0);
                }
                if (textBox20.Text == "")
                {
                    textBox20.Text = Convert.ToString(0);
                }
                if (textBox19.Text == "")
                {
                    textBox19.Text = Convert.ToString(0);
                }
                if (textBox18.Text == "")
                {
                    textBox18.Text = Convert.ToString(0);
                }
                if (textBox17.Text == "")
                {
                    textBox17.Text = Convert.ToString(0);
                }
                if (textBox16.Text == "")
                {
                    textBox16.Text = Convert.ToString(0);
                }
                if (textBox15.Text == "")
                {
                    textBox15.Text = Convert.ToString(0);
                }
                if (textBox14.Text == "")
                {
                    textBox14.Text = Convert.ToString(0);
                }
                if (textBox39.Text == "")
                {
                    textBox39.Text = Convert.ToString(0);
                }
                if (textBox38.Text == "")
                {
                    textBox38.Text = Convert.ToString(0);
                }
                if (textBox37.Text == "")
                {
                    textBox37.Text = Convert.ToString(0);
                }
                if (textBox36.Text == "")
                {
                    textBox36.Text = Convert.ToString(0);
                }
                if (textBox35.Text == "")
                {
                    textBox35.Text = Convert.ToString(0);
                }
                if (textBox34.Text == "")
                {
                    textBox34.Text = Convert.ToString(0);
                }
                if (textBox33.Text == "")
                {
                    textBox33.Text = Convert.ToString(0);
                }
                if (textBox32.Text == "")
                {
                    textBox32.Text = Convert.ToString(0);
                }
                if (textBox31.Text == "")
                {
                    textBox31.Text = Convert.ToString(0);
                }
                if (textBox30.Text == "")
                {
                    textBox30.Text = Convert.ToString(0);
                }
                if (textBox29.Text == "")
                {
                    textBox29.Text = Convert.ToString(0);
                }
                if (textBox28.Text == "")
                {
                    textBox28.Text = Convert.ToString(0);
                }
                if (textBox27.Text == "")
                {
                    textBox27.Text = Convert.ToString(0);
                }

                int a, b, c;
                a = int.Parse(textBox26.Text);
                b = int.Parse(textBox39.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox52.Text = c.ToString();
                    textBox65.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox52.Text = c.ToString();
                    textBox65.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox65.Text = c.ToString();
                    textBox52.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox52.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox65.Text = c.ToString();
                            }
                        }

                    }

                }

                a = int.Parse(textBox25.Text);
                b = int.Parse(textBox38.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox51.Text = c.ToString();
                    textBox64.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox51.Text = c.ToString();
                    textBox64.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox51.Text = Convert.ToString(0);
                    textBox64.Text = c.ToString();
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox51.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox64.Text = c.ToString();
                            }
                        }

                    }

                }

                a = int.Parse(textBox24.Text);
                b = int.Parse(textBox37.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox50.Text = c.ToString();
                    textBox63.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox50.Text = c.ToString();
                    textBox63.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox63.Text = c.ToString();
                    textBox50.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox50.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox63.Text = c.ToString();
                            }
                        }

                    }

                }

                a = int.Parse(textBox23.Text);
                b = int.Parse(textBox36.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox49.Text = c.ToString();
                    textBox62.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox49.Text = c.ToString();
                    textBox62.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox62.Text = c.ToString();
                    textBox49.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox49.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox62.Text = c.ToString();
                            }
                        }

                    }

                }

                a = int.Parse(textBox22.Text);
                b = int.Parse(textBox35.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox48.Text = c.ToString();
                    textBox61.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox48.Text = c.ToString();
                    textBox61.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox61.Text = c.ToString();
                    textBox48.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox48.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox61.Text = c.ToString();
                            }
                        }

                    }

                }

                a = int.Parse(textBox21.Text);
                b = int.Parse(textBox34.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox47.Text = c.ToString();
                    textBox60.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox47.Text = c.ToString();
                    textBox60.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox60.Text = c.ToString();
                    textBox47.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox49.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox60.Text = c.ToString();
                            }
                        }

                    }

                }
                a = int.Parse(textBox20.Text);
                b = int.Parse(textBox33.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox46.Text = c.ToString();
                    textBox59.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox46.Text = c.ToString();
                    textBox59.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox59.Text = c.ToString();
                    textBox46.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox48.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox59.Text = c.ToString();
                            }
                        }

                    }

                }

                a = int.Parse(textBox19.Text);
                b = int.Parse(textBox32.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox45.Text = c.ToString();
                    textBox58.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox45.Text = c.ToString();
                    textBox58.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox58.Text = c.ToString();
                    textBox45.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox49.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox58.Text = c.ToString();
                            }
                        }

                    }

                }


                a = int.Parse(textBox18.Text);
                b = int.Parse(textBox31.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox44.Text = c.ToString();
                    textBox57.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox44.Text = c.ToString();
                    textBox57.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox57.Text = c.ToString();
                    textBox44.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox48.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox57.Text = c.ToString();
                            }
                        }

                    }

                }
                a = int.Parse(textBox17.Text);
                b = int.Parse(textBox30.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox43.Text = c.ToString();
                    textBox56.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox43.Text = c.ToString();
                    textBox56.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox56.Text = c.ToString();
                    textBox43.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox47.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox56.Text = c.ToString();
                            }
                        }

                    }

                }

                a = int.Parse(textBox16.Text);
                b = int.Parse(textBox29.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox42.Text = c.ToString();
                    textBox55.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox42.Text = c.ToString();
                    textBox55.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox55.Text = c.ToString();
                    textBox42.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox46.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox55.Text = c.ToString();
                            }
                        }

                    }

                }
                a = int.Parse(textBox15.Text);
                b = int.Parse(textBox28.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox41.Text = c.ToString();
                    textBox54.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox41.Text = c.ToString();
                    textBox54.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox54.Text = c.ToString();
                    textBox41.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox41.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox54.Text = c.ToString();
                            }
                        }

                    }

                }
                a = int.Parse(textBox14.Text);
                b = int.Parse(textBox27.Text);

                if (a > b)
                {
                    c = a - b;
                    textBox40.Text = c.ToString();
                    textBox53.Text = Convert.ToString(0);
                }
                else
                    if (a == 0 && b == 0)
                {
                    c = 0;
                    textBox40.Text = c.ToString();
                    textBox53.Text = c.ToString();
                }
                else
                    if (b > a)
                {
                    c = b - a;
                    textBox53.Text = c.ToString();
                    textBox40.Text = Convert.ToString(0);
                }
                else
                {
                    if (b == 0)
                    {
                        c = a;
                        textBox40.Text = c.ToString();
                    }
                    else
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                c = b;
                                textBox53.Text = c.ToString();
                            }
                        }

                    }

                }

            }
            catch (FormatException)
            {

                MessageBox.Show("Formato no valido");
            }
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int a, b, c, d, p, f, g, h, i, j, k, l, m, res;

            a = Convert.ToInt32(textBox26.Text);
            b = Convert.ToInt32(textBox25.Text);
            c = Convert.ToInt32(textBox24.Text);
            d = Convert.ToInt32(textBox23.Text);
            p = Convert.ToInt32(textBox22.Text);
            f = Convert.ToInt32(textBox21.Text);
            g = Convert.ToInt32(textBox20.Text);
            h = Convert.ToInt32(textBox19.Text);
            i = Convert.ToInt32(textBox18.Text);
            j = Convert.ToInt32(textBox17.Text);
            k = Convert.ToInt32(textBox16.Text);
            l = Convert.ToInt32(textBox15.Text);
            m = Convert.ToInt32(textBox14.Text);
            res = a + b + c + d + p + f + g + h + i + j + k + l + m;
            textBox71.Text = res.ToString();
           

            a = Convert.ToInt32(textBox39.Text);
            b = Convert.ToInt32(textBox38.Text);
            c = Convert.ToInt32(textBox37.Text);
            d = Convert.ToInt32(textBox36.Text);
            p = Convert.ToInt32(textBox35.Text);
            f = Convert.ToInt32(textBox34.Text);
            g = Convert.ToInt32(textBox33.Text);
            h = Convert.ToInt32(textBox32.Text);
            i = Convert.ToInt32(textBox31.Text);
            j = Convert.ToInt32(textBox30.Text);
            k = Convert.ToInt32(textBox29.Text);
            l = Convert.ToInt32(textBox28.Text);
            m = Convert.ToInt32(textBox27.Text);
            res = a + b + c + d + p + f + g + h + i + j + k + l + m;
            textBox70.Text = res.ToString();


            a = Convert.ToInt32(textBox52.Text);
            b = Convert.ToInt32(textBox51.Text);
            c = Convert.ToInt32(textBox50.Text);
            d = Convert.ToInt32(textBox49.Text);
            p = Convert.ToInt32(textBox48.Text);
            f = Convert.ToInt32(textBox47.Text);
            g = Convert.ToInt32(textBox46.Text);
            h = Convert.ToInt32(textBox45.Text);
            i = Convert.ToInt32(textBox44.Text);
            j = Convert.ToInt32(textBox43.Text);
            k = Convert.ToInt32(textBox42.Text);
            l = Convert.ToInt32(textBox41.Text);
            m = Convert.ToInt32(textBox40.Text);
            res = a + b + c + d + p + f + g + h + i + j + k + l + m;
            textBox69.Text = res.ToString();


            a = Convert.ToInt32(textBox65.Text);
            b = Convert.ToInt32(textBox64.Text);
            c = Convert.ToInt32(textBox63.Text);
            d = Convert.ToInt32(textBox62.Text);
            p = Convert.ToInt32(textBox61.Text);
            f = Convert.ToInt32(textBox60.Text);
            g = Convert.ToInt32(textBox59.Text);
            h = Convert.ToInt32(textBox58.Text);
            i = Convert.ToInt32(textBox57.Text);
            j = Convert.ToInt32(textBox56.Text);
            k = Convert.ToInt32(textBox55.Text);
            l = Convert.ToInt32(textBox54.Text);
            m = Convert.ToInt32(textBox53.Text);
            res = a + b + c + d + p + f + g + h + i + j + k + l + m;
            textBox68.Text = res.ToString();
        }
    

        private void limpiarFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textCu1.Text = ""; textBox31.Text = ""; textBox61.Text = "";
            textBox2.Text = ""; textBox32.Text = ""; textBox62.Text = "";
            textBox3.Text = ""; textBox33.Text = ""; textBox63.Text = "";
            textBox4.Text = ""; textBox34.Text = ""; textBox64.Text = "";
            textBox5.Text = ""; textBox35.Text = ""; textBox65.Text = "";
            textBox6.Text = ""; textBox36.Text = "";
            textBox7.Text = ""; textBox37.Text = ""; 
            textBox8.Text = ""; textBox38.Text = ""; textBox68.Text = "";
            textBox9.Text = ""; textBox39.Text = ""; textBox69.Text = "";
            textBox10.Text = ""; textBox40.Text = ""; textBox70.Text = "";
            textBox11.Text = ""; textBox41.Text = ""; textBox71.Text = "";
            textBox12.Text = ""; textBox42.Text = ""; 
            textBox13.Text = ""; textBox43.Text = ""; 
            textBox14.Text = ""; textBox44.Text = "";
            textBox15.Text = ""; textBox45.Text = "";
            textBox16.Text = ""; textBox46.Text = "";
            textBox17.Text = ""; textBox47.Text = "";
            textBox18.Text = ""; textBox48.Text = "";
            textBox19.Text = ""; textBox49.Text = "";
            textBox20.Text = ""; textBox50.Text = "";
            textBox21.Text = ""; textBox51.Text = "";
            textBox22.Text = ""; textBox52.Text = "";
            textBox23.Text = ""; textBox53.Text = "";
            textBox24.Text = ""; textBox54.Text = "";
            textBox25.Text = ""; textBox55.Text = "";
            textBox26.Text = ""; textBox56.Text = "";
            textBox27.Text = ""; textBox57.Text = "";
            textBox28.Text = ""; textBox58.Text = "";
            textBox29.Text = ""; textBox59.Text = "";
            textBox30.Text = ""; textBox60.Text = "";

        }

        private void nuevoFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Balanza b = new Balanza();
            b.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void ocultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    }
    


