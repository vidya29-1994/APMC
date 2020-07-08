using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APMCWaterBill
{
    public partial class Form1 : Form
    {
        public static string SetValueForDate = "";
        public static string SetValueForMarket = "";
        string connstr = ConfigurationManager.ConnectionStrings["conStr"].ToString();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            SetValueForDate = Convert.ToDateTime(dpBillDate.Text).ToShortDateString();
            SetValueForDate = SetValueForDate.Remove(0, 3);
            SetValueForDate = SetValueForDate.Remove(2, 1);
            SetValueForMarket = lblMarket.Text.ToString();
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
