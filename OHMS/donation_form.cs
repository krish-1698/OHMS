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

namespace OHMS
{
    public partial class donation_form : Form
    {
        string id, btn;
        dbConnection dbConnect = new dbConnection();
        Auto_increment aid = new Auto_increment();
        public donation_form(string d_id, string btn_check)
        {
            InitializeComponent();
            id = d_id;
            btn = btn_check;
        }

        private bool checkEmpty()
        {
            if (txt_donation_Id.Text == "" || dtp_date.Text == "" || txt_fname.Text == "" || txt_lname.Text == "" || txt_nic.Text == "" || txt_email.Text == "" || txt_contact.Text == ""  )
                if (panel_cash.Visible == true && txt_cash_amount.Text=="")
                {
                    return true;
                }
            else if (panel_cheque.Visible == true && txt_cheque_no.Text == "")
                {
                    return true;
                }
            else{
                return true;
            }
            return false;

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
                    }

        private void textBoxBorder1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBorder1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxBorder1_MouseHover(object sender, EventArgs e)
        {
            txt_donor_Id.Text= sender.GetType().ToString() + ": MouseHover";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
           /* panel_cash.Visible = true;
            panel_product.Visible = false;
            panel_cheque.Visible = false;*/
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            /*panel_cheque.Visible = true;
            panel_cash.Visible = false;
            panel_product.Visible = false;*/
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

           /* panel_product.Visible = true;
            panel_cheque.Visible = false;
            panel_cash.Visible = false;*/
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        //save
        private void button3_Click(object sender, EventArgs e)
        {

            if (checkEmpty() == true)
            {
                MessageBox.Show("Please fill all the fields", "MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string amount;
                    if (txt_amount.Text == "")
                    {
                        amount = txt_cash_amount.Text;
                    }
                    else
                    {
                        amount = txt_amount.Text;
                    }
                    string type = type_selection();
                    dbConnect.OpenConnection();
                    dbConnect.ExecuteQueries("insert into donation(donation_Id,donor_id,donated_date,type,amount, cheque_no,bank_details,product_type,quantity) Values ('" + txt_donation_Id.Text + "','" + txt_donor_Id.Text + "','" + dtp_date.Text + "','" + type + "','" + amount + "','" + txt_cheque_no.Text + "','" + richTxt_bankdetail.Text + "','" + txt_product.Text + "','" + numeric_qty.Text + "')");
                    MessageBox.Show("Added Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private string type_selection()
        {
            string type = null;
            if (radio_cash.Checked == true)
            {
                type = radio_cash.Text;
            }
            else if (radio_cheque.Checked == true)
            {
                type =radio_cheque.Text;
            }
            else
            {
                type = radio_product.Text;
            }
            return type;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkEmpty() == true)
            {
                MessageBox.Show("Please fill all the fields", "MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string type = type_selection();
                    dbConnect.OpenConnection();
                    dbConnect.ExecuteQueries("update donation,donor set  donor.donor_id='" + txt_donor_Id.Text + "', donor.nic_no='" + txt_nic.Text + "', donor.first_name='" + txt_fname + "', donor.last_name='" + txt_lname + "', donor.mobile_no='" + txt_contact.Text + "', donor.email='" + txt_email.Text + "', donation.donation_id='" + txt_donation_Id.Text + "', donation.donated_date='" + dtp_date.Text + "',donation.type='" + type + "',donation.amount='" + txt_cash_amount.Text + "',donation.amount='" + txt_amount.Text + "',donation.cheque_no='" + txt_cheque_no.Text + "',donation.bank_details='" + richTxt_bankdetail + "',donation.product_type='" + txt_product.Text + "',donation.quantity='" + numeric_qty.Text + "' where donation.donation_id='" + txt_donation_Id.Text + "' && donor.donor_id='"+txt_donor_Id.Text+"'");
                    MessageBox.Show("UPDATED Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbConnect.CloseConnection();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radio_product_CheckedChanged(object sender, EventArgs e)
        {
            panel_product.Visible = true;
            panel_cheque.Visible = false;
            panel_cash.Visible = false;
        }

        private void radio_cheque_CheckedChanged(object sender, EventArgs e)
        {
            panel_cheque.Visible = true;
            panel_cash.Visible = false;
            panel_product.Visible = false;
        }

        private void radio_cash_CheckedChanged(object sender, EventArgs e)
        {
            panel_cash.Visible = true;
            panel_product.Visible = false;
            panel_cheque.Visible = false;
        }
        //delete
        private void button6_Click(object sender, EventArgs e)
        {

            try
            {

                dbConnect.OpenConnection();
                dbConnect.ExecuteQueries("delete from donation where donation_Id='" + txt_donation_Id.Text + "'");
                DialogResult result = MessageBox.Show("Are you sure you Delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("DELETED Sucessfully", "MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dbConnect.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    

        private void donation_form_Load(object sender, EventArgs e)
        {
            panel_product.Visible = false;
            panel_cheque.Visible = false;
            panel_cash.Visible = false;
            dbConnect.OpenConnection();
            dtp_date.MaxDate = DateTime.Today;
            dtp_date.Value = DateTime.Today;
            
            if (btn.Equals("grid_click"))
            {
                sc_panel.Hide();
                MySqlDataReader reader = dbConnect.DataReader("Select * from donation,donor where donation.donation_id='" + id + "' &&  donation.donor_id=donor.donor_id");
                while (reader.Read())
                {
                    txt_donation_Id.Text = reader.GetString("donation_id");
                    txt_donor_Id.Text= reader.GetString("donor_id");
                    dtp_date.Text = reader.GetString("donated_date");

                    txt_cheque_no.Text = reader.GetString("cheque_no");
                    richTxt_bankdetail.Text = reader.GetString("bank_details");
                    txt_product.Text = reader.GetString("product_type");
                    numeric_qty.Text = reader.GetString("quantity");
                    // txt_amount.Text = reader.GetString("amount");
                    if (reader.GetString("type") == "Cash")
                    {
                        radio_cash.Checked = true;
                        txt_cash_amount.Text = reader.GetString("amount");
                        panel_cash.Visible = true;
                        // radioButton2.Checked = false;
                    }
                    else if(reader.GetString("type") == "Cheque")
                    {
                        radio_cheque.Checked = true;
                        txt_amount.Text = reader.GetString("amount");
                        panel_cheque.Visible = true;
                        //radioButton1.Checked = false;
                    }
                    else if(reader.GetString("type") == "Product")
                    {
                        radio_product.Checked = true;
                        panel_product.Visible = true;
                    }
                    else
                    {

                    }

                  //  txt_donor_Id.Text = reader.GetString("donor.donor_id");
                    txt_nic.Text = reader.GetString("nic_no");
                    txt_fname.Text = reader.GetString("first_name");
                    txt_lname.Text = reader.GetString("last_name");
                    txt_contact.Text = reader.GetString("mobile_no");
                    txt_email.Text = reader.GetString("email");

                }

            }
            else
            {
                ud_panel.Hide();
                txt_donation_Id.Text = aid.getPrimaryKey("DT", "SELECT donation_id FROM donation Order BY donation_id DESC LIMIT 1");
                MySqlDataReader reader = dbConnect.DataReader("Select * from donor where donor_id='" + id + "'");
                while (reader.Read())
                {

                    txt_donor_Id.Text = reader.GetString("donor_id");
                    txt_nic.Text = reader.GetString("nic_no");
                    txt_fname.Text = reader.GetString("first_name");
                    txt_lname.Text = reader.GetString("last_name");
                    txt_contact.Text= reader.GetString("mobile_no");
                    txt_email.Text = reader.GetString("email");
                }
            }
           
        }
    }
}
