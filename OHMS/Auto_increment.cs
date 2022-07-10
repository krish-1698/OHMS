using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OHMS
{
    class Auto_increment
    {

        dbConnection dbConnect = new dbConnection();
        public String getPrimaryKey(String prefix, String query)
        {
            String value = null;

            try
            {
                dbConnect.OpenConnection();
                MySqlDataReader rs=dbConnect.DataReader(query);
                String id = null;
                while (rs.Read())
                {
                    if (rs.HasRows)
                    {
                        id = rs.GetString(0);
                        String getLastVal = "0";
                        int j = 0;
                        for (int i = 2; i < id.Length; i++)
                        {
                            getLastVal += id[i];
                            j++;
                        }
                        int num = Convert.ToInt32(getLastVal);

                        num++;
                        if (prefix.Equals("SN"))
                        {
                            value = "SN" + num;
                        }
                        else if (prefix.Equals("OR"))
                        {
                            value = "OR" + num;
                        }
                        else if (prefix.Equals("DN"))
                        {
                            value = "DN" + num;
                        }
                        else if (prefix.Equals("DT"))
                        {
                            value = "DT" + num;
                        }
                        else if (prefix.Equals("EX"))
                        {
                            value = "EX" + num;
                        }
                        else
                        {
                        }

                    }
                    else
                    {
                        String pr = prefix;
                        value = pr + "1";
                    }
                }
                dbConnect.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return value;
        }

    }
}
