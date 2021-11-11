using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Chit_Fund_Management_System
{
    public partial class Edit_Agent : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Edit_Agent()
        {
            InitializeComponent();
        }
        private void bt_Edit_a_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into MemberTB(Aname, Adob, Gname, Aage, Agender, Aqualification, Apaddr, Aemail, Amob, Aadhaarno, Bid, Dor, Agname1, " +
                    "Agaddr1, Agname2, Agaddr2, Apan, Abname, Aacno, Aifsc, Aactype) values(@Aname, @Adob, @Gname, @Aage, @Agender, @Aqualification, @Apaddr, " +
                    "@Aemail, @Amob, @Aadhaarno, @Bid, @Dor, @Agname1, @Agaddr1, @Agname2, @Agaddr2, @Apan, @Abname, @Aacno, @Aifsc, @Aactype)", con);
                cmd.Parameters.AddWithValue("@Aname", tb_Edit_a_name.Text);
                cmd.Parameters.AddWithValue("@Adob", dtp_Edit_a_dob.Text);
                cmd.Parameters.AddWithValue("@Gname", tb_Edit_a_gname.Text);
                cmd.Parameters.AddWithValue("@Aage", tb_Edit_a_age.Text);
                cmd.Parameters.AddWithValue("@Agender", cb_Edit_a_gender.Text);
                cmd.Parameters.AddWithValue("@Aqualification", tb_Edit_a_qualification.Text);
                cmd.Parameters.AddWithValue("@Apaddr", tb_Edit_a_paddr.Text);
                cmd.Parameters.AddWithValue("@Aemail", tb_Edit_a_aemail.Text);
                cmd.Parameters.AddWithValue("@Amob", tb_Edit_a_amob.Text);
                cmd.Parameters.AddWithValue("@Aadhaarno", tb_Edit_a_aadhaar.Text);
                cmd.Parameters.AddWithValue("@Bid", tb_Edit_A_bid.Text);
                cmd.Parameters.AddWithValue("@Dor", dtp_Edit_a_dor.Text);
                cmd.Parameters.AddWithValue("@Agname1", tb_Edit_a_1gname.Text);
                cmd.Parameters.AddWithValue("@Agaddr1", tb_Edit_a_1gaddr.Text);
                cmd.Parameters.AddWithValue("@Agname2", tb_Edit_a_2gname.Text);
                cmd.Parameters.AddWithValue("@Agaddr2", tb_Edit_a_2gaddr.Text);
                cmd.Parameters.AddWithValue("@Apan", tb_Edit_a_apan.Text);
                cmd.Parameters.AddWithValue("@Abname", tb_Edit_a_bankname.Text);
                cmd.Parameters.AddWithValue("@Aacno", tb_Edit_a_acno.Text);
                cmd.Parameters.AddWithValue("@Aifsc", tb_Edit_a_ifsc.Text);
                cmd.Parameters.AddWithValue("@Aactype", tb_Edit_a_actype.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void bt_Edit_a_clear_Click(object sender, EventArgs e)
        {

            tb_Edit_a_name.Clear();
            tb_Edit_a_gname.Clear();
            tb_Edit_a_age.Clear();
            cb_Edit_a_gender.Items.Clear();
            tb_Edit_a_qualification.Clear();
            tb_Edit_a_paddr.Clear();
            tb_Edit_a_aemail.Clear();
            tb_Edit_a_amob.Clear();
            tb_Edit_a_aadhaar.Clear();
            tb_Edit_A_bid.Clear();
            tb_Edit_a_1gname.Clear();
            tb_Edit_a_1gaddr.Clear();
            tb_Edit_a_2gname.Clear();
            tb_Edit_a_2gaddr.Clear();
            tb_Edit_a_apan.Clear();
            tb_Edit_a_bankname.Clear();
            tb_Edit_a_acno.Clear();
            tb_Edit_a_ifsc.Clear();
            tb_Edit_a_actype.Clear();
        }

        private void bt_Edit_a_close_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }

        private void bt_Edit_a_del_Click(object sender, EventArgs e)
        {
            
        }
        private void tb_Edit_a_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_Edit_a_name.Text, "[^a-zA-Z]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_Edit_a_name.Text = tb_Edit_a_name.Text.Remove(tb_Edit_a_name.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void tb_Edit_a_gname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_Edit_a_gname.Text, "[^a-zA-Z]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_Edit_a_gname.Text = tb_Edit_a_gname.Text.Remove(tb_Edit_a_gname.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_Edit_a_age_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_Edit_a_age.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid age.");
                    tb_Edit_a_age.Text = tb_Edit_a_age.Text.Remove(tb_Edit_a_age.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void tb_Edit_a_amob_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_Edit_a_amob.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid mobile number.");
                    tb_Edit_a_amob.Text = tb_Edit_a_amob.Text.Remove(tb_Edit_a_amob.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_Edit_a_aadhaar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_Edit_a_aadhaar.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid adhaar number.");
                    tb_Edit_a_aadhaar.Text = tb_Edit_a_aadhaar.Text.Remove(tb_Edit_a_aadhaar.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_Edit_a_bid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_Edit_A_bid.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid id.");
                    tb_Edit_A_bid.Text = tb_Edit_A_bid.Text.Remove(tb_Edit_A_bid.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void tb_Edit_a_1gname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_Edit_a_1gname.Text, "[^a-zA-Z]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_Edit_a_1gname.Text = tb_Edit_a_1gname.Text.Remove(tb_Edit_a_1gname.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_Edit_a_2gname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_Edit_a_2gname.Text, "[^a-zA-Z]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_Edit_a_2gname.Text = tb_Edit_a_2gname.Text.Remove(tb_Edit_a_2gname.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_Edit_a_bankname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_Edit_a_bankname.Text, "[^a-zA-Z]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_Edit_a_bankname.Text = tb_Edit_a_bankname.Text.Remove(tb_Edit_a_bankname.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void tb_Edit_a_acno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_Edit_a_acno.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid A/C number.");
                    tb_Edit_a_acno.Text = tb_Edit_a_acno.Text.Remove(tb_Edit_a_acno.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_Edit_a_actype_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_Edit_a_actype.Text, "[^a-zA-Z]"))
                {
                    MessageBox.Show("Please enter valid A/C type.");
                    tb_Edit_a_actype.Text = tb_Edit_a_actype.Text.Remove(tb_Edit_a_actype.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void tb_Edit_A_bid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_Edit_A_bid.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid id.");
                    tb_Edit_A_bid.Text = tb_Edit_A_bid.Text.Remove(tb_Edit_A_bid.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
