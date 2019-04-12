using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        Zero zero1;
        Zero zero2;
        Zero zero3;
        Zero zero4;
        Zero zero5;
        public Form1()
        {
            zero1 = new Zero();
            zero2 = new Zero();
            zero3 = new Zero();
            zero4 = new Zero();
            zero5 = new Zero();
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            zero1.A = Convert.ToDouble(t1.Text == "" ? "0" : t1.Text);
            zero1.B = Convert.ToDouble(t2.Text == "" ? "0" : t2.Text);
            zero2.A = Convert.ToDouble(t3.Text == "" ? "0" : t3.Text);
            zero2.B = Convert.ToDouble(t4.Text == "" ? "0" : t4.Text);
            zero3.A = Convert.ToDouble(t5.Text == "" ? "0" : t5.Text);
            zero3.B = Convert.ToDouble(t6.Text == "" ? "0" : t6.Text);
            zero4.A = Convert.ToDouble(t7.Text == "" ? "0" : t7.Text);
            zero4.B = Convert.ToDouble(t8.Text == "" ? "0" : t8.Text);
            zero5.A = Convert.ToDouble(t9.Text == "" ? "0" : t9.Text);
            zero5.B = Convert.ToDouble(t10.Text == "" ? "0" : t10.Text);
            Text0.Text = GetResult();

        }

        public string GetResult()
        {

            //double summa = zero1 + zero2;
            //double delenie = summa / (zero3.E/zero3.F); 
            Zero Z = ((zero1 + zero2) / zero3) * (zero4 - zero5);
            return "Z = " + Z.ToString();
        }
    }
}
