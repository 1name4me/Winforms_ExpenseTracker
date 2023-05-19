using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms.VisualStyles;

namespace Expense_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       

        public void AddCalender()
        {
            MonthCalendar calendar = new MonthCalendar();
            calendar.Location = new Point(115, 194);
            calendar.Name = "calendar1";
            calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.display_date);


            this.Controls.Add(calendar);
        }
        private void display_date(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            this.usr_date.Text = e.Start.ToShortDateString();
           
        }

        private void calendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            AddCalender();
            
           
        }

      
        private void add_btn_Click(object sender, EventArgs e)
        {
            string pound = "£";

            ExpenseOutput expenses = new ExpenseOutput();
            expenses.Type_txt.Text = Type_Drpdown.Text;
            expenses.Name.Text = usr_name.Text;
            expenses.Date.Text = usr_date.Text;
            expenses.Amount.Text = pound + usr_amount.Text;
            FLP.Controls.Add(expenses);
            clear_txtbox(); 
        }

        public void clear_txtbox()
        {
            usr_amount.Text = "";
            usr_name.Text = "";
            usr_date.Text = "";
        }
    }
}