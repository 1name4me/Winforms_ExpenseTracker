namespace Expense_Tracker
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.usr_name = new System.Windows.Forms.TextBox();
            this.usr_amount = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.Type_Drpdown = new System.Windows.Forms.ComboBox();
            this.usr_date = new System.Windows.Forms.Label();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(284, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expense Tracker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(324, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add A New Item:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(59, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(59, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(421, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(421, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Amount";
            // 
            // usr_name
            // 
            this.usr_name.Location = new System.Drawing.Point(487, 120);
            this.usr_name.Name = "usr_name";
            this.usr_name.Size = new System.Drawing.Size(227, 23);
            this.usr_name.TabIndex = 8;
            // 
            // usr_amount
            // 
            this.usr_amount.Location = new System.Drawing.Point(487, 170);
            this.usr_amount.Name = "usr_amount";
            this.usr_amount.Size = new System.Drawing.Size(227, 23);
            this.usr_amount.TabIndex = 9;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.add_btn.Location = new System.Drawing.Point(346, 223);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(105, 35);
            this.add_btn.TabIndex = 10;
            this.add_btn.Text = "Add Expense";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // Type_Drpdown
            // 
            this.Type_Drpdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_Drpdown.FormattingEnabled = true;
            this.Type_Drpdown.Items.AddRange(new object[] {
            "Card",
            "Cash ",
            "Online"});
            this.Type_Drpdown.Location = new System.Drawing.Point(115, 120);
            this.Type_Drpdown.Name = "Type_Drpdown";
            this.Type_Drpdown.Size = new System.Drawing.Size(227, 23);
            this.Type_Drpdown.TabIndex = 12;
            this.Type_Drpdown.TabStop = false;
            // 
            // usr_date
            // 
            this.usr_date.BackColor = System.Drawing.Color.White;
            this.usr_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usr_date.Location = new System.Drawing.Point(115, 174);
            this.usr_date.Name = "usr_date";
            this.usr_date.Size = new System.Drawing.Size(227, 23);
            this.usr_date.TabIndex = 13;
            this.usr_date.Click += new System.EventHandler(this.label7_Click);
            // 
            // FLP
            // 
            this.FLP.Location = new System.Drawing.Point(59, 365);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(655, 211);
            this.FLP.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(59, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 37);
            this.panel1.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(428, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(287, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(138, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.FLP);
            this.Controls.Add(this.usr_date);
            this.Controls.Add(this.Type_Drpdown);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.usr_amount);
            this.Controls.Add(this.usr_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox usr_name;
        private TextBox usr_amount;
        private Button add_btn;
        private ComboBox Type_Drpdown;
        private Label usr_date;
        private FlowLayoutPanel FLP;
        private Panel panel1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private MonthCalendar calendar;
    }
}