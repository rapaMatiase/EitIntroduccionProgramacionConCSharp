using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerInterfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Saludar(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            MessageBox.Show("Saludar " + name);
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mostrar(object sender, EventArgs e)
        {
            string text = listBox1.Text;
            MessageBox.Show(text);

            pictureBox1.ImageLocation = "C:/Users/Eit/Desktop/FundamentosDeHTML5-Temario";
        }
    }
}
