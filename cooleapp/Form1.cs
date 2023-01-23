using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cooleapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Controls.Add(new Startscherm());
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("De game gaat nu beginnen!");
            panel1.Controls.Clear();
            panel1.Controls.Add(new Gamevenster());
            button1.Enabled = false;
            button2.Enabled = true;
        }
    }
}
