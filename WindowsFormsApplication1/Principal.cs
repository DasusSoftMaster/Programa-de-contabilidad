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
    public partial class Principal : Form
    {
        ///int a = 0;
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Balanza B = new Balanza();
            B.Show();
           // this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EsResultado ER = new EsResultado();
            ER.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EsMayor es = new EsMayor();
            es.Show ();
            //this.Hide();
        }

      
        private void estadoDeResultadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EsResultado ER = new EsResultado();
            ER.ShowDialog();
        }

        private void esquemaDeMayorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EsMayor es = new EsMayor();
            es.ShowDialog();
        }

        private void estadoDeResultadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Balanza B = new Balanza();
            B.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

             if (MessageBox.Show("Estas seguro que desea Salir", "◄ AVISO | Tecnologico ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pROMEDIOPONDERADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Promedio p = new Promedio();
            p.ShowDialog();
        }

        private void uEPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UEPS us = new UEPS();
            us.ShowDialog();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
