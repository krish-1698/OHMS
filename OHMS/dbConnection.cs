using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace OHMS
{
    class dbConnection
    {
        MySqlConnection con;
        //MySqlConnection con =new MySqlConnection("datasource=localhost; username=root; password=; database=OHMS");
        MySqlCommand cmd;

        public void OpenConnection()
        {
            con = new MySqlConnection("datasource=localhost; username=root; password=; database=OHMS");
            con.Open();
        }
        public void ExecuteQueries(string query)
        {
           // con.Open();
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            //con.Close();
        }
        public MySqlDataReader DataReader(string query)
        {
            //con.Close();
            //con.Open();
            cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
            
        }
        public void  ShowDataInGridView(DataGridView grid,string query)
        {
            //con.Open();
            MySqlDataAdapter adapt = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            grid.DataSource = dt;
            if(query == "select `Staff_Id`, `Nic_No`, `First_Name`, `Last_Name`, `Gender`, `DOB`, `Contact_no`, `Email`, `Address`, `Employment_Type`,`photo` from staff "|| query== "select `Orphan_Id`, `First_name`, `last_name`, `Gender`, `DOB`,`Date_of_Admission`, `Health_Deficiencies`, `Guardian_name`, `Guardian_nic`,`contact_no`,`Guardian_Address`,`How_Inmate_Boarded`,`photo` from orphan ")
            {
                dt.Columns.Add("Img", Type.GetType("System.Byte[]"));
                foreach (DataRow drow in dt.Rows)
                {          
                 
                     drow["Img"] = File.ReadAllBytes(drow["Photo"].ToString());
                 
                   }


            }
            //con.Close();
            //  object dataum = ds.Tables[0];
            //return dataum;
        }
        public void CloseConnection()
        {
            con.Close();
        }

    }
}