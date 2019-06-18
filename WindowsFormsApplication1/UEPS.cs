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
    public partial class UEPS : Form
    {
        public UEPS()
       {
            InitializeComponent();
      }


        private void CTotalUno_Click(object sender, EventArgs e)
        {
             double debe, ent,pre;

            if (sal1.Text == "")
            {
                sal1.Text = Convert.ToString(0);    
            }
            if (ent1.Text == "")
            {
                ent1.Text = Convert.ToString(0);
            }
            if (ctotal1.Text == "")
            {
                ctotal1.Text = Convert.ToString(0);
            }
           
            if (Convert.ToDouble( ent1.Text) == 0 || Convert.ToDouble(sal1.Text) == 0)
            {
                ctotal1.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(ent1.Text);
                pre = double.Parse(sal1.Text);
                debe = ent * pre;
                ctotal1.Text = Convert.ToString(debe);
               
            }
            //deb1.Text =Convert.ToString( debe);

            if (sal2.Text == "")
            {
                sal2.Text = Convert.ToString(0);
            }
            if (ent2.Text == "")
            {
                ent2.Text = Convert.ToString(0);
            }

            if (Convert.ToDouble(ent2.Text) == 0 || Convert.ToDouble(sal2.Text) == 0)
            {
                ctotal2.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(ent2.Text);
                pre = double.Parse(sal2.Text);
                debe = ent * pre;
                ctotal2.Text = Convert.ToString(debe);
            }

            if (sal3.Text == "")
            {
                sal3.Text = Convert.ToString(0);
            }
            if (ent3.Text == "")
            {
                ent3.Text = Convert.ToString(0);
            }

            if (Convert.ToDouble(ent3.Text) == 0 || Convert.ToDouble(sal3.Text) == 0)
            {
                ctotal3.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(ent3.Text);
                pre = double.Parse(sal3.Text);
                debe = ent * pre;
                ctotal3.Text = Convert.ToString(debe);
            }

            if (sal4.Text == "")
            {
                sal4.Text = Convert.ToString(0);
            }
            if (ent4.Text == "")
            {
                ent4.Text = Convert.ToString(0);
            }
            if (Convert.ToDouble(ent4.Text) == 0 || Convert.ToDouble(sal4.Text) == 0)
            {
                ctotal4.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(ent4.Text);
                pre = double.Parse(sal4.Text);
                debe = ent * pre;
                ctotal4.Text = Convert.ToString(debe);
            }

            if (sal5.Text == "")
            {
                sal5.Text = Convert.ToString(0);
            }
            if (ent5.Text == "")
            {
                ent5.Text = Convert.ToString(0);
            }
            if (Convert.ToDouble(ent5.Text) == 0 || Convert.ToDouble(sal5.Text) == 0)
            {
                ctotal5.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(ent5.Text);
                pre = double.Parse(sal5.Text);
                debe = ent * pre;
                ctotal5.Text = Convert.ToString(debe);
            }

           if (sal6.Text == "")
            {
                sal6.Text = Convert.ToString(0);
            }
            if (ent6.Text == "")
            {
                ent6.Text = Convert.ToString(0);
            }

            if (Convert.ToDouble(ent6.Text) == 0 || Convert.ToDouble(sal6.Text) == 0)
            {
                ctotal6.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(ent6.Text);
                pre = double.Parse(sal6.Text);
                debe = ent * pre;
                ctotal6.Text = Convert.ToString(debe);
            }

            if (sal7.Text == "")
            {
                sal7.Text = Convert.ToString(0);
            }
            if (ent7.Text == "")
            {
                ent7.Text = Convert.ToString(0);
            }
            if (Convert.ToDouble(ent7.Text) == 0 || Convert.ToDouble(sal7.Text) == 0)
            {
                ctotal7.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(ent7.Text);
                pre = double.Parse(sal7.Text);
                debe = ent * pre;
                ctotal7.Text = Convert.ToString(debe);
            }

            if (sal8.Text == "")
            {
                sal8.Text = Convert.ToString(0);
            }
            if (ent8.Text == "")
            {
                ent8.Text = Convert.ToString(0);
            }
            if (Convert.ToDouble(ent8.Text) == 0 || Convert.ToDouble(sal8.Text) == 0)
            {
                ctotal8.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(ent8.Text);
                pre = double.Parse(sal8.Text);
                debe = ent * pre;
                ctotal8.Text = Convert.ToString(debe);
            }

            if (sal9.Text == "")
            {
                sal9.Text = Convert.ToString(0);
            }
            if (ent9.Text == "")
            {
                ent9.Text = Convert.ToString(0);
            }
            if (Convert.ToDouble(ent9.Text) == 0 || Convert.ToDouble(sal9.Text) == 0)
            {
                ctotal9.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(ent9.Text);
                pre = double.Parse(sal9.Text);
                debe = ent * pre;
                ctotal9.Text = Convert.ToString(debe);
            }

            if (sal10.Text == "")
            {
                sal10.Text = Convert.ToString(0);
            }
            if (ent10.Text == "")
            {
                ent10.Text = Convert.ToString(0);
            }
            if (Convert.ToDouble(ent10.Text) == 0 || Convert.ToDouble(sal10.Text) == 0)
            {
                ctotal10.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(ent10.Text);
                pre = double.Parse(sal10.Text);
                debe = ent * pre;
                ctotal10.Text = Convert.ToString(debe);
            }

            if (sal11.Text == "")
            {
                sal11.Text = Convert.ToString(0);
            }
            if (ent11.Text == "")
            {
                ent11.Text = Convert.ToString(0);
            }
            if (Convert.ToDouble(ent11.Text) == 0 || Convert.ToDouble(sal11.Text) == 0)
            {
                ctotal11.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(ent11.Text);
                pre = double.Parse(sal11.Text);
                debe = ent * pre;
                ctotal11.Text = Convert.ToString(debe);
            }

            if (sal12.Text == "")
            {
                sal12.Text = Convert.ToString(0);
            }
            if (ent12.Text == "")
            {
                ent12.Text = Convert.ToString(0);
            }
            if (Convert.ToDouble(ent12.Text) == 0 || Convert.ToDouble(sal12.Text) == 0)
            {
                ctotal12.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(ent12.Text);
                pre = double.Parse(sal12.Text);
                debe = ent * pre;
                ctotal12.Text = Convert.ToString(debe);
            }

            if (sal13.Text == "")
            {
                sal13.Text = Convert.ToString(0);
            }
            if (ent13.Text == "")
            {
                ent13.Text = Convert.ToString(0);
            }
            if (Convert.ToDouble(ent13.Text) == 0 || Convert.ToDouble(sal13.Text) == 0)
            {
                ctotal13.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(ent13.Text);
                pre = double.Parse(sal13.Text);
                debe = ent * pre;
                ctotal13.Text = Convert.ToString(debe);
            }
        }

        private void CTotalDos_Click(object sender, EventArgs e)
        {
            double debe, ent, pre;

            if (cuni1.Text == "")
            {
                cuni1.Text = Convert.ToString(0);
            }
            if (cant1.Text == "")
            {
                cant1.Text = Convert.ToString(0);
            }
            if (ct1.Text == "")
            {
                ct1.Text = Convert.ToString(0);
            }

            if (Convert.ToDouble(cant1.Text) == 0 || Convert.ToDouble(sal1.Text) == 0)
            {
                ct1.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(cant1.Text);
                pre = double.Parse(cuni1.Text);
                debe = ent * pre;
                ct1.Text = Convert.ToString(debe);

            }
            //deb1.Text =Convert.ToString( debe);

            if (cuni2.Text == "")
            {
                cuni2.Text = Convert.ToString(0);
            }
            if (cant2.Text == "")
            {
                cant2.Text = Convert.ToString(0);
            }

            if (Convert.ToDouble(cant2.Text) == 0 || Convert.ToDouble(cuni2.Text) == 0)
            {
                ct2.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(cant2.Text);
                pre = double.Parse(cuni2.Text);
                debe = ent * pre;
                ct2.Text = Convert.ToString(debe);
            }

            if (cuni3.Text == "")
            {
                cuni3.Text = Convert.ToString(0);
            }
            if (cant3.Text == "")
            {
                cant3.Text = Convert.ToString(0);
            }

            if (Convert.ToDouble(cant3.Text) == 0 || Convert.ToDouble(cuni3.Text) == 0)
            {
                ct3.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(cant3.Text);
                pre = double.Parse(cuni3.Text);
                debe = ent * pre;
                ct3.Text = Convert.ToString(debe);
            }

            if (cuni4.Text == "")
            {
                cuni4.Text = Convert.ToString(0);
            }
            if (cant4.Text == "")
            {
                cant4.Text = Convert.ToString(0);
            }
            if (Convert.ToDouble(cant4.Text) == 0 || Convert.ToDouble(cuni4.Text) == 0)
            {
                ct4.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(cant4.Text);
                pre = double.Parse(cuni4.Text);
                debe = ent * pre;
                ct4.Text = Convert.ToString(debe);
            }

            if (cuni5.Text == "")
            {
                cuni5.Text = Convert.ToString(0);
            }
            if (cant5.Text == "")
            {
                cant5.Text = Convert.ToString(0);
            }
            if (Convert.ToDouble(cant5.Text) == 0 || Convert.ToDouble(cuni5.Text) == 0)
            {
                ct5.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(cant5.Text);
                pre = double.Parse(cuni5.Text);
                debe = ent * pre;
                ct5.Text = Convert.ToString(debe);
            }

            if (cuni6.Text == "")
            {
                cuni6.Text = Convert.ToString(0);
            }
            if (cant6.Text == "")
            {
                cant6.Text = Convert.ToString(0);
            }

            if (Convert.ToDouble(cant6.Text) == 0 || Convert.ToDouble(cuni6.Text) == 0)
            {
                ct6.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(cant6.Text);
                pre = double.Parse(cuni6.Text);
                debe = ent * pre;
                ct6.Text = Convert.ToString(debe);
            }

            if (cuni7.Text == "")
            {
                cuni7.Text = Convert.ToString(0);
            }
            if (cant7.Text == "")
            {
                cant7.Text = Convert.ToString(0);
            }
            if (Convert.ToDouble(cant7.Text) == 0 || Convert.ToDouble(cuni7.Text) == 0)
            {
                ct7.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(cant7.Text);
                pre = double.Parse(cuni7.Text);
                debe = ent * pre;
                ct7.Text = Convert.ToString(debe);
            }

            if (cuni8.Text == "")
            {
                cuni8.Text = Convert.ToString(0);
            }
            if (cant8.Text == "")
            {
                cant8.Text = Convert.ToString(0);
            }
            if (Convert.ToDouble(cant8.Text) == 0 || Convert.ToDouble(cuni8.Text) == 0)
            {
                ct8.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(cant8.Text);
                pre = double.Parse(cuni8.Text);
                debe = ent * pre;
                ct8.Text = Convert.ToString(debe);
            }

            if (cuni9.Text == "")
            {
                cuni9.Text = Convert.ToString(0);
            }
            if (cant9.Text == "")
            {
                cant9.Text = Convert.ToString(0);
            }
            if (Convert.ToDouble(cant9.Text) == 0 || Convert.ToDouble(cuni9.Text) == 0)
            {
                ct9.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(cant9.Text);
                pre = double.Parse(cuni9.Text);
                debe = ent * pre;
                ct9.Text = Convert.ToString(debe);
            }

            if (cuni10.Text == "")
            {
                cuni10.Text = Convert.ToString(0);
            }
            if (cant10.Text == "")
            {
                cant10.Text = Convert.ToString(0);
            }
            if (Convert.ToDouble(cant10.Text) == 0 || Convert.ToDouble(cuni10.Text) == 0)
            {
                ct10.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(cant10.Text);
                pre = double.Parse(cuni10.Text);
                debe = ent * pre;
                ct10.Text = Convert.ToString(debe);
            }

            if (cuni11.Text == "")
            {
                cuni11.Text = Convert.ToString(0);
            }
            if (cant11.Text == "")
            {
                cant11.Text = Convert.ToString(0);
            }
            if (Convert.ToDouble(cant11.Text) == 0 || Convert.ToDouble(cuni11.Text) == 0)
            {
                ct11.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(cant11.Text);
                pre = double.Parse(cuni11.Text);
                debe = ent * pre;
                ct11.Text = Convert.ToString(debe);
            }

            if (cuni12.Text == "")
            {
                cuni12.Text = Convert.ToString(0);
            }
            if (cant12.Text == "")
            {
                cant12.Text = Convert.ToString(0);
            }
            if (Convert.ToDouble(cant12.Text) == 0 || Convert.ToDouble(cuni12.Text) == 0)
            {
                ct12.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(cant12.Text);
                pre = double.Parse(cuni12.Text);
                debe = ent * pre;
                ct12.Text = Convert.ToString(debe);
            }

            if (cuni13.Text == "")
            {
                cuni13.Text = Convert.ToString(0);
            }
            if (cant13.Text == "")
            {
                cant13.Text = Convert.ToString(0);
            }
            if (Convert.ToDouble(cant13.Text) == 0 || Convert.ToDouble(cuni13.Text) == 0)
            {
                ct13.Text = Convert.ToString(0);
            }
            else
            {
                ent = double.Parse(cant13.Text);
                pre = double.Parse(cuni13.Text);
                debe = ent * pre;
                ct13.Text = Convert.ToString(debe);
            }
        }

        private void Cantidad_Click(object sender, EventArgs e)
        {
            


            double en, sa, tot;

            ctd1.Text = ent1.Text;
           
            en = Convert.ToDouble(ent2.Text);
            sa = Convert.ToDouble(cant2.Text);
            tot = (Convert.ToDouble(ctd1.Text) + en) - sa;
            if (sa == 0 && en == 0)
            {
                ctd2.Text = Convert.ToString(0);
            }
            else
            {
                ctd2.Text = Convert.ToString(tot);
            }

            en = Convert.ToDouble(ent3.Text);
            sa = Convert.ToDouble(cant3.Text);
            tot = (Convert.ToDouble(ctd2.Text) + en) - sa;
            //exist3.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                ctd3.Text = Convert.ToString(0);
            }
            else
            {
                ctd3.Text = Convert.ToString(tot);
            }



            if (ent4.Text == "")
            {
                ent4.Text = Convert.ToString(0);
            }
            if (cant4.Text == "")
            {
                cant4.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent4.Text);
            sa = Convert.ToDouble(cant4.Text);
            tot = (Convert.ToDouble(ctd3.Text) + en) - sa;
            //exist4.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                ctd4.Text = Convert.ToString(0);
            }
            else
            {
                ctd4.Text = Convert.ToString(tot);
            }



            if (ent5.Text == "")
            {
                ent5.Text = Convert.ToString(0);
            }
            if (cant5.Text == "")
            {
                cant5.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent5.Text);
            sa = Convert.ToDouble(cant5.Text);
            tot = (Convert.ToDouble(ctd4.Text) + en) - sa;
            // exist5.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                ctd5.Text = Convert.ToString(0);
            }
            else
            {
                ctd5.Text = Convert.ToString(tot);
            }


            if (ent6.Text == "")
            {
                ent6.Text = Convert.ToString(0);
            }
            if (cant6.Text == "")
            {
                cant6.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent6.Text);
            sa = Convert.ToDouble(cant6.Text);
            tot = (Convert.ToDouble(ctd5.Text) + en) - sa;
            //exist6.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                ctd6.Text = Convert.ToString(0);
            }
            else
            {
                ctd6.Text = Convert.ToString(tot);
            }

            if (ent7.Text == "")
            {
                ent7.Text = Convert.ToString(0);
            }
            if (cant7.Text == "")
            {
                cant7.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent7.Text);
            sa = Convert.ToDouble(cant7.Text);
            tot = (Convert.ToDouble(ctd6.Text) + en) - sa;
            // exist7.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                ctd7.Text = Convert.ToString(0);
            }
            else
            {
                ctd7.Text = Convert.ToString(tot);
            }

            if (ent8.Text == "")
            {
                ent8.Text = Convert.ToString(0);
            }
            if (cant8.Text == "")
            {
                cant8.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent8.Text);
            sa = Convert.ToDouble(cant8.Text);
            tot = (Convert.ToDouble(ctd7.Text) + en) - sa;
            // exist7.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                ctd8.Text = Convert.ToString(0);
            }
            else
            {
                ctd8.Text = Convert.ToString(tot);
            }

            if (ent9.Text == "")
            {
                ent9.Text = Convert.ToString(0);
            }
            if (cant9.Text == "")
            {
                cant9.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent9.Text);
            sa = Convert.ToDouble(cant9.Text);
            tot = (Convert.ToDouble(ctd8.Text) + en) - sa;
            // exist9.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                ctd9.Text = Convert.ToString(0);
            }
            else
            {
                ctd9.Text = Convert.ToString(tot);
            }

            if (ent10.Text == "")
            {
                ent10.Text = Convert.ToString(0);
            }
            if (cant10.Text == "")
            {
                cant10.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent10.Text);
            sa = Convert.ToDouble(cant10.Text);
            tot = (Convert.ToDouble(ctd9.Text) + en) - sa;
            // exist10.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                ctd10.Text = Convert.ToString(0);
            }
            else
            {
                ctd10.Text = Convert.ToString(tot);
            }

            if (ent11.Text == "")
            {
                ent11.Text = Convert.ToString(0);
            }
            if (cant11.Text == "")
            {
                cant11.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent11.Text);
            sa = Convert.ToDouble(cant11.Text);
            tot = (Convert.ToDouble(ctd10.Text) + en) - sa;
            // exist11.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                ctd11.Text = Convert.ToString(0);
            }
            else
            {
                ctd11.Text = Convert.ToString(tot);
            }

            if (ent12.Text == "")
            {
                ent12.Text = Convert.ToString(0);
            }
            if (cant12.Text == "")
            {
                cant12.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent12.Text);
            sa = Convert.ToDouble(cant12.Text);
            tot = (Convert.ToDouble(ctd11.Text) + en) - sa;
            // exist12.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                ctd12.Text = Convert.ToString(0);
            }
            else
            {
                ctd12.Text = Convert.ToString(tot);
            }

            if (ent13.Text == "")
            {
                ent13.Text = Convert.ToString(0);
            }
            if (cant13.Text == "")
            {
                cant13.Text = Convert.ToString(0);
            }
            en = Convert.ToDouble(ent13.Text);
            sa = Convert.ToDouble(cant13.Text);
            tot = (Convert.ToDouble(ctd12.Text) + en) - sa;
            // exist13.Text = Convert.ToString(tot);
            if (sa == 0 && en == 0)
            {
                ctd13.Text = Convert.ToString(0);
            }
            else
            {
                ctd13.Text = Convert.ToString(tot);
            }
        }

        private void CUnitario_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(sal1.Text)==0)
            {
                uni1.Text = cuni1.Text;
            }
            else
            {
                uni1.Text = sal1.Text;
            }

            if (Convert.ToDouble(cuni2.Text)>0)
            {
                uni2.Text = uni1.Text;
            }
            else
            {
                uni2.Text = sal2.Text;
            }

            if (Convert.ToDouble(cuni3.Text) > 0)
            {
                uni3.Text = uni2.Text;
            }
            else
            {
                uni3.Text = sal3.Text;
            }

            if (Convert.ToDouble(cuni4.Text) > 0)
            {
                uni4.Text = uni3.Text;
            }
            else
            {
                uni4.Text = sal4.Text;
            }

            if (Convert.ToDouble(cuni5.Text) > 0)
            {
                uni5.Text = uni4.Text;
            }
            else
            {
                uni5.Text = sal5.Text;
            }

            if (Convert.ToDouble(cuni6.Text) > 0)
            {
                uni6.Text = uni5.Text;
            }
            else
            {
                uni6.Text = sal6.Text;
            }

            if (Convert.ToDouble(cuni7.Text) > 0)
            {
                uni7.Text = uni6.Text;
            }
            else
            {
                uni7.Text = sal7.Text;
            }

            if (Convert.ToDouble(cuni8.Text) > 0)
            {
                uni8.Text = uni7.Text;
            }
            else
            {
                uni8.Text = sal8.Text;
            }

            if (Convert.ToDouble(cuni9.Text) > 0)
            {
                uni9.Text = uni8.Text;
            }
            else
            {
                uni9.Text = sal9.Text;
            }
            if (Convert.ToDouble(cuni10.Text) > 0)
            {
                uni10.Text= uni9.Text;
            }
            else
            {
                uni10.Text = sal10.Text; ;
            }

            if (Convert.ToDouble(cuni11.Text) > 0)
            {
                uni11.Text = uni10.Text;
            }
            else
            {
                uni11.Text = sal11.Text; ;
            }

            if (Convert.ToDouble(cuni12.Text) > 0) 
            {
                uni12.Text = uni11.Text;
            }
            else
            {
                uni12.Text = sal12.Text; ;
            }

            if (Convert.ToDouble(cuni13.Text) > 0)
            {
                uni13.Text = uni12.Text;
            }
            else
            {
                uni13.Text = sal13.Text; ;
            }
        }

        private void CTotal_Click(object sender, EventArgs e)
        {
            ctl1.Text = ent1.Text;

            double cantidad1, cantidad2, total, saldo;

            cantidad1 = Convert.ToDouble(ent2.Text);
            cantidad2= Convert.ToDouble(cant2.Text);
            saldo = Convert.ToDouble(ctl1.Text);
            total = saldo + cantidad1 - cantidad2;

            ctl2.Text = total.ToString();

            

            if (Convert.ToDouble(ent3.Text)>0 && Convert.ToDouble(cant2.Text)>0)
            {
                ctl3.Text = ent3.Text;
            }
            else
            {
                cantidad1 = Convert.ToDouble(ent3.Text);
                cantidad2 = Convert.ToDouble(cant3.Text);
                saldo = Convert.ToDouble(ctl2.Text);
                total = saldo + cantidad1 - cantidad2;
                ctl3.Text = total.ToString();
            }

            if (Convert.ToDouble(ent4.Text) > 0 && Convert.ToDouble(cant3.Text) > 0)
            {
                ctl4.Text = ent4.Text;
            }
            else
            {
                cantidad1 = Convert.ToDouble(ent4.Text);
                cantidad2 = Convert.ToDouble(cant4.Text);
                saldo = Convert.ToDouble(ctl3.Text);
                total = saldo + cantidad1 - cantidad2;
                ctl4.Text = total.ToString();
            }

            if (Convert.ToDouble(ent5.Text) > 0 && Convert.ToDouble(cant4.Text) > 0)
            {
                ctl5.Text = ent5.Text;
            }
            else
            {
                cantidad1 = Convert.ToDouble(ent5.Text);
                cantidad2 = Convert.ToDouble(cant5.Text);
                saldo = Convert.ToDouble(ctl4.Text);
                total = saldo + cantidad1 - cantidad2;
                ctl5.Text = total.ToString();
            }

            if (Convert.ToDouble(ent6.Text) > 0 && Convert.ToDouble(cant5.Text) > 0)
            {
                ctl6.Text = ent6.Text;
            }
            else
            {
                cantidad1 = Convert.ToDouble(ent6.Text);
                cantidad2 = Convert.ToDouble(cant6.Text);
                saldo = Convert.ToDouble(ctl5.Text);
                total = saldo + cantidad1 - cantidad2;
                ctl6.Text = total.ToString();
            }

            if (Convert.ToDouble(ent7.Text) > 0 && Convert.ToDouble(cant6.Text) > 0)
            {
                ctl7.Text = ent7.Text;
            }
            else
            {
                cantidad1 = Convert.ToDouble(ent7.Text);
                cantidad2 = Convert.ToDouble(cant7.Text);
                saldo = Convert.ToDouble(ctl6.Text);
                total = saldo + cantidad1 - cantidad2;
                ctl7.Text = total.ToString();
            }
            if (Convert.ToDouble(ent8.Text) > 0 && Convert.ToDouble(cant7.Text) > 0)
            {
                ctl8.Text = ent8.Text;
            }
            else
            {
                cantidad1 = Convert.ToDouble(ent8.Text);
                cantidad2 = Convert.ToDouble(cant8.Text);
                saldo = Convert.ToDouble(ctl7.Text);
                total = saldo + cantidad1 - cantidad2;
                ctl8.Text = total.ToString();
            }

            if (Convert.ToDouble(ent9.Text) > 0 && Convert.ToDouble(cant8.Text) > 0)
            {
                ctl9.Text = ent9.Text;
            }
            else
            {
                cantidad1 = Convert.ToDouble(ent9.Text);
                cantidad2 = Convert.ToDouble(cant9.Text);
                saldo = Convert.ToDouble(ctl8.Text);
                total = saldo + cantidad1 - cantidad2;
                ctl9.Text = total.ToString();
            }

           if(Convert.ToDouble(ent10.Text) > 0 && Convert.ToDouble(cant9.Text) > 0)
            {
                ctl10.Text =ent10.Text;
            }
            else
            {
                cantidad1 = Convert.ToDouble(ent10.Text);
                cantidad2 = Convert.ToDouble(cant10.Text);
                saldo = Convert.ToDouble(ctl9.Text);
                total = saldo + cantidad1 - cantidad2;
                ctl10.Text = total.ToString();
            }


            if (Convert.ToDouble(ent11.Text) > 0 && Convert.ToDouble(cant10.Text) > 0)
            {
                ctl11.Text = ent11.Text;
            }
            else
            {
                cantidad1 = Convert.ToDouble(ent11.Text);
                cantidad2 = Convert.ToDouble(cant11.Text);
                saldo = Convert.ToDouble(ctl10.Text);
                total = saldo + cantidad1 - cantidad2;
                ctl11.Text = total.ToString();
            }
            if (Convert.ToDouble(ent12.Text) > 0 && Convert.ToDouble(cant11.Text) > 0)
            {
                ctl12.Text = ent12.Text;
            }
            else
            {
                cantidad1 = Convert.ToDouble(ent12.Text);
                cantidad2 = Convert.ToDouble(cant12.Text);
                saldo = Convert.ToDouble(ctl11.Text);
                total = saldo + cantidad1 - cantidad2;
                ctl12.Text = total.ToString();
            }

            if (Convert.ToDouble(ent13.Text) > 0 && Convert.ToDouble(cant12.Text) > 0)
            {
                ctl13.Text = ent13.Text;
            }
            else
            {
                cantidad1 = Convert.ToDouble(ent13.Text);
                cantidad2 = Convert.ToDouble(cant13.Text);
                saldo = Convert.ToDouble(ctl11.Text);
                total = saldo + cantidad1 - cantidad2;
                ctl13.Text = total.ToString();
            }
        }

        private void CostoTotal_Click(object sender, EventArgs e)
        {

            if (Convert.ToDouble(uni1.Text)!=Convert.ToDouble(uni2.Text))
            {
                ext1.Show();
                ext1.Text = (Convert.ToDouble(uni1.Text) * Convert.ToDouble(ctl1.Text)).ToString();
            }
            if (Convert.ToDouble(uni2.Text) != Convert.ToDouble(uni3.Text))
            {
                ext2.Show();
                ext2.Text = (Convert.ToDouble(uni2.Text) * Convert.ToDouble(ctl2.Text)).ToString();
            }
            if (Convert.ToDouble(uni3.Text) != Convert.ToDouble(uni4.Text))
            {
                ext3.Show();
                ext3.Text = (Convert.ToDouble(uni3.Text) * Convert.ToDouble(ctl3.Text)).ToString();
            }
            if (Convert.ToDouble(uni4.Text) != Convert.ToDouble(uni5.Text))
            {
                ext4.Show();
                ext4.Text = (Convert.ToDouble(uni4.Text) * Convert.ToDouble(ctl4.Text)).ToString();
            }

            if (Convert.ToDouble(uni5.Text) != Convert.ToDouble(uni6.Text))
            {
                ext5.Show();
                ext5.Text = (Convert.ToDouble(uni5.Text) * Convert.ToDouble(ctl5.Text)).ToString();
            }

            if (Convert.ToDouble(uni6.Text) != Convert.ToDouble(uni7.Text))
            {
                ext6.Show();
                ext6.Text = (Convert.ToDouble(uni6.Text) * Convert.ToDouble(ctl6.Text)).ToString();
            }

            if (Convert.ToDouble(uni7.Text) != Convert.ToDouble(uni8.Text))
            {
                ext7.Show();
                ext7.Text = (Convert.ToDouble(uni7.Text) * Convert.ToDouble(ctl7.Text)).ToString();
            }

            if (Convert.ToDouble(uni8.Text) != Convert.ToDouble(uni9.Text))
            {
                ext8.Show();
                ext8.Text = (Convert.ToDouble(uni8.Text) * Convert.ToDouble(ctl8.Text)).ToString();
            }

            if (Convert.ToDouble(uni9.Text) != Convert.ToDouble(uni10.Text))
            {
                ext9.Show();
                ext9.Text = (Convert.ToDouble(uni9.Text) * Convert.ToDouble(ctl9.Text)).ToString();
            }

            if (Convert.ToDouble(uni10.Text) != Convert.ToDouble(uni11.Text))
            {
                ext10.Show();
                ext10.Text = (Convert.ToDouble(uni10.Text) * Convert.ToDouble(ctl10.Text)).ToString();
            }
            if (Convert.ToDouble(uni11.Text) != Convert.ToDouble(uni12.Text))
            {
                ext11.Show();
                ext11.Text = (Convert.ToDouble(uni11.Text) * Convert.ToDouble(ctl11.Text)).ToString();
            }
            if (Convert.ToDouble(uni12.Text) != Convert.ToDouble(uni13.Text))
            {
                ext12.Show();
                ext12.Text = (Convert.ToDouble(uni12.Text) * Convert.ToDouble(ctl12.Text)).ToString();
            }




            total1.Text = (Convert.ToDouble(ctd1.Text) * Convert.ToDouble(uni1.Text)).ToString();

            if (Convert.ToDouble(ctotal2.Text)>0)
            {
                total2.Text = (Convert.ToDouble(total1.Text) +Convert.ToDouble(ctotal2.Text)).ToString();
            }
            else
            {
                total2.Text = (Convert.ToDouble(total1.Text) - Convert.ToDouble(ct2.Text)).ToString();
            }

            if (Convert.ToDouble(ctotal3.Text) > 0)
            {
                total3.Text = (Convert.ToDouble(total2.Text) + Convert.ToDouble(ctotal3.Text)).ToString();
            }
            else
            {
                total3.Text = (Convert.ToDouble(total2.Text) - Convert.ToDouble(ct3.Text)).ToString();
            }

            if (Convert.ToDouble(ctotal4.Text) > 0)
            {
                total4.Text = (Convert.ToDouble(total3.Text) + Convert.ToDouble(ctotal4.Text)).ToString();
            }
            else
            {
                total4.Text = (Convert.ToDouble(total3.Text) - Convert.ToDouble(ct4.Text)).ToString();
            }

            if (Convert.ToDouble(ctotal5.Text) > 0)
            {
                total5.Text = (Convert.ToDouble(total4.Text) + Convert.ToDouble(ctotal5.Text)).ToString();
            }
            else
            {
                total5.Text = (Convert.ToDouble(total4.Text) - Convert.ToDouble(ct5.Text)).ToString();
            }

            if (Convert.ToDouble(ctotal6.Text) > 0)
            {
                total6.Text = (Convert.ToDouble(total5.Text) + Convert.ToDouble(ctotal6.Text)).ToString();
            }
            else
            {
                total6.Text = (Convert.ToDouble(total5.Text) - Convert.ToDouble(ct6.Text)).ToString();
            }

            if (Convert.ToDouble(ctotal7.Text) > 0)
            {
                total7.Text = (Convert.ToDouble(total6.Text) + Convert.ToDouble(ctotal7.Text)).ToString();
            }
            else
            {
                total7.Text = (Convert.ToDouble(total6.Text) - Convert.ToDouble(ct7.Text)).ToString();
            }

            if (Convert.ToDouble(ctotal8.Text) > 0)
            {
                total8.Text = (Convert.ToDouble(total7.Text) +Convert.ToDouble(ctotal8.Text)).ToString();
            }
            else
            {
                total8.Text = (Convert.ToDouble(total7.Text) - Convert.ToDouble(ct8.Text)).ToString();
            }
            if (Convert.ToDouble(ctotal9.Text) > 0)
            {
                total9.Text = (Convert.ToDouble(total8.Text) + Convert.ToDouble(ctotal9.Text)).ToString();
            }
            else
            {
                total9.Text = (Convert.ToDouble(total8.Text) - Convert.ToDouble(ct9.Text)).ToString();
            }
            if (Convert.ToDouble(ctotal10.Text) > 0)
            {
                total10.Text = (Convert.ToDouble(total9.Text) + Convert.ToDouble(ctotal10.Text)).ToString();
            }
            else
            {
                total10.Text = (Convert.ToDouble(total9.Text) - Convert.ToDouble(ct10.Text)).ToString();
            }

            if (Convert.ToDouble(ctotal11.Text) > 0)
            {
                total11.Text = (Convert.ToDouble(total10.Text) + Convert.ToDouble(ctotal11.Text)).ToString();
            }
            else
            {
                total11.Text = (Convert.ToDouble(total10.Text) - Convert.ToDouble(ct11.Text)).ToString();
            }

            if (Convert.ToDouble(ctotal12.Text) > 0)
            {
                total12.Text = (Convert.ToDouble(total11.Text) + Convert.ToDouble(ctotal12.Text)).ToString();
            }
            else
            {
                total12.Text = (Convert.ToDouble(total11.Text) - Convert.ToDouble(ct12.Text)).ToString();
            }
            if (Convert.ToDouble(ctotal13.Text) > 0)
            {
                total13.Text = (Convert.ToDouble(total12.Text) + Convert.ToDouble(ctotal13.Text)).ToString();
            }
            else
            {
                total13.Text = (Convert.ToDouble(total12.Text) - Convert.ToDouble(ct13.Text)).ToString();
            }


/*

            if (((Convert.ToDouble(ent3.Text) > 0 && Convert.ToDouble(cant2.Text) > 0)) && (Convert.ToDouble(ent2.Text) ==0)) 
            {
                ext2.Show();
                ext2.Text =(Convert.ToDouble(uni2.Text) * Convert.ToDouble(ctl2.Text)).ToString();
            }
            if (((Convert.ToDouble(ent4.Text) > 0 && Convert.ToDouble(cant3.Text) > 0)) && (Convert.ToDouble(ent3.Text) == 0))
            {
                ext3.Show();
                ext3.Text = (Convert.ToDouble(uni3.Text) * Convert.ToDouble(ctl3.Text)).ToString();
            }

            if (((Convert.ToDouble(ent5.Text) > 0 && Convert.ToDouble(cant4.Text) > 0)) && (Convert.ToDouble(ent4.Text) == 0))
            {
                ext4.Show();
                ext4.Text = (Convert.ToDouble(uni4.Text) * Convert.ToDouble(ctl4.Text)).ToString();
            }

            if (((Convert.ToDouble(ent6.Text) > 0 && Convert.ToDouble(cant5.Text) > 0)) && (Convert.ToDouble(ent5.Text) == 0))
            {
                ext5.Show();
                ext5.Text = (Convert.ToDouble(uni5.Text) * Convert.ToDouble(ctl5.Text)).ToString();
            }

            if (((Convert.ToDouble(ent7.Text) > 0 && Convert.ToDouble(cant6.Text) > 0)) && (Convert.ToDouble(ent6.Text) == 0))
            {
                ext6.Show();
                ext6.Text = (Convert.ToDouble(uni6.Text) * Convert.ToDouble(ctl6.Text)).ToString();
            }


            if (((Convert.ToDouble(ent8.Text) > 0 && Convert.ToDouble(cant7.Text) > 0)) && (Convert.ToDouble(ent7.Text) == 0))
            {
                ext7.Show();
                ext7.Text = (Convert.ToDouble(uni7.Text) * Convert.ToDouble(ctl7.Text)).ToString();
            }

            if (((Convert.ToDouble(ent9.Text) > 0 && Convert.ToDouble(cant8.Text) > 0)) && (Convert.ToDouble(ent8.Text) == 0))
            {
                ext8.Show();
                ext8.Text = (Convert.ToDouble(uni8.Text) * Convert.ToDouble(ctl8.Text)).ToString();
            }

            if (((Convert.ToDouble(ent10.Text) > 0 && Convert.ToDouble(cant9.Text) > 0)) && (Convert.ToDouble(ent9.Text) == 0))
            {
                ext9.Show();
                ext9.Text = (Convert.ToDouble(uni9.Text) * Convert.ToDouble(ctl9.Text)).ToString();
            }
            if (((Convert.ToDouble(ent11.Text) > 0 && Convert.ToDouble(cant10.Text) > 0)) && (Convert.ToDouble(ent10.Text) == 0))
            {
                ext10.Show();
                ext10.Text = (Convert.ToDouble(uni10.Text) * Convert.ToDouble(ctl10.Text)).ToString();
            }
            if (((Convert.ToDouble(ent12.Text) > 0 && Convert.ToDouble(cant11.Text) > 0)) && (Convert.ToDouble(ent11.Text) == 0))
            {
                ext11.Show();
                ext11.Text = (Convert.ToDouble(uni11.Text) * Convert.ToDouble(ctl11.Text)).ToString();
            }

            if (((Convert.ToDouble(ent13.Text) > 0 && Convert.ToDouble(cant12.Text) > 0)) && (Convert.ToDouble(ent12.Text) == 0))
            {
                ext12.Show();
                ext12.Text = (Convert.ToDouble(uni12.Text) * Convert.ToDouble(ctl12.Text)).ToString();
            }*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ext1.Hide();
            ext2.Hide();
            ext3.Hide();
            ext4.Hide();
            ext5.Hide();
            ext6.Hide();
            ext7.Hide();
            ext8.Hide();
            ext9.Hide();
            ext10.Hide();
            ext11.Hide();
            ext12.Hide();
            ext13.Hide();
        }
    }
    }


