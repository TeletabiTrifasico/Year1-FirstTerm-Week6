namespace assignment5
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
            txtStaticNumberOne = new Label();
            txtStaticNumberTwo = new Label();
            txtbxNumberOne = new TextBox();
            txtbxNumberTwo = new TextBox();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            txtStaticResult = new Label();
            txtResult = new Label();
            SuspendLayout();
            // 
            // txtStaticNumberOne
            // 
            txtStaticNumberOne.AutoSize = true;
            txtStaticNumberOne.Location = new Point(47, 54);
            txtStaticNumberOne.Name = "txtStaticNumberOne";
            txtStaticNumberOne.Size = new Size(75, 20);
            txtStaticNumberOne.TabIndex = 0;
            txtStaticNumberOne.Text = "Number 1";
            // 
            // txtStaticNumberTwo
            // 
            txtStaticNumberTwo.AutoSize = true;
            txtStaticNumberTwo.Location = new Point(47, 112);
            txtStaticNumberTwo.Name = "txtStaticNumberTwo";
            txtStaticNumberTwo.Size = new Size(75, 20);
            txtStaticNumberTwo.TabIndex = 1;
            txtStaticNumberTwo.Text = "Number 2";
            // 
            // txtbxNumberOne
            // 
            txtbxNumberOne.Location = new Point(212, 51);
            txtbxNumberOne.Name = "txtbxNumberOne";
            txtbxNumberOne.Size = new Size(182, 27);
            txtbxNumberOne.TabIndex = 2;
            // 
            // txtbxNumberTwo
            // 
            txtbxNumberTwo.Location = new Point(212, 109);
            txtbxNumberTwo.Name = "txtbxNumberTwo";
            txtbxNumberTwo.Size = new Size(182, 27);
            txtbxNumberTwo.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(22, 174);
            btnAdd.Margin = new Padding(3, 1, 1, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 83);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.TextAlign = ContentAlignment.TopCenter;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubtract.Location = new Point(122, 174);
            btnSubtract.Margin = new Padding(3, 1, 1, 3);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(90, 83);
            btnSubtract.TabIndex = 5;
            btnSubtract.Text = "-";
            btnSubtract.TextAlign = ContentAlignment.TopCenter;
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiply.Location = new Point(222, 174);
            btnMultiply.Margin = new Padding(3, 1, 1, 3);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(90, 83);
            btnMultiply.TabIndex = 6;
            btnMultiply.Text = "x";
            btnMultiply.TextAlign = ContentAlignment.TopCenter;
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivide.Location = new Point(322, 174);
            btnDivide.Margin = new Padding(3, 1, 1, 3);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(90, 83);
            btnDivide.TabIndex = 7;
            btnDivide.Text = ":";
            btnDivide.TextAlign = ContentAlignment.TopCenter;
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // txtStaticResult
            // 
            txtStaticResult.AutoSize = true;
            txtStaticResult.Location = new Point(47, 302);
            txtStaticResult.Name = "txtStaticResult";
            txtStaticResult.Size = new Size(49, 20);
            txtStaticResult.TabIndex = 8;
            txtStaticResult.Text = "Result";
            // 
            // txtResult
            // 
            txtResult.AutoSize = true;
            txtResult.Location = new Point(222, 302);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(0, 20);
            txtResult.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 367);
            Controls.Add(txtResult);
            Controls.Add(txtStaticResult);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(txtbxNumberTwo);
            Controls.Add(txtbxNumberOne);
            Controls.Add(txtStaticNumberTwo);
            Controls.Add(txtStaticNumberOne);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtStaticNumberOne;
        private Label txtStaticNumberTwo;
        private TextBox txtbxNumberOne;
        private TextBox txtbxNumberTwo;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Label txtStaticResult;
        private Label txtResult;
    }
}