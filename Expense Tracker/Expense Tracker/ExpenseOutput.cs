﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class ExpenseOutput : UserControl
    {
        public ExpenseOutput()
        {
            InitializeComponent();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Dispose();
        }
    }
}
