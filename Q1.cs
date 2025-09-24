using System;
using System.Windows.Forms;

namespace Practoid
{
    public partial class Q1 : Form
    {
        public Q1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            rAddition.Checked = true;
            exitBn.Click += (s, e) => { this.Close(); };
            labelHint.ForeColor = System.Drawing.Color.White;

            textBox1.TextChanged += new EventHandler(Run_cal);
            textBox2.TextChanged += new EventHandler(Run_cal);
            rAddition.CheckedChanged += new EventHandler(Run_cal);
            rSubtraction.CheckedChanged += new EventHandler(Run_cal);
            rDivison.CheckedChanged += new EventHandler(Run_cal);
            rMultiplication.CheckedChanged += new EventHandler(Run_cal);
            
            textBox1.AllowDrop = true;
            textBox2.AllowDrop = true;
            rResult.MouseDown += new MouseEventHandler(rResult_MouseDown);
            textBox1.DragEnter += new DragEventHandler(textBoxNum_DragEnter);
            textBox1.DragDrop += new DragEventHandler(textBoxNum_DragDrop);
            textBox2.DragEnter += new DragEventHandler(textBoxNum_DragEnter);
            textBox2.DragDrop += new DragEventHandler(textBoxNum_DragDrop);

        }

        private void Run_cal(object sender, EventArgs e)
        {
            int num1, num2, result = 0;
            if (!int.TryParse(textBox1.Text, out num1))
            {
                labelHint.Text = "Please enter a valid integer for Number 1.";
                labelHint.ForeColor = System.Drawing.Color.Crimson;
                return;
            }
            if (!int.TryParse(textBox2.Text, out num2))
            {
                labelHint.Text = "Please enter a valid integer for Number 2.";
                labelHint.ForeColor = System.Drawing.Color.Crimson;
                return;
            }
            if (rAddition.Checked)
            {
                result = num1 + num2;
            }
            else if (rSubtraction.Checked)
            {
                result = num1 - num2;
            }
            else if (rMultiplication.Checked)
            {
                result = num1 * num2;
            }
            else if (rDivison.Checked)
            {
                if (num2 == 0)
                {
                    MessageBox.Show("Cannot divide by zero.");
                    return;
                }
                result = num1 / num2;
            }
            rResult.Text = result.ToString();
            labelHint.Text = "Click and Drag result to reuse for new calculation!";
            labelHint.ForeColor = System.Drawing.Color.Black;
        }
        private void rResult_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rResult.DoDragDrop(rResult.Text, DragDropEffects.Copy);
            }
        }
        private void textBoxNum_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void textBoxNum_DragDrop(object sender, DragEventArgs e)
        {
            string droppedText = e.Data.GetData(DataFormats.Text).ToString();

            TextBox destinationTextBox = sender as TextBox;
            if (destinationTextBox != null)
            {
                destinationTextBox.Text = droppedText;
            }
        }
    }
}
