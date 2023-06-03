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
            Groupbox = new GroupBox();
            rbGreen = new RadioButton();
            rbBlue = new RadioButton();
            rbRed = new RadioButton();
            rbBlack = new RadioButton();
            chBold = new CheckBox();
            chItalic = new CheckBox();
            Groupbox.SuspendLayout();
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
            txtStartFrom.KeyPress += txtStartFrom_KeyPress;
            // 
            // txtTo
            // 
            txtTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTo.Location = new Point(264, 55);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(100, 29);
            txtTo.TabIndex = 3;
            txtTo.KeyPress += txtTo_KeyPress;
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
            // Groupbox
            // 
            Groupbox.Controls.Add(rbGreen);
            Groupbox.Controls.Add(rbBlue);
            Groupbox.Controls.Add(rbRed);
            Groupbox.Controls.Add(rbBlack);
            Groupbox.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Groupbox.Location = new Point(403, 30);
            Groupbox.Margin = new Padding(2, 1, 2, 1);
            Groupbox.Name = "Groupbox";
            Groupbox.Padding = new Padding(2, 1, 2, 1);
            Groupbox.Size = new Size(302, 140);
            Groupbox.TabIndex = 10;
            Groupbox.TabStop = false;
            Groupbox.Text = "Select Color";
            // 
            // rbGreen
            // 
            rbGreen.AutoSize = true;
            rbGreen.Location = new Point(27, 105);
            rbGreen.Margin = new Padding(2, 1, 2, 1);
            rbGreen.Name = "rbGreen";
            rbGreen.Size = new Size(67, 23);
            rbGreen.TabIndex = 3;
            rbGreen.Text = "Green";
            rbGreen.UseVisualStyleBackColor = true;
            rbGreen.CheckedChanged += rbGreen_CheckedChanged;
            // 
            // rbBlue
            // 
            rbBlue.AutoSize = true;
            rbBlue.Location = new Point(29, 82);
            rbBlue.Margin = new Padding(2, 1, 2, 1);
            rbBlue.Name = "rbBlue";
            rbBlue.Size = new Size(56, 23);
            rbBlue.TabIndex = 2;
            rbBlue.Text = "Blue";
            rbBlue.UseVisualStyleBackColor = true;
            rbBlue.CheckedChanged += rbBlue_CheckedChanged;
            // 
            // rbRed
            // 
            rbRed.AutoSize = true;
            rbRed.Location = new Point(29, 59);
            rbRed.Margin = new Padding(2, 1, 2, 1);
            rbRed.Name = "rbRed";
            rbRed.Size = new Size(53, 23);
            rbRed.TabIndex = 1;
            rbRed.Text = "Red";
            rbRed.UseVisualStyleBackColor = true;
            rbRed.CheckedChanged += rbRed_CheckedChanged;
            // 
            // rbBlack
            // 
            rbBlack.AutoSize = true;
            rbBlack.Checked = true;
            rbBlack.Location = new Point(29, 35);
            rbBlack.Margin = new Padding(2, 1, 2, 1);
            rbBlack.Name = "rbBlack";
            rbBlack.Size = new Size(63, 23);
            rbBlack.TabIndex = 0;
            rbBlack.TabStop = true;
            rbBlack.Text = "Black";
            rbBlack.UseVisualStyleBackColor = true;
            rbBlack.CheckedChanged += rbBlack_CheckedChanged;
            // 
            // chBold
            // 
            chBold.AutoSize = true;
            chBold.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chBold.Location = new Point(28, 130);
            chBold.Name = "chBold";
            chBold.Size = new Size(55, 21);
            chBold.TabIndex = 11;
            chBold.Text = "Bold";
            chBold.UseVisualStyleBackColor = true;
            chBold.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chItalic
            // 
            chItalic.AutoSize = true;
            chItalic.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            chItalic.Location = new Point(29, 149);
            chItalic.Name = "chItalic";
            chItalic.Size = new Size(58, 21);
            chItalic.TabIndex = 12;
            chItalic.Text = "Italic";
            chItalic.UseVisualStyleBackColor = true;
            chItalic.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // Count
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 419);
            Controls.Add(chItalic);
            Controls.Add(chBold);
            Controls.Add(Groupbox);
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
            Groupbox.ResumeLayout(false);
            Groupbox.PerformLayout();
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
        private GroupBox Groupbox;
        private RadioButton rbGreen;
        private RadioButton rbBlue;
        private RadioButton rbRed;
        private RadioButton rbBlack;
        private CheckBox chBold;
        private CheckBox chItalic;
    }
}