namespace Miniräknare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTotal = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btnClear = new Button();
            btnDiv = new Button();
            btnMul = new Button();
            btnMin = new Button();
            btnPlus = new Button();
            btnEql = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(12, 12);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(444, 85);
            txtTotal.TabIndex = 0;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point
                );
            btn1.Location = new Point(12, 115);
            btn1.Name = "btn1";
            btn1.Size = new Size(84, 83);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(102, 115);
            btn2.Name = "btn2";
            btn2.Size = new Size(84, 83);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(192, 115);
            btn3.Name = "btn3";
            btn3.Size = new Size(84, 83);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(282, 115);
            btn4.Name = "btn4";
            btn4.Size = new Size(84, 83);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(372, 115);
            btn5.Name = "btn5";
            btn5.Size = new Size(84, 83);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(372, 204);
            btn0.Name = "btn0";
            btn0.Size = new Size(84, 83);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(282, 204);
            btn9.Name = "btn9";
            btn9.Size = new Size(84, 83);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(192, 204);
            btn8.Name = "btn8";
            btn8.Size = new Size(84, 83);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(102, 204);
            btn7.Name = "btn7";
            btn7.Size = new Size(84, 83);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(12, 204);
            btn6.Name = "btn6";
            btn6.Size = new Size(84, 83);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(372, 293);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(84, 83);
            btnClear.TabIndex = 15;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiv.Location = new Point(282, 293);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(84, 83);
            btnDiv.TabIndex = 14;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMul
            // 
            btnMul.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnMul.Location = new Point(192, 293);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(84, 83);
            btnMul.TabIndex = 13;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btnMin
            // 
            btnMin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnMin.Location = new Point(102, 293);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(84, 83);
            btnMin.TabIndex = 12;
            btnMin.Text = "-";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlus.Location = new Point(12, 293);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(84, 83);
            btnPlus.TabIndex = 11;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnEql
            // 
            btnEql.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnEql.Location = new Point(12, 382);
            btnEql.Name = "btnEql";
            btnEql.Size = new Size(444, 83);
            btnEql.TabIndex = 16;
            btnEql.Text = "=";
            btnEql.UseVisualStyleBackColor = true;
            btnEql.Click += btnEql_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 478);
            Controls.Add(btnEql);
            Controls.Add(btnClear);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnMin);
            Controls.Add(btnPlus);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtTotal);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn0;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btnClear;
        private Button btnDiv;
        private Button btnMul;
        private Button btnMin;
        private Button btnPlus;
        private Button btnEql;
    }
}