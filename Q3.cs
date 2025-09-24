using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practoid
{
    public partial class Q3 : Form
    {
        public Q3()
        {
            InitializeComponent();

            exitBtn.Click += (s, e) => { this.Close(); };

            radioButton1.CheckedChanged += new EventHandler(radioBtn_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(radioBtn_CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(radioBtn_CheckedChanged);
            radioButton4.CheckedChanged += new EventHandler(radioBtn_CheckedChanged);
        }

        private void radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Font = new Font("Times New Roman", textBox1.Font.Size, FontStyle.Regular);
            }
            else if (radioButton2.Checked)
            {
                textBox1.Font = new Font("Arial", textBox1.Font.Size, FontStyle.Regular);
            }
            else if (radioButton3.Checked)
            {
                textBox1.Font = new Font("Tahoma", textBox1.Font.Size, FontStyle.Regular);
            }
            else if (radioButton4.Checked)
            {
                textBox1.Font = new Font("Courier New", textBox1.Font.Size, FontStyle.Regular);
            }
            else
            {
                textBox1.Font = new Font("Consolas", textBox1.Font.Size, FontStyle.Regular);
            }
        }
    }
}
