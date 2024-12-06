namespace CalculatorApp
{
    partial class CalculatorForm
    {
        private System.ComponentModel.IContainer components = null;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClear = new Button();
            resultTextBox = new TextBox();
            btnMultiplication = new Button();
            btnDivision = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnEquals = new Button();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightCoral;
            btnClear.Font = new Font("Segoe UI", 19F);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(12, 104);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(72, 63);
            btnClear.TabIndex = 0;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += ClearButton_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.BorderStyle = BorderStyle.None;
            resultTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            resultTextBox.Location = new Point(12, 12);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(346, 70);
            resultTextBox.TabIndex = 1;
            resultTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // btnMultiplication
            // 
            btnMultiplication.BackColor = Color.LightCoral;
            btnMultiplication.Font = new Font("Segoe UI", 19F);
            btnMultiplication.ForeColor = SystemColors.ButtonHighlight;
            btnMultiplication.Location = new Point(107, 104);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(72, 63);
            btnMultiplication.TabIndex = 2;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = false;
            btnMultiplication.Click += OperatorButton_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.LightCoral;
            btnDivision.Font = new Font("Segoe UI", 19F);
            btnDivision.ForeColor = SystemColors.ButtonHighlight;
            btnDivision.Location = new Point(196, 104);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(72, 63);
            btnDivision.TabIndex = 3;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += OperatorButton_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.LightCoral;
            btnPlus.Font = new Font("Segoe UI", 19F);
            btnPlus.ForeColor = SystemColors.ButtonHighlight;
            btnPlus.Location = new Point(287, 104);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(72, 63);
            btnPlus.TabIndex = 4;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += OperatorButton_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.LightCoral;
            btnMinus.Font = new Font("Segoe UI", 19F);
            btnMinus.ForeColor = SystemColors.ButtonHighlight;
            btnMinus.Location = new Point(287, 190);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(72, 63);
            btnMinus.TabIndex = 5;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += OperatorButton_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.LightSalmon;
            btn1.Font = new Font("Segoe UI", 19F);
            btn1.ForeColor = SystemColors.ButtonHighlight;
            btn1.Location = new Point(12, 376);
            btn1.Name = "btn1";
            btn1.Size = new Size(72, 63);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += NumberButton_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.LightSalmon;
            btn2.Font = new Font("Segoe UI", 19F);
            btn2.ForeColor = SystemColors.ButtonHighlight;
            btn2.Location = new Point(12, 283);
            btn2.Name = "btn2";
            btn2.Size = new Size(72, 63);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += NumberButton_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.LightSalmon;
            btn3.Font = new Font("Segoe UI", 19F);
            btn3.ForeColor = SystemColors.ButtonHighlight;
            btn3.Location = new Point(12, 190);
            btn3.Name = "btn3";
            btn3.Size = new Size(72, 63);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += NumberButton_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.LightSalmon;
            btn5.Font = new Font("Segoe UI", 19F);
            btn5.ForeColor = SystemColors.ButtonHighlight;
            btn5.Location = new Point(107, 283);
            btn5.Name = "btn5";
            btn5.Size = new Size(72, 63);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += NumberButton_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.LightSalmon;
            btn4.Font = new Font("Segoe UI", 19F);
            btn4.ForeColor = SystemColors.ButtonHighlight;
            btn4.Location = new Point(107, 376);
            btn4.Name = "btn4";
            btn4.Size = new Size(72, 63);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += NumberButton_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.LightSalmon;
            btn6.Font = new Font("Segoe UI", 19F);
            btn6.ForeColor = SystemColors.ButtonHighlight;
            btn6.Location = new Point(107, 190);
            btn6.Name = "btn6";
            btn6.Size = new Size(72, 63);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += NumberButton_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.LightSalmon;
            btn7.Font = new Font("Segoe UI", 19F);
            btn7.ForeColor = SystemColors.ButtonHighlight;
            btn7.Location = new Point(196, 376);
            btn7.Name = "btn7";
            btn7.Size = new Size(72, 63);
            btn7.TabIndex = 12;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += NumberButton_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.LightSalmon;
            btn8.Font = new Font("Segoe UI", 19F);
            btn8.ForeColor = SystemColors.ButtonHighlight;
            btn8.Location = new Point(196, 283);
            btn8.Name = "btn8";
            btn8.Size = new Size(72, 63);
            btn8.TabIndex = 13;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += NumberButton_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.LightSalmon;
            btn9.Font = new Font("Segoe UI", 19F);
            btn9.ForeColor = SystemColors.ButtonHighlight;
            btn9.Location = new Point(196, 190);
            btn9.Name = "btn9";
            btn9.Size = new Size(72, 63);
            btn9.TabIndex = 14;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += NumberButton_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.LightSalmon;
            btn0.Font = new Font("Segoe UI", 19F);
            btn0.ForeColor = SystemColors.ButtonHighlight;
            btn0.Location = new Point(287, 376);
            btn0.Name = "btn0";
            btn0.Size = new Size(72, 63);
            btn0.TabIndex = 15;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += NumberButton_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.LightCoral;
            btnEquals.Font = new Font("Segoe UI", 19F);
            btnEquals.ForeColor = SystemColors.ButtonHighlight;
            btnEquals.Location = new Point(287, 283);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(72, 63);
            btnEquals.TabIndex = 16;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += BtnEquals_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(380, 474);
            Controls.Add(btnEquals);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiplication);
            Controls.Add(resultTextBox);
            Controls.Add(btnClear);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "CalculatorForm";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnMultiplication;
        private Button btnDivision;
        private Button btnEquals;
        private Button btnPlus;
        private Button btnMinus;
        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn5;
        private Button btn4;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;

        private TextBox resultTextBox;

        private String fullText = "";
        private List<string> expression = new List<string>();
    }
}
