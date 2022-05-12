using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDWEB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            double disc, deno, x1, x2;
            

            a = Convert.ToDouble(A.Text);
            b = Convert.ToDouble(B.Text);
            c = Convert.ToDouble(C.Text);
            x2 = 0;
            x1 = 0;
            if (a == 0)
            {
                x1 = -c / b;
                
            }
            else
            {
                disc = (b * b) - (4 * a * c);
                deno = 2 * a;
                if (disc > 0)
                {
                    
                    x1 = (-b / deno) + (Math.Sqrt(disc) / deno);
                    x2 = (-b / deno) - (Math.Sqrt(disc) / deno);
                    
                }
                else if (disc == 0)
                {
                    
                    x1 = -b / deno;
                    
                }
                else
                {
                    
                    x1 = -b / deno;
                    x2 = ((Math.Sqrt((4 * a * c) - (b * b))) / deno);
                    
                }
            }
            x1r.Text = x1.ToString();
            x2r.Text = x2.ToString();
        }
    }
}
