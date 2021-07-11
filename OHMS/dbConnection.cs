using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace OHMS
{
    class dbConnection
    {
      
        MySqlConnection con =new MySqlConnection("datasource=localhost; username=root; password=; database=OHMS");
        MySqlCommand cmd;

       
        public void ExecuteQueries(string query)
        {
            con.Open();
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
        public MySqlDataReader DataReader(string query)
        {
            con.Open();
            cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public object ShowDataInGridView(string query)
        {
            MySqlDataAdapter dr = new MySqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }

    }
}