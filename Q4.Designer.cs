namespace Practoid
{
    partial class Q4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxInt = new System.Windows.Forms.GroupBox();
            this.warnLabel = new System.Windows.Forms.Label();
            this.groupBoxSubInt = new System.Windows.Forms.GroupBox();
            this.radioButtonCream = new System.Windows.Forms.RadioButton();
            this.radioButtonIce = new System.Windows.Forms.RadioButton();
            this.radioButtonIceMilk = new System.Windows.Forms.RadioButton();
            this.radioButtonMilk = new System.Windows.Forms.RadioButton();
            this.radioButtonBlack = new System.Windows.Forms.RadioButton();
            this.stdCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBoxPrev = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.billLabel = new System.Windows.Forms.Label();
            this.customersLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.FinalizeBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.warnLabel2 = new System.Windows.Forms.Label();
            this.groupBoxBill = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBoxInt.SuspendLayout();
            this.groupBoxSubInt.SuspendLayout();
            this.groupBoxPrev.SuspendLayout();
            this.groupBoxBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(73, 50);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(153, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Customer\'s Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 47);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBoxInt
            // 
            this.groupBoxInt.Controls.Add(this.warnLabel);
            this.groupBoxInt.Controls.Add(this.groupBoxSubInt);
            this.groupBoxInt.Controls.Add(this.stdCheckBox);
            this.groupBoxInt.Controls.Add(this.nameLabel);
            this.groupBoxInt.Controls.Add(this.textBox1);
            this.groupBoxInt.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxInt.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInt.Name = "groupBoxInt";
            this.groupBoxInt.Size = new System.Drawing.Size(810, 311);
            this.groupBoxInt.TabIndex = 2;
            this.groupBoxInt.TabStop = false;
            this.groupBoxInt.Text = "Infomation:";
            // 
            // warnLabel
            // 
            this.warnLabel.AutoSize = true;
            this.warnLabel.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warnLabel.ForeColor = System.Drawing.Color.Red;
            this.warnLabel.Location = new System.Drawing.Point(217, 47);
            this.warnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warnLabel.Name = "warnLabel";
            this.warnLabel.Size = new System.Drawing.Size(18, 20);
            this.warnLabel.TabIndex = 4;
            this.warnLabel.Text = "*";
            this.warnLabel.Visible = false;
            // 
            // groupBoxSubInt
            // 
            this.groupBoxSubInt.Controls.Add(this.radioButtonCream);
            this.groupBoxSubInt.Controls.Add(this.radioButtonIce);
            this.groupBoxSubInt.Controls.Add(this.radioButtonIceMilk);
            this.groupBoxSubInt.Controls.Add(this.radioButtonMilk);
            this.groupBoxSubInt.Controls.Add(this.radioButtonBlack);
            this.groupBoxSubInt.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSubInt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxSubInt.Location = new System.Drawing.Point(234, 118);
            this.groupBoxSubInt.Name = "groupBoxSubInt";
            this.groupBoxSubInt.Size = new System.Drawing.Size(495, 187);
            this.groupBoxSubInt.TabIndex = 3;
            this.groupBoxSubInt.TabStop = false;
            this.groupBoxSubInt.Text = "Select your order:";
            // 
            // radioButtonCream
            // 
            this.radioButtonCream.AutoSize = true;
            this.radioButtonCream.Location = new System.Drawing.Point(251, 79);
            this.radioButtonCream.Name = "radioButtonCream";
            this.radioButtonCream.Padding = new System.Windows.Forms.Padding(0, 0, 130, 30);
            this.radioButtonCream.Size = new System.Drawing.Size(239, 48);
            this.radioButtonCream.TabIndex = 4;
            this.radioButtonCream.TabStop = true;
            this.radioButtonCream.Text = "Cream Coffee";
            this.radioButtonCream.UseVisualStyleBackColor = true;
            // 
            // radioButtonIce
            // 
            this.radioButtonIce.AutoSize = true;
            this.radioButtonIce.Location = new System.Drawing.Point(251, 25);
            this.radioButtonIce.Name = "radioButtonIce";
            this.radioButtonIce.Padding = new System.Windows.Forms.Padding(0, 0, 130, 30);
            this.radioButtonIce.Size = new System.Drawing.Size(232, 48);
            this.radioButtonIce.TabIndex = 3;
            this.radioButtonIce.TabStop = true;
            this.radioButtonIce.Text = "Iced Coffee";
            this.radioButtonIce.UseVisualStyleBackColor = true;
            // 
            // radioButtonIceMilk
            // 
            this.radioButtonIceMilk.AutoSize = true;
            this.radioButtonIceMilk.Location = new System.Drawing.Point(6, 133);
            this.radioButtonIceMilk.Name = "radioButtonIceMilk";
            this.radioButtonIceMilk.Padding = new System.Windows.Forms.Padding(0, 0, 130, 30);
            this.radioButtonIceMilk.Size = new System.Drawing.Size(267, 48);
            this.radioButtonIceMilk.TabIndex = 2;
            this.radioButtonIceMilk.TabStop = true;
            this.radioButtonIceMilk.Text = "Iced Milk Coffee";
            this.radioButtonIceMilk.UseVisualStyleBackColor = true;
            // 
            // radioButtonMilk
            // 
            this.radioButtonMilk.AutoSize = true;
            this.radioButtonMilk.Location = new System.Drawing.Point(6, 79);
            this.radioButtonMilk.Name = "radioButtonMilk";
            this.radioButtonMilk.Padding = new System.Windows.Forms.Padding(0, 0, 130, 30);
            this.radioButtonMilk.Size = new System.Drawing.Size(232, 48);
            this.radioButtonMilk.TabIndex = 1;
            this.radioButtonMilk.TabStop = true;
            this.radioButtonMilk.Text = "Milk Coffee";
            this.radioButtonMilk.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlack
            // 
            this.radioButtonBlack.AutoSize = true;
            this.radioButtonBlack.Location = new System.Drawing.Point(6, 25);
            this.radioButtonBlack.Name = "radioButtonBlack";
            this.radioButtonBlack.Padding = new System.Windows.Forms.Padding(0, 0, 130, 30);
            this.radioButtonBlack.Size = new System.Drawing.Size(239, 48);
            this.radioButtonBlack.TabIndex = 0;
            this.radioButtonBlack.TabStop = true;
            this.radioButtonBlack.Text = "Black Coffee";
            this.radioButtonBlack.UseVisualStyleBackColor = true;
            // 
            // stdCheckBox
            // 
            this.stdCheckBox.AutoSize = true;
            this.stdCheckBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdCheckBox.Location = new System.Drawing.Point(234, 82);
            this.stdCheckBox.Name = "stdCheckBox";
            this.stdCheckBox.Size = new System.Drawing.Size(117, 19);
            this.stdCheckBox.TabIndex = 2;
            this.stdCheckBox.Text = "I am student!";
            this.stdCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBoxPrev
            // 
            this.groupBoxPrev.Controls.Add(this.warnLabel2);
            this.groupBoxPrev.Controls.Add(this.textBox3);
            this.groupBoxPrev.Controls.Add(this.textBox2);
            this.groupBoxPrev.Controls.Add(this.billLabel);
            this.groupBoxPrev.Controls.Add(this.customersLabel);
            this.groupBoxPrev.Controls.Add(this.exitBtn);
            this.groupBoxPrev.Controls.Add(this.FinalizeBtn);
            this.groupBoxPrev.Controls.Add(this.resetBtn);
            this.groupBoxPrev.Controls.Add(this.addBtn);
            this.groupBoxPrev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPrev.Location = new System.Drawing.Point(0, 311);
            this.groupBoxPrev.Name = "groupBoxPrev";
            this.groupBoxPrev.Size = new System.Drawing.Size(810, 250);
            this.groupBoxPrev.TabIndex = 3;
            this.groupBoxPrev.TabStop = false;
            this.groupBoxPrev.Text = "Preview";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(234, 111);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(450, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(234, 78);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(450, 20);
            this.textBox2.TabIndex = 4;
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billLabel.Location = new System.Drawing.Point(73, 114);
            this.billLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(108, 20);
            this.billLabel.TabIndex = 4;
            this.billLabel.Text = "Bill Value:";
            // 
            // customersLabel
            // 
            this.customersLabel.AutoSize = true;
            this.customersLabel.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersLabel.Location = new System.Drawing.Point(73, 81);
            this.customersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customersLabel.Name = "customersLabel";
            this.customersLabel.Size = new System.Drawing.Size(90, 20);
            this.customersLabel.TabIndex = 4;
            this.customersLabel.Text = "Customers";
            // 
            // exitBtn
            // 
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exitBtn.Location = new System.Drawing.Point(564, 26);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.exitBtn.Size = new System.Drawing.Size(120, 30);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // FinalizeBtn
            // 
            this.FinalizeBtn.Enabled = false;
            this.FinalizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FinalizeBtn.Location = new System.Drawing.Point(402, 26);
            this.FinalizeBtn.Name = "FinalizeBtn";
            this.FinalizeBtn.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.FinalizeBtn.Size = new System.Drawing.Size(120, 30);
            this.FinalizeBtn.TabIndex = 3;
            this.FinalizeBtn.Text = "Finalize";
            this.FinalizeBtn.UseVisualStyleBackColor = true;
            this.FinalizeBtn.Click += new System.EventHandler(this.FinalizeBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Enabled = false;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.resetBtn.Location = new System.Drawing.Point(240, 26);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.resetBtn.Size = new System.Drawing.Size(120, 30);
            this.resetBtn.TabIndex = 2;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Enabled = false;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addBtn.Location = new System.Drawing.Point(77, 26);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(120, 30);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // warnLabel2
            // 
            this.warnLabel2.AutoSize = true;
            this.warnLabel2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warnLabel2.ForeColor = System.Drawing.Color.Red;
            this.warnLabel2.Location = new System.Drawing.Point(279, 59);
            this.warnLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warnLabel2.Name = "warnLabel2";
            this.warnLabel2.Size = new System.Drawing.Size(37, 13);
            this.warnLabel2.TabIndex = 5;
            this.warnLabel2.Text = "\"all\"";
            this.warnLabel2.Visible = false;
            // 
            // groupBoxBill
            // 
            this.groupBoxBill.Controls.Add(this.textBox5);
            this.groupBoxBill.Controls.Add(this.label1);
            this.groupBoxBill.Controls.Add(this.textBox4);
            this.groupBoxBill.Controls.Add(this.label2);
            this.groupBoxBill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxBill.Location = new System.Drawing.Point(0, 457);
            this.groupBoxBill.Name = "groupBoxBill";
            this.groupBoxBill.Size = new System.Drawing.Size(810, 104);
            this.groupBoxBill.TabIndex = 4;
            this.groupBoxBill.TabStop = false;
            this.groupBoxBill.Text = "Bill\'s info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bill Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Customers";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(234, 63);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(450, 20);
            this.textBox5.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(234, 30);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(450, 20);
            this.textBox4.TabIndex = 6;
            // 
            // Q4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 561);
            this.Controls.Add(this.groupBoxBill);
            this.Controls.Add(this.groupBoxPrev);
            this.Controls.Add(this.groupBoxInt);
            this.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(826, 600);
            this.Name = "Q4";
            this.Text = "Q4 PhamTrungDuc 22304059";
            this.groupBoxInt.ResumeLayout(false);
            this.groupBoxInt.PerformLayout();
            this.groupBoxSubInt.ResumeLayout(false);
            this.groupBoxSubInt.PerformLayout();
            this.groupBoxPrev.ResumeLayout(false);
            this.groupBoxPrev.PerformLayout();
            this.groupBoxBill.ResumeLayout(false);
            this.groupBoxBill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxInt;
        private System.Windows.Forms.GroupBox groupBoxSubInt;
        private System.Windows.Forms.CheckBox stdCheckBox;
        private System.Windows.Forms.GroupBox groupBoxPrev;
        private System.Windows.Forms.RadioButton radioButtonCream;
        private System.Windows.Forms.RadioButton radioButtonIce;
        private System.Windows.Forms.RadioButton radioButtonIceMilk;
        private System.Windows.Forms.RadioButton radioButtonMilk;
        private System.Windows.Forms.RadioButton radioButtonBlack;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label customersLabel;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button FinalizeBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.Label warnLabel;
        private System.Windows.Forms.Label warnLabel2;
        private System.Windows.Forms.GroupBox groupBoxBill;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
    }
}