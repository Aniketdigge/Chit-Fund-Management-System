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
    public partial class Add_Member : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Add_Member()
        {
            InitializeComponent();
        }

        private void bt_add_m_save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into MemberTB(Mname, Mdob, Fname, Sname, Mage, mgender, Mladdr, Memail, Mmob, Madhaar, Moaddr, Mdesign, Salary, Mpan, " +
                    "Nname, Nrelation, Nage, Nemail, Nmob, Nadhaar, gid, aid, Bid, camt, lamt, Dor) values(@Mname, @Mdob, @Fname, @Sname, @Mage, @Mgender, @Mladdr, " +
                    "@Memail, @Mmob, @Madhaar, @Moaddr, @Mdesign, @Salary, @Mpan, @Nname, @Nrelation, @Nage, @Nemail, @Nmob, @Nadhaar, @Gid, @Aid, @Bid, @Camt, @Lamt, @Dor)", con);
                cmd.Parameters.AddWithValue("@Mname", tb_add_m_name.Text);
                cmd.Parameters.AddWithValue("@Mdob", dtp_add_m_dob.Text);
                cmd.Parameters.AddWithValue("@Fname", tb_add_m_fname.Text);
                cmd.Parameters.AddWithValue("@Sname", tb_add_m_sname.Text);
                cmd.Parameters.AddWithValue("@Mage", tb_add_m_age.Text);
                cmd.Parameters.AddWithValue("@Mgender", cb_add_m_gender.Text);
                cmd.Parameters.AddWithValue("@Mladdr", tb_add_m_laddr.Text);
                cmd.Parameters.AddWithValue("@Memail", tb_add_m_memail.Text);
                cmd.Parameters.AddWithValue("@Mmob", tb_add_m_mmob.Text);
                cmd.Parameters.AddWithValue("@Madhaar", tb_add_m_madhaar.Text);
                cmd.Parameters.AddWithValue("@Moaddr", tb_add_m_oaddr.Text);
                cmd.Parameters.AddWithValue("@Mdesign", tb_add_m_mdesig.Text);
                cmd.Parameters.AddWithValue("@Salary", tb_add_m_msalary.Text);
                cmd.Parameters.AddWithValue("@Mpan", tb_add_m_mpan.Text);
                cmd.Parameters.AddWithValue("@Nname", tb_add_m_nname.Text);
                cmd.Parameters.AddWithValue("@Nrelation", tb_add_m_nrelation.Text);
                cmd.Parameters.AddWithValue("@Nage", tb_add_m_nage.Text);
                cmd.Parameters.AddWithValue("@Nemail", tb_add_m_nemail.Text);
                cmd.Parameters.AddWithValue("@Nmob", tb_add_m_nmob.Text);
                cmd.Parameters.AddWithValue("@Nadhaar", tb_add_m_nadhaar.Text);
                cmd.Parameters.AddWithValue("@Gid", tb_add_m_gid.Text);
                cmd.Parameters.AddWithValue("@Aid", tb_add_m_aid.Text);
                cmd.Parameters.AddWithValue("@Bid", tb_add_m_bid.Text);
                cmd.Parameters.AddWithValue("@Camt", tb_add_m_camt.Text);
                cmd.Parameters.AddWithValue("@Lamt", tb_add_m_lamt.Text);
                cmd.Parameters.AddWithValue("@Dor", dtp_add_m_dor.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_add_m_close_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }

        private void bt_add_m_clear_Click(object sender, EventArgs e)
        {
            tb_add_m_name.Clear();
            tb_add_m_fname.Clear();
            tb_add_m_sname.Clear();
            tb_add_m_age.Clear();
            cb_add_m_gender.Items.Clear();
            tb_add_m_laddr.Clear();
            tb_add_m_memail.Clear();
            tb_add_m_mmob.Clear();
            tb_add_m_madhaar.Clear();
            tb_add_m_oaddr.Clear();
            tb_add_m_mdesig.Clear();
            tb_add_m_msalary.Clear();
            tb_add_m_mpan.Clear();
            tb_add_m_nname.Clear();
            tb_add_m_nrelation.Clear();
            tb_add_m_nage.Clear();
            tb_add_m_nemail.Clear();
            tb_add_m_nmob.Clear();
            tb_add_m_nadhaar.Clear();
            tb_add_m_gid.Clear();
            tb_add_m_aid.Clear();
            tb_add_m_bid.Clear();
            tb_add_m_camt.Clear();
            tb_add_m_lamt.Clear();
        }

        private void tb_add_m_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_m_name.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_add_m_name.Text = tb_add_m_name.Text.Remove(tb_add_m_name.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_m_fname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_m_fname.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_add_m_fname.Text = tb_add_m_fname.Text.Remove(tb_add_m_fname.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_m_sname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_m_sname.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_add_m_sname.Text = tb_add_m_sname.Text.Remove(tb_add_m_sname.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_m_age_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_m_age.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid age.");
                    tb_add_m_age.Text = tb_add_m_age.Text.Remove(tb_add_m_age.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_m_mmob_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_m_mmob.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid mobile number.");
                    tb_add_m_mmob.Text = tb_add_m_mmob.Text.Remove(tb_add_m_mmob.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_m_madhaar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_m_madhaar.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid adhaar number.");
                    tb_add_m_madhaar.Text = tb_add_m_madhaar.Text.Remove(tb_add_m_madhaar.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_m_mdesig_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_m_mdesig.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid designation.");
                    tb_add_m_mdesig.Text = tb_add_m_mdesig.Text.Remove(tb_add_m_mdesig.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_m_msalary_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_m_msalary.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid amount.");
                    tb_add_m_msalary.Text = tb_add_m_msalary.Text.Remove(tb_add_m_msalary.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_m_nname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_m_nname.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_add_m_nname.Text = tb_add_m_nname.Text.Remove(tb_add_m_nname.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_m_nrelation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_m_nrelation.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid relation.");
                    tb_add_m_nrelation.Text = tb_add_m_nrelation.Text.Remove(tb_add_m_nrelation.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_m_nage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_m_nage.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid age.");
                    tb_add_m_nage.Text = tb_add_m_nage.Text.Remove(tb_add_m_nage.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_m_nmob_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_m_nmob.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid mobile number.");
                    tb_add_m_nmob.Text = tb_add_m_nmob.Text.Remove(tb_add_m_nmob.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_m_nadhaar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_m_nadhaar.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid adhaar number.");
                    tb_add_m_nadhaar.Text = tb_add_m_nadhaar.Text.Remove(tb_add_m_nadhaar.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_m_gid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_m_gid.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid id.");
                    tb_add_m_gid.Text = tb_add_m_gid.Text.Remove(tb_add_m_gid.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_m_aid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_m_aid.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid id.");
                    tb_add_m_aid.Text = tb_add_m_aid.Text.Remove(tb_add_m_aid.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_m_bid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_m_bid.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid id.");
                    tb_add_m_bid.Text = tb_add_m_bid.Text.Remove(tb_add_m_bid.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_m_camt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_m_camt.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid amount.");
                    tb_add_m_camt.Text = tb_add_m_camt.Text.Remove(tb_add_m_camt.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_m_lamt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_m_lamt.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid amount.");
                    tb_add_m_lamt.Text = tb_add_m_lamt.Text.Remove(tb_add_m_lamt.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
