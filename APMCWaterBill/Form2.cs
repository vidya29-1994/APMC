using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace APMCWaterBill
{
    public partial class Form2 : Form
    {
        public string BillMonth = "";
        public string Market = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BillMonth = Form1.SetValueForDate;
            Market = Form1.SetValueForMarket;
        }

        private void btnReading_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {

        }
    }
}
