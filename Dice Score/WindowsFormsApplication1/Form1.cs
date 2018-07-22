using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int range;
        int save = 0;
        public void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            range = rnd.Next(1,36);
            this.label1.Text = range.ToString();
            this.button1.Text = "push";
            this.label2.Text = "Target";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 6);

            int coun =0;
            this.label2.Text = null;
            this.label2.Text += a.ToString();
            save = a + save;
            //MessageBox.Show(save.ToString());
            if(save == range ){
                MessageBox.Show("won");
                this.button1.Enabled = false;
            }
            coun++;
            if (coun == 6)
                this.button1.Enabled = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
