using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
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
            int a, b, c;
            double disc, deno, x1, x2;
            

            a = Convert.ToInt32(A.Text);
            b = Convert.ToInt32(B.Text);
            c = Convert.ToInt32(C.Text);
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
                    string[] complexNumber = Backend.SolveQuadratic(a, b, c);
                    x1r.Text = complexNumber[0];
                    x2r.Text = complexNumber[1];

                }
            }
           
            Database con = new Database();
            
            
            double[] results = con.read(a, b, c);
            if (results[0] == -99999 && results[1] == -99999)
            {
                con.InsertBD(a, b, c, x1, x2);
                x1r.Text = x1.ToString();
                x2r.Text = x2.ToString();
            }
            else
            {
                x1r.Text = results[0].ToString();
                x2r.Text = results[1].ToString();
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
