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
    public partial class Edit_Member : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Edit_Member()
        {
            InitializeComponent();
        }

        private void bt_edit_m_search_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataReader dr;
                DataTable dt = new DataTable();
                con.Open();
                cmd = new OleDbCommand("select * from MemberTB where [Member_id]=@memberid", con);
                cmd.Parameters.AddWithValue("@memberid", tb_edit_m_memberid.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tb_edit_m_name.Text = (dr["Mname"].ToString());
                    dtp_edit_m_dob.Text = (dr["Mdob"].ToString());
                    tb_edit_m_fname.Text = (dr["Fname"].ToString());
                    tb_edit_m_sname.Text = (dr["Sname"].ToString());
                    tb_edit_m_age.Text = (dr["Mage"].ToString());
                    cb_edit_m_gender.Text = (dr["Mgender"].ToString());
                    tb_edit_m_laddr.Text = (dr["Mladdr"].ToString());
                    tb_edit_m_memail.Text = (dr["Memail"].ToString());
                    tb_edit_m_mmob.Text = (dr["Mmob"].ToString());
                    tb_edit_m_madhaar.Text = (dr["Madhaar"].ToString());
                    tb_edit_m_oaddr.Text = (dr["Moaddr"].ToString());
                    tb_edit_m_mdesig.Text = (dr["Mdesign"].ToString());
                    tb_edit_m_msalary.Text = (dr["Salary"].ToString());
                    tb_edit_m_mpan.Text = (dr["Mpan"].ToString());
                    tb_edit_m_nname.Text = (dr["Nname"].ToString());
                    tb_edit_m_nrelation.Text = (dr["Nrelation"].ToString());
                    tb_edit_m_nage.Text = (dr["Nage"].ToString());
                    tb_edit_m_nemail.Text = (dr["Nemail"].ToString());
                    tb_edit_m_nmob.Text = (dr["Nmob"].ToString());
                    tb_edit_m_nadhaar.Text = (dr["Nadhaar"].ToString());
                    tb_edit_m_gid.Text = (dr["Gid"].ToString());
                    tb_edit_m_aid.Text = (dr["Aid"].ToString());
                    tb_edit_m_bid.Text = (dr["Bid"].ToString());
                    tb_edit_m_camt.Text = (dr["Camt"].ToString());
                    tb_edit_m_lamt.Text = (dr["Lamt"].ToString());
                    dtp_edit_m_dor.Text = (dr["Dor"].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_edit_m_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("update MemberTB set Mname=@Mname, Mdob=@Mdob, Fname=@Fname, Sname=@Sname, Mage=@Mage, Mgender=@Mgender, Mladdr=@Mladdr, " +
                    "Memail=@Memail, Mmob=@Mmob, Madhaar=@Madhaar, Moaddr=@Moaddr, Mdesign=@Mdesign, Salary=@Salary, Mpan=@Mpan, Nname=@Nname, Nrelation=@Nrelation, " +
                    "Nage=@Nage, Nemail=@Nemail, Nmob=@Nmob, Nadhaar=@Nadhaar, Gid=@Gid, Aid=@Aid, Bid=@Bid, Camt=@Camt, Lamt=@Lamt, Dor=@Dor where Member_id=@memberid", con);
                cmd.Parameters.AddWithValue("@memberid", tb_edit_m_memberid.Text);
                cmd.Parameters.AddWithValue("@Mname", tb_edit_m_name.Text);
                cmd.Parameters.AddWithValue("@Mdob", dtp_edit_m_dob.Text);
                cmd.Parameters.AddWithValue("@Fname", tb_edit_m_fname.Text);
                cmd.Parameters.AddWithValue("@Sname", tb_edit_m_sname.Text);
                cmd.Parameters.AddWithValue("@Mage", tb_edit_m_age.Text);
                cmd.Parameters.AddWithValue("@Mgender", cb_edit_m_gender.Text);
                cmd.Parameters.AddWithValue("@Mladdr", tb_edit_m_laddr.Text);
                cmd.Parameters.AddWithValue("@Memail", tb_edit_m_memail.Text);
                cmd.Parameters.AddWithValue("@Mmob", tb_edit_m_mmob.Text);
                cmd.Parameters.AddWithValue("@Madhaar", tb_edit_m_madhaar.Text);
                cmd.Parameters.AddWithValue("@Moaddr", tb_edit_m_oaddr.Text);
                cmd.Parameters.AddWithValue("@Mdesign", tb_edit_m_mdesig.Text);
                cmd.Parameters.AddWithValue("@Salary", tb_edit_m_msalary.Text);
                cmd.Parameters.AddWithValue("@Mpan", tb_edit_m_mpan.Text);
                cmd.Parameters.AddWithValue("@Nname", tb_edit_m_nname.Text);
                cmd.Parameters.AddWithValue("@Nrelation", tb_edit_m_nrelation.Text);
                cmd.Parameters.AddWithValue("@Nage", tb_edit_m_nrelation.Text);
                cmd.Parameters.AddWithValue("@Nemail", tb_edit_m_nemail.Text);
                cmd.Parameters.AddWithValue("@Nmob", tb_edit_m_nmob.Text);
                cmd.Parameters.AddWithValue("@Nadhaar", tb_edit_m_nadhaar.Text);
                cmd.Parameters.AddWithValue("@Gid", tb_edit_m_gid.Text);
                cmd.Parameters.AddWithValue("@Aid", tb_edit_m_aid.Text);
                cmd.Parameters.AddWithValue("@Bid", tb_edit_m_bid.Text);
                cmd.Parameters.AddWithValue("@Camt", tb_edit_m_camt.Text);
                cmd.Parameters.AddWithValue("@Lamt", tb_edit_m_lamt.Text);
                cmd.Parameters.AddWithValue("@Dor", dtp_edit_m_dor.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated Successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_edit_m_clear_Click(object sender, EventArgs e)
        {

            tb_edit_m_memberid.Clear();
            tb_edit_m_name.Clear();
            tb_edit_m_fname.Clear();
            tb_edit_m_sname.Clear();
            tb_edit_m_age.Clear();
            cb_edit_m_gender.Items.Clear();
            tb_edit_m_laddr.Clear();
            tb_edit_m_memail.Clear();
            tb_edit_m_mmob.Clear();
            tb_edit_m_madhaar.Clear();
            tb_edit_m_oaddr.Clear();
            tb_edit_m_mdesig.Clear();
            tb_edit_m_msalary.Clear();
            tb_edit_m_mpan.Clear();
            tb_edit_m_nname.Clear();
            tb_edit_m_nrelation.Clear();
            tb_edit_m_nrelation.Clear();
            tb_edit_m_nemail.Clear();
            tb_edit_m_nmob.Clear();
            tb_edit_m_nadhaar.Clear();
            tb_edit_m_gid.Clear();
            tb_edit_m_aid.Clear();
            tb_edit_m_bid.Clear();
            tb_edit_m_camt.Clear();
            tb_edit_m_lamt.Clear();
        }

        private void bt_edit_m_close_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }

        private void bt_edit_m_del_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("delete from MemberTB where Member_id=@memberid", con);
                cmd.Parameters.AddWithValue("@memberid", tb_edit_m_memberid.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Successfully....");
                tb_edit_m_memberid.Clear();
                tb_edit_m_name.Clear();
                tb_edit_m_fname.Clear();
                tb_edit_m_sname.Clear();
                tb_edit_m_age.Clear();
                cb_edit_m_gender.Items.Clear();
                tb_edit_m_laddr.Clear();
                tb_edit_m_memail.Clear();
                tb_edit_m_mmob.Clear();
                tb_edit_m_madhaar.Clear();
                tb_edit_m_oaddr.Clear();
                tb_edit_m_mdesig.Clear();
                tb_edit_m_msalary.Clear();
                tb_edit_m_mpan.Clear();
                tb_edit_m_nname.Clear();
                tb_edit_m_nrelation.Clear();
                tb_edit_m_nrelation.Clear();
                tb_edit_m_nemail.Clear();
                tb_edit_m_nmob.Clear();
                tb_edit_m_nadhaar.Clear();
                tb_edit_m_gid.Clear();
                tb_edit_m_aid.Clear();
                tb_edit_m_bid.Clear();
                tb_edit_m_camt.Clear();
                tb_edit_m_lamt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_m_memberid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_m_memberid.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid id.");
                    tb_edit_m_memberid.Text = tb_edit_m_memberid.Text.Remove(tb_edit_m_memberid.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_m_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_m_name.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_edit_m_name.Text = tb_edit_m_name.Text.Remove(tb_edit_m_name.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_m_fname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_m_fname.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_edit_m_fname.Text = tb_edit_m_fname.Text.Remove(tb_edit_m_fname.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_m_sname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_m_sname.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_edit_m_sname.Text = tb_edit_m_sname.Text.Remove(tb_edit_m_sname.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_m_age_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_m_age.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid age.");
                    tb_edit_m_age.Text = tb_edit_m_age.Text.Remove(tb_edit_m_age.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_m_mmob_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_m_mmob.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid mobile number.");
                    tb_edit_m_mmob.Text = tb_edit_m_mmob.Text.Remove(tb_edit_m_mmob.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_m_madhaar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_m_madhaar.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid adhaar number.");
                    tb_edit_m_madhaar.Text = tb_edit_m_madhaar.Text.Remove(tb_edit_m_madhaar.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_m_mdesig_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_m_mdesig.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid designation.");
                    tb_edit_m_mdesig.Text = tb_edit_m_mdesig.Text.Remove(tb_edit_m_mdesig.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_m_msalary_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_m_msalary.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid amount.");
                    tb_edit_m_msalary.Text = tb_edit_m_msalary.Text.Remove(tb_edit_m_msalary.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_m_nname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_m_nname.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_edit_m_nname.Text = tb_edit_m_nname.Text.Remove(tb_edit_m_nname.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_m_nrelation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_m_nrelation.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid relation.");
                    tb_edit_m_nrelation.Text = tb_edit_m_nrelation.Text.Remove(tb_edit_m_nrelation.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_m_nage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_m_nage.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid age.");
                    tb_edit_m_nage.Text = tb_edit_m_nage.Text.Remove(tb_edit_m_nage.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_m_nmob_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_m_nmob.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid mobile number.");
                    tb_edit_m_nmob.Text = tb_edit_m_nmob.Text.Remove(tb_edit_m_nmob.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_m_nadhaar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_m_nadhaar.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid adhaar number.");
                    tb_edit_m_nadhaar.Text = tb_edit_m_nadhaar.Text.Remove(tb_edit_m_nadhaar.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_m_gid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_m_gid.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid id.");
                    tb_edit_m_gid.Text = tb_edit_m_gid.Text.Remove(tb_edit_m_gid.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_m_aid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_m_aid.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid id.");
                    tb_edit_m_aid.Text = tb_edit_m_aid.Text.Remove(tb_edit_m_aid.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_m_bid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_m_bid.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid id.");
                    tb_edit_m_bid.Text = tb_edit_m_bid.Text.Remove(tb_edit_m_bid.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_m_camt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_m_camt.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid amount.");
                    tb_edit_m_camt.Text = tb_edit_m_camt.Text.Remove(tb_edit_m_camt.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_m_lamt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_m_lamt.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid amount.");
                    tb_edit_m_lamt.Text = tb_edit_m_lamt.Text.Remove(tb_edit_m_lamt.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
