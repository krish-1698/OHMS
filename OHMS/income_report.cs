using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;
namespace OHMS
{
    public partial class income_report : Form
    {
        String ptotal;
        string ptotal1 = "";
        string ptotal2 = "";
        public income_report()
        {
          
            InitializeComponent();
           
            
        }

        private void data()
        {
            
            MySqlConnection SqlConnection = new MySqlConnection("datasource=localhost; username=root; password=; database=OHMS");
            MySqlDataReader reader1 = null;
            MySqlDataReader reader2 = null;


            SqlConnection.Open();//open the connction
            MySqlCommand command1 = new MySqlCommand("Select sum(amount) as total from expense", SqlConnection);
            reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                //   ptotal1 = reader["total"].ToString();
                ptotal1 = reader1["total"].ToString();
            }
            SqlConnection.Close();

            SqlConnection.Open();
            MySqlCommand command2 = new MySqlCommand("Select sum(amount) as total1 from donation where type!='product'", SqlConnection);
            reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                ptotal2 = reader2["total1"].ToString();
            }
            double tot =   Convert.ToDouble(ptotal2)-Convert.ToDouble(ptotal1);
            ptotal = tot.ToString();
            SqlConnection.Close();
        }

        private void income_report_Load(object sender, EventArgs e)
        {
            data();
            ReportParameter[] parms = new ReportParameter[3];
            parms[0] = new ReportParameter("Total", ptotal);
            parms[1] = new ReportParameter("Tot2", ptotal1);
            parms[2] = new ReportParameter("Tot1", ptotal2);
            this.reportViewer1.LocalReport.SetParameters(parms);

            // TODO: This line of code loads data into the 'ohmsDataSet.expense' table. You can move, or remove it, as needed.
            this.expenseTableAdapter.Fill(this.ohmsDataSet.expense);
            // TODO: This line of code loads data into the 'ohmsDataSet.donation' table. You can move, or remove it, as needed.
            this.donationTableAdapter.Fill(this.ohmsDataSet.donation);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
