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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 122);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 45);
            label1.TabIndex = 0;
            label1.Text = "Start From";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(427, 122);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 45);
            label2.TabIndex = 1;
            label2.Text = "To";
            // 
            // txtStartFrom
            // 
            txtStartFrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartFrom.Location = new Point(230, 117);
            txtStartFrom.Margin = new Padding(6);
            txtStartFrom.Name = "txtStartFrom";
            txtStartFrom.Size = new Size(182, 50);
            txtStartFrom.TabIndex = 2;
            txtStartFrom.TextChanged += textBox1_TextChanged;
            // 
            // txtTo
            // 
            txtTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTo.Location = new Point(490, 117);
            txtTo.Margin = new Padding(6);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(182, 50);
            txtTo.TabIndex = 3;
            // 
            // btnCount
            // 
            btnCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCount.Location = new Point(249, 279);
            btnCount.Margin = new Padding(6);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(163, 68);
            btnCount.TabIndex = 4;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(490, 279);
            btnExit.Margin = new Padding(6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(163, 68);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // divNum
            // 
            divNum.AutoSize = true;
            divNum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            divNum.Location = new Point(57, 190);
            divNum.Margin = new Padding(6, 0, 6, 0);
            divNum.Name = "divNum";
            divNum.Size = new Size(280, 45);
            divNum.TabIndex = 6;
            divNum.Text = "Divisible Number";
            divNum.Click += label3_Click;
            // 
            // cmbDivisibleTerm
            // 
            cmbDivisibleTerm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDivisibleTerm.FormattingEnabled = true;
            cmbDivisibleTerm.Location = new Point(346, 187);
            cmbDivisibleTerm.Name = "cmbDivisibleTerm";
            cmbDivisibleTerm.Size = new Size(242, 53);
            cmbDivisibleTerm.TabIndex = 7;
            cmbDivisibleTerm.SelectedIndexChanged += cmbDivisibleTerm_SelectedIndexChanged;
            // 
            // Count
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 960);
            Controls.Add(cmbDivisibleTerm);
            Controls.Add(divNum);
            Controls.Add(btnExit);
            Controls.Add(btnCount);
            Controls.Add(txtTo);
            Controls.Add(txtStartFrom);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6);
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
    }
}