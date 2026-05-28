using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examennn
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte nota1 = byte.Parse(textnota1.Text); 
            byte nota2 = byte.Parse(textnota2.Text);
            byte nota3 = byte.Parse(textnota3.Text);
            byte nota4 = byte.Parse(textnota4.Text);
            float promedio= ((nota1 + nota2 + nota3 + nota4)/4)
        MessageBox.Show("el resultado es"+promedio)


        }
    }
}
