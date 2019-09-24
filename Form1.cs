using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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


        private void button2_Click(object sender, EventArgs e)
        {
            rtbsum.Text = lblsaxeli.Text + " : " + txtsaxeli.Text + "\n" + lblgvari.Text + " : " + txtgvari.Text + "\n" + lblsex.Text + " : " + txtsex.Text + "\n" + lblnomeri.Text + " : " + txtnomeri.Text + "\n" + lbldate.Text + " : " + txtdate.Value.ToString() + "\n" + lblqveyana.Text + " : " + txtqveyana.Text + "\n" + lblqalaqi.Text + " : " + txtqalaqi.Text + "\n" + lblmisamarti.Text + " : " + txtmisamarti.Text + "\n"; 

                
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtsaxeli.Text = "";
            txtgvari.Text = "";
            txtsex.Text = "";
            txtmisamarti.Text = "";
            txtqalaqi.Text = "";
            txtqveyana.Text = "";
            txtnomeri.Text = "";
            rtbsum.Text = "";
            
           

            
        }
    }
}
