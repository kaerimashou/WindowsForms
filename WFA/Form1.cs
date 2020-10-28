using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Form1 : Form
    {
        Calcul C;
        private void correct()
        {
            if (labelNumber.Text.IndexOf("∞") != -1)
            {
                labelNumber.Text = labelNumber.Text.Substring(0, labelNumber.Text.Length - 1);
            }
            if (labelNumber.Text[0] == '0' && labelNumber.Text[1] != ',')
            {
                labelNumber.Text = labelNumber.Text.Remove(0, 1);
            }
            if (labelNumber.Text[0] == '-')
            {
                if (labelNumber.Text[1] == '0' && labelNumber.Text[2] != ',')
                {
                    labelNumber.Text = labelNumber.Text.Remove(1, 1);
                }
            }
        }
        private bool ifPress()
        {
            if (!bmult.Enabled)
            {
                return false;
            }
            if (!bsub.Enabled)
            {
                return false;
            }
            if (!bplus.Enabled)
            {
                return false;
            }
            if (!bminus.Enabled)
            {
                return false;
            }
            if (!bpowb.Enabled)
            {
                return false;
            }
            if (!bsqb.Enabled)
            {
                return false;
            }
            return true;
        }
        private void freeBut()
        {
            bmult.Enabled = true;
            bsub.Enabled = true;
            bplus.Enabled = true;
            bminus.Enabled = true;
            bsqb.Enabled = true;
            bpowb.Enabled = true;
        }
        private void b1_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "1";
            correct();
        }
        private void b2_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "2";
            correct();
        }
        private void b3_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "3";
            correct();
        }
        private void b4_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "4";
            correct();
        }
        private void b5_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "5";
            correct();
        }
        private void b6_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "6";
            correct();
        }
        private void b7_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "7";
            correct();
        }
        private void b8_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "8";
            correct();
        }
        private void b9_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "9";
            correct();
        }
        private void b0_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "0";
            correct();
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button but=sender as Button;
            if (ifPress())
            {
                C.save_a(Convert.ToDouble(labelNumber.Text));
                but.Enabled = false;
                labelNumber.Text = "0";
            }
        }
        private void bclear_Click(object sender, EventArgs e)
        {
            labelNumber.Text = "0";
            C.clear_a();
            freeBut();
        }
        private void bchange_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text[0] == '-')
            {
                labelNumber.Text = labelNumber.Text.Remove(0, 1);
            }
            else
            {
                labelNumber.Text = "-" + labelNumber.Text;
            }
        }
        private void bpoint_Click(object sender, EventArgs e)
        {
            if ((labelNumber.Text.IndexOf(",") == -1) && (labelNumber.Text.IndexOf("∞") == -1))
            {
                labelNumber.Text += ",";
            }
        }
        private void bequal_Click(object sender, EventArgs e)
        {
            if (!bmult.Enabled)
            {
                labelNumber.Text = C.multi(Convert.ToDouble(labelNumber.Text)).ToString();
            }
            if (!bsub.Enabled)
            {
                labelNumber.Text = C.div(Convert.ToDouble(labelNumber.Text)).ToString();
            }
            if (!bplus.Enabled)
            {
                labelNumber.Text = C.sum(Convert.ToDouble(labelNumber.Text)).ToString();
            }
            if (!bminus.Enabled)
            {
                labelNumber.Text = C.minus(Convert.ToDouble(labelNumber.Text)).ToString();
            }
            if (!bsqb.Enabled)
            {
                labelNumber.Text = C.sqrtx(Convert.ToDouble(labelNumber.Text)).ToString();
            }
            if (!bpowb.Enabled)
            {
                labelNumber.Text = C.power(Convert.ToDouble(labelNumber.Text)).ToString();
            }

            C.clear_a();
            freeBut();
        }
        private void bpow2_Click(object sender, EventArgs e)
        {
            if (ifPress())
            {
                C.save_a(Convert.ToDouble(labelNumber.Text));
                labelNumber.Text = C.square().ToString();
                C.clear_a();
                freeBut();
            }
        }
        private void bfact_Click(object sender, EventArgs e)
        {
            if (ifPress())
            {
                if ((Convert.ToDouble(labelNumber.Text) == (int)(Convert.ToDouble(labelNumber.Text))) && ((Convert.ToDouble(labelNumber.Text) >= 0)))
                {
                    C.save_a(Convert.ToDouble(labelNumber.Text));
                    labelNumber.Text = C.factorial().ToString();
                    C.clear_a();
                    freeBut();
                }
                else
                {
                    MessageBox.Show("Number must be >=0");
                }
            }
            
        }
        private void bsqrt_Click(object sender, EventArgs e)
        {
            if (ifPress()  && (Convert.ToDouble(labelNumber.Text) >= 0))
            {
                C.save_a(Convert.ToDouble(labelNumber.Text));
                labelNumber.Text = C.sqrt().ToString();
                C.clear_a();
                freeBut();
            }
            else
            {
                MessageBox.Show("Number must be >=0");
            }
        }
        public Form1()
        {
            InitializeComponent();
            C = new Calcul();
            labelNumber.Text = "0";
        }
    }
}
