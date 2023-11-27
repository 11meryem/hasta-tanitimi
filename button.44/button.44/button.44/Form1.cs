using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            hasta.ad = "Büşra";
            hasta.soyad = "Ekmen";
            hasta.hastaligi = "Şizofren";
            hasta.yas = 61;
            hasta.tc = 15384603685;
            hasta.odaNum = 5;
            hasta.bakiciAdi = "Meryem Hanım";

            label1.Text=hasta.ad+"  "+hasta.soyad+"  "+hasta.hastaligi+"  "+hasta.yas+"  "+hasta.tc+"  "+hasta.odaNum+"  "+hasta.bakiciAdi+"  ";
        }
    }
}
