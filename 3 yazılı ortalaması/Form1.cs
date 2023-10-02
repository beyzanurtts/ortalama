using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_yazılı_ortalaması
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

        private void Form1_Click(object sender, EventArgs e)
        {
            int not1, not2, not3;
            double sonuc; //double ve float ondalıklı sayılar

            not1 = Convert.ToInt32(txtNot1.Text);
            not2 = Convert.ToInt32(txtNot2.Text);
            not3 = Convert.ToInt32(txtNot3.Text);

            sonuc = (not1 + not2 + not3) / 3; //ondalıkolabilir
        
            lblOrtalama.Text = sonuc.ToString();
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}

