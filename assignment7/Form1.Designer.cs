namespace assignment7
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
            txtStaticDegrees = new Label();
            txtbxDegrees = new TextBox();
            groupBox1 = new GroupBox();
            rbtnCtoK = new RadioButton();
            rbtnCtoF = new RadioButton();
            rbtnFtoC = new RadioButton();
            btnCalculate = new Button();
            txtStaticResult = new Label();
            txtResult = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtStaticDegrees
            // 
            txtStaticDegrees.AutoSize = true;
            txtStaticDegrees.Location = new Point(25, 29);
            txtStaticDegrees.Name = "txtStaticDegrees";
            txtStaticDegrees.Size = new Size(64, 20);
            txtStaticDegrees.TabIndex = 0;
            txtStaticDegrees.Text = "Degrees";
            // 
            // txtbxDegrees
            // 
            txtbxDegrees.Location = new Point(236, 26);
            txtbxDegrees.Name = "txtbxDegrees";
            txtbxDegrees.Size = new Size(125, 27);
            txtbxDegrees.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnFtoC);
            groupBox1.Controls.Add(rbtnCtoF);
            groupBox1.Controls.Add(rbtnCtoK);
            groupBox1.Location = new Point(25, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 137);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Conversion";
            // 
            // rbtnCtoK
            // 
            rbtnCtoK.AutoSize = true;
            rbtnCtoK.Location = new Point(24, 35);
            rbtnCtoK.Name = "rbtnCtoK";
            rbtnCtoK.Size = new Size(137, 24);
            rbtnCtoK.TabIndex = 0;
            rbtnCtoK.TabStop = true;
            rbtnCtoK.Text = "Celsius to Kelvin";
            rbtnCtoK.UseVisualStyleBackColor = true;
            // 
            // rbtnCtoF
            // 
            rbtnCtoF.AutoSize = true;
            rbtnCtoF.Location = new Point(24, 65);
            rbtnCtoF.Name = "rbtnCtoF";
            rbtnCtoF.Size = new Size(165, 24);
            rbtnCtoF.TabIndex = 1;
            rbtnCtoF.TabStop = true;
            rbtnCtoF.Text = "Celsius to Fahrenheit";
            rbtnCtoF.UseVisualStyleBackColor = true;
            // 
            // rbtnFtoC
            // 
            rbtnFtoC.AutoSize = true;
            rbtnFtoC.Location = new Point(24, 95);
            rbtnFtoC.Name = "rbtnFtoC";
            rbtnFtoC.Size = new Size(165, 24);
            rbtnFtoC.TabIndex = 2;
            rbtnFtoC.TabStop = true;
            rbtnFtoC.Text = "Fahrenheit to Celsius";
            rbtnFtoC.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(25, 269);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(336, 52);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtStaticResult
            // 
            txtStaticResult.AutoSize = true;
            txtStaticResult.Location = new Point(25, 358);
            txtStaticResult.Name = "txtStaticResult";
            txtStaticResult.Size = new Size(134, 20);
            txtStaticResult.TabIndex = 4;
            txtStaticResult.Text = "Converted degrees";
            // 
            // txtResult
            // 
            txtResult.AutoSize = true;
            txtResult.Location = new Point(236, 358);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(0, 20);
            txtResult.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 409);
            Controls.Add(txtResult);
            Controls.Add(txtStaticResult);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox1);
            Controls.Add(txtbxDegrees);
            Controls.Add(txtStaticDegrees);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtStaticDegrees;
        private TextBox txtbxDegrees;
        private GroupBox groupBox1;
        private RadioButton rbtnCtoF;
        private RadioButton rbtnCtoK;
        private RadioButton rbtnFtoC;
        private Button btnCalculate;
        private Label txtStaticResult;
        private Label txtResult;
    }
}