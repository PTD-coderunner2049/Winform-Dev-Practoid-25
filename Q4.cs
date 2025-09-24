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
    public partial class Q4 : Form
    {
        double bCaf = 20; // black coffee
        double iCaf = 25; // iced coffee
        double mCaf = 25; // milk coffee
        double imCaf = 30; // iced milk coffee
        double cCaf = 35; // cream coffee ??? why
        double total = 0;
        public Q4()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; 

            Load += Form_Load;
            
            resetBtn.MouseEnter += (s, e) => { warnLabel2.Visible = true; };
            resetBtn.MouseLeave += (s, e) => { warnLabel2.Visible = false; };
        }

        public void Form_Load(object sender, EventArgs e)
        {
            radioButtonBlack.Checked = true;
            warnLabel.Visible = true;
            FinalizeBtn.Enabled = false;
            resetBtn.Enabled = false;
            addBtn.Enabled = false;
            textBox1.Focus();
            textBox1.Text = "";
            textBox2.Text = "0";
            textBox3.Text = "0 VND";
            stdCheckBox.Checked = false;
            return;
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                warnLabel.Visible = false;
                resetBtn.Enabled = true;
                addBtn.Enabled = true;
            }
            else
            {
                warnLabel.Visible = true;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            FinalizeBtn.Enabled = true;

            textBox2.Text = (int.Parse(textBox2.Text) + 1).ToString("");
            if (radioButtonBlack.Checked)
            {
                total += bCaf;
            }
            else if (radioButtonIce.Checked)
            {
                total += iCaf;
            }
            else if (radioButtonMilk.Checked)
            {
                total += mCaf;
            }
            else if (radioButtonIceMilk.Checked)
            {
                total += imCaf;
            }
            else if (radioButtonCream.Checked)
            {
                total += cCaf;
            }
            textBox3.Text = total.ToString("0.000 VND");
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            //textBox1.Clear();
            //radioButtonBlack.Checked = true;
            //radioButtonIce.Checked = false;
            //radioButtonMilk.Checked = false;
            //radioButtonIceMilk.Checked = false;
            //radioButtonCream.Checked = false;
            //stdCheckBox.Checked = false;
            Form_Load(sender, e);
        }
        
        private void FinalizeBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Overwrite previous billing info?\nAre you sure you want to proceed?",
                "Are you broke arse being sure?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                textBox4.Text = textBox2.Text;
                textBox5.Text = textBox3.Text;
                Form_Load(sender, e);
            }
            else
            {
                return;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exiting now will lose all unsaved data.",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {                
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
