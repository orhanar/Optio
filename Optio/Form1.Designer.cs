namespace Optio
{
    partial class Count
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
            label1 = new Label();
            label2 = new Label();
            txtStartFrom = new TextBox();
            txtTo = new TextBox();
            btnCount = new Button();
            btnExit = new Button();
            divNum = new Label();
            cmbDivisibleTerm = new ComboBox();
            txtDivisibleNumbers = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 57);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 0;
            label1.Text = "Start From";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(230, 57);
            label2.Name = "label2";
            label2.Size = new Size(28, 21);
            label2.TabIndex = 1;
            label2.Text = "To";
            // 
            // txtStartFrom
            // 
            txtStartFrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartFrom.Location = new Point(124, 55);
            txtStartFrom.Name = "txtStartFrom";
            txtStartFrom.Size = new Size(100, 29);
            txtStartFrom.TabIndex = 2;
            txtStartFrom.TextChanged += textBox1_TextChanged;
            // 
            // txtTo
            // 
            txtTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTo.Location = new Point(264, 55);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(100, 29);
            txtTo.TabIndex = 3;
            // 
            // btnCount
            // 
            btnCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCount.Location = new Point(134, 131);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(88, 32);
            btnCount.TabIndex = 4;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(264, 131);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(88, 32);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // divNum
            // 
            divNum.AutoSize = true;
            divNum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            divNum.Location = new Point(31, 89);
            divNum.Name = "divNum";
            divNum.Size = new Size(144, 21);
            divNum.TabIndex = 6;
            divNum.Text = "Divisible Number";
            divNum.Click += label3_Click;
            // 
            // cmbDivisibleTerm
            // 
            cmbDivisibleTerm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDivisibleTerm.FormattingEnabled = true;
            cmbDivisibleTerm.Location = new Point(186, 88);
            cmbDivisibleTerm.Margin = new Padding(2, 1, 2, 1);
            cmbDivisibleTerm.Name = "cmbDivisibleTerm";
            cmbDivisibleTerm.Size = new Size(132, 29);
            cmbDivisibleTerm.TabIndex = 7;
            cmbDivisibleTerm.SelectedIndexChanged += cmbDivisibleTerm_SelectedIndexChanged;
            // 
            // txtDivisibleNumbers
            // 
            txtDivisibleNumbers.Dock = DockStyle.Bottom;
            txtDivisibleNumbers.Location = new Point(0, 186);
            txtDivisibleNumbers.Margin = new Padding(2, 1, 2, 1);
            txtDivisibleNumbers.Multiline = true;
            txtDivisibleNumbers.Name = "txtDivisibleNumbers";
            txtDivisibleNumbers.Size = new Size(739, 233);
            txtDivisibleNumbers.TabIndex = 8;
            txtDivisibleNumbers.TextChanged += txtDivisibleNumbers_TextChanged;
            // 
            // Count
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 419);
            Controls.Add(txtDivisibleNumbers);
            Controls.Add(cmbDivisibleTerm);
            Controls.Add(divNum);
            Controls.Add(btnExit);
            Controls.Add(btnCount);
            Controls.Add(txtTo);
            Controls.Add(txtStartFrom);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Count";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Count";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtStartFrom;
        private TextBox txtTo;
        private Button btnCount;
        private Button btnExit;
        private Label divNum;
        private ComboBox cmbDivisibleTerm;
        private TextBox txtDivisibleNumbers;
    }
}