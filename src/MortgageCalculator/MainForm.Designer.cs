namespace MortgageCalculator
{
    partial class MainForm
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxMortgageAmountInput = new System.Windows.Forms.TextBox();
            this.textBoxPrincipalOutput = new System.Windows.Forms.TextBox();
            this.textBoxInterestRateOutput = new System.Windows.Forms.TextBox();
            this.textBoxPeriodOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPeriodInput = new System.Windows.Forms.ComboBox();
            this.textBoxInterestRateInput = new System.Windows.Forms.TextBox();
            this.panelCalculate = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMonthlyPayment = new System.Windows.Forms.TextBox();
            this.textBoxMortgageTotal = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxLoad = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxSave = new System.Windows.Forms.TextBox();
            this.panelCalculate.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCalculate.Location = new System.Drawing.Point(3, 56);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxMortgageAmountInput
            // 
            this.textBoxMortgageAmountInput.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMortgageAmountInput.Location = new System.Drawing.Point(6, 28);
            this.textBoxMortgageAmountInput.MaxLength = 10;
            this.textBoxMortgageAmountInput.Name = "textBoxMortgageAmountInput";
            this.textBoxMortgageAmountInput.Size = new System.Drawing.Size(80, 20);
            this.textBoxMortgageAmountInput.TabIndex = 4;
            this.textBoxMortgageAmountInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMortgageAmount_KeyPress);
            // 
            // textBoxPrincipalOutput
            // 
            this.textBoxPrincipalOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxPrincipalOutput.Location = new System.Drawing.Point(22, 19);
            this.textBoxPrincipalOutput.Name = "textBoxPrincipalOutput";
            this.textBoxPrincipalOutput.ReadOnly = true;
            this.textBoxPrincipalOutput.Size = new System.Drawing.Size(80, 20);
            this.textBoxPrincipalOutput.TabIndex = 5;
            // 
            // textBoxInterestRateOutput
            // 
            this.textBoxInterestRateOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxInterestRateOutput.Location = new System.Drawing.Point(114, 19);
            this.textBoxInterestRateOutput.Name = "textBoxInterestRateOutput";
            this.textBoxInterestRateOutput.ReadOnly = true;
            this.textBoxInterestRateOutput.Size = new System.Drawing.Size(50, 20);
            this.textBoxInterestRateOutput.TabIndex = 10;
            // 
            // textBoxPeriodOutput
            // 
            this.textBoxPeriodOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxPeriodOutput.Location = new System.Drawing.Point(205, 19);
            this.textBoxPeriodOutput.Name = "textBoxPeriodOutput";
            this.textBoxPeriodOutput.ReadOnly = true;
            this.textBoxPeriodOutput.Size = new System.Drawing.Size(50, 20);
            this.textBoxPeriodOutput.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mortgage Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Interest Rate (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Period (in years)";
            // 
            // comboBoxPeriodInput
            // 
            this.comboBoxPeriodInput.FormattingEnabled = true;
            this.comboBoxPeriodInput.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40"});
            this.comboBoxPeriodInput.Location = new System.Drawing.Point(194, 28);
            this.comboBoxPeriodInput.Name = "comboBoxPeriodInput";
            this.comboBoxPeriodInput.Size = new System.Drawing.Size(50, 21);
            this.comboBoxPeriodInput.TabIndex = 17;
            this.comboBoxPeriodInput.Text = "30";
            this.comboBoxPeriodInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxPeriod_KeyPress);
            // 
            // textBoxInterestRateInput
            // 
            this.textBoxInterestRateInput.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxInterestRateInput.Location = new System.Drawing.Point(103, 28);
            this.textBoxInterestRateInput.MaxLength = 5;
            this.textBoxInterestRateInput.Name = "textBoxInterestRateInput";
            this.textBoxInterestRateInput.Size = new System.Drawing.Size(50, 20);
            this.textBoxInterestRateInput.TabIndex = 16;
            this.textBoxInterestRateInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInterestRate_KeyPress);
            // 
            // panelCalculate
            // 
            this.panelCalculate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCalculate.Controls.Add(this.label1);
            this.panelCalculate.Controls.Add(this.comboBoxPeriodInput);
            this.panelCalculate.Controls.Add(this.textBoxInterestRateInput);
            this.panelCalculate.Controls.Add(this.label3);
            this.panelCalculate.Controls.Add(this.buttonCalculate);
            this.panelCalculate.Controls.Add(this.textBoxMortgageAmountInput);
            this.panelCalculate.Controls.Add(this.label2);
            this.panelCalculate.Location = new System.Drawing.Point(12, 12);
            this.panelCalculate.Name = "panelCalculate";
            this.panelCalculate.Size = new System.Drawing.Size(280, 84);
            this.panelCalculate.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBoxMonthlyPayment);
            this.panel2.Controls.Add(this.textBoxMortgageTotal);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxPrincipalOutput);
            this.panel2.Controls.Add(this.textBoxPeriodOutput);
            this.panel2.Controls.Add(this.textBoxInterestRateOutput);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 234);
            this.panel2.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(111, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(3, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(3, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Monthly Payment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Total Cost";
            // 
            // textBoxMonthlyPayment
            // 
            this.textBoxMonthlyPayment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxMonthlyPayment.Location = new System.Drawing.Point(133, 74);
            this.textBoxMonthlyPayment.Name = "textBoxMonthlyPayment";
            this.textBoxMonthlyPayment.ReadOnly = true;
            this.textBoxMonthlyPayment.Size = new System.Drawing.Size(80, 20);
            this.textBoxMonthlyPayment.TabIndex = 24;
            // 
            // textBoxMortgageTotal
            // 
            this.textBoxMortgageTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxMortgageTotal.Location = new System.Drawing.Point(25, 74);
            this.textBoxMortgageTotal.Name = "textBoxMortgageTotal";
            this.textBoxMortgageTotal.ReadOnly = true;
            this.textBoxMortgageTotal.Size = new System.Drawing.Size(80, 20);
            this.textBoxMortgageTotal.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(613, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(610, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Principal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Period (in years)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Interest Rate (%)";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(3, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxLoad);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonLoad);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.textBoxSave);
            this.panel1.Location = new System.Drawing.Point(472, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 84);
            this.panel1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(0, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Save As";
            // 
            // comboBoxLoad
            // 
            this.comboBoxLoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoad.Enabled = false;
            this.comboBoxLoad.FormattingEnabled = true;
            this.comboBoxLoad.Location = new System.Drawing.Point(155, 4);
            this.comboBoxLoad.Name = "comboBoxLoad";
            this.comboBoxLoad.Size = new System.Drawing.Size(140, 21);
            this.comboBoxLoad.TabIndex = 21;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(220, 56);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLoad.Enabled = false;
            this.buttonLoad.Location = new System.Drawing.Point(220, 31);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 21;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxSave
            // 
            this.textBoxSave.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSave.Enabled = false;
            this.textBoxSave.Location = new System.Drawing.Point(3, 56);
            this.textBoxSave.MaxLength = 15;
            this.textBoxSave.Name = "textBoxSave";
            this.textBoxSave.Size = new System.Drawing.Size(140, 20);
            this.textBoxSave.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelCalculate);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "MainForm";
            this.Text = "Mortgage Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCalculate.ResumeLayout(false);
            this.panelCalculate.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxMortgageAmountInput;
        private System.Windows.Forms.TextBox textBoxPrincipalOutput;
        private System.Windows.Forms.TextBox textBoxInterestRateOutput;
        private System.Windows.Forms.TextBox textBoxPeriodOutput;
        private System.Windows.Forms.TextBox textBoxInterestRateInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPeriodInput;
        private System.Windows.Forms.Panel panelCalculate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxSave;
        private System.Windows.Forms.ComboBox comboBoxLoad;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMonthlyPayment;
        private System.Windows.Forms.TextBox textBoxMortgageTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

