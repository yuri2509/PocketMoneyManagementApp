using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocketMoneyManagementApp
{
    public partial class MenuForm : System.Windows.Forms.Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MoneyManagemenButton_Click(object sender, EventArgs e)
        {
            BalanceForm balanceForm= new BalanceForm();
            balanceForm.ShowDialog();
        }
    }
}
