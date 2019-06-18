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
    public partial class Promedio : Form
    {
        public Promedio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double en, sa, tot;

            exist1.Text = ent1.Text;

            if (ent2.Text == "")
            {
                ent2.Text = Convert.ToString(0);
            }
            if (sal2.Text == "")
            {
                sal2.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent2.Text);
            sa = Convert.ToDouble(sal2.Text);
            tot = (Convert.ToDouble(exist1.Text) + en) - sa;
            // exist2.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                exist2.Text = Convert.ToString(0);
            }
            else
            {
                exist2.Text = Convert.ToString(tot);
            }

            if (ent3.Text == "")
            {
                ent3.Text = Convert.ToString(0);
            }
            if (sal3.Text == "")
            {
                sal3.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent3.Text);
            sa = Convert.ToDouble(sal3.Text);
            tot = (Convert.ToDouble(exist2.Text) + en) - sa;
            //exist3.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                exist3.Text = Convert.ToString(0);
            }
            else
            {
                exist3.Text = Convert.ToString(tot);
            }



            if (ent4.Text == "")
            {
                ent4.Text = Convert.ToString(0);
            }
            if (sal4.Text == "")
            {
                sal4.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent4.Text);
            sa = Convert.ToDouble(sal4.Text);
            tot = (Convert.ToDouble(exist3.Text) + en) - sa;
            //exist4.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                exist4.Text = Convert.ToString(0);
            }
            else
            {
                exist4.Text = Convert.ToString(tot);
            }



            if (ent5.Text == "")
            {
                ent5.Text = Convert.ToString(0);
            }
            if (sal5.Text == "")
            {
                sal5.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent5.Text);
            sa = Convert.ToDouble(sal5.Text);
            tot = (Convert.ToDouble(exist4.Text) + en) - sa;
            // exist5.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                exist5.Text = Convert.ToString(0);
            }
            else
            {
                exist5.Text = Convert.ToString(tot);
            }


            if (ent6.Text == "")
            {
                ent6.Text = Convert.ToString(0);
            }
            if (sal6.Text == "")
            {
                sal6.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent6.Text);
            sa = Convert.ToDouble(sal6.Text);
            tot = (Convert.ToDouble(exist5.Text) + en) - sa;
            //exist6.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                exist6.Text = Convert.ToString(0);
            }
            else
            {
                exist6.Text = Convert.ToString(tot);
            }

            if (ent7.Text == "")
            {
                ent7.Text = Convert.ToString(0);
            }
            if (sal7.Text == "")
            {
                sal7.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent7.Text);
            sa = Convert.ToDouble(sal7.Text);
            tot = (Convert.ToDouble(exist6.Text) + en) - sa;
            // exist7.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                exist7.Text = Convert.ToString(0);
            }
            else
            {
                exist7.Text = Convert.ToString(tot);
            }

            if (ent8.Text == "")
            {
                ent8.Text = Convert.ToString(0);
            }
            if (sal8.Text == "")
            {
                sal8.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent8.Text);
            sa = Convert.ToDouble(sal8.Text);
            tot = (Convert.ToDouble(exist7.Text) + en) - sa;
            // exist7.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                exist8.Text = Convert.ToString(0);
            }
            else
            {
                exist8.Text = Convert.ToString(tot);
            }

            if (ent9.Text == "")
            {
                ent9.Text = Convert.ToString(0);
            }
            if (sal9.Text == "")
            {
                sal9.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent9.Text);
            sa = Convert.ToDouble(sal9.Text);
            tot = (Convert.ToDouble(exist8.Text) + en) - sa;
            // exist9.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                exist9.Text = Convert.ToString(0);
            }
            else
            {
                exist9.Text = Convert.ToString(tot);
            }

            if (ent10.Text == "")
            {
                ent10.Text = Convert.ToString(0);
            }
            if (sal10.Text == "")
            {
                sal10.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent10.Text);
            sa = Convert.ToDouble(sal10.Text);
            tot = (Convert.ToDouble(exist9.Text) + en) - sa;
            // exist10.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                exist10.Text = Convert.ToString(0);
            }
            else
            {
                exist10.Text = Convert.ToString(tot);
            }

            if (ent11.Text == "")
            {
                ent11.Text = Convert.ToString(0);
            }
            if (sal11.Text == "")
            {
                sal11.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent11.Text);
            sa = Convert.ToDouble(sal11.Text);
            tot = (Convert.ToDouble(exist10.Text) + en) - sa;
            // exist11.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                exist11.Text = Convert.ToString(0);
            }
            else
            {
                exist11.Text = Convert.ToString(tot);
            }

            if (ent12.Text == "")
            {
                ent12.Text = Convert.ToString(0);
            }
            if (sal12.Text == "")
            {
                sal12.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent12.Text);
            sa = Convert.ToDouble(sal12.Text);
            tot = (Convert.ToDouble(exist11.Text) + en) - sa;
            // exist12.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                exist12.Text = Convert.ToString(0);
            }
            else
            {
                exist12.Text = Convert.ToString(tot);
            }

            if (ent13.Text == "")
            {
                ent13.Text = Convert.ToString(0);
            }
            if (sal13.Text == "")
            {
                sal13.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent13.Text);
            sa = Convert.ToDouble(sal13.Text);
            tot = (Convert.ToDouble(exist12.Text) + en) - sa;
            // exist13.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                exist13.Text = Convert.ToString(0);
            }
            else
            {
                exist13.Text = Convert.ToString(tot);
            }
        }

        private void debe_Click(object sender, EventArgs e)
        {
            decimal debe, ent, pre;

            if (pre1.Text == "")
            {
                pre1.Text = Convert.ToString(0);
                MessageBox.Show("Asegurese de ingresar el precio por unidad");
            }
            ent = decimal.Parse(ent1.Text);
            pre = decimal.Parse(pre1.Text);
            debe = ent * pre;
            if (ent == 0 || pre == 0)
            {
                deb1.Text = Convert.ToString(0);
            }
            else
            {
                deb1.Text = Convert.ToString(debe);
            }
            //deb1.Text =Convert.ToString( debe);

            if (pre2.Text == "")
            {
                pre2.Text = Convert.ToString(0);
            }
            ent = decimal.Parse(ent2.Text);
            pre = decimal.Parse(pre2.Text);
            debe = ent * pre;
            if (ent == 0 || pre == 0)
            {
                deb2.Text = Convert.ToString(0);
            }
            else
            {
                deb2.Text = Convert.ToString(debe);
            }

            if (pre3.Text == "")
            {
                pre3.Text = Convert.ToString(0);
            }
            ent = decimal.Parse(ent3.Text);
            pre = decimal.Parse(pre3.Text);
            debe = ent * pre;

            if (ent == 0 || pre == 0)
            {
                deb3.Text = Convert.ToString(0);
            }
            else
            {
                deb3.Text = Convert.ToString(debe);
            }

            if (pre4.Text == "")
            {
                pre4.Text = Convert.ToString(0);
            }
            ent = decimal.Parse(ent4.Text);
            pre = decimal.Parse(pre4.Text);
            debe = ent * pre;
            if (ent == 0 || pre == 0)
            {
                deb4.Text = Convert.ToString(0);
            }
            else
            {
                deb4.Text = Convert.ToString(debe);
            }

            if (pre5.Text == "")
            {
                pre5.Text = Convert.ToString(0);
            }
            ent = decimal.Parse(ent5.Text);
            pre = decimal.Parse(pre5.Text);
            debe = ent * pre;
            if (ent == 0 || pre == 0)
            {
                deb5.Text = Convert.ToString(0);
            }
            else
            {
                deb5.Text = Convert.ToString(debe);
            }

            if (pre6.Text == "")
            {
                pre6.Text = Convert.ToString(0);
            }
            ent = decimal.Parse(ent6.Text);
            pre = decimal.Parse(pre6.Text);
            debe = ent * pre;
            if (ent == 0 || pre == 0)
            {
                deb6.Text = Convert.ToString(0);
            }
            else
            {
                deb6.Text = Convert.ToString(debe);
            }

            if (pre7.Text == "")
            {
                pre7.Text = Convert.ToString(0);
            }
            ent = decimal.Parse(ent7.Text);
            pre = decimal.Parse(pre7.Text);
            debe = ent * pre;
            if (ent == 0 || pre == 0)
            {
                deb7.Text = Convert.ToString(0);
            }
            else
            {
                deb7.Text = Convert.ToString(debe);
            }

            if (pre8.Text == "")
            {
                pre8.Text = Convert.ToString(0);
            }
            ent = decimal.Parse(ent8.Text);
            pre = decimal.Parse(pre8.Text);
            debe = ent * pre;
            if (ent == 0 || pre == 0)
            {
                deb8.Text = Convert.ToString(0);
            }
            else
            {
                deb8.Text = Convert.ToString(debe);
            }

            if (pre9.Text == "")
            {
                pre9.Text = Convert.ToString(0);
            }
            ent = decimal.Parse(ent9.Text);
            pre = decimal.Parse(pre9.Text);
            debe = ent * pre;
            if (ent == 0 || pre == 0)
            {
                deb9.Text = Convert.ToString(0);
            }
            else
            {
                deb9.Text = Convert.ToString(debe);
            }

            if (pre10.Text == "")
            {
                pre10.Text = Convert.ToString(0);
            }
            ent = decimal.Parse(ent10.Text);
            pre = decimal.Parse(pre10.Text);
            debe = ent * pre;
            if (ent == 0 || pre == 0)
            {
                deb10.Text = Convert.ToString(0);
            }
            else
            {
                deb10.Text = Convert.ToString(debe);
            }

            if (pre11.Text == "")
            {
                pre11.Text = Convert.ToString(0);
            }
            ent = decimal.Parse(ent11.Text);
            pre = decimal.Parse(pre11.Text);
            debe = ent * pre;
            if (ent == 0 || pre == 0)
            {
                deb11.Text = Convert.ToString(0);
            }
            else
            {
                deb11.Text = Convert.ToString(debe);
            }

            if (pre12.Text == "")
            {
                pre12.Text = Convert.ToString(0);
            }
            ent = decimal.Parse(ent12.Text);
            pre = decimal.Parse(pre12.Text);
            debe = ent * pre;
            if (ent == 0 || pre == 0)
            {
                deb12.Text = Convert.ToString(0);
            }
            else
            {
                deb12.Text = Convert.ToString(debe);
            }

            if (pre13.Text == "")
            {
                pre13.Text = Convert.ToString(0);
            }
            ent = decimal.Parse(ent13.Text);
            pre = decimal.Parse(pre13.Text);
            debe = ent * pre;
            if (ent == 0 || pre == 0)
            {
                deb13.Text = Convert.ToString(0);
            }
            else
            {
                deb13.Text = Convert.ToString(debe);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double haber, salida, pre;
            hab1.Text = Convert.ToString(0);
            /* if (pre1.Text == "")
             {
                 pre1.Text = Convert.ToString(0);
             }
             salida = double.Parse(sal1.Text);
             pre = double.Parse(pre1.Text);
             haber = salida * pre;
             if (salida == 0 || pre == 0)
             {
                 hab1.Text = Convert.ToString(0);
             }
             else
             {
                 hab1.Text = Convert.ToString(haber);
             }*/

            if (pre2.Text == "")
            {
                pre2.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal2.Text);
            pre = double.Parse(pre2.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab2.Text = Convert.ToString(0);
            }
            else
            {
                hab2.Text = Convert.ToString(haber);
            }

            if (pre3.Text == "")
            {
                pre3.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal3.Text);
            pre = double.Parse(pre3.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab3.Text = Convert.ToString(0);
            }
            else
            {
                hab3.Text = Convert.ToString(haber);
            }

            if (pre4.Text == "")
            {
                pre4.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal4.Text);
            pre = double.Parse(pre4.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab4.Text = Convert.ToString(0);
            }
            else
            {
                hab4.Text = Convert.ToString(haber);
            }

            if (pre5.Text == "")
            {
                pre5.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal5.Text);
            pre = double.Parse(pre5.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab5.Text = Convert.ToString(0);
            }
            else
            {
                hab5.Text = Convert.ToString(haber);
            }

            if (pre6.Text == "")
            {
                pre6.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal6.Text);
            pre = double.Parse(pre6.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab6.Text = Convert.ToString(0);
            }
            else
            {
                hab6.Text = Convert.ToString(haber);
            }

            if (pre7.Text == "")
            {
                pre7.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal7.Text);
            pre = double.Parse(pre7.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab7.Text = Convert.ToString(0);
            }
            else
            {
                hab7.Text = Convert.ToString(haber);
            }

            if (pre8.Text == "")
            {
                pre8.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal8.Text);
            pre = double.Parse(pre8.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab8.Text = Convert.ToString(0);
            }
            else
            {
                hab8.Text = Convert.ToString(haber);
            }

            if (pre9.Text == "")
            {
                pre9.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal9.Text);
            pre = double.Parse(pre9.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab9.Text = Convert.ToString(0);
            }
            else
            {
                hab9.Text = Convert.ToString(haber);
            }

            if (pre10.Text == "")
            {
                pre10.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal10.Text);
            pre = double.Parse(pre10.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab10.Text = Convert.ToString(0);
            }
            else
            {
                hab10.Text = Convert.ToString(haber);
            }

            if (pre11.Text == "")
            {
                pre11.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal11.Text);
            pre = double.Parse(pre11.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab11.Text = Convert.ToString(0);
            }
            else
            {
                hab11.Text = Convert.ToString(haber);
            }

            if (pre12.Text == "")
            {
                pre12.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal12.Text);
            pre = double.Parse(pre12.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab12.Text = Convert.ToString(0);
            }
            else
            {
                hab12.Text = Convert.ToString(haber);
            }

            if (pre13.Text == "")
            {
                pre13.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal13.Text);
            pre = double.Parse(pre13.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab13.Text = Convert.ToString(0);
            }
            else
            {
                hab13.Text = Convert.ToString(haber);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double saldo, sal, debe, haber;
            saldo1.Text = deb1.Text;

            sal = double.Parse(saldo1.Text);
            debe = double.Parse(deb2.Text);
            haber = double.Parse(hab2.Text);
            saldo = sal + debe - haber;
            if (debe == 0 && haber == 0)
            {
                saldo2.Text = Convert.ToString(0);
            }
            else
            {
                saldo2.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo2.Text);
            debe = double.Parse(deb3.Text);
            haber = double.Parse(hab3.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo1.Text) + debe - haber;
                saldo3.Text = Convert.ToString(saldo);
            }
            if (debe == 0 && haber == 0)
            {
                saldo3.Text = Convert.ToString(0);

            }
            else
            {
                saldo3.Text = Convert.ToString(saldo);
            }

            //gggggg
            sal = double.Parse(saldo3.Text);
            debe = double.Parse(deb4.Text);
            haber = double.Parse(hab4.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo2.Text) + debe - haber;
                saldo4.Text = Convert.ToString(saldo);
                if (double.Parse(saldo2.Text) == 0)
                {
                    saldo = double.Parse(saldo1.Text) + debe - haber;
                    saldo4.Text = Convert.ToString(saldo);
                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo4.Text = Convert.ToString(0);
            }
            else
            {
                saldo4.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo4.Text);
            debe = double.Parse(deb5.Text);
            haber = double.Parse(hab5.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo3.Text) + debe - haber;
                saldo5.Text = Convert.ToString(saldo);
                if (double.Parse(saldo3.Text) == 0)
                {
                    saldo = double.Parse(saldo2.Text) + debe - haber;
                    saldo5.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo2.Text) == 0)
                    {
                        saldo = double.Parse(saldo1.Text) + debe - haber;
                        saldo5.Text = Convert.ToString(saldo);
                    }
                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo5.Text = Convert.ToString(0);
            }
            else
            {
                saldo5.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo5.Text);
            debe = double.Parse(deb6.Text);
            haber = double.Parse(hab6.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo4.Text) + debe - haber;
                saldo6.Text = Convert.ToString(saldo);
                if (double.Parse(saldo4.Text) == 0)
                {
                    saldo = double.Parse(saldo3.Text) + debe - haber;
                    saldo6.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo2.Text) == 0)
                    {
                        saldo = double.Parse(saldo2.Text) + debe - haber;
                        saldo6.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo2.Text) == 0)
                        {
                            saldo = double.Parse(saldo1.Text) + debe - haber;
                            saldo6.Text = Convert.ToString(saldo);
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo6.Text = Convert.ToString(0);
            }
            else
            {
                saldo6.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo6.Text);
            debe = double.Parse(deb7.Text);
            haber = double.Parse(hab7.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo5.Text) + debe - haber;
                saldo7.Text = Convert.ToString(saldo);
                if (double.Parse(saldo5.Text) == 0)
                {
                    saldo = double.Parse(saldo4.Text) + debe - haber;
                    saldo7.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo4.Text) == 0)
                    {
                        saldo = double.Parse(saldo3.Text) + debe - haber;
                        saldo7.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo3.Text) == 0)
                        {
                            saldo = double.Parse(saldo2.Text) + debe - haber;
                            saldo7.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo2.Text) == 0)
                            {
                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                saldo7.Text = Convert.ToString(saldo);

                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo7.Text = Convert.ToString(0);
            }
            else
            {
                saldo7.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo7.Text);
            debe = double.Parse(deb8.Text);
            haber = double.Parse(hab8.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo6.Text) + debe - haber;
                saldo8.Text = Convert.ToString(saldo);
                if (double.Parse(saldo6.Text) == 0)
                {
                    saldo = double.Parse(saldo5.Text) + debe - haber;
                    saldo8.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo5.Text) == 0)
                    {
                        saldo = double.Parse(saldo4.Text) + debe - haber;
                        saldo8.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo4.Text) == 0)
                        {
                            saldo = double.Parse(saldo3.Text) + debe - haber;
                            saldo8.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo3.Text) == 0)
                            {
                                saldo = double.Parse(saldo2.Text) + debe - haber;
                                saldo8.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo2.Text) == 0)
                                {
                                    saldo = double.Parse(saldo1.Text) + debe - haber;
                                    saldo8.Text = Convert.ToString(saldo);

                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo8.Text = Convert.ToString(0);
            }
            else
            {
                saldo8.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo8.Text);
            debe = double.Parse(deb9.Text);
            haber = double.Parse(hab9.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo7.Text) + debe - haber;
                saldo9.Text = Convert.ToString(saldo);
                if (double.Parse(saldo7.Text) == 0)
                {
                    saldo = double.Parse(saldo6.Text) + debe - haber;
                    saldo9.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo6.Text) == 0)
                    {
                        saldo = double.Parse(saldo5.Text) + debe - haber;
                        saldo9.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo5.Text) == 0)
                        {
                            saldo = double.Parse(saldo4.Text) + debe - haber;
                            saldo9.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo4.Text) == 0)
                            {
                                saldo = double.Parse(saldo3.Text) + debe - haber;
                                saldo9.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo3.Text) == 0)
                                {
                                    saldo = double.Parse(saldo2.Text) + debe - haber;
                                    saldo9.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo2.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo1.Text) + debe - haber;
                                        saldo9.Text = Convert.ToString(saldo);

                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo9.Text = Convert.ToString(0);
            }
            else
            {
                saldo9.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo9.Text);
            debe = double.Parse(deb10.Text);
            haber = double.Parse(hab10.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo8.Text) + debe - haber;
                saldo10.Text = Convert.ToString(saldo);
                if (double.Parse(saldo8.Text) == 0)
                {
                    saldo = double.Parse(saldo7.Text) + debe - haber;
                    saldo10.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo7.Text) == 0)
                    {
                        saldo = double.Parse(saldo6.Text) + debe - haber;
                        saldo10.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo6.Text) == 0)
                        {
                            saldo = double.Parse(saldo5.Text) + debe - haber;
                            saldo10.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo5.Text) == 0)
                            {
                                saldo = double.Parse(saldo4.Text) + debe - haber;
                                saldo10.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo4.Text) == 0)
                                {
                                    saldo = double.Parse(saldo3.Text) + debe - haber;
                                    saldo10.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo3.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo2.Text) + debe - haber;
                                        saldo10.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo2.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo1.Text) + debe - haber;
                                            saldo10.Text = Convert.ToString(saldo);

                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo10.Text = Convert.ToString(0);
            }
            else
            {
                saldo10.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo10.Text);
            debe = double.Parse(deb11.Text);
            haber = double.Parse(hab11.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo9.Text) + debe - haber;
                saldo11.Text = Convert.ToString(saldo);
                if (double.Parse(saldo9.Text) == 0)
                {
                    saldo = double.Parse(saldo8.Text) + debe - haber;
                    saldo11.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo8.Text) == 0)
                    {
                        saldo = double.Parse(saldo7.Text) + debe - haber;
                        saldo11.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo7.Text) == 0)
                        {
                            saldo = double.Parse(saldo6.Text) + debe - haber;
                            saldo11.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo6.Text) == 0)
                            {
                                saldo = double.Parse(saldo5.Text) + debe - haber;
                                saldo11.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo5.Text) == 0)
                                {
                                    saldo = double.Parse(saldo4.Text) + debe - haber;
                                    saldo11.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo4.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo3.Text) + debe - haber;
                                        saldo11.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo3.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo2.Text) + debe - haber;
                                            saldo11.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo2.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                                saldo11.Text = Convert.ToString(saldo);

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo11.Text = Convert.ToString(0);
            }
            else
            {
                saldo11.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo11.Text);
            debe = double.Parse(deb12.Text);
            haber = double.Parse(hab12.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo10.Text) + debe - haber;
                saldo12.Text = Convert.ToString(saldo);
                if (double.Parse(saldo10.Text) == 0)
                {
                    saldo = double.Parse(saldo9.Text) + debe - haber;
                    saldo12.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo9.Text) == 0)
                    {
                        saldo = double.Parse(saldo8.Text) + debe - haber;
                        saldo12.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo8.Text) == 0)
                        {
                            saldo = double.Parse(saldo7.Text) + debe - haber;
                            saldo12.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo7.Text) == 0)
                            {
                                saldo = double.Parse(saldo6.Text) + debe - haber;
                                saldo12.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo6.Text) == 0)
                                {
                                    saldo = double.Parse(saldo5.Text) + debe - haber;
                                    saldo12.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo5.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo4.Text) + debe - haber;
                                        saldo12.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo4.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo3.Text) + debe - haber;
                                            saldo12.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo3.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo2.Text) + debe - haber;
                                                saldo12.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo2.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo1.Text) + debe - haber;
                                                    saldo12.Text = Convert.ToString(saldo);

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo12.Text = Convert.ToString(0);
            }
            else
            {
                saldo12.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo12.Text);
            debe = double.Parse(deb13.Text);
            haber = double.Parse(hab13.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo11.Text) + debe - haber;
                saldo13.Text = Convert.ToString(saldo);
                if (double.Parse(saldo11.Text) == 0)
                {
                    saldo = double.Parse(saldo10.Text) + debe - haber;
                    saldo13.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo10.Text) == 0)
                    {
                        saldo = double.Parse(saldo9.Text) + debe - haber;
                        saldo13.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo9.Text) == 0)
                        {
                            saldo = double.Parse(saldo8.Text) + debe - haber;
                            saldo13.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo8.Text) == 0)
                            {
                                saldo = double.Parse(saldo7.Text) + debe - haber;
                                saldo13.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo7.Text) == 0)
                                {
                                    saldo = double.Parse(saldo6.Text) + debe - haber;
                                    saldo13.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo6.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo5.Text) + debe - haber;
                                        saldo13.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo5.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo4.Text) + debe - haber;
                                            saldo13.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo4.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo3.Text) + debe - haber;
                                                saldo13.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo3.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo2.Text) + debe - haber;
                                                    saldo13.Text = Convert.ToString(saldo);
                                                    if (double.Parse(saldo2.Text) == 0)
                                                    {
                                                        saldo = double.Parse(saldo1.Text) + debe - haber;
                                                        saldo13.Text = Convert.ToString(saldo);

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo13.Text = Convert.ToString(0);
            }
            else
            {
                saldo13.Text = Convert.ToString(saldo);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            double saldo, sal, debe, haber;
            saldo1.Text = deb1.Text;

            sal = double.Parse(saldo1.Text);
            debe = double.Parse(deb2.Text);
            haber = double.Parse(hab2.Text);
            saldo = sal + debe - haber;
            if (debe == 0 && haber == 0)
            {
                saldo2.Text = Convert.ToString(0);
            }
            else
            {
                saldo2.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo2.Text);
            debe = double.Parse(deb3.Text);
            haber = double.Parse(hab3.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo1.Text) + debe - haber;
                saldo3.Text = Convert.ToString(saldo);
            }
            if (debe == 0 && haber == 0)
            {
                saldo3.Text = Convert.ToString(0);

            }
            else
            {
                saldo3.Text = Convert.ToString(saldo);
            }

            //gggggg
            sal = double.Parse(saldo3.Text);
            debe = double.Parse(deb4.Text);
            haber = double.Parse(hab4.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo2.Text) + debe - haber;
                saldo4.Text = Convert.ToString(saldo);
                if (double.Parse(saldo2.Text) == 0)
                {
                    saldo = double.Parse(saldo1.Text) + debe - haber;
                    saldo4.Text = Convert.ToString(saldo);
                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo4.Text = Convert.ToString(0);
            }
            else
            {
                saldo4.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo4.Text);
            debe = double.Parse(deb5.Text);
            haber = double.Parse(hab5.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo3.Text) + debe - haber;
                saldo5.Text = Convert.ToString(saldo);
                if (double.Parse(saldo3.Text) == 0)
                {
                    saldo = double.Parse(saldo2.Text) + debe - haber;
                    saldo5.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo2.Text) == 0)
                    {
                        saldo = double.Parse(saldo1.Text) + debe - haber;
                        saldo5.Text = Convert.ToString(saldo);
                    }
                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo5.Text = Convert.ToString(0);
            }
            else
            {
                saldo5.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo5.Text);
            debe = double.Parse(deb6.Text);
            haber = double.Parse(hab6.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo4.Text) + debe - haber;
                saldo6.Text = Convert.ToString(saldo);
                if (double.Parse(saldo4.Text) == 0)
                {
                    saldo = double.Parse(saldo3.Text) + debe - haber;
                    saldo6.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo2.Text) == 0)
                    {
                        saldo = double.Parse(saldo2.Text) + debe - haber;
                        saldo6.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo2.Text) == 0)
                        {
                            saldo = double.Parse(saldo1.Text) + debe - haber;
                            saldo6.Text = Convert.ToString(saldo);
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo6.Text = Convert.ToString(0);
            }
            else
            {
                saldo6.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo6.Text);
            debe = double.Parse(deb7.Text);
            haber = double.Parse(hab7.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo5.Text) + debe - haber;
                saldo7.Text = Convert.ToString(saldo);
                if (double.Parse(saldo5.Text) == 0)
                {
                    saldo = double.Parse(saldo4.Text) + debe - haber;
                    saldo7.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo4.Text) == 0)
                    {
                        saldo = double.Parse(saldo3.Text) + debe - haber;
                        saldo7.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo3.Text) == 0)
                        {
                            saldo = double.Parse(saldo2.Text) + debe - haber;
                            saldo7.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo2.Text) == 0)
                            {
                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                saldo7.Text = Convert.ToString(saldo);

                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo7.Text = Convert.ToString(0);
            }
            else
            {
                saldo7.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo7.Text);
            debe = double.Parse(deb8.Text);
            haber = double.Parse(hab8.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo6.Text) + debe - haber;
                saldo8.Text = Convert.ToString(saldo);
                if (double.Parse(saldo6.Text) == 0)
                {
                    saldo = double.Parse(saldo5.Text) + debe - haber;
                    saldo8.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo5.Text) == 0)
                    {
                        saldo = double.Parse(saldo4.Text) + debe - haber;
                        saldo8.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo4.Text) == 0)
                        {
                            saldo = double.Parse(saldo3.Text) + debe - haber;
                            saldo8.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo3.Text) == 0)
                            {
                                saldo = double.Parse(saldo2.Text) + debe - haber;
                                saldo8.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo2.Text) == 0)
                                {
                                    saldo = double.Parse(saldo1.Text) + debe - haber;
                                    saldo8.Text = Convert.ToString(saldo);

                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo8.Text = Convert.ToString(0);
            }
            else
            {
                saldo8.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo8.Text);
            debe = double.Parse(deb9.Text);
            haber = double.Parse(hab9.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo7.Text) + debe - haber;
                saldo9.Text = Convert.ToString(saldo);
                if (double.Parse(saldo7.Text) == 0)
                {
                    saldo = double.Parse(saldo6.Text) + debe - haber;
                    saldo9.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo6.Text) == 0)
                    {
                        saldo = double.Parse(saldo5.Text) + debe - haber;
                        saldo9.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo5.Text) == 0)
                        {
                            saldo = double.Parse(saldo4.Text) + debe - haber;
                            saldo9.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo4.Text) == 0)
                            {
                                saldo = double.Parse(saldo3.Text) + debe - haber;
                                saldo9.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo3.Text) == 0)
                                {
                                    saldo = double.Parse(saldo2.Text) + debe - haber;
                                    saldo9.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo2.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo1.Text) + debe - haber;
                                        saldo9.Text = Convert.ToString(saldo);

                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo9.Text = Convert.ToString(0);
            }
            else
            {
                saldo9.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo9.Text);
            debe = double.Parse(deb10.Text);
            haber = double.Parse(hab10.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo8.Text) + debe - haber;
                saldo10.Text = Convert.ToString(saldo);
                if (double.Parse(saldo8.Text) == 0)
                {
                    saldo = double.Parse(saldo7.Text) + debe - haber;
                    saldo10.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo7.Text) == 0)
                    {
                        saldo = double.Parse(saldo6.Text) + debe - haber;
                        saldo10.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo6.Text) == 0)
                        {
                            saldo = double.Parse(saldo5.Text) + debe - haber;
                            saldo10.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo5.Text) == 0)
                            {
                                saldo = double.Parse(saldo4.Text) + debe - haber;
                                saldo10.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo4.Text) == 0)
                                {
                                    saldo = double.Parse(saldo3.Text) + debe - haber;
                                    saldo10.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo3.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo2.Text) + debe - haber;
                                        saldo10.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo2.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo1.Text) + debe - haber;
                                            saldo10.Text = Convert.ToString(saldo);

                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo10.Text = Convert.ToString(0);
            }
            else
            {
                saldo10.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo10.Text);
            debe = double.Parse(deb11.Text);
            haber = double.Parse(hab11.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo9.Text) + debe - haber;
                saldo11.Text = Convert.ToString(saldo);
                if (double.Parse(saldo9.Text) == 0)
                {
                    saldo = double.Parse(saldo8.Text) + debe - haber;
                    saldo11.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo8.Text) == 0)
                    {
                        saldo = double.Parse(saldo7.Text) + debe - haber;
                        saldo11.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo7.Text) == 0)
                        {
                            saldo = double.Parse(saldo6.Text) + debe - haber;
                            saldo11.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo6.Text) == 0)
                            {
                                saldo = double.Parse(saldo5.Text) + debe - haber;
                                saldo11.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo5.Text) == 0)
                                {
                                    saldo = double.Parse(saldo4.Text) + debe - haber;
                                    saldo11.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo4.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo3.Text) + debe - haber;
                                        saldo11.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo3.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo2.Text) + debe - haber;
                                            saldo11.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo2.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                                saldo11.Text = Convert.ToString(saldo);

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo11.Text = Convert.ToString(0);
            }
            else
            {
                saldo11.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo11.Text);
            debe = double.Parse(deb12.Text);
            haber = double.Parse(hab12.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo10.Text) + debe - haber;
                saldo12.Text = Convert.ToString(saldo);
                if (double.Parse(saldo10.Text) == 0)
                {
                    saldo = double.Parse(saldo9.Text) + debe - haber;
                    saldo12.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo9.Text) == 0)
                    {
                        saldo = double.Parse(saldo8.Text) + debe - haber;
                        saldo12.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo8.Text) == 0)
                        {
                            saldo = double.Parse(saldo7.Text) + debe - haber;
                            saldo12.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo7.Text) == 0)
                            {
                                saldo = double.Parse(saldo6.Text) + debe - haber;
                                saldo12.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo6.Text) == 0)
                                {
                                    saldo = double.Parse(saldo5.Text) + debe - haber;
                                    saldo12.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo5.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo4.Text) + debe - haber;
                                        saldo12.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo4.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo3.Text) + debe - haber;
                                            saldo12.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo3.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo2.Text) + debe - haber;
                                                saldo12.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo2.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo1.Text) + debe - haber;
                                                    saldo12.Text = Convert.ToString(saldo);

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo12.Text = Convert.ToString(0);
            }
            else
            {
                saldo12.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo12.Text);
            debe = double.Parse(deb13.Text);
            haber = double.Parse(hab13.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo11.Text) + debe - haber;
                saldo13.Text = Convert.ToString(saldo);
                if (double.Parse(saldo11.Text) == 0)
                {
                    saldo = double.Parse(saldo10.Text) + debe - haber;
                    saldo13.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo10.Text) == 0)
                    {
                        saldo = double.Parse(saldo9.Text) + debe - haber;
                        saldo13.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo9.Text) == 0)
                        {
                            saldo = double.Parse(saldo8.Text) + debe - haber;
                            saldo13.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo8.Text) == 0)
                            {
                                saldo = double.Parse(saldo7.Text) + debe - haber;
                                saldo13.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo7.Text) == 0)
                                {
                                    saldo = double.Parse(saldo6.Text) + debe - haber;
                                    saldo13.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo6.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo5.Text) + debe - haber;
                                        saldo13.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo5.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo4.Text) + debe - haber;
                                            saldo13.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo4.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo3.Text) + debe - haber;
                                                saldo13.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo3.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo2.Text) + debe - haber;
                                                    saldo13.Text = Convert.ToString(saldo);
                                                    if (double.Parse(saldo2.Text) == 0)
                                                    {
                                                        saldo = double.Parse(saldo1.Text) + debe - haber;
                                                        saldo13.Text = Convert.ToString(saldo);

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo13.Text = Convert.ToString(0);
            }
            else
            {
                saldo13.Text = Convert.ToString(saldo);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float saldo, existencia, promedio, entrada;

            prom1.Text = pre1.Text;

            saldo = float.Parse(saldo2.Text);
            existencia = float.Parse(exist2.Text);
            entrada = float.Parse(ent2.Text);
            promedio = saldo / existencia;
            if (entrada != 0)
            {
                prom2.Text = promedio.ToString("0.00");
                if (prom1.Text == prom2.Text)
                {
                    prom2.Text = "";
                }

            }
            else
            {
                prom2.Text = "";
            }

            saldo = float.Parse(saldo3.Text);
            existencia = float.Parse(exist3.Text);
            entrada = float.Parse(ent3.Text);
            promedio = saldo / existencia;
            if (entrada != 0)
            {
                prom3.Text = promedio.ToString("0.00");
                if (prom2.Text == prom3.Text)
                {
                    prom3.Text = "";
                }

            }
            else
            {
                prom3.Text = "";
            }

            saldo = float.Parse(saldo4.Text);
            existencia = float.Parse(exist4.Text);
            entrada = float.Parse(ent4.Text);
            promedio = saldo / existencia;
            if (entrada != 0)
            {
                prom4.Text = promedio.ToString("0.00");
                if (prom3.Text == prom4.Text)
                {
                    prom4.Text = "";
                }

            }
            else
            {
                prom4.Text = "";
            }

            saldo = float.Parse(saldo5.Text);
            existencia = float.Parse(exist5.Text);
            entrada = float.Parse(ent5.Text);
            promedio = saldo / existencia;
            if (entrada != 0)
            {
                prom5.Text = promedio.ToString("0.00");
                if (prom4.Text == prom5.Text)
                {
                    prom5.Text = "";
                }

            }
            else
            {
                prom5.Text = "";
            }

            saldo = float.Parse(saldo6.Text);
            existencia = float.Parse(exist6.Text);
            entrada = float.Parse(ent6.Text);
            promedio = ((saldo / existencia) * 1000) / 1000;
            if (entrada != 0)
            {
                prom6.Text = promedio.ToString("0.00");
                if (prom5.Text == prom6.Text)
                {
                    prom6.Text = "";
                }

            }
            else
            {
                prom6.Text = "";
            }


            saldo = float.Parse(saldo7.Text);
            existencia = float.Parse(exist7.Text);
            entrada = float.Parse(ent7.Text);
            promedio = saldo / existencia;
            if (entrada != 0)
            {
                prom7.Text = promedio.ToString("0.00");
                if (prom6.Text == prom7.Text)
                {
                    prom7.Text = "";
                }

            }
            else
            {
                prom7.Text = "";
            }

            saldo = float.Parse(saldo8.Text);
            existencia = float.Parse(exist8.Text);
            entrada = float.Parse(ent8.Text);
            promedio = saldo / existencia;
            if (entrada != 0)
            {
                prom8.Text = promedio.ToString("0.00");
                if (prom7.Text == prom8.Text)
                {
                    prom8.Text = "";
                }

            }
            else
            {
                prom8.Text = "";
            }

            saldo = float.Parse(saldo9.Text);
            existencia = float.Parse(exist9.Text);
            entrada = float.Parse(ent9.Text);
            promedio = saldo / existencia;
            if (entrada != 0)
            {
                prom9.Text = promedio.ToString("0.00");
                if (prom8.Text == prom9.Text)
                {
                    prom9.Text = "";
                }

            }
            else
            {
                prom9.Text = "";
            }

            saldo = float.Parse(saldo10.Text);
            existencia = float.Parse(exist10.Text);
            entrada = float.Parse(ent10.Text);
            promedio = saldo / existencia;
            if (entrada != 0)
            {
                prom10.Text = promedio.ToString("0.00");
                if (prom9.Text == prom10.Text)
                {
                    prom10.Text = "";
                }

            }
            else
            {
                prom10.Text = "";
            }

            saldo = float.Parse(saldo11.Text);
            existencia = float.Parse(exist11.Text);
            entrada = float.Parse(ent11.Text);
            promedio = saldo / existencia;
            if (entrada != 0)
            {
                prom11.Text = promedio.ToString("0.00");
                if (prom10.Text == prom11.Text)
                {
                    prom11.Text = "";
                }

            }
            else
            {
                prom11.Text = "";
            }

            saldo = float.Parse(saldo12.Text);
            existencia = float.Parse(exist12.Text);
            entrada = float.Parse(ent12.Text);
            promedio = saldo / existencia;
            if (entrada != 0)
            {
                prom12.Text = promedio.ToString("0.00");
                if (prom11.Text == prom12.Text)
                {
                    prom12.Text = "";
                }

            }
            else
            {
                prom12.Text = "";
            }

            saldo = float.Parse(saldo13.Text);
            existencia = float.Parse(exist13.Text);
            entrada = float.Parse(ent13.Text);
            promedio = saldo / existencia;
            if (entrada != 0)
            {
                prom13.Text = promedio.ToString("0.00");
                if (prom12.Text == prom13.Text)
                {
                    prom13.Text = "";
                }

            }
            else
            {
                prom13.Text = "";
            }
        }

        private void Pre_Unidad_Click(object sender, EventArgs e)
        {
            double salida;

            salida = Convert.ToDouble(sal2.Text);
            if (salida > 0)
            {
                pre2.Text = prom1.Text;
            }


            salida = Convert.ToDouble(sal3.Text);
            if (salida > 0)
            {
                pre3.Text = prom2.Text;
                if (prom2.Text == "")
                {
                    pre3.Text = prom1.Text;
                }

            }


            salida = Convert.ToDouble(sal4.Text);
            if (salida > 0)
            {
                pre4.Text = prom3.Text;
                if (prom3.Text == "")
                {
                    pre4.Text = prom2.Text;
                    if (prom2.Text == "")
                    {
                        pre4.Text = prom1.Text;
                    }
                }

            }

            //sssssss
            salida = Convert.ToDouble(sal5.Text);
            if (salida > 0)
            {
                pre5.Text = prom4.Text;
                if (prom4.Text == "")
                {
                    pre5.Text = prom3.Text;
                    if (prom3.Text == "")
                    {
                        pre5.Text = prom2.Text;
                        if (prom2.Text == "")
                        {
                            pre5.Text = prom1.Text;
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal6.Text);
            if (salida > 0)
            {
                pre6.Text = prom5.Text;
                if (prom5.Text == "")
                {
                    pre6.Text = prom4.Text;
                    if (prom4.Text == "")
                    {
                        pre6.Text = prom3.Text;
                        if (prom3.Text == "")
                        {
                            pre6.Text = prom2.Text;
                            if (prom2.Text == "")
                            {
                                pre6.Text = prom1.Text;
                            }
                        }
                    }
                }
            }
            salida = Convert.ToDouble(sal7.Text);
            if (salida > 0)
            {
                pre7.Text = prom6.Text;
                if (prom6.Text == "")
                {
                    pre7.Text = prom5.Text;
                    if (prom5.Text == "")
                    {
                        pre7.Text = prom4.Text;
                        if (prom4.Text == "")
                        {
                            pre7.Text = prom3.Text;
                            if (prom3.Text == "")
                            {
                                pre7.Text = prom2.Text;
                                if (prom2.Text == "")
                                {
                                    pre7.Text = prom1.Text;
                                }
                            }
                        }
                    }
                }
            }
            salida = Convert.ToDouble(sal8.Text);
            if (salida > 0)
            {
                pre8.Text = prom7.Text;
                if (prom7.Text == "")
                {
                    pre8.Text = prom6.Text;
                    if (prom6.Text == "")
                    {
                        pre8.Text = prom5.Text;
                        if (prom5.Text == "")
                        {
                            pre8.Text = prom4.Text;
                            if (prom4.Text == "")
                            {
                                pre8.Text = prom3.Text;
                                if (prom3.Text == "")
                                {
                                    pre8.Text = prom2.Text;
                                    if (prom2.Text == "")
                                    {
                                        pre8.Text = prom1.Text;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal9.Text);
            if (salida > 0)
            {
                pre9.Text = prom8.Text;
                if (prom8.Text == "")
                {
                    pre9.Text = prom7.Text;
                    if (prom7.Text == "")
                    {
                        pre9.Text = prom6.Text;
                        if (prom6.Text == "")
                        {
                            pre9.Text = prom5.Text;
                            if (prom5.Text == "")
                            {
                                pre9.Text = prom4.Text;
                                if (prom4.Text == "")
                                {
                                    pre9.Text = prom3.Text;
                                    if (prom3.Text == "")
                                    {
                                        pre9.Text = prom2.Text;
                                        if (prom2.Text == "")
                                        {
                                            pre9.Text = prom1.Text;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal10.Text);
            if (salida > 0)
            {
                pre10.Text = prom9.Text;
                if (prom9.Text == "")
                {
                    pre10.Text = prom8.Text;
                    if (prom8.Text == "")
                    {
                        pre10.Text = prom7.Text;
                        if (prom7.Text == "")
                        {
                            pre10.Text = prom6.Text;
                            if (prom6.Text == "")
                            {
                                pre10.Text = prom5.Text;
                                if (prom5.Text == "")
                                {
                                    pre10.Text = prom4.Text;
                                    if (prom4.Text == "")
                                    {
                                        pre10.Text = prom3.Text;
                                        if (prom3.Text == "")
                                        {
                                            pre10.Text = prom2.Text;
                                            if (prom2.Text == "")
                                            {
                                                pre10.Text = prom1.Text;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal11.Text);
            if (salida > 0)
            {
                pre11.Text = prom10.Text;
                if (prom10.Text == "")
                {
                    pre11.Text = prom9.Text;
                    if (prom9.Text == "")
                    {
                        pre11.Text = prom8.Text;
                        if (prom8.Text == "")
                        {
                            pre11.Text = prom7.Text;
                            if (prom7.Text == "")
                            {
                                pre11.Text = prom6.Text;
                                if (prom6.Text == "")
                                {
                                    pre11.Text = prom5.Text;
                                    if (prom5.Text == "")
                                    {
                                        pre11.Text = prom4.Text;
                                        if (prom4.Text == "")
                                        {
                                            pre11.Text = prom3.Text;
                                            if (prom3.Text == "")
                                            {
                                                pre11.Text = prom2.Text;
                                                if (prom2.Text == "")
                                                {
                                                    pre11.Text = prom1.Text;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal12.Text);
            if (salida > 0)
            {
                pre12.Text = prom11.Text;
                if (prom10.Text == "")
                {
                    pre12.Text = prom10.Text;
                    if (prom10.Text == "")
                    {
                        pre12.Text = prom9.Text;
                        if (prom9.Text == "")
                        {
                            pre12.Text = prom8.Text;
                            if (prom8.Text == "")
                            {
                                pre12.Text = prom7.Text;
                                if (prom7.Text == "")
                                {
                                    pre12.Text = prom6.Text;
                                    if (prom6.Text == "")
                                    {
                                        pre12.Text = prom5.Text;
                                        if (prom5.Text == "")
                                        {
                                            pre12.Text = prom4.Text;
                                            if (prom4.Text == "")
                                            {
                                                pre12.Text = prom3.Text;
                                                if (prom3.Text == "")
                                                {
                                                    pre12.Text = prom2.Text;
                                                    if (prom2.Text == "")
                                                    {
                                                        pre12.Text = prom1.Text;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            salida = Convert.ToDouble(sal13.Text);
            if (salida > 0)
            {
                pre13.Text = prom12.Text;
                if (prom12.Text == "")
                {
                    pre13.Text = prom11.Text;
                    if (prom11.Text == "")
                    {
                        pre13.Text = prom10.Text;
                        if (prom10.Text == "")
                        {
                            pre13.Text = prom9.Text;
                            if (prom9.Text == "")
                            {
                                pre13.Text = prom8.Text;
                                if (prom8.Text == "")
                                {
                                    pre13.Text = prom7.Text;
                                    if (prom7.Text == "")
                                    {
                                        pre13.Text = prom6.Text;
                                        if (prom6.Text == "")
                                        {
                                            pre13.Text = prom5.Text;
                                            if (prom5.Text == "")
                                            {
                                                pre13.Text = prom4.Text;
                                                if (prom4.Text == "")
                                                {
                                                    pre13.Text = prom3.Text;
                                                    if (prom3.Text == "")
                                                    {
                                                        pre13.Text = prom2.Text;
                                                        if (prom2.Text == "")
                                                        {
                                                            pre13.Text = prom1.Text;

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Total_Click(object sender, EventArgs e)
        {
            double haber, salida, pre;
            hab1.Text = Convert.ToString(0);
            if (pre2.Text == "")
            {
                pre2.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal2.Text);
            pre = double.Parse(pre2.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab2.Text = Convert.ToString(0);
            }
            else
            {
                hab2.Text = Convert.ToString(haber);
            }

            if (pre3.Text == "")
            {
                pre3.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal3.Text);
            pre = double.Parse(pre3.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab3.Text = Convert.ToString(0);
            }
            else
            {
                hab3.Text = Convert.ToString(haber);
            }

            if (pre4.Text == "")
            {
                pre4.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal4.Text);
            pre = double.Parse(pre4.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab4.Text = Convert.ToString(0);
            }
            else
            {
                hab4.Text = Convert.ToString(haber);
            }

            if (pre5.Text == "")
            {
                pre5.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal5.Text);
            pre = double.Parse(pre5.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab5.Text = Convert.ToString(0);
            }
            else
            {
                hab5.Text = Convert.ToString(haber);
            }

            if (pre6.Text == "")
            {
                pre6.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal6.Text);
            pre = double.Parse(pre6.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab6.Text = Convert.ToString(0);
            }
            else
            {
                hab6.Text = Convert.ToString(haber);
            }

            if (pre7.Text == "")
            {
                pre7.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal7.Text);
            pre = double.Parse(pre7.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab7.Text = Convert.ToString(0);
            }
            else
            {
                hab7.Text = Convert.ToString(haber);
            }

            if (pre8.Text == "")
            {
                pre8.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal8.Text);
            pre = double.Parse(pre8.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab8.Text = Convert.ToString(0);
            }
            else
            {
                hab8.Text = Convert.ToString(haber);
            }

            if (pre9.Text == "")
            {
                pre9.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal9.Text);
            pre = double.Parse(pre9.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab9.Text = Convert.ToString(0);
            }
            else
            {
                hab9.Text = Convert.ToString(haber);
            }

            if (pre10.Text == "")
            {
                pre10.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal10.Text);
            pre = double.Parse(pre10.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab10.Text = Convert.ToString(0);
            }
            else
            {
                hab10.Text = Convert.ToString(haber);
            }

            if (pre11.Text == "")
            {
                pre11.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal11.Text);
            pre = double.Parse(pre11.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab11.Text = Convert.ToString(0);
            }
            else
            {
                hab11.Text = Convert.ToString(haber);
            }

            if (pre12.Text == "")
            {
                pre12.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal12.Text);
            pre = double.Parse(pre12.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab12.Text = Convert.ToString(0);
            }
            else
            {
                hab12.Text = Convert.ToString(haber);
            }

            if (pre13.Text == "")
            {
                pre13.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal13.Text);
            pre = double.Parse(pre13.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab13.Text = Convert.ToString(0);
            }
            else
            {
                hab13.Text = Convert.ToString(haber);
            }


            double saldo, sal, debe;
            saldo1.Text = deb1.Text;

            sal = double.Parse(saldo1.Text);
            debe = double.Parse(deb2.Text);
            haber = double.Parse(hab2.Text);
            saldo = sal + debe - haber;
            if (debe == 0 && haber == 0)
            {
                saldo2.Text = Convert.ToString(0);
            }
            else
            {
                saldo2.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo2.Text);
            debe = double.Parse(deb3.Text);
            haber = double.Parse(hab3.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo1.Text) + debe - haber;
                saldo3.Text = Convert.ToString(saldo);
            }
            if (debe == 0 && haber == 0)
            {
                saldo3.Text = Convert.ToString(0);

            }
            else
            {
                saldo3.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo3.Text);
            debe = double.Parse(deb4.Text);
            haber = double.Parse(hab4.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo2.Text) + debe - haber;
                saldo4.Text = Convert.ToString(saldo);
                if (double.Parse(saldo2.Text) == 0)
                {
                    saldo = double.Parse(saldo1.Text) + debe - haber;
                    saldo4.Text = Convert.ToString(saldo);
                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo4.Text = Convert.ToString(0);
            }
            else
            {
                saldo4.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo4.Text);
            debe = double.Parse(deb5.Text);
            haber = double.Parse(hab5.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo3.Text) + debe - haber;
                saldo5.Text = Convert.ToString(saldo);
                if (double.Parse(saldo3.Text) == 0)
                {
                    saldo = double.Parse(saldo2.Text) + debe - haber;
                    saldo5.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo2.Text) == 0)
                    {
                        saldo = double.Parse(saldo1.Text) + debe - haber;
                        saldo5.Text = Convert.ToString(saldo);
                    }
                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo5.Text = Convert.ToString(0);
            }
            else
            {
                saldo5.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo5.Text);
            debe = double.Parse(deb6.Text);
            haber = double.Parse(hab6.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo4.Text) + debe - haber;
                saldo6.Text = Convert.ToString(saldo);
                if (double.Parse(saldo4.Text) == 0)
                {
                    saldo = double.Parse(saldo3.Text) + debe - haber;
                    saldo6.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo2.Text) == 0)
                    {
                        saldo = double.Parse(saldo2.Text) + debe - haber;
                        saldo6.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo2.Text) == 0)
                        {
                            saldo = double.Parse(saldo1.Text) + debe - haber;
                            saldo6.Text = Convert.ToString(saldo);
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo6.Text = Convert.ToString(0);
            }
            else
            {
                saldo6.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo6.Text);
            debe = double.Parse(deb7.Text);
            haber = double.Parse(hab7.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo5.Text) + debe - haber;
                saldo7.Text = Convert.ToString(saldo);
                if (double.Parse(saldo5.Text) == 0)
                {
                    saldo = double.Parse(saldo4.Text) + debe - haber;
                    saldo7.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo4.Text) == 0)
                    {
                        saldo = double.Parse(saldo3.Text) + debe - haber;
                        saldo7.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo3.Text) == 0)
                        {
                            saldo = double.Parse(saldo2.Text) + debe - haber;
                            saldo7.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo2.Text) == 0)
                            {
                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                saldo7.Text = Convert.ToString(saldo);

                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo7.Text = Convert.ToString(0);
            }
            else
            {
                saldo7.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo7.Text);
            debe = double.Parse(deb8.Text);
            haber = double.Parse(hab8.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo6.Text) + debe - haber;
                saldo8.Text = Convert.ToString(saldo);
                if (double.Parse(saldo6.Text) == 0)
                {
                    saldo = double.Parse(saldo5.Text) + debe - haber;
                    saldo8.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo5.Text) == 0)
                    {
                        saldo = double.Parse(saldo4.Text) + debe - haber;
                        saldo8.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo4.Text) == 0)
                        {
                            saldo = double.Parse(saldo3.Text) + debe - haber;
                            saldo8.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo3.Text) == 0)
                            {
                                saldo = double.Parse(saldo2.Text) + debe - haber;
                                saldo8.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo2.Text) == 0)
                                {
                                    saldo = double.Parse(saldo1.Text) + debe - haber;
                                    saldo8.Text = Convert.ToString(saldo);

                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo8.Text = Convert.ToString(0);
            }
            else
            {
                saldo8.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo8.Text);
            debe = double.Parse(deb9.Text);
            haber = double.Parse(hab9.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo7.Text) + debe - haber;
                saldo9.Text = Convert.ToString(saldo);
                if (double.Parse(saldo7.Text) == 0)
                {
                    saldo = double.Parse(saldo6.Text) + debe - haber;
                    saldo9.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo6.Text) == 0)
                    {
                        saldo = double.Parse(saldo5.Text) + debe - haber;
                        saldo9.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo5.Text) == 0)
                        {
                            saldo = double.Parse(saldo4.Text) + debe - haber;
                            saldo9.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo4.Text) == 0)
                            {
                                saldo = double.Parse(saldo3.Text) + debe - haber;
                                saldo9.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo3.Text) == 0)
                                {
                                    saldo = double.Parse(saldo2.Text) + debe - haber;
                                    saldo9.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo2.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo1.Text) + debe - haber;
                                        saldo9.Text = Convert.ToString(saldo);

                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo9.Text = Convert.ToString(0);
            }
            else
            {
                saldo9.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo9.Text);
            debe = double.Parse(deb10.Text);
            haber = double.Parse(hab10.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo8.Text) + debe - haber;
                saldo10.Text = Convert.ToString(saldo);
                if (double.Parse(saldo8.Text) == 0)
                {
                    saldo = double.Parse(saldo7.Text) + debe - haber;
                    saldo10.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo7.Text) == 0)
                    {
                        saldo = double.Parse(saldo6.Text) + debe - haber;
                        saldo10.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo6.Text) == 0)
                        {
                            saldo = double.Parse(saldo5.Text) + debe - haber;
                            saldo10.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo5.Text) == 0)
                            {
                                saldo = double.Parse(saldo4.Text) + debe - haber;
                                saldo10.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo4.Text) == 0)
                                {
                                    saldo = double.Parse(saldo3.Text) + debe - haber;
                                    saldo10.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo3.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo2.Text) + debe - haber;
                                        saldo10.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo2.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo1.Text) + debe - haber;
                                            saldo10.Text = Convert.ToString(saldo);

                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo10.Text = Convert.ToString(0);
            }
            else
            {
                saldo10.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo10.Text);
            debe = double.Parse(deb11.Text);
            haber = double.Parse(hab11.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo9.Text) + debe - haber;
                saldo11.Text = Convert.ToString(saldo);
                if (double.Parse(saldo9.Text) == 0)
                {
                    saldo = double.Parse(saldo8.Text) + debe - haber;
                    saldo11.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo8.Text) == 0)
                    {
                        saldo = double.Parse(saldo7.Text) + debe - haber;
                        saldo11.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo7.Text) == 0)
                        {
                            saldo = double.Parse(saldo6.Text) + debe - haber;
                            saldo11.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo6.Text) == 0)
                            {
                                saldo = double.Parse(saldo5.Text) + debe - haber;
                                saldo11.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo5.Text) == 0)
                                {
                                    saldo = double.Parse(saldo4.Text) + debe - haber;
                                    saldo11.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo4.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo3.Text) + debe - haber;
                                        saldo11.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo3.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo2.Text) + debe - haber;
                                            saldo11.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo2.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                                saldo11.Text = Convert.ToString(saldo);

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo11.Text = Convert.ToString(0);
            }
            else
            {
                saldo11.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo11.Text);
            debe = double.Parse(deb12.Text);
            haber = double.Parse(hab12.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo10.Text) + debe - haber;
                saldo12.Text = Convert.ToString(saldo);
                if (double.Parse(saldo10.Text) == 0)
                {
                    saldo = double.Parse(saldo9.Text) + debe - haber;
                    saldo12.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo9.Text) == 0)
                    {
                        saldo = double.Parse(saldo8.Text) + debe - haber;
                        saldo12.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo8.Text) == 0)
                        {
                            saldo = double.Parse(saldo7.Text) + debe - haber;
                            saldo12.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo7.Text) == 0)
                            {
                                saldo = double.Parse(saldo6.Text) + debe - haber;
                                saldo12.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo6.Text) == 0)
                                {
                                    saldo = double.Parse(saldo5.Text) + debe - haber;
                                    saldo12.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo5.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo4.Text) + debe - haber;
                                        saldo12.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo4.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo3.Text) + debe - haber;
                                            saldo12.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo3.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo2.Text) + debe - haber;
                                                saldo12.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo2.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo1.Text) + debe - haber;
                                                    saldo12.Text = Convert.ToString(saldo);

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo12.Text = Convert.ToString(0);
            }
            else
            {
                saldo12.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo12.Text);
            debe = double.Parse(deb13.Text);
            haber = double.Parse(hab13.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo11.Text) + debe - haber;
                saldo13.Text = Convert.ToString(saldo);
                if (double.Parse(saldo11.Text) == 0)
                {
                    saldo = double.Parse(saldo10.Text) + debe - haber;
                    saldo13.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo10.Text) == 0)
                    {
                        saldo = double.Parse(saldo9.Text) + debe - haber;
                        saldo13.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo9.Text) == 0)
                        {
                            saldo = double.Parse(saldo8.Text) + debe - haber;
                            saldo13.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo8.Text) == 0)
                            {
                                saldo = double.Parse(saldo7.Text) + debe - haber;
                                saldo13.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo7.Text) == 0)
                                {
                                    saldo = double.Parse(saldo6.Text) + debe - haber;
                                    saldo13.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo6.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo5.Text) + debe - haber;
                                        saldo13.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo5.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo4.Text) + debe - haber;
                                            saldo13.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo4.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo3.Text) + debe - haber;
                                                saldo13.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo3.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo2.Text) + debe - haber;
                                                    saldo13.Text = Convert.ToString(saldo);
                                                    if (double.Parse(saldo2.Text) == 0)
                                                    {
                                                        saldo = double.Parse(saldo1.Text) + debe - haber;
                                                        saldo13.Text = Convert.ToString(saldo);

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo13.Text = Convert.ToString(0);
            }
            else
            {
                saldo13.Text = Convert.ToString(saldo);
            }



            float sald, existencia, promedio, entrada;

            prom1.Text = pre1.Text;

            sald = float.Parse(saldo2.Text);
            existencia = float.Parse(exist2.Text);
            entrada = float.Parse(ent2.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom2.Text = promedio.ToString("0.00");
                if (prom1.Text == prom2.Text)
                {
                    prom2.Text = "";
                }

            }
            else
            {
                prom2.Text = "";
            }

            sald = float.Parse(saldo3.Text);
            existencia = float.Parse(exist3.Text);
            entrada = float.Parse(ent3.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom3.Text = promedio.ToString("0.00");
                if (prom2.Text == prom3.Text)
                {
                    prom3.Text = "";
                }

            }
            else
            {
                prom3.Text = "";
            }

            sald = float.Parse(saldo4.Text);
            existencia = float.Parse(exist4.Text);
            entrada = float.Parse(ent4.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom4.Text = promedio.ToString("0.00");
                if (prom3.Text == prom4.Text)
                {
                    prom4.Text = "";
                }

            }
            else
            {
                prom4.Text = "";
            }

            sald = float.Parse(saldo5.Text);
            existencia = float.Parse(exist5.Text);
            entrada = float.Parse(ent5.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom5.Text = promedio.ToString("0.00");
                if (prom4.Text == prom5.Text)
                {
                    prom5.Text = "";
                }

            }
            else
            {
                prom5.Text = "";
            }

            sald = float.Parse(saldo6.Text);
            existencia = float.Parse(exist6.Text);
            entrada = float.Parse(ent6.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom6.Text = promedio.ToString("0.00");
                if (prom5.Text == prom6.Text)
                {
                    prom6.Text = "";
                }

            }
            else
            {
                prom6.Text = "";
            }


            sald = float.Parse(saldo7.Text);
            existencia = float.Parse(exist7.Text);
            entrada = float.Parse(ent7.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom7.Text = promedio.ToString("0.00");
                if (prom6.Text == prom7.Text)
                {
                    prom7.Text = "";
                }

            }
            else
            {
                prom7.Text = "";
            }

            sald = float.Parse(saldo8.Text);
            existencia = float.Parse(exist8.Text);
            entrada = float.Parse(ent8.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom8.Text = promedio.ToString("0.00");
                if (prom7.Text == prom8.Text)
                {
                    prom8.Text = "";
                }

            }
            else
            {
                prom8.Text = "";
            }

            sald = float.Parse(saldo9.Text);
            existencia = float.Parse(exist9.Text);
            entrada = float.Parse(ent9.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom9.Text = promedio.ToString("0.00");
                if (prom8.Text == prom9.Text)
                {
                    prom9.Text = "";
                }

            }
            else
            {
                prom9.Text = "";
            }

            sald = float.Parse(saldo10.Text);
            existencia = float.Parse(exist10.Text);
            entrada = float.Parse(ent10.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom10.Text = promedio.ToString("0.00");
                if (prom9.Text == prom10.Text)
                {
                    prom10.Text = "";
                }

            }
            else
            {
                prom10.Text = "";
            }

            sald = float.Parse(saldo11.Text);
            existencia = float.Parse(exist11.Text);
            entrada = float.Parse(ent11.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom11.Text = promedio.ToString("0.00");
                if (prom10.Text == prom11.Text)
                {
                    prom11.Text = "";
                }

            }
            else
            {
                prom11.Text = "";
            }

            sald = float.Parse(saldo12.Text);
            existencia = float.Parse(exist12.Text);
            entrada = float.Parse(ent12.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom12.Text = promedio.ToString("0.00");
                if (prom11.Text == prom12.Text)
                {
                    prom12.Text = "";
                }

            }
            else
            {
                prom12.Text = "";
            }

            sald = float.Parse(saldo13.Text);
            existencia = float.Parse(exist13.Text);
            entrada = float.Parse(ent13.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom13.Text = promedio.ToString("0.00");
                if (prom12.Text == prom13.Text)
                {
                    prom13.Text = "";
                }

            }
            else
            {
                prom13.Text = "";
            }



            salida = Convert.ToDouble(sal2.Text);
            if (salida > 0)
            {
                pre2.Text = prom1.Text;
            }


            salida = Convert.ToDouble(sal3.Text);
            if (salida > 0)
            {
                pre3.Text = prom2.Text;
                if (prom2.Text == "")
                {
                    pre3.Text = prom1.Text;
                }

            }


            salida = Convert.ToDouble(sal4.Text);
            if (salida > 0)
            {
                pre4.Text = prom3.Text;
                if (prom3.Text == "")
                {
                    pre4.Text = prom2.Text;
                    if (prom2.Text == "")
                    {
                        pre4.Text = prom1.Text;
                    }
                }

            }

            //sssssss
            salida = Convert.ToDouble(sal5.Text);
            if (salida > 0)
            {
                pre5.Text = prom4.Text;
                if (prom4.Text == "")
                {
                    pre5.Text = prom3.Text;
                    if (prom3.Text == "")
                    {
                        pre5.Text = prom2.Text;
                        if (prom2.Text == "")
                        {
                            pre5.Text = prom1.Text;
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal6.Text);
            if (salida > 0)
            {
                pre6.Text = prom5.Text;
                if (prom5.Text == "")
                {
                    pre6.Text = prom4.Text;
                    if (prom4.Text == "")
                    {
                        pre6.Text = prom3.Text;
                        if (prom3.Text == "")
                        {
                            pre6.Text = prom2.Text;
                            if (prom2.Text == "")
                            {
                                pre6.Text = prom1.Text;
                            }
                        }
                    }
                }
            }
            salida = Convert.ToDouble(sal7.Text);
            if (salida > 0)
            {
                pre7.Text = prom6.Text;
                if (prom6.Text == "")
                {
                    pre7.Text = prom5.Text;
                    if (prom5.Text == "")
                    {
                        pre7.Text = prom4.Text;
                        if (prom4.Text == "")
                        {
                            pre7.Text = prom3.Text;
                            if (prom3.Text == "")
                            {
                                pre7.Text = prom2.Text;
                                if (prom2.Text == "")
                                {
                                    pre7.Text = prom1.Text;
                                }
                            }
                        }
                    }
                }
            }
            salida = Convert.ToDouble(sal8.Text);
            if (salida > 0)
            {
                pre8.Text = prom7.Text;
                if (prom7.Text == "")
                {
                    pre8.Text = prom6.Text;
                    if (prom6.Text == "")
                    {
                        pre8.Text = prom5.Text;
                        if (prom5.Text == "")
                        {
                            pre8.Text = prom4.Text;
                            if (prom4.Text == "")
                            {
                                pre8.Text = prom3.Text;
                                if (prom3.Text == "")
                                {
                                    pre8.Text = prom2.Text;
                                    if (prom2.Text == "")
                                    {
                                        pre8.Text = prom1.Text;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal9.Text);
            if (salida > 0)
            {
                pre9.Text = prom8.Text;
                if (prom8.Text == "")
                {
                    pre9.Text = prom7.Text;
                    if (prom7.Text == "")
                    {
                        pre9.Text = prom6.Text;
                        if (prom6.Text == "")
                        {
                            pre9.Text = prom5.Text;
                            if (prom5.Text == "")
                            {
                                pre9.Text = prom4.Text;
                                if (prom4.Text == "")
                                {
                                    pre9.Text = prom3.Text;
                                    if (prom3.Text == "")
                                    {
                                        pre9.Text = prom2.Text;
                                        if (prom2.Text == "")
                                        {
                                            pre9.Text = prom1.Text;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal10.Text);
            if (salida > 0)
            {
                pre10.Text = prom9.Text;
                if (prom9.Text == "")
                {
                    pre10.Text = prom8.Text;
                    if (prom8.Text == "")
                    {
                        pre10.Text = prom7.Text;
                        if (prom7.Text == "")
                        {
                            pre10.Text = prom6.Text;
                            if (prom6.Text == "")
                            {
                                pre10.Text = prom5.Text;
                                if (prom5.Text == "")
                                {
                                    pre10.Text = prom4.Text;
                                    if (prom4.Text == "")
                                    {
                                        pre10.Text = prom3.Text;
                                        if (prom3.Text == "")
                                        {
                                            pre10.Text = prom2.Text;
                                            if (prom2.Text == "")
                                            {
                                                pre10.Text = prom1.Text;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal11.Text);
            if (salida > 0)
            {
                pre11.Text = prom10.Text;
                if (prom10.Text == "")
                {
                    pre11.Text = prom9.Text;
                    if (prom9.Text == "")
                    {
                        pre11.Text = prom8.Text;
                        if (prom8.Text == "")
                        {
                            pre11.Text = prom7.Text;
                            if (prom7.Text == "")
                            {
                                pre11.Text = prom6.Text;
                                if (prom6.Text == "")
                                {
                                    pre11.Text = prom5.Text;
                                    if (prom5.Text == "")
                                    {
                                        pre11.Text = prom4.Text;
                                        if (prom4.Text == "")
                                        {
                                            pre11.Text = prom3.Text;
                                            if (prom3.Text == "")
                                            {
                                                pre11.Text = prom2.Text;
                                                if (prom2.Text == "")
                                                {
                                                    pre11.Text = prom1.Text;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal12.Text);
            if (salida > 0)
            {
                pre12.Text = prom11.Text;
                if (prom10.Text == "")
                {
                    pre12.Text = prom10.Text;
                    if (prom10.Text == "")
                    {
                        pre12.Text = prom9.Text;
                        if (prom9.Text == "")
                        {
                            pre12.Text = prom8.Text;
                            if (prom8.Text == "")
                            {
                                pre12.Text = prom7.Text;
                                if (prom7.Text == "")
                                {
                                    pre12.Text = prom6.Text;
                                    if (prom6.Text == "")
                                    {
                                        pre12.Text = prom5.Text;
                                        if (prom5.Text == "")
                                        {
                                            pre12.Text = prom4.Text;
                                            if (prom4.Text == "")
                                            {
                                                pre12.Text = prom3.Text;
                                                if (prom3.Text == "")
                                                {
                                                    pre12.Text = prom2.Text;
                                                    if (prom2.Text == "")
                                                    {
                                                        pre12.Text = prom1.Text;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            salida = Convert.ToDouble(sal13.Text);
            if (salida > 0)
            {
                pre13.Text = prom12.Text;
                if (prom12.Text == "")
                {
                    pre13.Text = prom11.Text;
                    if (prom11.Text == "")
                    {
                        pre13.Text = prom10.Text;
                        if (prom10.Text == "")
                        {
                            pre13.Text = prom9.Text;
                            if (prom9.Text == "")
                            {
                                pre13.Text = prom8.Text;
                                if (prom8.Text == "")
                                {
                                    pre13.Text = prom7.Text;
                                    if (prom7.Text == "")
                                    {
                                        pre13.Text = prom6.Text;
                                        if (prom6.Text == "")
                                        {
                                            pre13.Text = prom5.Text;
                                            if (prom5.Text == "")
                                            {
                                                pre13.Text = prom4.Text;
                                                if (prom4.Text == "")
                                                {
                                                    pre13.Text = prom3.Text;
                                                    if (prom3.Text == "")
                                                    {
                                                        pre13.Text = prom2.Text;
                                                        if (prom2.Text == "")
                                                        {
                                                            pre13.Text = prom1.Text;

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            hab1.Text = Convert.ToString(0);
            if (pre2.Text == "")
            {
                pre2.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal2.Text);
            pre = double.Parse(pre2.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab2.Text = Convert.ToString(0);
            }
            else
            {
                hab2.Text = Convert.ToString(haber);
            }

            if (pre3.Text == "")
            {
                pre3.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal3.Text);
            pre = double.Parse(pre3.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab3.Text = Convert.ToString(0);
            }
            else
            {
                hab3.Text = Convert.ToString(haber);
            }

            if (pre4.Text == "")
            {
                pre4.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal4.Text);
            pre = double.Parse(pre4.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab4.Text = Convert.ToString(0);
            }
            else
            {
                hab4.Text = Convert.ToString(haber);
            }

            if (pre5.Text == "")
            {
                pre5.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal5.Text);
            pre = double.Parse(pre5.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab5.Text = Convert.ToString(0);
            }
            else
            {
                hab5.Text = Convert.ToString(haber);
            }

            if (pre6.Text == "")
            {
                pre6.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal6.Text);
            pre = double.Parse(pre6.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab6.Text = Convert.ToString(0);
            }
            else
            {
                hab6.Text = Convert.ToString(haber);
            }

            if (pre7.Text == "")
            {
                pre7.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal7.Text);
            pre = double.Parse(pre7.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab7.Text = Convert.ToString(0);
            }
            else
            {
                hab7.Text = Convert.ToString(haber);
            }

            if (pre8.Text == "")
            {
                pre8.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal8.Text);
            pre = double.Parse(pre8.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab8.Text = Convert.ToString(0);
            }
            else
            {
                hab8.Text = Convert.ToString(haber);
            }

            if (pre9.Text == "")
            {
                pre9.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal9.Text);
            pre = double.Parse(pre9.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab9.Text = Convert.ToString(0);
            }
            else
            {
                hab9.Text = Convert.ToString(haber);
            }

            if (pre10.Text == "")
            {
                pre10.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal10.Text);
            pre = double.Parse(pre10.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab10.Text = Convert.ToString(0);
            }
            else
            {
                hab10.Text = Convert.ToString(haber);
            }

            if (pre11.Text == "")
            {
                pre11.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal11.Text);
            pre = double.Parse(pre11.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab11.Text = Convert.ToString(0);
            }
            else
            {
                hab11.Text = Convert.ToString(haber);
            }

            if (pre12.Text == "")
            {
                pre12.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal12.Text);
            pre = double.Parse(pre12.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab12.Text = Convert.ToString(0);
            }
            else
            {
                hab12.Text = Convert.ToString(haber);
            }

            if (pre13.Text == "")
            {
                pre13.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal13.Text);
            pre = double.Parse(pre13.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab13.Text = Convert.ToString(0);
            }
            else
            {
                hab13.Text = Convert.ToString(haber);
            }

            saldo1.Text = deb1.Text;

            sal = double.Parse(saldo1.Text);
            debe = double.Parse(deb2.Text);
            haber = double.Parse(hab2.Text);
            saldo = sal + debe - haber;
            if (debe == 0 && haber == 0)
            {
                saldo2.Text = Convert.ToString(0);
            }
            else
            {
                saldo2.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo2.Text);
            debe = double.Parse(deb3.Text);
            haber = double.Parse(hab3.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo1.Text) + debe - haber;
                saldo3.Text = Convert.ToString(saldo);
            }
            if (debe == 0 && haber == 0)
            {
                saldo3.Text = Convert.ToString(0);

            }
            else
            {
                saldo3.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo3.Text);
            debe = double.Parse(deb4.Text);
            haber = double.Parse(hab4.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo2.Text) + debe - haber;
                saldo4.Text = Convert.ToString(saldo);
                if (double.Parse(saldo2.Text) == 0)
                {
                    saldo = double.Parse(saldo1.Text) + debe - haber;
                    saldo4.Text = Convert.ToString(saldo);
                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo4.Text = Convert.ToString(0);
            }
            else
            {
                saldo4.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo4.Text);
            debe = double.Parse(deb5.Text);
            haber = double.Parse(hab5.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo3.Text) + debe - haber;
                saldo5.Text = Convert.ToString(saldo);
                if (double.Parse(saldo3.Text) == 0)
                {
                    saldo = double.Parse(saldo2.Text) + debe - haber;
                    saldo5.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo2.Text) == 0)
                    {
                        saldo = double.Parse(saldo1.Text) + debe - haber;
                        saldo5.Text = Convert.ToString(saldo);
                    }
                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo5.Text = Convert.ToString(0);
            }
            else
            {
                saldo5.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo5.Text);
            debe = double.Parse(deb6.Text);
            haber = double.Parse(hab6.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo4.Text) + debe - haber;
                saldo6.Text = Convert.ToString(saldo);
                if (double.Parse(saldo4.Text) == 0)
                {
                    saldo = double.Parse(saldo3.Text) + debe - haber;
                    saldo6.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo2.Text) == 0)
                    {
                        saldo = double.Parse(saldo2.Text) + debe - haber;
                        saldo6.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo2.Text) == 0)
                        {
                            saldo = double.Parse(saldo1.Text) + debe - haber;
                            saldo6.Text = Convert.ToString(saldo);
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo6.Text = Convert.ToString(0);
            }
            else
            {
                saldo6.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo6.Text);
            debe = double.Parse(deb7.Text);
            haber = double.Parse(hab7.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo5.Text) + debe - haber;
                saldo7.Text = Convert.ToString(saldo);
                if (double.Parse(saldo5.Text) == 0)
                {
                    saldo = double.Parse(saldo4.Text) + debe - haber;
                    saldo7.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo4.Text) == 0)
                    {
                        saldo = double.Parse(saldo3.Text) + debe - haber;
                        saldo7.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo3.Text) == 0)
                        {
                            saldo = double.Parse(saldo2.Text) + debe - haber;
                            saldo7.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo2.Text) == 0)
                            {
                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                saldo7.Text = Convert.ToString(saldo);

                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo7.Text = Convert.ToString(0);
            }
            else
            {
                saldo7.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo7.Text);
            debe = double.Parse(deb8.Text);
            haber = double.Parse(hab8.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo6.Text) + debe - haber;
                saldo8.Text = Convert.ToString(saldo);
                if (double.Parse(saldo6.Text) == 0)
                {
                    saldo = double.Parse(saldo5.Text) + debe - haber;
                    saldo8.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo5.Text) == 0)
                    {
                        saldo = double.Parse(saldo4.Text) + debe - haber;
                        saldo8.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo4.Text) == 0)
                        {
                            saldo = double.Parse(saldo3.Text) + debe - haber;
                            saldo8.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo3.Text) == 0)
                            {
                                saldo = double.Parse(saldo2.Text) + debe - haber;
                                saldo8.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo2.Text) == 0)
                                {
                                    saldo = double.Parse(saldo1.Text) + debe - haber;
                                    saldo8.Text = Convert.ToString(saldo);

                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo8.Text = Convert.ToString(0);
            }
            else
            {
                saldo8.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo8.Text);
            debe = double.Parse(deb9.Text);
            haber = double.Parse(hab9.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo7.Text) + debe - haber;
                saldo9.Text = Convert.ToString(saldo);
                if (double.Parse(saldo7.Text) == 0)
                {
                    saldo = double.Parse(saldo6.Text) + debe - haber;
                    saldo9.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo6.Text) == 0)
                    {
                        saldo = double.Parse(saldo5.Text) + debe - haber;
                        saldo9.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo5.Text) == 0)
                        {
                            saldo = double.Parse(saldo4.Text) + debe - haber;
                            saldo9.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo4.Text) == 0)
                            {
                                saldo = double.Parse(saldo3.Text) + debe - haber;
                                saldo9.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo3.Text) == 0)
                                {
                                    saldo = double.Parse(saldo2.Text) + debe - haber;
                                    saldo9.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo2.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo1.Text) + debe - haber;
                                        saldo9.Text = Convert.ToString(saldo);

                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo9.Text = Convert.ToString(0);
            }
            else
            {
                saldo9.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo9.Text);
            debe = double.Parse(deb10.Text);
            haber = double.Parse(hab10.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo8.Text) + debe - haber;
                saldo10.Text = Convert.ToString(saldo);
                if (double.Parse(saldo8.Text) == 0)
                {
                    saldo = double.Parse(saldo7.Text) + debe - haber;
                    saldo10.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo7.Text) == 0)
                    {
                        saldo = double.Parse(saldo6.Text) + debe - haber;
                        saldo10.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo6.Text) == 0)
                        {
                            saldo = double.Parse(saldo5.Text) + debe - haber;
                            saldo10.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo5.Text) == 0)
                            {
                                saldo = double.Parse(saldo4.Text) + debe - haber;
                                saldo10.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo4.Text) == 0)
                                {
                                    saldo = double.Parse(saldo3.Text) + debe - haber;
                                    saldo10.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo3.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo2.Text) + debe - haber;
                                        saldo10.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo2.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo1.Text) + debe - haber;
                                            saldo10.Text = Convert.ToString(saldo);

                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo10.Text = Convert.ToString(0);
            }
            else
            {
                saldo10.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo10.Text);
            debe = double.Parse(deb11.Text);
            haber = double.Parse(hab11.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo9.Text) + debe - haber;
                saldo11.Text = Convert.ToString(saldo);
                if (double.Parse(saldo9.Text) == 0)
                {
                    saldo = double.Parse(saldo8.Text) + debe - haber;
                    saldo11.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo8.Text) == 0)
                    {
                        saldo = double.Parse(saldo7.Text) + debe - haber;
                        saldo11.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo7.Text) == 0)
                        {
                            saldo = double.Parse(saldo6.Text) + debe - haber;
                            saldo11.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo6.Text) == 0)
                            {
                                saldo = double.Parse(saldo5.Text) + debe - haber;
                                saldo11.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo5.Text) == 0)
                                {
                                    saldo = double.Parse(saldo4.Text) + debe - haber;
                                    saldo11.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo4.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo3.Text) + debe - haber;
                                        saldo11.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo3.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo2.Text) + debe - haber;
                                            saldo11.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo2.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                                saldo11.Text = Convert.ToString(saldo);

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo11.Text = Convert.ToString(0);
            }
            else
            {
                saldo11.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo11.Text);
            debe = double.Parse(deb12.Text);
            haber = double.Parse(hab12.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo10.Text) + debe - haber;
                saldo12.Text = Convert.ToString(saldo);
                if (double.Parse(saldo10.Text) == 0)
                {
                    saldo = double.Parse(saldo9.Text) + debe - haber;
                    saldo12.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo9.Text) == 0)
                    {
                        saldo = double.Parse(saldo8.Text) + debe - haber;
                        saldo12.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo8.Text) == 0)
                        {
                            saldo = double.Parse(saldo7.Text) + debe - haber;
                            saldo12.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo7.Text) == 0)
                            {
                                saldo = double.Parse(saldo6.Text) + debe - haber;
                                saldo12.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo6.Text) == 0)
                                {
                                    saldo = double.Parse(saldo5.Text) + debe - haber;
                                    saldo12.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo5.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo4.Text) + debe - haber;
                                        saldo12.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo4.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo3.Text) + debe - haber;
                                            saldo12.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo3.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo2.Text) + debe - haber;
                                                saldo12.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo2.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo1.Text) + debe - haber;
                                                    saldo12.Text = Convert.ToString(saldo);

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo12.Text = Convert.ToString(0);
            }
            else
            {
                saldo12.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo12.Text);
            debe = double.Parse(deb13.Text);
            haber = double.Parse(hab13.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo11.Text) + debe - haber;
                saldo13.Text = Convert.ToString(saldo);
                if (double.Parse(saldo11.Text) == 0)
                {
                    saldo = double.Parse(saldo10.Text) + debe - haber;
                    saldo13.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo10.Text) == 0)
                    {
                        saldo = double.Parse(saldo9.Text) + debe - haber;
                        saldo13.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo9.Text) == 0)
                        {
                            saldo = double.Parse(saldo8.Text) + debe - haber;
                            saldo13.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo8.Text) == 0)
                            {
                                saldo = double.Parse(saldo7.Text) + debe - haber;
                                saldo13.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo7.Text) == 0)
                                {
                                    saldo = double.Parse(saldo6.Text) + debe - haber;
                                    saldo13.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo6.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo5.Text) + debe - haber;
                                        saldo13.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo5.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo4.Text) + debe - haber;
                                            saldo13.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo4.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo3.Text) + debe - haber;
                                                saldo13.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo3.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo2.Text) + debe - haber;
                                                    saldo13.Text = Convert.ToString(saldo);
                                                    if (double.Parse(saldo2.Text) == 0)
                                                    {
                                                        saldo = double.Parse(saldo1.Text) + debe - haber;
                                                        saldo13.Text = Convert.ToString(saldo);

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo13.Text = Convert.ToString(0);
            }
            else
            {
                saldo13.Text = Convert.ToString(saldo);
            }


            prom1.Text = pre1.Text;

            sald = float.Parse(saldo2.Text);
            existencia = float.Parse(exist2.Text);
            entrada = float.Parse(ent2.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom2.Text = promedio.ToString("0.00");
                if (prom1.Text == prom2.Text)
                {
                    prom2.Text = "";
                }

            }
            else
            {
                prom2.Text = "";
            }

            sald = float.Parse(saldo3.Text);
            existencia = float.Parse(exist3.Text);
            entrada = float.Parse(ent3.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom3.Text = promedio.ToString("0.00");
                if (prom2.Text == prom3.Text)
                {
                    prom3.Text = "";
                }

            }
            else
            {
                prom3.Text = "";
            }

            sald = float.Parse(saldo4.Text);
            existencia = float.Parse(exist4.Text);
            entrada = float.Parse(ent4.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom4.Text = promedio.ToString("0.00");
                if (prom3.Text == prom4.Text)
                {
                    prom4.Text = "";
                }

            }
            else
            {
                prom4.Text = "";
            }

            sald = float.Parse(saldo5.Text);
            existencia = float.Parse(exist5.Text);
            entrada = float.Parse(ent5.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom5.Text = promedio.ToString("0.00");
                if (prom4.Text == prom5.Text)
                {
                    prom5.Text = "";
                }

            }
            else
            {
                prom5.Text = "";
            }

            sald = float.Parse(saldo6.Text);
            existencia = float.Parse(exist6.Text);
            entrada = float.Parse(ent6.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom6.Text = promedio.ToString("0.00");
                if (prom5.Text == prom6.Text)
                {
                    prom6.Text = "";
                }

            }
            else
            {
                prom6.Text = "";
            }


            sald = float.Parse(saldo7.Text);
            existencia = float.Parse(exist7.Text);
            entrada = float.Parse(ent7.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom7.Text = promedio.ToString("0.00");
                if (prom6.Text == prom7.Text)
                {
                    prom7.Text = "";
                }

            }
            else
            {
                prom7.Text = "";
            }

            sald = float.Parse(saldo8.Text);
            existencia = float.Parse(exist8.Text);
            entrada = float.Parse(ent8.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom8.Text = promedio.ToString("0.00");
                if (prom7.Text == prom8.Text)
                {
                    prom8.Text = "";
                }

            }
            else
            {
                prom8.Text = "";
            }

            sald = float.Parse(saldo9.Text);
            existencia = float.Parse(exist9.Text);
            entrada = float.Parse(ent9.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom9.Text = promedio.ToString("0.00");
                if (prom8.Text == prom9.Text)
                {
                    prom9.Text = "";
                }

            }
            else
            {
                prom9.Text = "";
            }

            sald = float.Parse(saldo10.Text);
            existencia = float.Parse(exist10.Text);
            entrada = float.Parse(ent10.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom10.Text = promedio.ToString("0.00");
                if (prom9.Text == prom10.Text)
                {
                    prom10.Text = "";
                }

            }
            else
            {
                prom10.Text = "";
            }

            sald = float.Parse(saldo11.Text);
            existencia = float.Parse(exist11.Text);
            entrada = float.Parse(ent11.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom11.Text = promedio.ToString("0.00");
                if (prom10.Text == prom11.Text)
                {
                    prom11.Text = "";
                }

            }
            else
            {
                prom11.Text = "";
            }

            sald = float.Parse(saldo12.Text);
            existencia = float.Parse(exist12.Text);
            entrada = float.Parse(ent12.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom12.Text = promedio.ToString("0.00");
                if (prom11.Text == prom12.Text)
                {
                    prom12.Text = "";
                }

            }
            else
            {
                prom12.Text = "";
            }

            sald = float.Parse(saldo13.Text);
            existencia = float.Parse(exist13.Text);
            entrada = float.Parse(ent13.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom13.Text = promedio.ToString("0.00");
                if (prom12.Text == prom13.Text)
                {
                    prom13.Text = "";
                }

            }
            else
            {
                prom13.Text = "";
            }



            salida = Convert.ToDouble(sal2.Text);
            if (salida > 0)
            {
                pre2.Text = prom1.Text;
            }


            salida = Convert.ToDouble(sal3.Text);
            if (salida > 0)
            {
                pre3.Text = prom2.Text;
                if (prom2.Text == "")
                {
                    pre3.Text = prom1.Text;
                }

            }


            salida = Convert.ToDouble(sal4.Text);
            if (salida > 0)
            {
                pre4.Text = prom3.Text;
                if (prom3.Text == "")
                {
                    pre4.Text = prom2.Text;
                    if (prom2.Text == "")
                    {
                        pre4.Text = prom1.Text;
                    }
                }

            }

            //sssssss
            salida = Convert.ToDouble(sal5.Text);
            if (salida > 0)
            {
                pre5.Text = prom4.Text;
                if (prom4.Text == "")
                {
                    pre5.Text = prom3.Text;
                    if (prom3.Text == "")
                    {
                        pre5.Text = prom2.Text;
                        if (prom2.Text == "")
                        {
                            pre5.Text = prom1.Text;
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal6.Text);
            if (salida > 0)
            {
                pre6.Text = prom5.Text;
                if (prom5.Text == "")
                {
                    pre6.Text = prom4.Text;
                    if (prom4.Text == "")
                    {
                        pre6.Text = prom3.Text;
                        if (prom3.Text == "")
                        {
                            pre6.Text = prom2.Text;
                            if (prom2.Text == "")
                            {
                                pre6.Text = prom1.Text;
                            }
                        }
                    }
                }
            }
            salida = Convert.ToDouble(sal7.Text);
            if (salida > 0)
            {
                pre7.Text = prom6.Text;
                if (prom6.Text == "")
                {
                    pre7.Text = prom5.Text;
                    if (prom5.Text == "")
                    {
                        pre7.Text = prom4.Text;
                        if (prom4.Text == "")
                        {
                            pre7.Text = prom3.Text;
                            if (prom3.Text == "")
                            {
                                pre7.Text = prom2.Text;
                                if (prom2.Text == "")
                                {
                                    pre7.Text = prom1.Text;
                                }
                            }
                        }
                    }
                }
            }
            salida = Convert.ToDouble(sal8.Text);
            if (salida > 0)
            {
                pre8.Text = prom7.Text;
                if (prom7.Text == "")
                {
                    pre8.Text = prom6.Text;
                    if (prom6.Text == "")
                    {
                        pre8.Text = prom5.Text;
                        if (prom5.Text == "")
                        {
                            pre8.Text = prom4.Text;
                            if (prom4.Text == "")
                            {
                                pre8.Text = prom3.Text;
                                if (prom3.Text == "")
                                {
                                    pre8.Text = prom2.Text;
                                    if (prom2.Text == "")
                                    {
                                        pre8.Text = prom1.Text;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal9.Text);
            if (salida > 0)
            {
                pre9.Text = prom8.Text;
                if (prom8.Text == "")
                {
                    pre9.Text = prom7.Text;
                    if (prom7.Text == "")
                    {
                        pre9.Text = prom6.Text;
                        if (prom6.Text == "")
                        {
                            pre9.Text = prom5.Text;
                            if (prom5.Text == "")
                            {
                                pre9.Text = prom4.Text;
                                if (prom4.Text == "")
                                {
                                    pre9.Text = prom3.Text;
                                    if (prom3.Text == "")
                                    {
                                        pre9.Text = prom2.Text;
                                        if (prom2.Text == "")
                                        {
                                            pre9.Text = prom1.Text;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal10.Text);
            if (salida > 0)
            {
                pre10.Text = prom9.Text;
                if (prom9.Text == "")
                {
                    pre10.Text = prom8.Text;
                    if (prom8.Text == "")
                    {
                        pre10.Text = prom7.Text;
                        if (prom7.Text == "")
                        {
                            pre10.Text = prom6.Text;
                            if (prom6.Text == "")
                            {
                                pre10.Text = prom5.Text;
                                if (prom5.Text == "")
                                {
                                    pre10.Text = prom4.Text;
                                    if (prom4.Text == "")
                                    {
                                        pre10.Text = prom3.Text;
                                        if (prom3.Text == "")
                                        {
                                            pre10.Text = prom2.Text;
                                            if (prom2.Text == "")
                                            {
                                                pre10.Text = prom1.Text;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal11.Text);
            if (salida > 0)
            {
                pre11.Text = prom10.Text;
                if (prom10.Text == "")
                {
                    pre11.Text = prom9.Text;
                    if (prom9.Text == "")
                    {
                        pre11.Text = prom8.Text;
                        if (prom8.Text == "")
                        {
                            pre11.Text = prom7.Text;
                            if (prom7.Text == "")
                            {
                                pre11.Text = prom6.Text;
                                if (prom6.Text == "")
                                {
                                    pre11.Text = prom5.Text;
                                    if (prom5.Text == "")
                                    {
                                        pre11.Text = prom4.Text;
                                        if (prom4.Text == "")
                                        {
                                            pre11.Text = prom3.Text;
                                            if (prom3.Text == "")
                                            {
                                                pre11.Text = prom2.Text;
                                                if (prom2.Text == "")
                                                {
                                                    pre11.Text = prom1.Text;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal12.Text);
            if (salida > 0)
            {
                pre12.Text = prom11.Text;
                if (prom10.Text == "")
                {
                    pre12.Text = prom10.Text;
                    if (prom10.Text == "")
                    {
                        pre12.Text = prom9.Text;
                        if (prom9.Text == "")
                        {
                            pre12.Text = prom8.Text;
                            if (prom8.Text == "")
                            {
                                pre12.Text = prom7.Text;
                                if (prom7.Text == "")
                                {
                                    pre12.Text = prom6.Text;
                                    if (prom6.Text == "")
                                    {
                                        pre12.Text = prom5.Text;
                                        if (prom5.Text == "")
                                        {
                                            pre12.Text = prom4.Text;
                                            if (prom4.Text == "")
                                            {
                                                pre12.Text = prom3.Text;
                                                if (prom3.Text == "")
                                                {
                                                    pre12.Text = prom2.Text;
                                                    if (prom2.Text == "")
                                                    {
                                                        pre12.Text = prom1.Text;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            salida = Convert.ToDouble(sal13.Text);
            if (salida > 0)
            {
                pre13.Text = prom12.Text;
                if (prom12.Text == "")
                {
                    pre13.Text = prom11.Text;
                    if (prom11.Text == "")
                    {
                        pre13.Text = prom10.Text;
                        if (prom10.Text == "")
                        {
                            pre13.Text = prom9.Text;
                            if (prom9.Text == "")
                            {
                                pre13.Text = prom8.Text;
                                if (prom8.Text == "")
                                {
                                    pre13.Text = prom7.Text;
                                    if (prom7.Text == "")
                                    {
                                        pre13.Text = prom6.Text;
                                        if (prom6.Text == "")
                                        {
                                            pre13.Text = prom5.Text;
                                            if (prom5.Text == "")
                                            {
                                                pre13.Text = prom4.Text;
                                                if (prom4.Text == "")
                                                {
                                                    pre13.Text = prom3.Text;
                                                    if (prom3.Text == "")
                                                    {
                                                        pre13.Text = prom2.Text;
                                                        if (prom2.Text == "")
                                                        {
                                                            pre13.Text = prom1.Text;

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }


                    hab1.Text = Convert.ToString(0);
                    if (pre2.Text == "")
                    {
                        pre2.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal2.Text);
                    pre = double.Parse(pre2.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab2.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab2.Text = Convert.ToString(haber);
                    }

                    if (pre3.Text == "")
                    {
                        pre3.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal3.Text);
                    pre = double.Parse(pre3.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab3.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab3.Text = Convert.ToString(haber);
                    }

                    if (pre4.Text == "")
                    {
                        pre4.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal4.Text);
                    pre = double.Parse(pre4.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab4.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab4.Text = Convert.ToString(haber);
                    }

                    if (pre5.Text == "")
                    {
                        pre5.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal5.Text);
                    pre = double.Parse(pre5.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab5.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab5.Text = Convert.ToString(haber);
                    }

                    if (pre6.Text == "")
                    {
                        pre6.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal6.Text);
                    pre = double.Parse(pre6.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab6.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab6.Text = Convert.ToString(haber);
                    }

                    if (pre7.Text == "")
                    {
                        pre7.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal7.Text);
                    pre = double.Parse(pre7.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab7.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab7.Text = Convert.ToString(haber);
                    }

                    if (pre8.Text == "")
                    {
                        pre8.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal8.Text);
                    pre = double.Parse(pre8.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab8.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab8.Text = Convert.ToString(haber);
                    }

                    if (pre9.Text == "")
                    {
                        pre9.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal9.Text);
                    pre = double.Parse(pre9.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab9.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab9.Text = Convert.ToString(haber);
                    }

                    if (pre10.Text == "")
                    {
                        pre10.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal10.Text);
                    pre = double.Parse(pre10.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab10.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab10.Text = Convert.ToString(haber);
                    }

                    if (pre11.Text == "")
                    {
                        pre11.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal11.Text);
                    pre = double.Parse(pre11.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab11.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab11.Text = Convert.ToString(haber);
                    }

                    if (pre12.Text == "")
                    {
                        pre12.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal12.Text);
                    pre = double.Parse(pre12.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab12.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab12.Text = Convert.ToString(haber);
                    }

                    if (pre13.Text == "")
                    {
                        pre13.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal13.Text);
                    pre = double.Parse(pre13.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab13.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab13.Text = Convert.ToString(haber);
                    }


                    saldo1.Text = deb1.Text;

                    sal = double.Parse(saldo1.Text);
                    debe = double.Parse(deb2.Text);
                    haber = double.Parse(hab2.Text);
                    saldo = sal + debe - haber;
                    if (debe == 0 && haber == 0)
                    {
                        saldo2.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo2.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo2.Text);
                    debe = double.Parse(deb3.Text);
                    haber = double.Parse(hab3.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo1.Text) + debe - haber;
                        saldo3.Text = Convert.ToString(saldo);
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo3.Text = Convert.ToString(0);

                    }
                    else
                    {
                        saldo3.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo3.Text);
                    debe = double.Parse(deb4.Text);
                    haber = double.Parse(hab4.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo2.Text) + debe - haber;
                        saldo4.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo2.Text) == 0)
                        {
                            saldo = double.Parse(saldo1.Text) + debe - haber;
                            saldo4.Text = Convert.ToString(saldo);
                        }
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo4.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo4.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo4.Text);
                    debe = double.Parse(deb5.Text);
                    haber = double.Parse(hab5.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo3.Text) + debe - haber;
                        saldo5.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo3.Text) == 0)
                        {
                            saldo = double.Parse(saldo2.Text) + debe - haber;
                            saldo5.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo2.Text) == 0)
                            {
                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                saldo5.Text = Convert.ToString(saldo);
                            }
                        }
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo5.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo5.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo5.Text);
                    debe = double.Parse(deb6.Text);
                    haber = double.Parse(hab6.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo4.Text) + debe - haber;
                        saldo6.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo4.Text) == 0)
                        {
                            saldo = double.Parse(saldo3.Text) + debe - haber;
                            saldo6.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo2.Text) == 0)
                            {
                                saldo = double.Parse(saldo2.Text) + debe - haber;
                                saldo6.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo2.Text) == 0)
                                {
                                    saldo = double.Parse(saldo1.Text) + debe - haber;
                                    saldo6.Text = Convert.ToString(saldo);
                                }
                            }

                        }
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo6.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo6.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo6.Text);
                    debe = double.Parse(deb7.Text);
                    haber = double.Parse(hab7.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo5.Text) + debe - haber;
                        saldo7.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo5.Text) == 0)
                        {
                            saldo = double.Parse(saldo4.Text) + debe - haber;
                            saldo7.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo4.Text) == 0)
                            {
                                saldo = double.Parse(saldo3.Text) + debe - haber;
                                saldo7.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo3.Text) == 0)
                                {
                                    saldo = double.Parse(saldo2.Text) + debe - haber;
                                    saldo7.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo2.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo1.Text) + debe - haber;
                                        saldo7.Text = Convert.ToString(saldo);

                                    }
                                }
                            }

                        }
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo7.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo7.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo7.Text);
                    debe = double.Parse(deb8.Text);
                    haber = double.Parse(hab8.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo6.Text) + debe - haber;
                        saldo8.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo6.Text) == 0)
                        {
                            saldo = double.Parse(saldo5.Text) + debe - haber;
                            saldo8.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo5.Text) == 0)
                            {
                                saldo = double.Parse(saldo4.Text) + debe - haber;
                                saldo8.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo4.Text) == 0)
                                {
                                    saldo = double.Parse(saldo3.Text) + debe - haber;
                                    saldo8.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo3.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo2.Text) + debe - haber;
                                        saldo8.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo2.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo1.Text) + debe - haber;
                                            saldo8.Text = Convert.ToString(saldo);

                                        }
                                    }
                                }
                            }

                        }
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo8.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo8.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo8.Text);
                    debe = double.Parse(deb9.Text);
                    haber = double.Parse(hab9.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo7.Text) + debe - haber;
                        saldo9.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo7.Text) == 0)
                        {
                            saldo = double.Parse(saldo6.Text) + debe - haber;
                            saldo9.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo6.Text) == 0)
                            {
                                saldo = double.Parse(saldo5.Text) + debe - haber;
                                saldo9.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo5.Text) == 0)
                                {
                                    saldo = double.Parse(saldo4.Text) + debe - haber;
                                    saldo9.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo4.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo3.Text) + debe - haber;
                                        saldo9.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo3.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo2.Text) + debe - haber;
                                            saldo9.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo2.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                                saldo9.Text = Convert.ToString(saldo);

                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo9.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo9.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo9.Text);
                    debe = double.Parse(deb10.Text);
                    haber = double.Parse(hab10.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo8.Text) + debe - haber;
                        saldo10.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo8.Text) == 0)
                        {
                            saldo = double.Parse(saldo7.Text) + debe - haber;
                            saldo10.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo7.Text) == 0)
                            {
                                saldo = double.Parse(saldo6.Text) + debe - haber;
                                saldo10.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo6.Text) == 0)
                                {
                                    saldo = double.Parse(saldo5.Text) + debe - haber;
                                    saldo10.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo5.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo4.Text) + debe - haber;
                                        saldo10.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo4.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo3.Text) + debe - haber;
                                            saldo10.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo3.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo2.Text) + debe - haber;
                                                saldo10.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo2.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo1.Text) + debe - haber;
                                                    saldo10.Text = Convert.ToString(saldo);

                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo10.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo10.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo10.Text);
                    debe = double.Parse(deb11.Text);
                    haber = double.Parse(hab11.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo9.Text) + debe - haber;
                        saldo11.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo9.Text) == 0)
                        {
                            saldo = double.Parse(saldo8.Text) + debe - haber;
                            saldo11.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo8.Text) == 0)
                            {
                                saldo = double.Parse(saldo7.Text) + debe - haber;
                                saldo11.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo7.Text) == 0)
                                {
                                    saldo = double.Parse(saldo6.Text) + debe - haber;
                                    saldo11.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo6.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo5.Text) + debe - haber;
                                        saldo11.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo5.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo4.Text) + debe - haber;
                                            saldo11.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo4.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo3.Text) + debe - haber;
                                                saldo11.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo3.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo2.Text) + debe - haber;
                                                    saldo11.Text = Convert.ToString(saldo);
                                                    if (double.Parse(saldo2.Text) == 0)
                                                    {
                                                        saldo = double.Parse(saldo1.Text) + debe - haber;
                                                        saldo11.Text = Convert.ToString(saldo);

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo11.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo11.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo11.Text);
                    debe = double.Parse(deb12.Text);
                    haber = double.Parse(hab12.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo10.Text) + debe - haber;
                        saldo12.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo10.Text) == 0)
                        {
                            saldo = double.Parse(saldo9.Text) + debe - haber;
                            saldo12.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo9.Text) == 0)
                            {
                                saldo = double.Parse(saldo8.Text) + debe - haber;
                                saldo12.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo8.Text) == 0)
                                {
                                    saldo = double.Parse(saldo7.Text) + debe - haber;
                                    saldo12.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo7.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo6.Text) + debe - haber;
                                        saldo12.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo6.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo5.Text) + debe - haber;
                                            saldo12.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo5.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo4.Text) + debe - haber;
                                                saldo12.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo4.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo3.Text) + debe - haber;
                                                    saldo12.Text = Convert.ToString(saldo);
                                                    if (double.Parse(saldo3.Text) == 0)
                                                    {
                                                        saldo = double.Parse(saldo2.Text) + debe - haber;
                                                        saldo12.Text = Convert.ToString(saldo);
                                                        if (double.Parse(saldo2.Text) == 0)
                                                        {
                                                            saldo = double.Parse(saldo1.Text) + debe - haber;
                                                            saldo12.Text = Convert.ToString(saldo);

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo12.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo12.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo12.Text);
                    debe = double.Parse(deb13.Text);
                    haber = double.Parse(hab13.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo11.Text) + debe - haber;
                        saldo13.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo11.Text) == 0)
                        {
                            saldo = double.Parse(saldo10.Text) + debe - haber;
                            saldo13.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo10.Text) == 0)
                            {
                                saldo = double.Parse(saldo9.Text) + debe - haber;
                                saldo13.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo9.Text) == 0)
                                {
                                    saldo = double.Parse(saldo8.Text) + debe - haber;
                                    saldo13.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo8.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo7.Text) + debe - haber;
                                        saldo13.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo7.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo6.Text) + debe - haber;
                                            saldo13.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo6.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo5.Text) + debe - haber;
                                                saldo13.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo5.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo4.Text) + debe - haber;
                                                    saldo13.Text = Convert.ToString(saldo);
                                                    if (double.Parse(saldo4.Text) == 0)
                                                    {
                                                        saldo = double.Parse(saldo3.Text) + debe - haber;
                                                        saldo13.Text = Convert.ToString(saldo);
                                                        if (double.Parse(saldo3.Text) == 0)
                                                        {
                                                            saldo = double.Parse(saldo2.Text) + debe - haber;
                                                            saldo13.Text = Convert.ToString(saldo);
                                                            if (double.Parse(saldo2.Text) == 0)
                                                            {
                                                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                                                saldo13.Text = Convert.ToString(saldo);

                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo13.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo13.Text = Convert.ToString(saldo);
                    }



                    prom1.Text = pre1.Text;

                    sald = float.Parse(saldo2.Text);
                    existencia = float.Parse(exist2.Text);
                    entrada = float.Parse(ent2.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom2.Text = promedio.ToString("0.00");
                        if (prom1.Text == prom2.Text)
                        {
                            prom2.Text = "";
                        }

                    }
                    else
                    {
                        prom2.Text = "";
                    }

                    sald = float.Parse(saldo3.Text);
                    existencia = float.Parse(exist3.Text);
                    entrada = float.Parse(ent3.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom3.Text = promedio.ToString("0.00");
                        if (prom2.Text == prom3.Text)
                        {
                            prom3.Text = "";
                        }

                    }
                    else
                    {
                        prom3.Text = "";
                    }

                    sald = float.Parse(saldo4.Text);
                    existencia = float.Parse(exist4.Text);
                    entrada = float.Parse(ent4.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom4.Text = promedio.ToString("0.00");
                        if (prom3.Text == prom4.Text)
                        {
                            prom4.Text = "";
                        }

                    }
                    else
                    {
                        prom4.Text = "";
                    }

                    sald = float.Parse(saldo5.Text);
                    existencia = float.Parse(exist5.Text);
                    entrada = float.Parse(ent5.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom5.Text = promedio.ToString("0.00");
                        if (prom4.Text == prom5.Text)
                        {
                            prom5.Text = "";
                        }

                    }
                    else
                    {
                        prom5.Text = "";
                    }

                    sald = float.Parse(saldo6.Text);
                    existencia = float.Parse(exist6.Text);
                    entrada = float.Parse(ent6.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom6.Text = promedio.ToString("0.00");
                        if (prom5.Text == prom6.Text)
                        {
                            prom6.Text = "";
                        }

                    }
                    else
                    {
                        prom6.Text = "";
                    }


                    sald = float.Parse(saldo7.Text);
                    existencia = float.Parse(exist7.Text);
                    entrada = float.Parse(ent7.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom7.Text = promedio.ToString("0.00");
                        if (prom6.Text == prom7.Text)
                        {
                            prom7.Text = "";
                        }

                    }
                    else
                    {
                        prom7.Text = "";
                    }

                    sald = float.Parse(saldo8.Text);
                    existencia = float.Parse(exist8.Text);
                    entrada = float.Parse(ent8.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom8.Text = promedio.ToString("0.00");
                        if (prom7.Text == prom8.Text)
                        {
                            prom8.Text = "";
                        }

                    }
                    else
                    {
                        prom8.Text = "";
                    }

                    sald = float.Parse(saldo9.Text);
                    existencia = float.Parse(exist9.Text);
                    entrada = float.Parse(ent9.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom9.Text = promedio.ToString("0.00");
                        if (prom8.Text == prom9.Text)
                        {
                            prom9.Text = "";
                        }

                    }
                    else
                    {
                        prom9.Text = "";
                    }

                    sald = float.Parse(saldo10.Text);
                    existencia = float.Parse(exist10.Text);
                    entrada = float.Parse(ent10.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom10.Text = promedio.ToString("0.00");
                        if (prom9.Text == prom10.Text)
                        {
                            prom10.Text = "";
                        }

                    }
                    else
                    {
                        prom10.Text = "";
                    }

                    sald = float.Parse(saldo11.Text);
                    existencia = float.Parse(exist11.Text);
                    entrada = float.Parse(ent11.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom11.Text = promedio.ToString("0.00");
                        if (prom10.Text == prom11.Text)
                        {
                            prom11.Text = "";
                        }

                    }
                    else
                    {
                        prom11.Text = "";
                    }

                    sald = float.Parse(saldo12.Text);
                    existencia = float.Parse(exist12.Text);
                    entrada = float.Parse(ent12.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom12.Text = promedio.ToString("0.00");
                        if (prom11.Text == prom12.Text)
                        {
                            prom12.Text = "";
                        }

                    }
                    else
                    {
                        prom12.Text = "";
                    }

                    sald = float.Parse(saldo13.Text);
                    existencia = float.Parse(exist13.Text);
                    entrada = float.Parse(ent13.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom13.Text = promedio.ToString("0.00");
                        if (prom12.Text == prom13.Text)
                        {
                            prom13.Text = "";
                        }

                    }
                    else
                    {
                        prom13.Text = "";
                    }
                    salida = Convert.ToDouble(sal2.Text);
                    if (salida > 0)
                    {
                        pre2.Text = prom1.Text;
                    }


                    salida = Convert.ToDouble(sal3.Text);
                    if (salida > 0)
                    {
                        pre3.Text = prom2.Text;
                        if (prom2.Text == "")
                        {
                            pre3.Text = prom1.Text;
                        }

                    }


                    salida = Convert.ToDouble(sal4.Text);
                    if (salida > 0)
                    {
                        pre4.Text = prom3.Text;
                        if (prom3.Text == "")
                        {
                            pre4.Text = prom2.Text;
                            if (prom2.Text == "")
                            {
                                pre4.Text = prom1.Text;
                            }
                        }

                    }

                    //sssssss
                    salida = Convert.ToDouble(sal5.Text);
                    if (salida > 0)
                    {
                        pre5.Text = prom4.Text;
                        if (prom4.Text == "")
                        {
                            pre5.Text = prom3.Text;
                            if (prom3.Text == "")
                            {
                                pre5.Text = prom2.Text;
                                if (prom2.Text == "")
                                {
                                    pre5.Text = prom1.Text;
                                }
                            }
                        }
                    }

                    salida = Convert.ToDouble(sal6.Text);
                    if (salida > 0)
                    {
                        pre6.Text = prom5.Text;
                        if (prom5.Text == "")
                        {
                            pre6.Text = prom4.Text;
                            if (prom4.Text == "")
                            {
                                pre6.Text = prom3.Text;
                                if (prom3.Text == "")
                                {
                                    pre6.Text = prom2.Text;
                                    if (prom2.Text == "")
                                    {
                                        pre6.Text = prom1.Text;
                                    }
                                }
                            }
                        }
                    }
                    salida = Convert.ToDouble(sal7.Text);
                    if (salida > 0)
                    {
                        pre7.Text = prom6.Text;
                        if (prom6.Text == "")
                        {
                            pre7.Text = prom5.Text;
                            if (prom5.Text == "")
                            {
                                pre7.Text = prom4.Text;
                                if (prom4.Text == "")
                                {
                                    pre7.Text = prom3.Text;
                                    if (prom3.Text == "")
                                    {
                                        pre7.Text = prom2.Text;
                                        if (prom2.Text == "")
                                        {
                                            pre7.Text = prom1.Text;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    salida = Convert.ToDouble(sal8.Text);
                    if (salida > 0)
                    {
                        pre8.Text = prom7.Text;
                        if (prom7.Text == "")
                        {
                            pre8.Text = prom6.Text;
                            if (prom6.Text == "")
                            {
                                pre8.Text = prom5.Text;
                                if (prom5.Text == "")
                                {
                                    pre8.Text = prom4.Text;
                                    if (prom4.Text == "")
                                    {
                                        pre8.Text = prom3.Text;
                                        if (prom3.Text == "")
                                        {
                                            pre8.Text = prom2.Text;
                                            if (prom2.Text == "")
                                            {
                                                pre8.Text = prom1.Text;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    salida = Convert.ToDouble(sal9.Text);
                    if (salida > 0)
                    {
                        pre9.Text = prom8.Text;
                        if (prom8.Text == "")
                        {
                            pre9.Text = prom7.Text;
                            if (prom7.Text == "")
                            {
                                pre9.Text = prom6.Text;
                                if (prom6.Text == "")
                                {
                                    pre9.Text = prom5.Text;
                                    if (prom5.Text == "")
                                    {
                                        pre9.Text = prom4.Text;
                                        if (prom4.Text == "")
                                        {
                                            pre9.Text = prom3.Text;
                                            if (prom3.Text == "")
                                            {
                                                pre9.Text = prom2.Text;
                                                if (prom2.Text == "")
                                                {
                                                    pre9.Text = prom1.Text;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    salida = Convert.ToDouble(sal10.Text);
                    if (salida > 0)
                    {
                        pre10.Text = prom9.Text;
                        if (prom9.Text == "")
                        {
                            pre10.Text = prom8.Text;
                            if (prom8.Text == "")
                            {
                                pre10.Text = prom7.Text;
                                if (prom7.Text == "")
                                {
                                    pre10.Text = prom6.Text;
                                    if (prom6.Text == "")
                                    {
                                        pre10.Text = prom5.Text;
                                        if (prom5.Text == "")
                                        {
                                            pre10.Text = prom4.Text;
                                            if (prom4.Text == "")
                                            {
                                                pre10.Text = prom3.Text;
                                                if (prom3.Text == "")
                                                {
                                                    pre10.Text = prom2.Text;
                                                    if (prom2.Text == "")
                                                    {
                                                        pre10.Text = prom1.Text;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    salida = Convert.ToDouble(sal11.Text);
                    if (salida > 0)
                    {
                        pre11.Text = prom10.Text;
                        if (prom10.Text == "")
                        {
                            pre11.Text = prom9.Text;
                            if (prom9.Text == "")
                            {
                                pre11.Text = prom8.Text;
                                if (prom8.Text == "")
                                {
                                    pre11.Text = prom7.Text;
                                    if (prom7.Text == "")
                                    {
                                        pre11.Text = prom6.Text;
                                        if (prom6.Text == "")
                                        {
                                            pre11.Text = prom5.Text;
                                            if (prom5.Text == "")
                                            {
                                                pre11.Text = prom4.Text;
                                                if (prom4.Text == "")
                                                {
                                                    pre11.Text = prom3.Text;
                                                    if (prom3.Text == "")
                                                    {
                                                        pre11.Text = prom2.Text;
                                                        if (prom2.Text == "")
                                                        {
                                                            pre11.Text = prom1.Text;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    salida = Convert.ToDouble(sal12.Text);
                    if (salida > 0)
                    {
                        pre12.Text = prom11.Text;
                        if (prom10.Text == "")
                        {
                            pre12.Text = prom10.Text;
                            if (prom10.Text == "")
                            {
                                pre12.Text = prom9.Text;
                                if (prom9.Text == "")
                                {
                                    pre12.Text = prom8.Text;
                                    if (prom8.Text == "")
                                    {
                                        pre12.Text = prom7.Text;
                                        if (prom7.Text == "")
                                        {
                                            pre12.Text = prom6.Text;
                                            if (prom6.Text == "")
                                            {
                                                pre12.Text = prom5.Text;
                                                if (prom5.Text == "")
                                                {
                                                    pre12.Text = prom4.Text;
                                                    if (prom4.Text == "")
                                                    {
                                                        pre12.Text = prom3.Text;
                                                        if (prom3.Text == "")
                                                        {
                                                            pre12.Text = prom2.Text;
                                                            if (prom2.Text == "")
                                                            {
                                                                pre12.Text = prom1.Text;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }


                    salida = Convert.ToDouble(sal13.Text);
                    if (salida > 0)
                    {
                        pre13.Text = prom12.Text;
                        if (prom12.Text == "")
                        {
                            pre13.Text = prom11.Text;
                            if (prom11.Text == "")
                            {
                                pre13.Text = prom10.Text;
                                if (prom10.Text == "")
                                {
                                    pre13.Text = prom9.Text;
                                    if (prom9.Text == "")
                                    {
                                        pre13.Text = prom8.Text;
                                        if (prom8.Text == "")
                                        {
                                            pre13.Text = prom7.Text;
                                            if (prom7.Text == "")
                                            {
                                                pre13.Text = prom6.Text;
                                                if (prom6.Text == "")
                                                {
                                                    pre13.Text = prom5.Text;
                                                    if (prom5.Text == "")
                                                    {
                                                        pre13.Text = prom4.Text;
                                                        if (prom4.Text == "")
                                                        {
                                                            pre13.Text = prom3.Text;
                                                            if (prom3.Text == "")
                                                            {
                                                                pre13.Text = prom2.Text;
                                                                if (prom2.Text == "")
                                                                {
                                                                    pre13.Text = prom1.Text;

                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }



            hab1.Text = Convert.ToString(0);

            if (pre2.Text == "")
            {
                pre2.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal2.Text);
            pre = double.Parse(pre2.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab2.Text = Convert.ToString(0);
            }
            else
            {
                hab2.Text = Convert.ToString(haber);
            }

            if (pre3.Text == "")
            {
                pre3.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal3.Text);
            pre = double.Parse(pre3.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab3.Text = Convert.ToString(0);
            }
            else
            {
                hab3.Text = Convert.ToString(haber);
            }

            if (pre4.Text == "")
            {
                pre4.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal4.Text);
            pre = double.Parse(pre4.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab4.Text = Convert.ToString(0);
            }
            else
            {
                hab4.Text = Convert.ToString(haber);
            }

            if (pre5.Text == "")
            {
                pre5.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal5.Text);
            pre = double.Parse(pre5.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab5.Text = Convert.ToString(0);
            }
            else
            {
                hab5.Text = Convert.ToString(haber);
            }

            if (pre6.Text == "")
            {
                pre6.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal6.Text);
            pre = double.Parse(pre6.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab6.Text = Convert.ToString(0);
            }
            else
            {
                hab6.Text = Convert.ToString(haber);
            }

            if (pre7.Text == "")
            {
                pre7.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal7.Text);
            pre = double.Parse(pre7.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab7.Text = Convert.ToString(0);
            }
            else
            {
                hab7.Text = Convert.ToString(haber);
            }

            if (pre8.Text == "")
            {
                pre8.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal8.Text);
            pre = double.Parse(pre8.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab8.Text = Convert.ToString(0);
            }
            else
            {
                hab8.Text = Convert.ToString(haber);
            }

            if (pre9.Text == "")
            {
                pre9.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal9.Text);
            pre = double.Parse(pre9.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab9.Text = Convert.ToString(0);
            }
            else
            {
                hab9.Text = Convert.ToString(haber);
            }

            if (pre10.Text == "")
            {
                pre10.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal10.Text);
            pre = double.Parse(pre10.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab10.Text = Convert.ToString(0);
            }
            else
            {
                hab10.Text = Convert.ToString(haber);
            }

            if (pre11.Text == "")
            {
                pre11.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal11.Text);
            pre = double.Parse(pre11.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab11.Text = Convert.ToString(0);
            }
            else
            {
                hab11.Text = Convert.ToString(haber);
            }

            if (pre12.Text == "")
            {
                pre12.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal12.Text);
            pre = double.Parse(pre12.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab12.Text = Convert.ToString(0);
            }
            else
            {
                hab12.Text = Convert.ToString(haber);
            }

            if (pre13.Text == "")
            {
                pre13.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal13.Text);
            pre = double.Parse(pre13.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab13.Text = Convert.ToString(0);
            }
            else
            {
                hab13.Text = Convert.ToString(haber);
            }


            saldo1.Text = deb1.Text;

            sal = double.Parse(saldo1.Text);
            debe = double.Parse(deb2.Text);
            haber = double.Parse(hab2.Text);
            saldo = sal + debe - haber;
            if (debe == 0 && haber == 0)
            {
                saldo2.Text = Convert.ToString(0);
            }
            else
            {
                saldo2.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo2.Text);
            debe = double.Parse(deb3.Text);
            haber = double.Parse(hab3.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo1.Text) + debe - haber;
                saldo3.Text = Convert.ToString(saldo);
            }
            if (debe == 0 && haber == 0)
            {
                saldo3.Text = Convert.ToString(0);

            }
            else
            {
                saldo3.Text = Convert.ToString(saldo);
            }

            //gggggg
            sal = double.Parse(saldo3.Text);
            debe = double.Parse(deb4.Text);
            haber = double.Parse(hab4.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo2.Text) + debe - haber;
                saldo4.Text = Convert.ToString(saldo);
                if (double.Parse(saldo2.Text) == 0)
                {
                    saldo = double.Parse(saldo1.Text) + debe - haber;
                    saldo4.Text = Convert.ToString(saldo);
                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo4.Text = Convert.ToString(0);
            }
            else
            {
                saldo4.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo4.Text);
            debe = double.Parse(deb5.Text);
            haber = double.Parse(hab5.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo3.Text) + debe - haber;
                saldo5.Text = Convert.ToString(saldo);
                if (double.Parse(saldo3.Text) == 0)
                {
                    saldo = double.Parse(saldo2.Text) + debe - haber;
                    saldo5.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo2.Text) == 0)
                    {
                        saldo = double.Parse(saldo1.Text) + debe - haber;
                        saldo5.Text = Convert.ToString(saldo);
                    }
                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo5.Text = Convert.ToString(0);
            }
            else
            {
                saldo5.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo5.Text);
            debe = double.Parse(deb6.Text);
            haber = double.Parse(hab6.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo4.Text) + debe - haber;
                saldo6.Text = Convert.ToString(saldo);
                if (double.Parse(saldo4.Text) == 0)
                {
                    saldo = double.Parse(saldo3.Text) + debe - haber;
                    saldo6.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo2.Text) == 0)
                    {
                        saldo = double.Parse(saldo2.Text) + debe - haber;
                        saldo6.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo2.Text) == 0)
                        {
                            saldo = double.Parse(saldo1.Text) + debe - haber;
                            saldo6.Text = Convert.ToString(saldo);
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo6.Text = Convert.ToString(0);
            }
            else
            {
                saldo6.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo6.Text);
            debe = double.Parse(deb7.Text);
            haber = double.Parse(hab7.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo5.Text) + debe - haber;
                saldo7.Text = Convert.ToString(saldo);
                if (double.Parse(saldo5.Text) == 0)
                {
                    saldo = double.Parse(saldo4.Text) + debe - haber;
                    saldo7.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo4.Text) == 0)
                    {
                        saldo = double.Parse(saldo3.Text) + debe - haber;
                        saldo7.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo3.Text) == 0)
                        {
                            saldo = double.Parse(saldo2.Text) + debe - haber;
                            saldo7.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo2.Text) == 0)
                            {
                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                saldo7.Text = Convert.ToString(saldo);

                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo7.Text = Convert.ToString(0);
            }
            else
            {
                saldo7.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo7.Text);
            debe = double.Parse(deb8.Text);
            haber = double.Parse(hab8.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo6.Text) + debe - haber;
                saldo8.Text = Convert.ToString(saldo);
                if (double.Parse(saldo6.Text) == 0)
                {
                    saldo = double.Parse(saldo5.Text) + debe - haber;
                    saldo8.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo5.Text) == 0)
                    {
                        saldo = double.Parse(saldo4.Text) + debe - haber;
                        saldo8.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo4.Text) == 0)
                        {
                            saldo = double.Parse(saldo3.Text) + debe - haber;
                            saldo8.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo3.Text) == 0)
                            {
                                saldo = double.Parse(saldo2.Text) + debe - haber;
                                saldo8.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo2.Text) == 0)
                                {
                                    saldo = double.Parse(saldo1.Text) + debe - haber;
                                    saldo8.Text = Convert.ToString(saldo);

                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo8.Text = Convert.ToString(0);
            }
            else
            {
                saldo8.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo8.Text);
            debe = double.Parse(deb9.Text);
            haber = double.Parse(hab9.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo7.Text) + debe - haber;
                saldo9.Text = Convert.ToString(saldo);
                if (double.Parse(saldo7.Text) == 0)
                {
                    saldo = double.Parse(saldo6.Text) + debe - haber;
                    saldo9.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo6.Text) == 0)
                    {
                        saldo = double.Parse(saldo5.Text) + debe - haber;
                        saldo9.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo5.Text) == 0)
                        {
                            saldo = double.Parse(saldo4.Text) + debe - haber;
                            saldo9.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo4.Text) == 0)
                            {
                                saldo = double.Parse(saldo3.Text) + debe - haber;
                                saldo9.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo3.Text) == 0)
                                {
                                    saldo = double.Parse(saldo2.Text) + debe - haber;
                                    saldo9.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo2.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo1.Text) + debe - haber;
                                        saldo9.Text = Convert.ToString(saldo);

                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo9.Text = Convert.ToString(0);
            }
            else
            {
                saldo9.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo9.Text);
            debe = double.Parse(deb10.Text);
            haber = double.Parse(hab10.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo8.Text) + debe - haber;
                saldo10.Text = Convert.ToString(saldo);
                if (double.Parse(saldo8.Text) == 0)
                {
                    saldo = double.Parse(saldo7.Text) + debe - haber;
                    saldo10.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo7.Text) == 0)
                    {
                        saldo = double.Parse(saldo6.Text) + debe - haber;
                        saldo10.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo6.Text) == 0)
                        {
                            saldo = double.Parse(saldo5.Text) + debe - haber;
                            saldo10.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo5.Text) == 0)
                            {
                                saldo = double.Parse(saldo4.Text) + debe - haber;
                                saldo10.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo4.Text) == 0)
                                {
                                    saldo = double.Parse(saldo3.Text) + debe - haber;
                                    saldo10.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo3.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo2.Text) + debe - haber;
                                        saldo10.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo2.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo1.Text) + debe - haber;
                                            saldo10.Text = Convert.ToString(saldo);

                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo10.Text = Convert.ToString(0);
            }
            else
            {
                saldo10.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo10.Text);
            debe = double.Parse(deb11.Text);
            haber = double.Parse(hab11.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo9.Text) + debe - haber;
                saldo11.Text = Convert.ToString(saldo);
                if (double.Parse(saldo9.Text) == 0)
                {
                    saldo = double.Parse(saldo8.Text) + debe - haber;
                    saldo11.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo8.Text) == 0)
                    {
                        saldo = double.Parse(saldo7.Text) + debe - haber;
                        saldo11.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo7.Text) == 0)
                        {
                            saldo = double.Parse(saldo6.Text) + debe - haber;
                            saldo11.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo6.Text) == 0)
                            {
                                saldo = double.Parse(saldo5.Text) + debe - haber;
                                saldo11.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo5.Text) == 0)
                                {
                                    saldo = double.Parse(saldo4.Text) + debe - haber;
                                    saldo11.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo4.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo3.Text) + debe - haber;
                                        saldo11.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo3.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo2.Text) + debe - haber;
                                            saldo11.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo2.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                                saldo11.Text = Convert.ToString(saldo);

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo11.Text = Convert.ToString(0);
            }
            else
            {
                saldo11.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo11.Text);
            debe = double.Parse(deb12.Text);
            haber = double.Parse(hab12.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo10.Text) + debe - haber;
                saldo12.Text = Convert.ToString(saldo);
                if (double.Parse(saldo10.Text) == 0)
                {
                    saldo = double.Parse(saldo9.Text) + debe - haber;
                    saldo12.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo9.Text) == 0)
                    {
                        saldo = double.Parse(saldo8.Text) + debe - haber;
                        saldo12.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo8.Text) == 0)
                        {
                            saldo = double.Parse(saldo7.Text) + debe - haber;
                            saldo12.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo7.Text) == 0)
                            {
                                saldo = double.Parse(saldo6.Text) + debe - haber;
                                saldo12.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo6.Text) == 0)
                                {
                                    saldo = double.Parse(saldo5.Text) + debe - haber;
                                    saldo12.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo5.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo4.Text) + debe - haber;
                                        saldo12.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo4.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo3.Text) + debe - haber;
                                            saldo12.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo3.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo2.Text) + debe - haber;
                                                saldo12.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo2.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo1.Text) + debe - haber;
                                                    saldo12.Text = Convert.ToString(saldo);

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo12.Text = Convert.ToString(0);
            }
            else
            {
                saldo12.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo12.Text);
            debe = double.Parse(deb13.Text);
            haber = double.Parse(hab13.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo11.Text) + debe - haber;
                saldo13.Text = Convert.ToString(saldo);
                if (double.Parse(saldo11.Text) == 0)
                {
                    saldo = double.Parse(saldo10.Text) + debe - haber;
                    saldo13.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo10.Text) == 0)
                    {
                        saldo = double.Parse(saldo9.Text) + debe - haber;
                        saldo13.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo9.Text) == 0)
                        {
                            saldo = double.Parse(saldo8.Text) + debe - haber;
                            saldo13.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo8.Text) == 0)
                            {
                                saldo = double.Parse(saldo7.Text) + debe - haber;
                                saldo13.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo7.Text) == 0)
                                {
                                    saldo = double.Parse(saldo6.Text) + debe - haber;
                                    saldo13.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo6.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo5.Text) + debe - haber;
                                        saldo13.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo5.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo4.Text) + debe - haber;
                                            saldo13.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo4.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo3.Text) + debe - haber;
                                                saldo13.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo3.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo2.Text) + debe - haber;
                                                    saldo13.Text = Convert.ToString(saldo);
                                                    if (double.Parse(saldo2.Text) == 0)
                                                    {
                                                        saldo = double.Parse(saldo1.Text) + debe - haber;
                                                        saldo13.Text = Convert.ToString(saldo);

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo13.Text = Convert.ToString(0);
            }
            else
            {
                saldo13.Text = Convert.ToString(saldo);
            }



            hab1.Text = Convert.ToString(0);
            if (pre2.Text == "")
            {
                pre2.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal2.Text);
            pre = double.Parse(pre2.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab2.Text = Convert.ToString(0);
            }
            else
            {
                hab2.Text = Convert.ToString(haber);
            }

            if (pre3.Text == "")
            {
                pre3.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal3.Text);
            pre = double.Parse(pre3.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab3.Text = Convert.ToString(0);
            }
            else
            {
                hab3.Text = Convert.ToString(haber);
            }

            if (pre4.Text == "")
            {
                pre4.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal4.Text);
            pre = double.Parse(pre4.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab4.Text = Convert.ToString(0);
            }
            else
            {
                hab4.Text = Convert.ToString(haber);
            }

            if (pre5.Text == "")
            {
                pre5.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal5.Text);
            pre = double.Parse(pre5.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab5.Text = Convert.ToString(0);
            }
            else
            {
                hab5.Text = Convert.ToString(haber);
            }

            if (pre6.Text == "")
            {
                pre6.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal6.Text);
            pre = double.Parse(pre6.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab6.Text = Convert.ToString(0);
            }
            else
            {
                hab6.Text = Convert.ToString(haber);
            }

            if (pre7.Text == "")
            {
                pre7.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal7.Text);
            pre = double.Parse(pre7.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab7.Text = Convert.ToString(0);
            }
            else
            {
                hab7.Text = Convert.ToString(haber);
            }

            if (pre8.Text == "")
            {
                pre8.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal8.Text);
            pre = double.Parse(pre8.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab8.Text = Convert.ToString(0);
            }
            else
            {
                hab8.Text = Convert.ToString(haber);
            }

            if (pre9.Text == "")
            {
                pre9.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal9.Text);
            pre = double.Parse(pre9.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab9.Text = Convert.ToString(0);
            }
            else
            {
                hab9.Text = Convert.ToString(haber);
            }

            if (pre10.Text == "")
            {
                pre10.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal10.Text);
            pre = double.Parse(pre10.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab10.Text = Convert.ToString(0);
            }
            else
            {
                hab10.Text = Convert.ToString(haber);
            }

            if (pre11.Text == "")
            {
                pre11.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal11.Text);
            pre = double.Parse(pre11.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab11.Text = Convert.ToString(0);
            }
            else
            {
                hab11.Text = Convert.ToString(haber);
            }

            if (pre12.Text == "")
            {
                pre12.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal12.Text);
            pre = double.Parse(pre12.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab12.Text = Convert.ToString(0);
            }
            else
            {
                hab12.Text = Convert.ToString(haber);
            }

            if (pre13.Text == "")
            {
                pre13.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal13.Text);
            pre = double.Parse(pre13.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab13.Text = Convert.ToString(0);
            }
            else
            {
                hab13.Text = Convert.ToString(haber);
            }



            saldo1.Text = deb1.Text;

            sal = double.Parse(saldo1.Text);
            debe = double.Parse(deb2.Text);
            haber = double.Parse(hab2.Text);
            saldo = sal + debe - haber;
            if (debe == 0 && haber == 0)
            {
                saldo2.Text = Convert.ToString(0);
            }
            else
            {
                saldo2.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo2.Text);
            debe = double.Parse(deb3.Text);
            haber = double.Parse(hab3.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo1.Text) + debe - haber;
                saldo3.Text = Convert.ToString(saldo);
            }
            if (debe == 0 && haber == 0)
            {
                saldo3.Text = Convert.ToString(0);

            }
            else
            {
                saldo3.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo3.Text);
            debe = double.Parse(deb4.Text);
            haber = double.Parse(hab4.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo2.Text) + debe - haber;
                saldo4.Text = Convert.ToString(saldo);
                if (double.Parse(saldo2.Text) == 0)
                {
                    saldo = double.Parse(saldo1.Text) + debe - haber;
                    saldo4.Text = Convert.ToString(saldo);
                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo4.Text = Convert.ToString(0);
            }
            else
            {
                saldo4.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo4.Text);
            debe = double.Parse(deb5.Text);
            haber = double.Parse(hab5.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo3.Text) + debe - haber;
                saldo5.Text = Convert.ToString(saldo);
                if (double.Parse(saldo3.Text) == 0)
                {
                    saldo = double.Parse(saldo2.Text) + debe - haber;
                    saldo5.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo2.Text) == 0)
                    {
                        saldo = double.Parse(saldo1.Text) + debe - haber;
                        saldo5.Text = Convert.ToString(saldo);
                    }
                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo5.Text = Convert.ToString(0);
            }
            else
            {
                saldo5.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo5.Text);
            debe = double.Parse(deb6.Text);
            haber = double.Parse(hab6.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo4.Text) + debe - haber;
                saldo6.Text = Convert.ToString(saldo);
                if (double.Parse(saldo4.Text) == 0)
                {
                    saldo = double.Parse(saldo3.Text) + debe - haber;
                    saldo6.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo2.Text) == 0)
                    {
                        saldo = double.Parse(saldo2.Text) + debe - haber;
                        saldo6.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo2.Text) == 0)
                        {
                            saldo = double.Parse(saldo1.Text) + debe - haber;
                            saldo6.Text = Convert.ToString(saldo);
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo6.Text = Convert.ToString(0);
            }
            else
            {
                saldo6.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo6.Text);
            debe = double.Parse(deb7.Text);
            haber = double.Parse(hab7.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo5.Text) + debe - haber;
                saldo7.Text = Convert.ToString(saldo);
                if (double.Parse(saldo5.Text) == 0)
                {
                    saldo = double.Parse(saldo4.Text) + debe - haber;
                    saldo7.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo4.Text) == 0)
                    {
                        saldo = double.Parse(saldo3.Text) + debe - haber;
                        saldo7.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo3.Text) == 0)
                        {
                            saldo = double.Parse(saldo2.Text) + debe - haber;
                            saldo7.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo2.Text) == 0)
                            {
                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                saldo7.Text = Convert.ToString(saldo);

                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo7.Text = Convert.ToString(0);
            }
            else
            {
                saldo7.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo7.Text);
            debe = double.Parse(deb8.Text);
            haber = double.Parse(hab8.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo6.Text) + debe - haber;
                saldo8.Text = Convert.ToString(saldo);
                if (double.Parse(saldo6.Text) == 0)
                {
                    saldo = double.Parse(saldo5.Text) + debe - haber;
                    saldo8.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo5.Text) == 0)
                    {
                        saldo = double.Parse(saldo4.Text) + debe - haber;
                        saldo8.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo4.Text) == 0)
                        {
                            saldo = double.Parse(saldo3.Text) + debe - haber;
                            saldo8.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo3.Text) == 0)
                            {
                                saldo = double.Parse(saldo2.Text) + debe - haber;
                                saldo8.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo2.Text) == 0)
                                {
                                    saldo = double.Parse(saldo1.Text) + debe - haber;
                                    saldo8.Text = Convert.ToString(saldo);

                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo8.Text = Convert.ToString(0);
            }
            else
            {
                saldo8.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo8.Text);
            debe = double.Parse(deb9.Text);
            haber = double.Parse(hab9.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo7.Text) + debe - haber;
                saldo9.Text = Convert.ToString(saldo);
                if (double.Parse(saldo7.Text) == 0)
                {
                    saldo = double.Parse(saldo6.Text) + debe - haber;
                    saldo9.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo6.Text) == 0)
                    {
                        saldo = double.Parse(saldo5.Text) + debe - haber;
                        saldo9.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo5.Text) == 0)
                        {
                            saldo = double.Parse(saldo4.Text) + debe - haber;
                            saldo9.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo4.Text) == 0)
                            {
                                saldo = double.Parse(saldo3.Text) + debe - haber;
                                saldo9.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo3.Text) == 0)
                                {
                                    saldo = double.Parse(saldo2.Text) + debe - haber;
                                    saldo9.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo2.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo1.Text) + debe - haber;
                                        saldo9.Text = Convert.ToString(saldo);

                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo9.Text = Convert.ToString(0);
            }
            else
            {
                saldo9.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo9.Text);
            debe = double.Parse(deb10.Text);
            haber = double.Parse(hab10.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo8.Text) + debe - haber;
                saldo10.Text = Convert.ToString(saldo);
                if (double.Parse(saldo8.Text) == 0)
                {
                    saldo = double.Parse(saldo7.Text) + debe - haber;
                    saldo10.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo7.Text) == 0)
                    {
                        saldo = double.Parse(saldo6.Text) + debe - haber;
                        saldo10.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo6.Text) == 0)
                        {
                            saldo = double.Parse(saldo5.Text) + debe - haber;
                            saldo10.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo5.Text) == 0)
                            {
                                saldo = double.Parse(saldo4.Text) + debe - haber;
                                saldo10.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo4.Text) == 0)
                                {
                                    saldo = double.Parse(saldo3.Text) + debe - haber;
                                    saldo10.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo3.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo2.Text) + debe - haber;
                                        saldo10.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo2.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo1.Text) + debe - haber;
                                            saldo10.Text = Convert.ToString(saldo);

                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo10.Text = Convert.ToString(0);
            }
            else
            {
                saldo10.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo10.Text);
            debe = double.Parse(deb11.Text);
            haber = double.Parse(hab11.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo9.Text) + debe - haber;
                saldo11.Text = Convert.ToString(saldo);
                if (double.Parse(saldo9.Text) == 0)
                {
                    saldo = double.Parse(saldo8.Text) + debe - haber;
                    saldo11.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo8.Text) == 0)
                    {
                        saldo = double.Parse(saldo7.Text) + debe - haber;
                        saldo11.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo7.Text) == 0)
                        {
                            saldo = double.Parse(saldo6.Text) + debe - haber;
                            saldo11.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo6.Text) == 0)
                            {
                                saldo = double.Parse(saldo5.Text) + debe - haber;
                                saldo11.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo5.Text) == 0)
                                {
                                    saldo = double.Parse(saldo4.Text) + debe - haber;
                                    saldo11.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo4.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo3.Text) + debe - haber;
                                        saldo11.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo3.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo2.Text) + debe - haber;
                                            saldo11.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo2.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                                saldo11.Text = Convert.ToString(saldo);

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo11.Text = Convert.ToString(0);
            }
            else
            {
                saldo11.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo11.Text);
            debe = double.Parse(deb12.Text);
            haber = double.Parse(hab12.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo10.Text) + debe - haber;
                saldo12.Text = Convert.ToString(saldo);
                if (double.Parse(saldo10.Text) == 0)
                {
                    saldo = double.Parse(saldo9.Text) + debe - haber;
                    saldo12.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo9.Text) == 0)
                    {
                        saldo = double.Parse(saldo8.Text) + debe - haber;
                        saldo12.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo8.Text) == 0)
                        {
                            saldo = double.Parse(saldo7.Text) + debe - haber;
                            saldo12.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo7.Text) == 0)
                            {
                                saldo = double.Parse(saldo6.Text) + debe - haber;
                                saldo12.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo6.Text) == 0)
                                {
                                    saldo = double.Parse(saldo5.Text) + debe - haber;
                                    saldo12.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo5.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo4.Text) + debe - haber;
                                        saldo12.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo4.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo3.Text) + debe - haber;
                                            saldo12.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo3.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo2.Text) + debe - haber;
                                                saldo12.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo2.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo1.Text) + debe - haber;
                                                    saldo12.Text = Convert.ToString(saldo);

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo12.Text = Convert.ToString(0);
            }
            else
            {
                saldo12.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo12.Text);
            debe = double.Parse(deb13.Text);
            haber = double.Parse(hab13.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo11.Text) + debe - haber;
                saldo13.Text = Convert.ToString(saldo);
                if (double.Parse(saldo11.Text) == 0)
                {
                    saldo = double.Parse(saldo10.Text) + debe - haber;
                    saldo13.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo10.Text) == 0)
                    {
                        saldo = double.Parse(saldo9.Text) + debe - haber;
                        saldo13.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo9.Text) == 0)
                        {
                            saldo = double.Parse(saldo8.Text) + debe - haber;
                            saldo13.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo8.Text) == 0)
                            {
                                saldo = double.Parse(saldo7.Text) + debe - haber;
                                saldo13.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo7.Text) == 0)
                                {
                                    saldo = double.Parse(saldo6.Text) + debe - haber;
                                    saldo13.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo6.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo5.Text) + debe - haber;
                                        saldo13.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo5.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo4.Text) + debe - haber;
                                            saldo13.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo4.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo3.Text) + debe - haber;
                                                saldo13.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo3.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo2.Text) + debe - haber;
                                                    saldo13.Text = Convert.ToString(saldo);
                                                    if (double.Parse(saldo2.Text) == 0)
                                                    {
                                                        saldo = double.Parse(saldo1.Text) + debe - haber;
                                                        saldo13.Text = Convert.ToString(saldo);

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo13.Text = Convert.ToString(0);
            }
            else
            {
                saldo13.Text = Convert.ToString(saldo);
            }





            prom1.Text = pre1.Text;

            sald = float.Parse(saldo2.Text);
            existencia = float.Parse(exist2.Text);
            entrada = float.Parse(ent2.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom2.Text = promedio.ToString("0.00");
                if (prom1.Text == prom2.Text)
                {
                    prom2.Text = "";
                }

            }
            else
            {
                prom2.Text = "";
            }

            sald = float.Parse(saldo3.Text);
            existencia = float.Parse(exist3.Text);
            entrada = float.Parse(ent3.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom3.Text = promedio.ToString("0.00");
                if (prom2.Text == prom3.Text)
                {
                    prom3.Text = "";
                }

            }
            else
            {
                prom3.Text = "";
            }

            sald = float.Parse(saldo4.Text);
            existencia = float.Parse(exist4.Text);
            entrada = float.Parse(ent4.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom4.Text = promedio.ToString("0.00");
                if (prom3.Text == prom4.Text)
                {
                    prom4.Text = "";
                }

            }
            else
            {
                prom4.Text = "";
            }

            sald = float.Parse(saldo5.Text);
            existencia = float.Parse(exist5.Text);
            entrada = float.Parse(ent5.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom5.Text = promedio.ToString("0.00");
                if (prom4.Text == prom5.Text)
                {
                    prom5.Text = "";
                }

            }
            else
            {
                prom5.Text = "";
            }

            sald = float.Parse(saldo6.Text);
            existencia = float.Parse(exist6.Text);
            entrada = float.Parse(ent6.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom6.Text = promedio.ToString("0.00");
                if (prom5.Text == prom6.Text)
                {
                    prom6.Text = "";
                }

            }
            else
            {
                prom6.Text = "";
            }


            sald = float.Parse(saldo7.Text);
            existencia = float.Parse(exist7.Text);
            entrada = float.Parse(ent7.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom7.Text = promedio.ToString("0.00");
                if (prom6.Text == prom7.Text)
                {
                    prom7.Text = "";
                }

            }
            else
            {
                prom7.Text = "";
            }

            sald = float.Parse(saldo8.Text);
            existencia = float.Parse(exist8.Text);
            entrada = float.Parse(ent8.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom8.Text = promedio.ToString("0.00");
                if (prom7.Text == prom8.Text)
                {
                    prom8.Text = "";
                }

            }
            else
            {
                prom8.Text = "";
            }

            sald = float.Parse(saldo9.Text);
            existencia = float.Parse(exist9.Text);
            entrada = float.Parse(ent9.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom9.Text = promedio.ToString("0.00");
                if (prom8.Text == prom9.Text)
                {
                    prom9.Text = "";
                }

            }
            else
            {
                prom9.Text = "";
            }

            sald = float.Parse(saldo10.Text);
            existencia = float.Parse(exist10.Text);
            entrada = float.Parse(ent10.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom10.Text = promedio.ToString("0.00");
                if (prom9.Text == prom10.Text)
                {
                    prom10.Text = "";
                }

            }
            else
            {
                prom10.Text = "";
            }

            sald = float.Parse(saldo11.Text);
            existencia = float.Parse(exist11.Text);
            entrada = float.Parse(ent11.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom11.Text = promedio.ToString("0.00");
                if (prom10.Text == prom11.Text)
                {
                    prom11.Text = "";
                }

            }
            else
            {
                prom11.Text = "";
            }

            sald = float.Parse(saldo12.Text);
            existencia = float.Parse(exist12.Text);
            entrada = float.Parse(ent12.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom12.Text = promedio.ToString("0.00");
                if (prom11.Text == prom12.Text)
                {
                    prom12.Text = "";
                }

            }
            else
            {
                prom12.Text = "";
            }

            sald = float.Parse(saldo13.Text);
            existencia = float.Parse(exist13.Text);
            entrada = float.Parse(ent13.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom13.Text = promedio.ToString("0.00");
                if (prom12.Text == prom13.Text)
                {
                    prom13.Text = "";
                }

            }
            else
            {
                prom13.Text = "";
            }



            salida = Convert.ToDouble(sal2.Text);
            if (salida > 0)
            {
                pre2.Text = prom1.Text;
            }


            salida = Convert.ToDouble(sal3.Text);
            if (salida > 0)
            {
                pre3.Text = prom2.Text;
                if (prom2.Text == "")
                {
                    pre3.Text = prom1.Text;
                }

            }


            salida = Convert.ToDouble(sal4.Text);
            if (salida > 0)
            {
                pre4.Text = prom3.Text;
                if (prom3.Text == "")
                {
                    pre4.Text = prom2.Text;
                    if (prom2.Text == "")
                    {
                        pre4.Text = prom1.Text;
                    }
                }

            }

            //sssssss
            salida = Convert.ToDouble(sal5.Text);
            if (salida > 0)
            {
                pre5.Text = prom4.Text;
                if (prom4.Text == "")
                {
                    pre5.Text = prom3.Text;
                    if (prom3.Text == "")
                    {
                        pre5.Text = prom2.Text;
                        if (prom2.Text == "")
                        {
                            pre5.Text = prom1.Text;
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal6.Text);
            if (salida > 0)
            {
                pre6.Text = prom5.Text;
                if (prom5.Text == "")
                {
                    pre6.Text = prom4.Text;
                    if (prom4.Text == "")
                    {
                        pre6.Text = prom3.Text;
                        if (prom3.Text == "")
                        {
                            pre6.Text = prom2.Text;
                            if (prom2.Text == "")
                            {
                                pre6.Text = prom1.Text;
                            }
                        }
                    }
                }
            }
            salida = Convert.ToDouble(sal7.Text);
            if (salida > 0)
            {
                pre7.Text = prom6.Text;
                if (prom6.Text == "")
                {
                    pre7.Text = prom5.Text;
                    if (prom5.Text == "")
                    {
                        pre7.Text = prom4.Text;
                        if (prom4.Text == "")
                        {
                            pre7.Text = prom3.Text;
                            if (prom3.Text == "")
                            {
                                pre7.Text = prom2.Text;
                                if (prom2.Text == "")
                                {
                                    pre7.Text = prom1.Text;
                                }
                            }
                        }
                    }
                }
            }
            salida = Convert.ToDouble(sal8.Text);
            if (salida > 0)
            {
                pre8.Text = prom7.Text;
                if (prom7.Text == "")
                {
                    pre8.Text = prom6.Text;
                    if (prom6.Text == "")
                    {
                        pre8.Text = prom5.Text;
                        if (prom5.Text == "")
                        {
                            pre8.Text = prom4.Text;
                            if (prom4.Text == "")
                            {
                                pre8.Text = prom3.Text;
                                if (prom3.Text == "")
                                {
                                    pre8.Text = prom2.Text;
                                    if (prom2.Text == "")
                                    {
                                        pre8.Text = prom1.Text;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal9.Text);
            if (salida > 0)
            {
                pre9.Text = prom8.Text;
                if (prom8.Text == "")
                {
                    pre9.Text = prom7.Text;
                    if (prom7.Text == "")
                    {
                        pre9.Text = prom6.Text;
                        if (prom6.Text == "")
                        {
                            pre9.Text = prom5.Text;
                            if (prom5.Text == "")
                            {
                                pre9.Text = prom4.Text;
                                if (prom4.Text == "")
                                {
                                    pre9.Text = prom3.Text;
                                    if (prom3.Text == "")
                                    {
                                        pre9.Text = prom2.Text;
                                        if (prom2.Text == "")
                                        {
                                            pre9.Text = prom1.Text;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal10.Text);
            if (salida > 0)
            {
                pre10.Text = prom9.Text;
                if (prom9.Text == "")
                {
                    pre10.Text = prom8.Text;
                    if (prom8.Text == "")
                    {
                        pre10.Text = prom7.Text;
                        if (prom7.Text == "")
                        {
                            pre10.Text = prom6.Text;
                            if (prom6.Text == "")
                            {
                                pre10.Text = prom5.Text;
                                if (prom5.Text == "")
                                {
                                    pre10.Text = prom4.Text;
                                    if (prom4.Text == "")
                                    {
                                        pre10.Text = prom3.Text;
                                        if (prom3.Text == "")
                                        {
                                            pre10.Text = prom2.Text;
                                            if (prom2.Text == "")
                                            {
                                                pre10.Text = prom1.Text;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal11.Text);
            if (salida > 0)
            {
                pre11.Text = prom10.Text;
                if (prom10.Text == "")
                {
                    pre11.Text = prom9.Text;
                    if (prom9.Text == "")
                    {
                        pre11.Text = prom8.Text;
                        if (prom8.Text == "")
                        {
                            pre11.Text = prom7.Text;
                            if (prom7.Text == "")
                            {
                                pre11.Text = prom6.Text;
                                if (prom6.Text == "")
                                {
                                    pre11.Text = prom5.Text;
                                    if (prom5.Text == "")
                                    {
                                        pre11.Text = prom4.Text;
                                        if (prom4.Text == "")
                                        {
                                            pre11.Text = prom3.Text;
                                            if (prom3.Text == "")
                                            {
                                                pre11.Text = prom2.Text;
                                                if (prom2.Text == "")
                                                {
                                                    pre11.Text = prom1.Text;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal12.Text);
            if (salida > 0)
            {
                pre12.Text = prom11.Text;
                if (prom10.Text == "")
                {
                    pre12.Text = prom10.Text;
                    if (prom10.Text == "")
                    {
                        pre12.Text = prom9.Text;
                        if (prom9.Text == "")
                        {
                            pre12.Text = prom8.Text;
                            if (prom8.Text == "")
                            {
                                pre12.Text = prom7.Text;
                                if (prom7.Text == "")
                                {
                                    pre12.Text = prom6.Text;
                                    if (prom6.Text == "")
                                    {
                                        pre12.Text = prom5.Text;
                                        if (prom5.Text == "")
                                        {
                                            pre12.Text = prom4.Text;
                                            if (prom4.Text == "")
                                            {
                                                pre12.Text = prom3.Text;
                                                if (prom3.Text == "")
                                                {
                                                    pre12.Text = prom2.Text;
                                                    if (prom2.Text == "")
                                                    {
                                                        pre12.Text = prom1.Text;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            salida = Convert.ToDouble(sal13.Text);
            if (salida > 0)
            {
                pre13.Text = prom12.Text;
                if (prom12.Text == "")
                {
                    pre13.Text = prom11.Text;
                    if (prom11.Text == "")
                    {
                        pre13.Text = prom10.Text;
                        if (prom10.Text == "")
                        {
                            pre13.Text = prom9.Text;
                            if (prom9.Text == "")
                            {
                                pre13.Text = prom8.Text;
                                if (prom8.Text == "")
                                {
                                    pre13.Text = prom7.Text;
                                    if (prom7.Text == "")
                                    {
                                        pre13.Text = prom6.Text;
                                        if (prom6.Text == "")
                                        {
                                            pre13.Text = prom5.Text;
                                            if (prom5.Text == "")
                                            {
                                                pre13.Text = prom4.Text;
                                                if (prom4.Text == "")
                                                {
                                                    pre13.Text = prom3.Text;
                                                    if (prom3.Text == "")
                                                    {
                                                        pre13.Text = prom2.Text;
                                                        if (prom2.Text == "")
                                                        {
                                                            pre13.Text = prom1.Text;

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            hab1.Text = Convert.ToString(0);
            if (pre2.Text == "")
            {
                pre2.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal2.Text);
            pre = double.Parse(pre2.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab2.Text = Convert.ToString(0);
            }
            else
            {
                hab2.Text = Convert.ToString(haber);
            }

            if (pre3.Text == "")
            {
                pre3.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal3.Text);
            pre = double.Parse(pre3.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab3.Text = Convert.ToString(0);
            }
            else
            {
                hab3.Text = Convert.ToString(haber);
            }

            if (pre4.Text == "")
            {
                pre4.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal4.Text);
            pre = double.Parse(pre4.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab4.Text = Convert.ToString(0);
            }
            else
            {
                hab4.Text = Convert.ToString(haber);
            }

            if (pre5.Text == "")
            {
                pre5.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal5.Text);
            pre = double.Parse(pre5.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab5.Text = Convert.ToString(0);
            }
            else
            {
                hab5.Text = Convert.ToString(haber);
            }

            if (pre6.Text == "")
            {
                pre6.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal6.Text);
            pre = double.Parse(pre6.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab6.Text = Convert.ToString(0);
            }
            else
            {
                hab6.Text = Convert.ToString(haber);
            }

            if (pre7.Text == "")
            {
                pre7.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal7.Text);
            pre = double.Parse(pre7.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab7.Text = Convert.ToString(0);
            }
            else
            {
                hab7.Text = Convert.ToString(haber);
            }

            if (pre8.Text == "")
            {
                pre8.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal8.Text);
            pre = double.Parse(pre8.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab8.Text = Convert.ToString(0);
            }
            else
            {
                hab8.Text = Convert.ToString(haber);
            }

            if (pre9.Text == "")
            {
                pre9.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal9.Text);
            pre = double.Parse(pre9.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab9.Text = Convert.ToString(0);
            }
            else
            {
                hab9.Text = Convert.ToString(haber);
            }

            if (pre10.Text == "")
            {
                pre10.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal10.Text);
            pre = double.Parse(pre10.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab10.Text = Convert.ToString(0);
            }
            else
            {
                hab10.Text = Convert.ToString(haber);
            }

            if (pre11.Text == "")
            {
                pre11.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal11.Text);
            pre = double.Parse(pre11.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab11.Text = Convert.ToString(0);
            }
            else
            {
                hab11.Text = Convert.ToString(haber);
            }

            if (pre12.Text == "")
            {
                pre12.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal12.Text);
            pre = double.Parse(pre12.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab12.Text = Convert.ToString(0);
            }
            else
            {
                hab12.Text = Convert.ToString(haber);
            }

            if (pre13.Text == "")
            {
                pre13.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal13.Text);
            pre = double.Parse(pre13.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab13.Text = Convert.ToString(0);
            }
            else
            {
                hab13.Text = Convert.ToString(haber);
            }

            saldo1.Text = deb1.Text;

            sal = double.Parse(saldo1.Text);
            debe = double.Parse(deb2.Text);
            haber = double.Parse(hab2.Text);
            saldo = sal + debe - haber;
            if (debe == 0 && haber == 0)
            {
                saldo2.Text = Convert.ToString(0);
            }
            else
            {
                saldo2.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo2.Text);
            debe = double.Parse(deb3.Text);
            haber = double.Parse(hab3.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo1.Text) + debe - haber;
                saldo3.Text = Convert.ToString(saldo);
            }
            if (debe == 0 && haber == 0)
            {
                saldo3.Text = Convert.ToString(0);

            }
            else
            {
                saldo3.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo3.Text);
            debe = double.Parse(deb4.Text);
            haber = double.Parse(hab4.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo2.Text) + debe - haber;
                saldo4.Text = Convert.ToString(saldo);
                if (double.Parse(saldo2.Text) == 0)
                {
                    saldo = double.Parse(saldo1.Text) + debe - haber;
                    saldo4.Text = Convert.ToString(saldo);
                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo4.Text = Convert.ToString(0);
            }
            else
            {
                saldo4.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo4.Text);
            debe = double.Parse(deb5.Text);
            haber = double.Parse(hab5.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo3.Text) + debe - haber;
                saldo5.Text = Convert.ToString(saldo);
                if (double.Parse(saldo3.Text) == 0)
                {
                    saldo = double.Parse(saldo2.Text) + debe - haber;
                    saldo5.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo2.Text) == 0)
                    {
                        saldo = double.Parse(saldo1.Text) + debe - haber;
                        saldo5.Text = Convert.ToString(saldo);
                    }
                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo5.Text = Convert.ToString(0);
            }
            else
            {
                saldo5.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo5.Text);
            debe = double.Parse(deb6.Text);
            haber = double.Parse(hab6.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo4.Text) + debe - haber;
                saldo6.Text = Convert.ToString(saldo);
                if (double.Parse(saldo4.Text) == 0)
                {
                    saldo = double.Parse(saldo3.Text) + debe - haber;
                    saldo6.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo2.Text) == 0)
                    {
                        saldo = double.Parse(saldo2.Text) + debe - haber;
                        saldo6.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo2.Text) == 0)
                        {
                            saldo = double.Parse(saldo1.Text) + debe - haber;
                            saldo6.Text = Convert.ToString(saldo);
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo6.Text = Convert.ToString(0);
            }
            else
            {
                saldo6.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo6.Text);
            debe = double.Parse(deb7.Text);
            haber = double.Parse(hab7.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo5.Text) + debe - haber;
                saldo7.Text = Convert.ToString(saldo);
                if (double.Parse(saldo5.Text) == 0)
                {
                    saldo = double.Parse(saldo4.Text) + debe - haber;
                    saldo7.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo4.Text) == 0)
                    {
                        saldo = double.Parse(saldo3.Text) + debe - haber;
                        saldo7.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo3.Text) == 0)
                        {
                            saldo = double.Parse(saldo2.Text) + debe - haber;
                            saldo7.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo2.Text) == 0)
                            {
                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                saldo7.Text = Convert.ToString(saldo);

                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo7.Text = Convert.ToString(0);
            }
            else
            {
                saldo7.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo7.Text);
            debe = double.Parse(deb8.Text);
            haber = double.Parse(hab8.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo6.Text) + debe - haber;
                saldo8.Text = Convert.ToString(saldo);
                if (double.Parse(saldo6.Text) == 0)
                {
                    saldo = double.Parse(saldo5.Text) + debe - haber;
                    saldo8.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo5.Text) == 0)
                    {
                        saldo = double.Parse(saldo4.Text) + debe - haber;
                        saldo8.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo4.Text) == 0)
                        {
                            saldo = double.Parse(saldo3.Text) + debe - haber;
                            saldo8.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo3.Text) == 0)
                            {
                                saldo = double.Parse(saldo2.Text) + debe - haber;
                                saldo8.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo2.Text) == 0)
                                {
                                    saldo = double.Parse(saldo1.Text) + debe - haber;
                                    saldo8.Text = Convert.ToString(saldo);

                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo8.Text = Convert.ToString(0);
            }
            else
            {
                saldo8.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo8.Text);
            debe = double.Parse(deb9.Text);
            haber = double.Parse(hab9.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo7.Text) + debe - haber;
                saldo9.Text = Convert.ToString(saldo);
                if (double.Parse(saldo7.Text) == 0)
                {
                    saldo = double.Parse(saldo6.Text) + debe - haber;
                    saldo9.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo6.Text) == 0)
                    {
                        saldo = double.Parse(saldo5.Text) + debe - haber;
                        saldo9.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo5.Text) == 0)
                        {
                            saldo = double.Parse(saldo4.Text) + debe - haber;
                            saldo9.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo4.Text) == 0)
                            {
                                saldo = double.Parse(saldo3.Text) + debe - haber;
                                saldo9.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo3.Text) == 0)
                                {
                                    saldo = double.Parse(saldo2.Text) + debe - haber;
                                    saldo9.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo2.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo1.Text) + debe - haber;
                                        saldo9.Text = Convert.ToString(saldo);

                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo9.Text = Convert.ToString(0);
            }
            else
            {
                saldo9.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo9.Text);
            debe = double.Parse(deb10.Text);
            haber = double.Parse(hab10.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo8.Text) + debe - haber;
                saldo10.Text = Convert.ToString(saldo);
                if (double.Parse(saldo8.Text) == 0)
                {
                    saldo = double.Parse(saldo7.Text) + debe - haber;
                    saldo10.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo7.Text) == 0)
                    {
                        saldo = double.Parse(saldo6.Text) + debe - haber;
                        saldo10.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo6.Text) == 0)
                        {
                            saldo = double.Parse(saldo5.Text) + debe - haber;
                            saldo10.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo5.Text) == 0)
                            {
                                saldo = double.Parse(saldo4.Text) + debe - haber;
                                saldo10.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo4.Text) == 0)
                                {
                                    saldo = double.Parse(saldo3.Text) + debe - haber;
                                    saldo10.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo3.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo2.Text) + debe - haber;
                                        saldo10.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo2.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo1.Text) + debe - haber;
                                            saldo10.Text = Convert.ToString(saldo);

                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo10.Text = Convert.ToString(0);
            }
            else
            {
                saldo10.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo10.Text);
            debe = double.Parse(deb11.Text);
            haber = double.Parse(hab11.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo9.Text) + debe - haber;
                saldo11.Text = Convert.ToString(saldo);
                if (double.Parse(saldo9.Text) == 0)
                {
                    saldo = double.Parse(saldo8.Text) + debe - haber;
                    saldo11.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo8.Text) == 0)
                    {
                        saldo = double.Parse(saldo7.Text) + debe - haber;
                        saldo11.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo7.Text) == 0)
                        {
                            saldo = double.Parse(saldo6.Text) + debe - haber;
                            saldo11.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo6.Text) == 0)
                            {
                                saldo = double.Parse(saldo5.Text) + debe - haber;
                                saldo11.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo5.Text) == 0)
                                {
                                    saldo = double.Parse(saldo4.Text) + debe - haber;
                                    saldo11.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo4.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo3.Text) + debe - haber;
                                        saldo11.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo3.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo2.Text) + debe - haber;
                                            saldo11.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo2.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                                saldo11.Text = Convert.ToString(saldo);

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo11.Text = Convert.ToString(0);
            }
            else
            {
                saldo11.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo11.Text);
            debe = double.Parse(deb12.Text);
            haber = double.Parse(hab12.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo10.Text) + debe - haber;
                saldo12.Text = Convert.ToString(saldo);
                if (double.Parse(saldo10.Text) == 0)
                {
                    saldo = double.Parse(saldo9.Text) + debe - haber;
                    saldo12.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo9.Text) == 0)
                    {
                        saldo = double.Parse(saldo8.Text) + debe - haber;
                        saldo12.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo8.Text) == 0)
                        {
                            saldo = double.Parse(saldo7.Text) + debe - haber;
                            saldo12.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo7.Text) == 0)
                            {
                                saldo = double.Parse(saldo6.Text) + debe - haber;
                                saldo12.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo6.Text) == 0)
                                {
                                    saldo = double.Parse(saldo5.Text) + debe - haber;
                                    saldo12.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo5.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo4.Text) + debe - haber;
                                        saldo12.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo4.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo3.Text) + debe - haber;
                                            saldo12.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo3.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo2.Text) + debe - haber;
                                                saldo12.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo2.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo1.Text) + debe - haber;
                                                    saldo12.Text = Convert.ToString(saldo);

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo12.Text = Convert.ToString(0);
            }
            else
            {
                saldo12.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo12.Text);
            debe = double.Parse(deb13.Text);
            haber = double.Parse(hab13.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo11.Text) + debe - haber;
                saldo13.Text = Convert.ToString(saldo);
                if (double.Parse(saldo11.Text) == 0)
                {
                    saldo = double.Parse(saldo10.Text) + debe - haber;
                    saldo13.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo10.Text) == 0)
                    {
                        saldo = double.Parse(saldo9.Text) + debe - haber;
                        saldo13.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo9.Text) == 0)
                        {
                            saldo = double.Parse(saldo8.Text) + debe - haber;
                            saldo13.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo8.Text) == 0)
                            {
                                saldo = double.Parse(saldo7.Text) + debe - haber;
                                saldo13.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo7.Text) == 0)
                                {
                                    saldo = double.Parse(saldo6.Text) + debe - haber;
                                    saldo13.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo6.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo5.Text) + debe - haber;
                                        saldo13.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo5.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo4.Text) + debe - haber;
                                            saldo13.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo4.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo3.Text) + debe - haber;
                                                saldo13.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo3.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo2.Text) + debe - haber;
                                                    saldo13.Text = Convert.ToString(saldo);
                                                    if (double.Parse(saldo2.Text) == 0)
                                                    {
                                                        saldo = double.Parse(saldo1.Text) + debe - haber;
                                                        saldo13.Text = Convert.ToString(saldo);

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo13.Text = Convert.ToString(0);
            }
            else
            {
                saldo13.Text = Convert.ToString(saldo);
            }


            prom1.Text = pre1.Text;

            sald = float.Parse(saldo2.Text);
            existencia = float.Parse(exist2.Text);
            entrada = float.Parse(ent2.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom2.Text = promedio.ToString("0.00");
                if (prom1.Text == prom2.Text)
                {
                    prom2.Text = "";
                }

            }
            else
            {
                prom2.Text = "";
            }

            sald = float.Parse(saldo3.Text);
            existencia = float.Parse(exist3.Text);
            entrada = float.Parse(ent3.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom3.Text = promedio.ToString("0.00");
                if (prom2.Text == prom3.Text)
                {
                    prom3.Text = "";
                }

            }
            else
            {
                prom3.Text = "";
            }

            sald = float.Parse(saldo4.Text);
            existencia = float.Parse(exist4.Text);
            entrada = float.Parse(ent4.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom4.Text = promedio.ToString("0.00");
                if (prom3.Text == prom4.Text)
                {
                    prom4.Text = "";
                }

            }
            else
            {
                prom4.Text = "";
            }

            sald = float.Parse(saldo5.Text);
            existencia = float.Parse(exist5.Text);
            entrada = float.Parse(ent5.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom5.Text = promedio.ToString("0.00");
                if (prom4.Text == prom5.Text)
                {
                    prom5.Text = "";
                }

            }
            else
            {
                prom5.Text = "";
            }

            sald = float.Parse(saldo6.Text);
            existencia = float.Parse(exist6.Text);
            entrada = float.Parse(ent6.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom6.Text = promedio.ToString("0.00");
                if (prom5.Text == prom6.Text)
                {
                    prom6.Text = "";
                }

            }
            else
            {
                prom6.Text = "";
            }


            sald = float.Parse(saldo7.Text);
            existencia = float.Parse(exist7.Text);
            entrada = float.Parse(ent7.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom7.Text = promedio.ToString("0.00");
                if (prom6.Text == prom7.Text)
                {
                    prom7.Text = "";
                }

            }
            else
            {
                prom7.Text = "";
            }

            sald = float.Parse(saldo8.Text);
            existencia = float.Parse(exist8.Text);
            entrada = float.Parse(ent8.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom8.Text = promedio.ToString("0.00");
                if (prom7.Text == prom8.Text)
                {
                    prom8.Text = "";
                }

            }
            else
            {
                prom8.Text = "";
            }

            sald = float.Parse(saldo9.Text);
            existencia = float.Parse(exist9.Text);
            entrada = float.Parse(ent9.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom9.Text = promedio.ToString("0.00");
                if (prom8.Text == prom9.Text)
                {
                    prom9.Text = "";
                }

            }
            else
            {
                prom9.Text = "";
            }

            sald = float.Parse(saldo10.Text);
            existencia = float.Parse(exist10.Text);
            entrada = float.Parse(ent10.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom10.Text = promedio.ToString("0.00");
                if (prom9.Text == prom10.Text)
                {
                    prom10.Text = "";
                }

            }
            else
            {
                prom10.Text = "";
            }

            sald = float.Parse(saldo11.Text);
            existencia = float.Parse(exist11.Text);
            entrada = float.Parse(ent11.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom11.Text = promedio.ToString("0.00");
                if (prom10.Text == prom11.Text)
                {
                    prom11.Text = "";
                }

            }
            else
            {
                prom11.Text = "";
            }

            sald = float.Parse(saldo12.Text);
            existencia = float.Parse(exist12.Text);
            entrada = float.Parse(ent12.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom12.Text = promedio.ToString("0.00");
                if (prom11.Text == prom12.Text)
                {
                    prom12.Text = "";
                }

            }
            else
            {
                prom12.Text = "";
            }

            sald = float.Parse(saldo13.Text);
            existencia = float.Parse(exist13.Text);
            entrada = float.Parse(ent13.Text);
            promedio = sald / existencia;
            if (entrada != 0)
            {
                prom13.Text = promedio.ToString("0.00");
                if (prom12.Text == prom13.Text)
                {
                    prom13.Text = "";
                }

            }
            else
            {
                prom13.Text = "";
            }



            salida = Convert.ToDouble(sal2.Text);
            if (salida > 0)
            {
                pre2.Text = prom1.Text;
            }


            salida = Convert.ToDouble(sal3.Text);
            if (salida > 0)
            {
                pre3.Text = prom2.Text;
                if (prom2.Text == "")
                {
                    pre3.Text = prom1.Text;
                }

            }


            salida = Convert.ToDouble(sal4.Text);
            if (salida > 0)
            {
                pre4.Text = prom3.Text;
                if (prom3.Text == "")
                {
                    pre4.Text = prom2.Text;
                    if (prom2.Text == "")
                    {
                        pre4.Text = prom1.Text;
                    }
                }

            }

            //sssssss
            salida = Convert.ToDouble(sal5.Text);
            if (salida > 0)
            {
                pre5.Text = prom4.Text;
                if (prom4.Text == "")
                {
                    pre5.Text = prom3.Text;
                    if (prom3.Text == "")
                    {
                        pre5.Text = prom2.Text;
                        if (prom2.Text == "")
                        {
                            pre5.Text = prom1.Text;
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal6.Text);
            if (salida > 0)
            {
                pre6.Text = prom5.Text;
                if (prom5.Text == "")
                {
                    pre6.Text = prom4.Text;
                    if (prom4.Text == "")
                    {
                        pre6.Text = prom3.Text;
                        if (prom3.Text == "")
                        {
                            pre6.Text = prom2.Text;
                            if (prom2.Text == "")
                            {
                                pre6.Text = prom1.Text;
                            }
                        }
                    }
                }
            }
            salida = Convert.ToDouble(sal7.Text);
            if (salida > 0)
            {
                pre7.Text = prom6.Text;
                if (prom6.Text == "")
                {
                    pre7.Text = prom5.Text;
                    if (prom5.Text == "")
                    {
                        pre7.Text = prom4.Text;
                        if (prom4.Text == "")
                        {
                            pre7.Text = prom3.Text;
                            if (prom3.Text == "")
                            {
                                pre7.Text = prom2.Text;
                                if (prom2.Text == "")
                                {
                                    pre7.Text = prom1.Text;
                                }
                            }
                        }
                    }
                }
            }
            salida = Convert.ToDouble(sal8.Text);
            if (salida > 0)
            {
                pre8.Text = prom7.Text;
                if (prom7.Text == "")
                {
                    pre8.Text = prom6.Text;
                    if (prom6.Text == "")
                    {
                        pre8.Text = prom5.Text;
                        if (prom5.Text == "")
                        {
                            pre8.Text = prom4.Text;
                            if (prom4.Text == "")
                            {
                                pre8.Text = prom3.Text;
                                if (prom3.Text == "")
                                {
                                    pre8.Text = prom2.Text;
                                    if (prom2.Text == "")
                                    {
                                        pre8.Text = prom1.Text;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal9.Text);
            if (salida > 0)
            {
                pre9.Text = prom8.Text;
                if (prom8.Text == "")
                {
                    pre9.Text = prom7.Text;
                    if (prom7.Text == "")
                    {
                        pre9.Text = prom6.Text;
                        if (prom6.Text == "")
                        {
                            pre9.Text = prom5.Text;
                            if (prom5.Text == "")
                            {
                                pre9.Text = prom4.Text;
                                if (prom4.Text == "")
                                {
                                    pre9.Text = prom3.Text;
                                    if (prom3.Text == "")
                                    {
                                        pre9.Text = prom2.Text;
                                        if (prom2.Text == "")
                                        {
                                            pre9.Text = prom1.Text;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal10.Text);
            if (salida > 0)
            {
                pre10.Text = prom9.Text;
                if (prom9.Text == "")
                {
                    pre10.Text = prom8.Text;
                    if (prom8.Text == "")
                    {
                        pre10.Text = prom7.Text;
                        if (prom7.Text == "")
                        {
                            pre10.Text = prom6.Text;
                            if (prom6.Text == "")
                            {
                                pre10.Text = prom5.Text;
                                if (prom5.Text == "")
                                {
                                    pre10.Text = prom4.Text;
                                    if (prom4.Text == "")
                                    {
                                        pre10.Text = prom3.Text;
                                        if (prom3.Text == "")
                                        {
                                            pre10.Text = prom2.Text;
                                            if (prom2.Text == "")
                                            {
                                                pre10.Text = prom1.Text;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal11.Text);
            if (salida > 0)
            {
                pre11.Text = prom10.Text;
                if (prom10.Text == "")
                {
                    pre11.Text = prom9.Text;
                    if (prom9.Text == "")
                    {
                        pre11.Text = prom8.Text;
                        if (prom8.Text == "")
                        {
                            pre11.Text = prom7.Text;
                            if (prom7.Text == "")
                            {
                                pre11.Text = prom6.Text;
                                if (prom6.Text == "")
                                {
                                    pre11.Text = prom5.Text;
                                    if (prom5.Text == "")
                                    {
                                        pre11.Text = prom4.Text;
                                        if (prom4.Text == "")
                                        {
                                            pre11.Text = prom3.Text;
                                            if (prom3.Text == "")
                                            {
                                                pre11.Text = prom2.Text;
                                                if (prom2.Text == "")
                                                {
                                                    pre11.Text = prom1.Text;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            salida = Convert.ToDouble(sal12.Text);
            if (salida > 0)
            {
                pre12.Text = prom11.Text;
                if (prom10.Text == "")
                {
                    pre12.Text = prom10.Text;
                    if (prom10.Text == "")
                    {
                        pre12.Text = prom9.Text;
                        if (prom9.Text == "")
                        {
                            pre12.Text = prom8.Text;
                            if (prom8.Text == "")
                            {
                                pre12.Text = prom7.Text;
                                if (prom7.Text == "")
                                {
                                    pre12.Text = prom6.Text;
                                    if (prom6.Text == "")
                                    {
                                        pre12.Text = prom5.Text;
                                        if (prom5.Text == "")
                                        {
                                            pre12.Text = prom4.Text;
                                            if (prom4.Text == "")
                                            {
                                                pre12.Text = prom3.Text;
                                                if (prom3.Text == "")
                                                {
                                                    pre12.Text = prom2.Text;
                                                    if (prom2.Text == "")
                                                    {
                                                        pre12.Text = prom1.Text;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            salida = Convert.ToDouble(sal13.Text);
            if (salida > 0)
            {
                pre13.Text = prom12.Text;
                if (prom12.Text == "")
                {
                    pre13.Text = prom11.Text;
                    if (prom11.Text == "")
                    {
                        pre13.Text = prom10.Text;
                        if (prom10.Text == "")
                        {
                            pre13.Text = prom9.Text;
                            if (prom9.Text == "")
                            {
                                pre13.Text = prom8.Text;
                                if (prom8.Text == "")
                                {
                                    pre13.Text = prom7.Text;
                                    if (prom7.Text == "")
                                    {
                                        pre13.Text = prom6.Text;
                                        if (prom6.Text == "")
                                        {
                                            pre13.Text = prom5.Text;
                                            if (prom5.Text == "")
                                            {
                                                pre13.Text = prom4.Text;
                                                if (prom4.Text == "")
                                                {
                                                    pre13.Text = prom3.Text;
                                                    if (prom3.Text == "")
                                                    {
                                                        pre13.Text = prom2.Text;
                                                        if (prom2.Text == "")
                                                        {
                                                            pre13.Text = prom1.Text;

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }


                    hab1.Text = Convert.ToString(0);
                    if (pre2.Text == "")
                    {
                        pre2.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal2.Text);
                    pre = double.Parse(pre2.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab2.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab2.Text = Convert.ToString(haber);
                    }

                    if (pre3.Text == "")
                    {
                        pre3.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal3.Text);
                    pre = double.Parse(pre3.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab3.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab3.Text = Convert.ToString(haber);
                    }

                    if (pre4.Text == "")
                    {
                        pre4.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal4.Text);
                    pre = double.Parse(pre4.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab4.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab4.Text = Convert.ToString(haber);
                    }

                    if (pre5.Text == "")
                    {
                        pre5.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal5.Text);
                    pre = double.Parse(pre5.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab5.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab5.Text = Convert.ToString(haber);
                    }

                    if (pre6.Text == "")
                    {
                        pre6.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal6.Text);
                    pre = double.Parse(pre6.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab6.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab6.Text = Convert.ToString(haber);
                    }

                    if (pre7.Text == "")
                    {
                        pre7.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal7.Text);
                    pre = double.Parse(pre7.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab7.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab7.Text = Convert.ToString(haber);
                    }

                    if (pre8.Text == "")
                    {
                        pre8.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal8.Text);
                    pre = double.Parse(pre8.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab8.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab8.Text = Convert.ToString(haber);
                    }

                    if (pre9.Text == "")
                    {
                        pre9.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal9.Text);
                    pre = double.Parse(pre9.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab9.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab9.Text = Convert.ToString(haber);
                    }

                    if (pre10.Text == "")
                    {
                        pre10.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal10.Text);
                    pre = double.Parse(pre10.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab10.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab10.Text = Convert.ToString(haber);
                    }

                    if (pre11.Text == "")
                    {
                        pre11.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal11.Text);
                    pre = double.Parse(pre11.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab11.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab11.Text = Convert.ToString(haber);
                    }

                    if (pre12.Text == "")
                    {
                        pre12.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal12.Text);
                    pre = double.Parse(pre12.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab12.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab12.Text = Convert.ToString(haber);
                    }

                    if (pre13.Text == "")
                    {
                        pre13.Text = Convert.ToString(0);
                    }
                    salida = double.Parse(sal13.Text);
                    pre = double.Parse(pre13.Text);
                    haber = salida * pre;
                    if (salida == 0 || pre == 0)
                    {
                        hab13.Text = Convert.ToString(0);
                    }
                    else
                    {
                        hab13.Text = Convert.ToString(haber);
                    }


                    saldo1.Text = deb1.Text;

                    sal = double.Parse(saldo1.Text);
                    debe = double.Parse(deb2.Text);
                    haber = double.Parse(hab2.Text);
                    saldo = sal + debe - haber;
                    if (debe == 0 && haber == 0)
                    {
                        saldo2.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo2.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo2.Text);
                    debe = double.Parse(deb3.Text);
                    haber = double.Parse(hab3.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo1.Text) + debe - haber;
                        saldo3.Text = Convert.ToString(saldo);
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo3.Text = Convert.ToString(0);

                    }
                    else
                    {
                        saldo3.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo3.Text);
                    debe = double.Parse(deb4.Text);
                    haber = double.Parse(hab4.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo2.Text) + debe - haber;
                        saldo4.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo2.Text) == 0)
                        {
                            saldo = double.Parse(saldo1.Text) + debe - haber;
                            saldo4.Text = Convert.ToString(saldo);
                        }
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo4.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo4.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo4.Text);
                    debe = double.Parse(deb5.Text);
                    haber = double.Parse(hab5.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo3.Text) + debe - haber;
                        saldo5.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo3.Text) == 0)
                        {
                            saldo = double.Parse(saldo2.Text) + debe - haber;
                            saldo5.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo2.Text) == 0)
                            {
                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                saldo5.Text = Convert.ToString(saldo);
                            }
                        }
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo5.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo5.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo5.Text);
                    debe = double.Parse(deb6.Text);
                    haber = double.Parse(hab6.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo4.Text) + debe - haber;
                        saldo6.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo4.Text) == 0)
                        {
                            saldo = double.Parse(saldo3.Text) + debe - haber;
                            saldo6.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo2.Text) == 0)
                            {
                                saldo = double.Parse(saldo2.Text) + debe - haber;
                                saldo6.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo2.Text) == 0)
                                {
                                    saldo = double.Parse(saldo1.Text) + debe - haber;
                                    saldo6.Text = Convert.ToString(saldo);
                                }
                            }

                        }
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo6.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo6.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo6.Text);
                    debe = double.Parse(deb7.Text);
                    haber = double.Parse(hab7.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo5.Text) + debe - haber;
                        saldo7.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo5.Text) == 0)
                        {
                            saldo = double.Parse(saldo4.Text) + debe - haber;
                            saldo7.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo4.Text) == 0)
                            {
                                saldo = double.Parse(saldo3.Text) + debe - haber;
                                saldo7.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo3.Text) == 0)
                                {
                                    saldo = double.Parse(saldo2.Text) + debe - haber;
                                    saldo7.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo2.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo1.Text) + debe - haber;
                                        saldo7.Text = Convert.ToString(saldo);

                                    }
                                }
                            }

                        }
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo7.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo7.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo7.Text);
                    debe = double.Parse(deb8.Text);
                    haber = double.Parse(hab8.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo6.Text) + debe - haber;
                        saldo8.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo6.Text) == 0)
                        {
                            saldo = double.Parse(saldo5.Text) + debe - haber;
                            saldo8.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo5.Text) == 0)
                            {
                                saldo = double.Parse(saldo4.Text) + debe - haber;
                                saldo8.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo4.Text) == 0)
                                {
                                    saldo = double.Parse(saldo3.Text) + debe - haber;
                                    saldo8.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo3.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo2.Text) + debe - haber;
                                        saldo8.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo2.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo1.Text) + debe - haber;
                                            saldo8.Text = Convert.ToString(saldo);

                                        }
                                    }
                                }
                            }

                        }
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo8.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo8.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo8.Text);
                    debe = double.Parse(deb9.Text);
                    haber = double.Parse(hab9.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo7.Text) + debe - haber;
                        saldo9.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo7.Text) == 0)
                        {
                            saldo = double.Parse(saldo6.Text) + debe - haber;
                            saldo9.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo6.Text) == 0)
                            {
                                saldo = double.Parse(saldo5.Text) + debe - haber;
                                saldo9.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo5.Text) == 0)
                                {
                                    saldo = double.Parse(saldo4.Text) + debe - haber;
                                    saldo9.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo4.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo3.Text) + debe - haber;
                                        saldo9.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo3.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo2.Text) + debe - haber;
                                            saldo9.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo2.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                                saldo9.Text = Convert.ToString(saldo);

                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo9.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo9.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo9.Text);
                    debe = double.Parse(deb10.Text);
                    haber = double.Parse(hab10.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo8.Text) + debe - haber;
                        saldo10.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo8.Text) == 0)
                        {
                            saldo = double.Parse(saldo7.Text) + debe - haber;
                            saldo10.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo7.Text) == 0)
                            {
                                saldo = double.Parse(saldo6.Text) + debe - haber;
                                saldo10.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo6.Text) == 0)
                                {
                                    saldo = double.Parse(saldo5.Text) + debe - haber;
                                    saldo10.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo5.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo4.Text) + debe - haber;
                                        saldo10.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo4.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo3.Text) + debe - haber;
                                            saldo10.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo3.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo2.Text) + debe - haber;
                                                saldo10.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo2.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo1.Text) + debe - haber;
                                                    saldo10.Text = Convert.ToString(saldo);

                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo10.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo10.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo10.Text);
                    debe = double.Parse(deb11.Text);
                    haber = double.Parse(hab11.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo9.Text) + debe - haber;
                        saldo11.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo9.Text) == 0)
                        {
                            saldo = double.Parse(saldo8.Text) + debe - haber;
                            saldo11.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo8.Text) == 0)
                            {
                                saldo = double.Parse(saldo7.Text) + debe - haber;
                                saldo11.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo7.Text) == 0)
                                {
                                    saldo = double.Parse(saldo6.Text) + debe - haber;
                                    saldo11.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo6.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo5.Text) + debe - haber;
                                        saldo11.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo5.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo4.Text) + debe - haber;
                                            saldo11.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo4.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo3.Text) + debe - haber;
                                                saldo11.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo3.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo2.Text) + debe - haber;
                                                    saldo11.Text = Convert.ToString(saldo);
                                                    if (double.Parse(saldo2.Text) == 0)
                                                    {
                                                        saldo = double.Parse(saldo1.Text) + debe - haber;
                                                        saldo11.Text = Convert.ToString(saldo);

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo11.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo11.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo11.Text);
                    debe = double.Parse(deb12.Text);
                    haber = double.Parse(hab12.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo10.Text) + debe - haber;
                        saldo12.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo10.Text) == 0)
                        {
                            saldo = double.Parse(saldo9.Text) + debe - haber;
                            saldo12.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo9.Text) == 0)
                            {
                                saldo = double.Parse(saldo8.Text) + debe - haber;
                                saldo12.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo8.Text) == 0)
                                {
                                    saldo = double.Parse(saldo7.Text) + debe - haber;
                                    saldo12.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo7.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo6.Text) + debe - haber;
                                        saldo12.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo6.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo5.Text) + debe - haber;
                                            saldo12.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo5.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo4.Text) + debe - haber;
                                                saldo12.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo4.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo3.Text) + debe - haber;
                                                    saldo12.Text = Convert.ToString(saldo);
                                                    if (double.Parse(saldo3.Text) == 0)
                                                    {
                                                        saldo = double.Parse(saldo2.Text) + debe - haber;
                                                        saldo12.Text = Convert.ToString(saldo);
                                                        if (double.Parse(saldo2.Text) == 0)
                                                        {
                                                            saldo = double.Parse(saldo1.Text) + debe - haber;
                                                            saldo12.Text = Convert.ToString(saldo);

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo12.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo12.Text = Convert.ToString(saldo);
                    }

                    sal = double.Parse(saldo12.Text);
                    debe = double.Parse(deb13.Text);
                    haber = double.Parse(hab13.Text);
                    saldo = sal + debe - haber;
                    if (sal == 0)
                    {
                        saldo = double.Parse(saldo11.Text) + debe - haber;
                        saldo13.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo11.Text) == 0)
                        {
                            saldo = double.Parse(saldo10.Text) + debe - haber;
                            saldo13.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo10.Text) == 0)
                            {
                                saldo = double.Parse(saldo9.Text) + debe - haber;
                                saldo13.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo9.Text) == 0)
                                {
                                    saldo = double.Parse(saldo8.Text) + debe - haber;
                                    saldo13.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo8.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo7.Text) + debe - haber;
                                        saldo13.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo7.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo6.Text) + debe - haber;
                                            saldo13.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo6.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo5.Text) + debe - haber;
                                                saldo13.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo5.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo4.Text) + debe - haber;
                                                    saldo13.Text = Convert.ToString(saldo);
                                                    if (double.Parse(saldo4.Text) == 0)
                                                    {
                                                        saldo = double.Parse(saldo3.Text) + debe - haber;
                                                        saldo13.Text = Convert.ToString(saldo);
                                                        if (double.Parse(saldo3.Text) == 0)
                                                        {
                                                            saldo = double.Parse(saldo2.Text) + debe - haber;
                                                            saldo13.Text = Convert.ToString(saldo);
                                                            if (double.Parse(saldo2.Text) == 0)
                                                            {
                                                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                                                saldo13.Text = Convert.ToString(saldo);

                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                    if (debe == 0 && haber == 0)
                    {
                        saldo13.Text = Convert.ToString(0);
                    }
                    else
                    {
                        saldo13.Text = Convert.ToString(saldo);
                    }



                    prom1.Text = pre1.Text;

                    sald = float.Parse(saldo2.Text);
                    existencia = float.Parse(exist2.Text);
                    entrada = float.Parse(ent2.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom2.Text = promedio.ToString("0.00");
                        if (prom1.Text == prom2.Text)
                        {
                            prom2.Text = "";
                        }

                    }
                    else
                    {
                        prom2.Text = "";
                    }

                    sald = float.Parse(saldo3.Text);
                    existencia = float.Parse(exist3.Text);
                    entrada = float.Parse(ent3.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom3.Text = promedio.ToString("0.00");
                        if (prom2.Text == prom3.Text)
                        {
                            prom3.Text = "";
                        }

                    }
                    else
                    {
                        prom3.Text = "";
                    }

                    sald = float.Parse(saldo4.Text);
                    existencia = float.Parse(exist4.Text);
                    entrada = float.Parse(ent4.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom4.Text = promedio.ToString("0.00");
                        if (prom3.Text == prom4.Text)
                        {
                            prom4.Text = "";
                        }

                    }
                    else
                    {
                        prom4.Text = "";
                    }

                    sald = float.Parse(saldo5.Text);
                    existencia = float.Parse(exist5.Text);
                    entrada = float.Parse(ent5.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom5.Text = promedio.ToString("0.00");
                        if (prom4.Text == prom5.Text)
                        {
                            prom5.Text = "";
                        }

                    }
                    else
                    {
                        prom5.Text = "";
                    }

                    sald = float.Parse(saldo6.Text);
                    existencia = float.Parse(exist6.Text);
                    entrada = float.Parse(ent6.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom6.Text = promedio.ToString("0.00");
                        if (prom5.Text == prom6.Text)
                        {
                            prom6.Text = "";
                        }

                    }
                    else
                    {
                        prom6.Text = "";
                    }


                    sald = float.Parse(saldo7.Text);
                    existencia = float.Parse(exist7.Text);
                    entrada = float.Parse(ent7.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom7.Text = promedio.ToString("0.00");
                        if (prom6.Text == prom7.Text)
                        {
                            prom7.Text = "";
                        }

                    }
                    else
                    {
                        prom7.Text = "";
                    }

                    sald = float.Parse(saldo8.Text);
                    existencia = float.Parse(exist8.Text);
                    entrada = float.Parse(ent8.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom8.Text = promedio.ToString("0.00");
                        if (prom7.Text == prom8.Text)
                        {
                            prom8.Text = "";
                        }

                    }
                    else
                    {
                        prom8.Text = "";
                    }

                    sald = float.Parse(saldo9.Text);
                    existencia = float.Parse(exist9.Text);
                    entrada = float.Parse(ent9.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom9.Text = promedio.ToString("0.00");
                        if (prom8.Text == prom9.Text)
                        {
                            prom9.Text = "";
                        }

                    }
                    else
                    {
                        prom9.Text = "";
                    }

                    sald = float.Parse(saldo10.Text);
                    existencia = float.Parse(exist10.Text);
                    entrada = float.Parse(ent10.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom10.Text = promedio.ToString("0.00");
                        if (prom9.Text == prom10.Text)
                        {
                            prom10.Text = "";
                        }

                    }
                    else
                    {
                        prom10.Text = "";
                    }

                    sald = float.Parse(saldo11.Text);
                    existencia = float.Parse(exist11.Text);
                    entrada = float.Parse(ent11.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom11.Text = promedio.ToString("0.00");
                        if (prom10.Text == prom11.Text)
                        {
                            prom11.Text = "";
                        }

                    }
                    else
                    {
                        prom11.Text = "";
                    }

                    sald = float.Parse(saldo12.Text);
                    existencia = float.Parse(exist12.Text);
                    entrada = float.Parse(ent12.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom12.Text = promedio.ToString("0.00");
                        if (prom11.Text == prom12.Text)
                        {
                            prom12.Text = "";
                        }

                    }
                    else
                    {
                        prom12.Text = "";
                    }

                    sald = float.Parse(saldo13.Text);
                    existencia = float.Parse(exist13.Text);
                    entrada = float.Parse(ent13.Text);
                    promedio = sald / existencia;
                    if (entrada != 0)
                    {
                        prom13.Text = promedio.ToString("0.00");
                        if (prom12.Text == prom13.Text)
                        {
                            prom13.Text = "";
                        }

                    }
                    else
                    {
                        prom13.Text = "";
                    }



                    salida = Convert.ToDouble(sal2.Text);
                    if (salida > 0)
                    {
                        pre2.Text = prom1.Text;
                    }


                    salida = Convert.ToDouble(sal3.Text);
                    if (salida > 0)
                    {
                        pre3.Text = prom2.Text;
                        if (prom2.Text == "")
                        {
                            pre3.Text = prom1.Text;
                        }

                    }


                    salida = Convert.ToDouble(sal4.Text);
                    if (salida > 0)
                    {
                        pre4.Text = prom3.Text;
                        if (prom3.Text == "")
                        {
                            pre4.Text = prom2.Text;
                            if (prom2.Text == "")
                            {
                                pre4.Text = prom1.Text;
                            }
                        }

                    }

                    //sssssss
                    salida = Convert.ToDouble(sal5.Text);
                    if (salida > 0)
                    {
                        pre5.Text = prom4.Text;
                        if (prom4.Text == "")
                        {
                            pre5.Text = prom3.Text;
                            if (prom3.Text == "")
                            {
                                pre5.Text = prom2.Text;
                                if (prom2.Text == "")
                                {
                                    pre5.Text = prom1.Text;
                                }
                            }
                        }
                    }

                    salida = Convert.ToDouble(sal6.Text);
                    if (salida > 0)
                    {
                        pre6.Text = prom5.Text;
                        if (prom5.Text == "")
                        {
                            pre6.Text = prom4.Text;
                            if (prom4.Text == "")
                            {
                                pre6.Text = prom3.Text;
                                if (prom3.Text == "")
                                {
                                    pre6.Text = prom2.Text;
                                    if (prom2.Text == "")
                                    {
                                        pre6.Text = prom1.Text;
                                    }
                                }
                            }
                        }
                    }
                    salida = Convert.ToDouble(sal7.Text);
                    if (salida > 0)
                    {
                        pre7.Text = prom6.Text;
                        if (prom6.Text == "")
                        {
                            pre7.Text = prom5.Text;
                            if (prom5.Text == "")
                            {
                                pre7.Text = prom4.Text;
                                if (prom4.Text == "")
                                {
                                    pre7.Text = prom3.Text;
                                    if (prom3.Text == "")
                                    {
                                        pre7.Text = prom2.Text;
                                        if (prom2.Text == "")
                                        {
                                            pre7.Text = prom1.Text;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    salida = Convert.ToDouble(sal8.Text);
                    if (salida > 0)
                    {
                        pre8.Text = prom7.Text;
                        if (prom7.Text == "")
                        {
                            pre8.Text = prom6.Text;
                            if (prom6.Text == "")
                            {
                                pre8.Text = prom5.Text;
                                if (prom5.Text == "")
                                {
                                    pre8.Text = prom4.Text;
                                    if (prom4.Text == "")
                                    {
                                        pre8.Text = prom3.Text;
                                        if (prom3.Text == "")
                                        {
                                            pre8.Text = prom2.Text;
                                            if (prom2.Text == "")
                                            {
                                                pre8.Text = prom1.Text;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    salida = Convert.ToDouble(sal9.Text);
                    if (salida > 0)
                    {
                        pre9.Text = prom8.Text;
                        if (prom8.Text == "")
                        {
                            pre9.Text = prom7.Text;
                            if (prom7.Text == "")
                            {
                                pre9.Text = prom6.Text;
                                if (prom6.Text == "")
                                {
                                    pre9.Text = prom5.Text;
                                    if (prom5.Text == "")
                                    {
                                        pre9.Text = prom4.Text;
                                        if (prom4.Text == "")
                                        {
                                            pre9.Text = prom3.Text;
                                            if (prom3.Text == "")
                                            {
                                                pre9.Text = prom2.Text;
                                                if (prom2.Text == "")
                                                {
                                                    pre9.Text = prom1.Text;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    salida = Convert.ToDouble(sal10.Text);
                    if (salida > 0)
                    {
                        pre10.Text = prom9.Text;
                        if (prom9.Text == "")
                        {
                            pre10.Text = prom8.Text;
                            if (prom8.Text == "")
                            {
                                pre10.Text = prom7.Text;
                                if (prom7.Text == "")
                                {
                                    pre10.Text = prom6.Text;
                                    if (prom6.Text == "")
                                    {
                                        pre10.Text = prom5.Text;
                                        if (prom5.Text == "")
                                        {
                                            pre10.Text = prom4.Text;
                                            if (prom4.Text == "")
                                            {
                                                pre10.Text = prom3.Text;
                                                if (prom3.Text == "")
                                                {
                                                    pre10.Text = prom2.Text;
                                                    if (prom2.Text == "")
                                                    {
                                                        pre10.Text = prom1.Text;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    salida = Convert.ToDouble(sal11.Text);
                    if (salida > 0)
                    {
                        pre11.Text = prom10.Text;
                        if (prom10.Text == "")
                        {
                            pre11.Text = prom9.Text;
                            if (prom9.Text == "")
                            {
                                pre11.Text = prom8.Text;
                                if (prom8.Text == "")
                                {
                                    pre11.Text = prom7.Text;
                                    if (prom7.Text == "")
                                    {
                                        pre11.Text = prom6.Text;
                                        if (prom6.Text == "")
                                        {
                                            pre11.Text = prom5.Text;
                                            if (prom5.Text == "")
                                            {
                                                pre11.Text = prom4.Text;
                                                if (prom4.Text == "")
                                                {
                                                    pre11.Text = prom3.Text;
                                                    if (prom3.Text == "")
                                                    {
                                                        pre11.Text = prom2.Text;
                                                        if (prom2.Text == "")
                                                        {
                                                            pre11.Text = prom1.Text;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    salida = Convert.ToDouble(sal12.Text);
                    if (salida > 0)
                    {
                        pre12.Text = prom11.Text;
                        if (prom10.Text == "")
                        {
                            pre12.Text = prom10.Text;
                            if (prom10.Text == "")
                            {
                                pre12.Text = prom9.Text;
                                if (prom9.Text == "")
                                {
                                    pre12.Text = prom8.Text;
                                    if (prom8.Text == "")
                                    {
                                        pre12.Text = prom7.Text;
                                        if (prom7.Text == "")
                                        {
                                            pre12.Text = prom6.Text;
                                            if (prom6.Text == "")
                                            {
                                                pre12.Text = prom5.Text;
                                                if (prom5.Text == "")
                                                {
                                                    pre12.Text = prom4.Text;
                                                    if (prom4.Text == "")
                                                    {
                                                        pre12.Text = prom3.Text;
                                                        if (prom3.Text == "")
                                                        {
                                                            pre12.Text = prom2.Text;
                                                            if (prom2.Text == "")
                                                            {
                                                                pre12.Text = prom1.Text;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }


                    salida = Convert.ToDouble(sal13.Text);
                    if (salida > 0)
                    {
                        pre13.Text = prom12.Text;
                        if (prom12.Text == "")
                        {
                            pre13.Text = prom11.Text;
                            if (prom11.Text == "")
                            {
                                pre13.Text = prom10.Text;
                                if (prom10.Text == "")
                                {
                                    pre13.Text = prom9.Text;
                                    if (prom9.Text == "")
                                    {
                                        pre13.Text = prom8.Text;
                                        if (prom8.Text == "")
                                        {
                                            pre13.Text = prom7.Text;
                                            if (prom7.Text == "")
                                            {
                                                pre13.Text = prom6.Text;
                                                if (prom6.Text == "")
                                                {
                                                    pre13.Text = prom5.Text;
                                                    if (prom5.Text == "")
                                                    {
                                                        pre13.Text = prom4.Text;
                                                        if (prom4.Text == "")
                                                        {
                                                            pre13.Text = prom3.Text;
                                                            if (prom3.Text == "")
                                                            {
                                                                pre13.Text = prom2.Text;
                                                                if (prom2.Text == "")
                                                                {
                                                                    pre13.Text = prom1.Text;

                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }



            hab1.Text = Convert.ToString(0);

            if (pre2.Text == "")
            {
                pre2.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal2.Text);
            pre = double.Parse(pre2.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab2.Text = Convert.ToString(0);
            }
            else
            {
                hab2.Text = Convert.ToString(haber);
            }

            if (pre3.Text == "")
            {
                pre3.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal3.Text);
            pre = double.Parse(pre3.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab3.Text = Convert.ToString(0);
            }
            else
            {
                hab3.Text = Convert.ToString(haber);
            }

            if (pre4.Text == "")
            {
                pre4.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal4.Text);
            pre = double.Parse(pre4.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab4.Text = Convert.ToString(0);
            }
            else
            {
                hab4.Text = Convert.ToString(haber);
            }

            if (pre5.Text == "")
            {
                pre5.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal5.Text);
            pre = double.Parse(pre5.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab5.Text = Convert.ToString(0);
            }
            else
            {
                hab5.Text = Convert.ToString(haber);
            }

            if (pre6.Text == "")
            {
                pre6.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal6.Text);
            pre = double.Parse(pre6.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab6.Text = Convert.ToString(0);
            }
            else
            {
                hab6.Text = Convert.ToString(haber);
            }

            if (pre7.Text == "")
            {
                pre7.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal7.Text);
            pre = double.Parse(pre7.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab7.Text = Convert.ToString(0);
            }
            else
            {
                hab7.Text = Convert.ToString(haber);
            }

            if (pre8.Text == "")
            {
                pre8.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal8.Text);
            pre = double.Parse(pre8.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab8.Text = Convert.ToString(0);
            }
            else
            {
                hab8.Text = Convert.ToString(haber);
            }

            if (pre9.Text == "")
            {
                pre9.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal9.Text);
            pre = double.Parse(pre9.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab9.Text = Convert.ToString(0);
            }
            else
            {
                hab9.Text = Convert.ToString(haber);
            }

            if (pre10.Text == "")
            {
                pre10.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal10.Text);
            pre = double.Parse(pre10.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab10.Text = Convert.ToString(0);
            }
            else
            {
                hab10.Text = Convert.ToString(haber);
            }

            if (pre11.Text == "")
            {
                pre11.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal11.Text);
            pre = double.Parse(pre11.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab11.Text = Convert.ToString(0);
            }
            else
            {
                hab11.Text = Convert.ToString(haber);
            }

            if (pre12.Text == "")
            {
                pre12.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal12.Text);
            pre = double.Parse(pre12.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab12.Text = Convert.ToString(0);
            }
            else
            {
                hab12.Text = Convert.ToString(haber);
            }

            if (pre13.Text == "")
            {
                pre13.Text = Convert.ToString(0);
            }
            salida = double.Parse(sal13.Text);
            pre = double.Parse(pre13.Text);
            haber = salida * pre;
            if (salida == 0 || pre == 0)
            {
                hab13.Text = Convert.ToString(0);
            }
            else
            {
                hab13.Text = Convert.ToString(haber);
            }


            saldo1.Text = deb1.Text;

            sal = double.Parse(saldo1.Text);
            debe = double.Parse(deb2.Text);
            haber = double.Parse(hab2.Text);
            saldo = sal + debe - haber;
            if (debe == 0 && haber == 0)
            {
                saldo2.Text = Convert.ToString(0);
            }
            else
            {
                saldo2.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo2.Text);
            debe = double.Parse(deb3.Text);
            haber = double.Parse(hab3.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo1.Text) + debe - haber;
                saldo3.Text = Convert.ToString(saldo);
            }
            if (debe == 0 && haber == 0)
            {
                saldo3.Text = Convert.ToString(0);

            }
            else
            {
                saldo3.Text = Convert.ToString(saldo);
            }

            //gggggg
            sal = double.Parse(saldo3.Text);
            debe = double.Parse(deb4.Text);
            haber = double.Parse(hab4.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo2.Text) + debe - haber;
                saldo4.Text = Convert.ToString(saldo);
                if (double.Parse(saldo2.Text) == 0)
                {
                    saldo = double.Parse(saldo1.Text) + debe - haber;
                    saldo4.Text = Convert.ToString(saldo);
                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo4.Text = Convert.ToString(0);
            }
            else
            {
                saldo4.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo4.Text);
            debe = double.Parse(deb5.Text);
            haber = double.Parse(hab5.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo3.Text) + debe - haber;
                saldo5.Text = Convert.ToString(saldo);
                if (double.Parse(saldo3.Text) == 0)
                {
                    saldo = double.Parse(saldo2.Text) + debe - haber;
                    saldo5.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo2.Text) == 0)
                    {
                        saldo = double.Parse(saldo1.Text) + debe - haber;
                        saldo5.Text = Convert.ToString(saldo);
                    }
                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo5.Text = Convert.ToString(0);
            }
            else
            {
                saldo5.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo5.Text);
            debe = double.Parse(deb6.Text);
            haber = double.Parse(hab6.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo4.Text) + debe - haber;
                saldo6.Text = Convert.ToString(saldo);
                if (double.Parse(saldo4.Text) == 0)
                {
                    saldo = double.Parse(saldo3.Text) + debe - haber;
                    saldo6.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo2.Text) == 0)
                    {
                        saldo = double.Parse(saldo2.Text) + debe - haber;
                        saldo6.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo2.Text) == 0)
                        {
                            saldo = double.Parse(saldo1.Text) + debe - haber;
                            saldo6.Text = Convert.ToString(saldo);
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo6.Text = Convert.ToString(0);
            }
            else
            {
                saldo6.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo6.Text);
            debe = double.Parse(deb7.Text);
            haber = double.Parse(hab7.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo5.Text) + debe - haber;
                saldo7.Text = Convert.ToString(saldo);
                if (double.Parse(saldo5.Text) == 0)
                {
                    saldo = double.Parse(saldo4.Text) + debe - haber;
                    saldo7.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo4.Text) == 0)
                    {
                        saldo = double.Parse(saldo3.Text) + debe - haber;
                        saldo7.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo3.Text) == 0)
                        {
                            saldo = double.Parse(saldo2.Text) + debe - haber;
                            saldo7.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo2.Text) == 0)
                            {
                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                saldo7.Text = Convert.ToString(saldo);

                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo7.Text = Convert.ToString(0);
            }
            else
            {
                saldo7.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo7.Text);
            debe = double.Parse(deb8.Text);
            haber = double.Parse(hab8.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo6.Text) + debe - haber;
                saldo8.Text = Convert.ToString(saldo);
                if (double.Parse(saldo6.Text) == 0)
                {
                    saldo = double.Parse(saldo5.Text) + debe - haber;
                    saldo8.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo5.Text) == 0)
                    {
                        saldo = double.Parse(saldo4.Text) + debe - haber;
                        saldo8.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo4.Text) == 0)
                        {
                            saldo = double.Parse(saldo3.Text) + debe - haber;
                            saldo8.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo3.Text) == 0)
                            {
                                saldo = double.Parse(saldo2.Text) + debe - haber;
                                saldo8.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo2.Text) == 0)
                                {
                                    saldo = double.Parse(saldo1.Text) + debe - haber;
                                    saldo8.Text = Convert.ToString(saldo);

                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo8.Text = Convert.ToString(0);
            }
            else
            {
                saldo8.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo8.Text);
            debe = double.Parse(deb9.Text);
            haber = double.Parse(hab9.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo7.Text) + debe - haber;
                saldo9.Text = Convert.ToString(saldo);
                if (double.Parse(saldo7.Text) == 0)
                {
                    saldo = double.Parse(saldo6.Text) + debe - haber;
                    saldo9.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo6.Text) == 0)
                    {
                        saldo = double.Parse(saldo5.Text) + debe - haber;
                        saldo9.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo5.Text) == 0)
                        {
                            saldo = double.Parse(saldo4.Text) + debe - haber;
                            saldo9.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo4.Text) == 0)
                            {
                                saldo = double.Parse(saldo3.Text) + debe - haber;
                                saldo9.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo3.Text) == 0)
                                {
                                    saldo = double.Parse(saldo2.Text) + debe - haber;
                                    saldo9.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo2.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo1.Text) + debe - haber;
                                        saldo9.Text = Convert.ToString(saldo);

                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo9.Text = Convert.ToString(0);
            }
            else
            {
                saldo9.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo9.Text);
            debe = double.Parse(deb10.Text);
            haber = double.Parse(hab10.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo8.Text) + debe - haber;
                saldo10.Text = Convert.ToString(saldo);
                if (double.Parse(saldo8.Text) == 0)
                {
                    saldo = double.Parse(saldo7.Text) + debe - haber;
                    saldo10.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo7.Text) == 0)
                    {
                        saldo = double.Parse(saldo6.Text) + debe - haber;
                        saldo10.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo6.Text) == 0)
                        {
                            saldo = double.Parse(saldo5.Text) + debe - haber;
                            saldo10.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo5.Text) == 0)
                            {
                                saldo = double.Parse(saldo4.Text) + debe - haber;
                                saldo10.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo4.Text) == 0)
                                {
                                    saldo = double.Parse(saldo3.Text) + debe - haber;
                                    saldo10.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo3.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo2.Text) + debe - haber;
                                        saldo10.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo2.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo1.Text) + debe - haber;
                                            saldo10.Text = Convert.ToString(saldo);

                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo10.Text = Convert.ToString(0);
            }
            else
            {
                saldo10.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo10.Text);
            debe = double.Parse(deb11.Text);
            haber = double.Parse(hab11.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo9.Text) + debe - haber;
                saldo11.Text = Convert.ToString(saldo);
                if (double.Parse(saldo9.Text) == 0)
                {
                    saldo = double.Parse(saldo8.Text) + debe - haber;
                    saldo11.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo8.Text) == 0)
                    {
                        saldo = double.Parse(saldo7.Text) + debe - haber;
                        saldo11.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo7.Text) == 0)
                        {
                            saldo = double.Parse(saldo6.Text) + debe - haber;
                            saldo11.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo6.Text) == 0)
                            {
                                saldo = double.Parse(saldo5.Text) + debe - haber;
                                saldo11.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo5.Text) == 0)
                                {
                                    saldo = double.Parse(saldo4.Text) + debe - haber;
                                    saldo11.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo4.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo3.Text) + debe - haber;
                                        saldo11.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo3.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo2.Text) + debe - haber;
                                            saldo11.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo2.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo1.Text) + debe - haber;
                                                saldo11.Text = Convert.ToString(saldo);

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo11.Text = Convert.ToString(0);
            }
            else
            {
                saldo11.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo11.Text);
            debe = double.Parse(deb12.Text);
            haber = double.Parse(hab12.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo10.Text) + debe - haber;
                saldo12.Text = Convert.ToString(saldo);
                if (double.Parse(saldo10.Text) == 0)
                {
                    saldo = double.Parse(saldo9.Text) + debe - haber;
                    saldo12.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo9.Text) == 0)
                    {
                        saldo = double.Parse(saldo8.Text) + debe - haber;
                        saldo12.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo8.Text) == 0)
                        {
                            saldo = double.Parse(saldo7.Text) + debe - haber;
                            saldo12.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo7.Text) == 0)
                            {
                                saldo = double.Parse(saldo6.Text) + debe - haber;
                                saldo12.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo6.Text) == 0)
                                {
                                    saldo = double.Parse(saldo5.Text) + debe - haber;
                                    saldo12.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo5.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo4.Text) + debe - haber;
                                        saldo12.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo4.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo3.Text) + debe - haber;
                                            saldo12.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo3.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo2.Text) + debe - haber;
                                                saldo12.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo2.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo1.Text) + debe - haber;
                                                    saldo12.Text = Convert.ToString(saldo);

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo12.Text = Convert.ToString(0);
            }
            else
            {
                saldo12.Text = Convert.ToString(saldo);
            }

            sal = double.Parse(saldo12.Text);
            debe = double.Parse(deb13.Text);
            haber = double.Parse(hab13.Text);
            saldo = sal + debe - haber;
            if (sal == 0)
            {
                saldo = double.Parse(saldo11.Text) + debe - haber;
                saldo13.Text = Convert.ToString(saldo);
                if (double.Parse(saldo11.Text) == 0)
                {
                    saldo = double.Parse(saldo10.Text) + debe - haber;
                    saldo13.Text = Convert.ToString(saldo);
                    if (double.Parse(saldo10.Text) == 0)
                    {
                        saldo = double.Parse(saldo9.Text) + debe - haber;
                        saldo13.Text = Convert.ToString(saldo);
                        if (double.Parse(saldo9.Text) == 0)
                        {
                            saldo = double.Parse(saldo8.Text) + debe - haber;
                            saldo13.Text = Convert.ToString(saldo);
                            if (double.Parse(saldo8.Text) == 0)
                            {
                                saldo = double.Parse(saldo7.Text) + debe - haber;
                                saldo13.Text = Convert.ToString(saldo);
                                if (double.Parse(saldo7.Text) == 0)
                                {
                                    saldo = double.Parse(saldo6.Text) + debe - haber;
                                    saldo13.Text = Convert.ToString(saldo);
                                    if (double.Parse(saldo6.Text) == 0)
                                    {
                                        saldo = double.Parse(saldo5.Text) + debe - haber;
                                        saldo13.Text = Convert.ToString(saldo);
                                        if (double.Parse(saldo5.Text) == 0)
                                        {
                                            saldo = double.Parse(saldo4.Text) + debe - haber;
                                            saldo13.Text = Convert.ToString(saldo);
                                            if (double.Parse(saldo4.Text) == 0)
                                            {
                                                saldo = double.Parse(saldo3.Text) + debe - haber;
                                                saldo13.Text = Convert.ToString(saldo);
                                                if (double.Parse(saldo3.Text) == 0)
                                                {
                                                    saldo = double.Parse(saldo2.Text) + debe - haber;
                                                    saldo13.Text = Convert.ToString(saldo);
                                                    if (double.Parse(saldo2.Text) == 0)
                                                    {
                                                        saldo = double.Parse(saldo1.Text) + debe - haber;
                                                        saldo13.Text = Convert.ToString(saldo);

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            if (debe == 0 && haber == 0)
            {
                saldo13.Text = Convert.ToString(0);
            }
            else
            {
                saldo13.Text = Convert.ToString(saldo);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UEPS u = new UEPS();

            u.ent1.Text = ent1.Text;
            u.ent2.Text = ent2.Text;
            u.ent3.Text = ent3.Text;
            u.ent4.Text = ent4.Text;
            u.ent5.Text = ent5.Text;
            u.ent6.Text = ent6.Text;
            u.ent7.Text = ent7.Text;
            u.ent8.Text = ent8.Text;
            u.ent9.Text = ent9.Text;
            u.ent10.Text = ent10.Text;
            u.ent11.Text = ent11.Text;
            u.ent12.Text = ent12.Text;
            u.ent13.Text = ent13.Text;

            u.cant1.Text = sal1.Text;
            u.cant2.Text = sal2.Text;
            u.cant3.Text = sal3.Text;
            u.cant4.Text = sal4.Text;
            u.cant5.Text = sal5.Text;
            u.cant6.Text = sal6.Text;
            u.cant7.Text = sal7.Text;
            u.cant8.Text = sal8.Text;
            u.cant9.Text = sal9.Text;
            u.cant10.Text = sal10.Text;
            u.cant11.Text = sal11.Text;
            u.cant12.Text = sal12.Text;
            u.cant13.Text = sal13.Text;

            u.ShowDialog();
        }
    }
}
