using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedTextBox_Giris_maskeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mtxTC.Mask = "00000000000";
            mtxTelefon.Mask = "(999) 000 00 00";
            mtxDgTarih.Mask = "00/00/0000";
            mtxKart.Mask = "0000-0000-0000-0000";
            mtxIp.Mask = "###.###.###.###";
        }
    }
}
