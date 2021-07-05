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
        public income_report()
        {
            //ptotal = total;
            InitializeComponent();
           // data();
            
        }

       private void data()
        {
            MySqlConnection SqlConnection = new MySqlConnection("datasource=localhost; username=root; password=; database=OHMS");
            MySqlDataReader reader = null;


            SqlConnection.Open();//open the connction
            MySqlCommand command = new MySqlCommand("Select sum(amount) as total from expense", SqlConnection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                ptotal = reader["total"].ToString();
            }
          
        }

        private void income_report_Load(object sender, EventArgs e)
        {
            data();
            ReportParameter[] parms = new ReportParameter[1];
            parms[0] = new ReportParameter("Total", ptotal);
            this.reportViewer1.LocalReport.SetParameters(parms);
           /* Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
           {
                new Microsoft.Reporting.WinForms.ReportParameter("Total",ptotal)
            };*/
            // TODO: This line of code loads data into the 'ohmsDataSet.expense' table. You can move, or remove it, as needed.
            this.expenseTableAdapter.Fill(this.ohmsDataSet.expense);

            //this.expenseTableAdapter.Fill(this.expensedata.expense);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
