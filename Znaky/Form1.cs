using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Znaky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int MAX = 0;
            char[] pole = textBox1.Text.ToCharArray();
            bool cislo = false;
            foreach (char c in pole)
            {
                cislo = false;
                if (c <= 57 && c >= 48)
                {
                    cislo = true;
                }     
            }
            if (cislo == true)
            {
                for (int i = 0; i < pole.Length; i++)
                {
                    if (pole[i] <= 57 && pole[i] >= 48)
                    {
                        pole[i] = 'X';
                    }
                }
            }
            else
            {
                foreach (char c in pole)
                {
                    if (c > MAX)
                    {
                        MAX = c;
                       
                    }
                }
                pole[Array.IndexOf(pole, Convert.ToChar(MAX))] = pole[pole.Length - 1];
                pole[pole.Length - 1] = Convert.ToChar(MAX);

            }
            string text = new string(pole);
            textBox2.Text = text; 
           
        }
    }
}
