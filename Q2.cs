using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practoid
{
    public partial class Q2 : Form
    {
        Font currentFont;
        public Q2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            aRadioButton.Checked = true;
            rCheckBox.Checked = true;
            labelShow.BackColor = Color.LightGray;
            currentFont = labelShow.Font;

            exitBn.Click += (s, e) => { this.Close(); };
            aRadioButton.CheckedChanged += new EventHandler(aRadioButton_CheckedChanged);
            rRadioButton.CheckedChanged += new EventHandler(rRadioButton_CheckedChanged);
            gRadioButton.CheckedChanged += new EventHandler(gRadioButton_CheckedChanged);
            bRadioButton.CheckedChanged += new EventHandler(bRadioButton_CheckedChanged);
            rCheckBox.CheckedChanged += new EventHandler(rCheckBox_CheckedChanged);
            bCheckBox.CheckedChanged += new EventHandler(bCheckBox_CheckedChanged);
            iCheckBox.CheckedChanged += new EventHandler(iCheckBox_CheckedChanged);
            biCheckBox.CheckedChanged += new EventHandler(biCheckBox_CheckedChanged);
        }

        private void aRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (aRadioButton.Checked)
            {
                rRadioButton.Checked = false;
                gRadioButton.Checked = false;
                bRadioButton.Checked = false;
                labelShow.ForeColor = Color.Black;
            }
        }
        private void rRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rRadioButton.Checked)
            {
                aRadioButton.Checked = false;
                gRadioButton.Checked = false;
                bRadioButton.Checked = false;
                labelShow.ForeColor = Color.Crimson;
            }
        }
        private void gRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (gRadioButton.Checked)
            {
                aRadioButton.Checked = false;
                rRadioButton.Checked = false;
                bRadioButton.Checked = false;
                labelShow.ForeColor = Color.Aquamarine;
                labelShow.BackColor = Color.DarkGray;
                return;
            }
            labelShow.BackColor = Color.LightGray;
        }
        private void bRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bRadioButton.Checked)
            {
                aRadioButton.Checked = false;
                rRadioButton.Checked = false;
                gRadioButton.Checked = false;
                labelShow.ForeColor = Color.Cyan;
                labelShow.BackColor = Color.DarkGray;
                return;
            }
            labelShow.BackColor = Color.LightGray;
        }

        private void rCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rCheckBox.Checked)
            {
                bCheckBox.Checked = false;
                iCheckBox.Checked = false;
                biCheckBox.Checked = false;
                labelShow.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular);
                return;
            }
            labelShow.Font = new Font(currentFont.FontFamily, currentFont.Size, currentFont.Style & ~FontStyle.Regular);
        }
        private void bCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bCheckBox.Checked)
            {
                rCheckBox.Checked = false;
                biCheckBox.Checked = false;
                if (iCheckBox.Checked)
                {
                    biCheckBox.Checked = true;
                    return;
                }
                labelShow.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold);
                return;
            }
            labelShow.Font = new Font(currentFont.FontFamily, currentFont.Size, currentFont.Style & ~FontStyle.Bold);
        }
        private void iCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (iCheckBox.Checked)
            {
                biCheckBox.Checked = false;
                if (bCheckBox.Checked)
                {
                    biCheckBox.Checked = true;
                    return;
                }
                labelShow.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Italic);
                return;
            }
            labelShow.Font = new Font(currentFont.FontFamily, currentFont.Size, currentFont.Style & ~FontStyle.Italic);
        }
        private void biCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (biCheckBox.Checked)
            {
                rCheckBox.Checked = false;
                bCheckBox.Checked = false;
                iCheckBox.Checked = false;
                labelShow.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold | FontStyle.Italic);
            }
            else
            {
                labelShow.Font = new Font(currentFont.FontFamily, currentFont.Size, currentFont.Style & ~FontStyle.Bold & ~FontStyle.Italic);
            }
        }
    }
}
