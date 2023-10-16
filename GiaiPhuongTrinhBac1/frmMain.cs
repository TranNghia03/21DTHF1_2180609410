using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiPhuongTrinhBac1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int heSoA = Int32.Parse(txtHeSoA.Text);
            int heSoB = Int32.Parse(txtHeSoA.Text);
            var ketQua = (-heSoB)/heSoA;
            txtKetQua.Text = ketQua.ToString();
            //Dmm Anh VU
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHeSoA.Text = "";
            txtHeSoB.Text = "";
            txtNghiem.Text = "";
            txtKetQua.Text = "";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//hello tai da o day
