namespace Expense_Tracker
{
    partial class ExpenseOutput
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Type_txt = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.remove_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Type_txt
            // 
            this.Type_txt.AutoSize = true;
            this.Type_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Type_txt.Location = new System.Drawing.Point(3, 13);
            this.Type_txt.Name = "Type_txt";
            this.Type_txt.Size = new System.Drawing.Size(41, 20);
            this.Type_txt.TabIndex = 0;
            this.Type_txt.Text = "Cash";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name.Location = new System.Drawing.Point(129, 13);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(62, 20);
            this.Name.TabIndex = 1;
            this.Name.Text = "Subway";
            this.Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Date.Location = new System.Drawing.Point(274, 13);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(81, 20);
            this.Date.TabIndex = 2;
            this.Date.Text = "2021-12-08";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Amount.Location = new System.Drawing.Point(432, 13);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(25, 20);
            this.Amount.TabIndex = 3;
            this.Amount.Text = "£0";
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.DarkRed;
            this.remove_btn.ForeColor = System.Drawing.Color.White;
            this.remove_btn.Location = new System.Drawing.Point(550, 10);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(55, 28);
            this.remove_btn.TabIndex = 4;
            this.remove_btn.Text = "remove";
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // ExpenseOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Type_txt);
           
            
            this.Size = new System.Drawing.Size(668, 44);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button remove_btn;
        public Label Type_txt;
        public Label Name;
        public Label Date;
        public Label Amount;
    }
}
