namespace assignment6
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
            txtStaticNumber = new Label();
            txtbxNumber = new TextBox();
            btnRefrence = new Button();
            btnRefrenceOut = new Button();
            btnValue = new Button();
            txtStaticResult = new Label();
            txtResult = new Label();
            SuspendLayout();
            // 
            // txtStaticNumber
            // 
            txtStaticNumber.AutoSize = true;
            txtStaticNumber.Location = new Point(30, 39);
            txtStaticNumber.Name = "txtStaticNumber";
            txtStaticNumber.Size = new Size(63, 20);
            txtStaticNumber.TabIndex = 0;
            txtStaticNumber.Text = "Number";
            // 
            // txtbxNumber
            // 
            txtbxNumber.Location = new Point(275, 36);
            txtbxNumber.Name = "txtbxNumber";
            txtbxNumber.Size = new Size(125, 27);
            txtbxNumber.TabIndex = 1;
            // 
            // btnRefrence
            // 
            btnRefrence.Location = new Point(30, 110);
            btnRefrence.Name = "btnRefrence";
            btnRefrence.Size = new Size(370, 30);
            btnRefrence.TabIndex = 2;
            btnRefrence.Text = "Square By Reference";
            btnRefrence.UseVisualStyleBackColor = true;
            btnRefrence.Click += btnRefrence_Click;
            // 
            // btnRefrenceOut
            // 
            btnRefrenceOut.Location = new Point(30, 146);
            btnRefrenceOut.Name = "btnRefrenceOut";
            btnRefrenceOut.Size = new Size(370, 30);
            btnRefrenceOut.TabIndex = 3;
            btnRefrenceOut.Text = "Square By Reference Out";
            btnRefrenceOut.UseVisualStyleBackColor = true;
            btnRefrenceOut.Click += btnRefrenceOut_Click;
            // 
            // btnValue
            // 
            btnValue.Location = new Point(30, 182);
            btnValue.Name = "btnValue";
            btnValue.Size = new Size(370, 30);
            btnValue.TabIndex = 4;
            btnValue.Text = "Square By Value";
            btnValue.UseVisualStyleBackColor = true;
            btnValue.Click += btnValue_Click;
            // 
            // txtStaticResult
            // 
            txtStaticResult.AutoSize = true;
            txtStaticResult.Location = new Point(30, 264);
            txtStaticResult.Name = "txtStaticResult";
            txtStaticResult.Size = new Size(49, 20);
            txtStaticResult.TabIndex = 5;
            txtStaticResult.Text = "Result";
            // 
            // txtResult
            // 
            txtResult.AutoSize = true;
            txtResult.Location = new Point(275, 264);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(0, 20);
            txtResult.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 301);
            Controls.Add(txtResult);
            Controls.Add(txtStaticResult);
            Controls.Add(btnValue);
            Controls.Add(btnRefrenceOut);
            Controls.Add(btnRefrence);
            Controls.Add(txtbxNumber);
            Controls.Add(txtStaticNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtStaticNumber;
        private TextBox txtbxNumber;
        private Button btnRefrence;
        private Button btnRefrenceOut;
        private Button btnValue;
        private Label txtStaticResult;
        private Label txtResult;
    }
}