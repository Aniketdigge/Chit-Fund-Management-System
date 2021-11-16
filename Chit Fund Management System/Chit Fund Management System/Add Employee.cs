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
    public partial class Add_Employee : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void bt_add_e_save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into EmployeeTB(Ename, EDob, Egname, Eage, Egender, Epaddr, Emstatus, Enationality, Edisability, Ebgroup, Eemail, Emob, " +
                    "Eadhaar, Equalification, Epassyear, Epercentage, Eworkexp, Especialization, EMname, EMaddr, EMemail, EMmob, EMrelation, Edepartment, Edesignation, " +
                    "Bid, Epan, Ebank, Eacno, Eifsc, Eactype, Doh) values(@Ename, @EDob, @Egname, @Eage, @Egender, @Epaddr, @Emstatus, @Enationality, @Edisability, " +
                    "@Ebgroup, @Eemail, @Emob, @Eadhaar, @Equalification, @Epassyear, @Epercentage, @Eworkexp, @Especialization, @EMname, @EMaddr, @EMemail, @EMmob, " +
                    "@EMrelation, @Edepartment, @Edesignation, @Bid, @Epan, @Ebank, @Eacno, @Eifsc, @Eactype, @Doh)", con);
                cmd.Parameters.AddWithValue("@Ename", tb_add_e_name.Text);
                cmd.Parameters.AddWithValue("@EDob", dtp_add_e_dob.Text);
                cmd.Parameters.AddWithValue("@Egname", tb_add_e_gname.Text);
                cmd.Parameters.AddWithValue("@Eage", tb_add_e_age.Text);
                cmd.Parameters.AddWithValue("@Egender", cb_add_e_gender.Text);
                cmd.Parameters.AddWithValue("@Epaddr", tb_add_e_paddr.Text);
                cmd.Parameters.AddWithValue("@Emstatus", cb_add_e_mstatus.Text);
                cmd.Parameters.AddWithValue("@Enationality", tb_add_e_nationality.Text);
                cmd.Parameters.AddWithValue("@Edisability", tb_add_e_Disability.Text);
                cmd.Parameters.AddWithValue("@Ebgroup", cb_add_e_bgroup.Text);
                cmd.Parameters.AddWithValue("@Eemail", tb_add_e_eemail.Text);
                cmd.Parameters.AddWithValue("@Emob", tb_add_e_emob.Text);
                cmd.Parameters.AddWithValue("@Eadhaar", tb_add_e_eadhaar.Text);
                cmd.Parameters.AddWithValue("@Equalification", tb_add_e_qualification.Text);
                cmd.Parameters.AddWithValue("@Epassyear", tb_add_e_passyear.Text);
                cmd.Parameters.AddWithValue("@Epercentage", tb_add_e_percentage.Text);
                cmd.Parameters.AddWithValue("@Eworkexp", tb_add_e_workexp.Text);
                cmd.Parameters.AddWithValue("@Especialization", tb_add_e_specialization.Text);
                cmd.Parameters.AddWithValue("@EMname", tb_add_e_emname.Text);
                cmd.Parameters.AddWithValue("@EMaddr", tb_add_e_emaddr.Text);
                cmd.Parameters.AddWithValue("@EMemail", tb_add_e_ememail.Text);
                cmd.Parameters.AddWithValue("@EMmob", tb_add_e_emmob.Text);
                cmd.Parameters.AddWithValue("@EMrelation", tb_add_e_relation.Text);
                cmd.Parameters.AddWithValue("@Edepartment", tb_add_e_department.Text);
                cmd.Parameters.AddWithValue("@Edesignation", tb_add_e_designation.Text);
                cmd.Parameters.AddWithValue("@Bid", tb_add_e_bid.Text);
                cmd.Parameters.AddWithValue("@Epan", tb_add_e_epan.Text);
                cmd.Parameters.AddWithValue("@Ebank", tb_add_e_bankname.Text);
                cmd.Parameters.AddWithValue("@Eacno", tb_add_e_acno.Text);
                cmd.Parameters.AddWithValue("@Eifsc", tb_add_e_ifsc.Text);
                cmd.Parameters.AddWithValue("@Eactype", tb_add_e_actype.Text);
                cmd.Parameters.AddWithValue("@Doh", dtp_add_e_doh.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_add_e_clear_Click(object sender, EventArgs e)
        {
            tb_add_e_name.Clear();
            tb_add_e_gname.Clear();
            tb_add_e_age.Clear();
            cb_add_e_gender.Items.Clear();
            tb_add_e_paddr.Clear();
            cb_add_e_mstatus.Items.Clear();
            tb_add_e_nationality.Clear();
            tb_add_e_Disability.Clear();
            cb_add_e_bgroup.Items.Clear();
            tb_add_e_eemail.Clear();
            tb_add_e_emob.Clear();
            tb_add_e_eadhaar.Clear();
            tb_add_e_qualification.Clear();
            tb_add_e_passyear.Clear();
            tb_add_e_percentage.Clear();
            tb_add_e_workexp.Clear();
            tb_add_e_specialization.Clear();
            tb_add_e_emname.Clear();
            tb_add_e_emaddr.Clear();
            tb_add_e_ememail.Clear();
            tb_add_e_emmob.Clear();
            tb_add_e_relation.Clear();
            tb_add_e_department.Clear();
            tb_add_e_designation.Clear();
            tb_add_e_bid.Clear();
            tb_add_e_epan.Clear();
            tb_add_e_bankname.Clear();
            tb_add_e_acno.Clear();
            tb_add_e_ifsc.Clear();
            tb_add_e_actype.Clear();
        }

        private void bt_add_e_close_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }

        private void tb_add_e_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_e_name.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_add_e_name.Text = tb_add_e_name.Text.Remove(tb_add_e_name.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_e_gname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_e_gname.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_add_e_gname.Text = tb_add_e_gname.Text.Remove(tb_add_e_gname.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_e_age_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_e_age.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid age.");
                    tb_add_e_age.Text = tb_add_e_age.Text.Remove(tb_add_e_age.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_e_nationality_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_e_nationality.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid nationality.");
                    tb_add_e_nationality.Text = tb_add_e_nationality.Text.Remove(tb_add_e_nationality.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_e_emob_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_e_emob.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid mobile number.");
                    tb_add_e_emob.Text = tb_add_e_emob.Text.Remove(tb_add_e_emob.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_e_eadhaar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_e_eadhaar.Text, "[^0-9 ]"))
                {
                    MessageBox.Show("Please enter valid adhaar number.");
                    tb_add_e_eadhaar.Text = tb_add_e_eadhaar.Text.Remove(tb_add_e_eadhaar.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_e_qualification_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_e_qualification.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid qualification.");
                    tb_add_e_qualification.Text = tb_add_e_qualification.Text.Remove(tb_add_e_qualification.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_e_passyear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_e_passyear.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid year.");
                    tb_add_e_passyear.Text = tb_add_e_passyear.Text.Remove(tb_add_e_passyear.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_e_workexp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_e_workexp.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid year count.");
                    tb_add_e_workexp.Text = tb_add_e_workexp.Text.Remove(tb_add_e_workexp.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_e_specialization_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_e_specialization.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid specialization.");
                    tb_add_e_specialization.Text = tb_add_e_specialization.Text.Remove(tb_add_e_specialization.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_e_emname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_e_emname.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_add_e_emname.Text = tb_add_e_emname.Text.Remove(tb_add_e_emname.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_e_emmob_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_e_emmob.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid mobile no.");
                    tb_add_e_emmob.Text = tb_add_e_emmob.Text.Remove(tb_add_e_emmob.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_e_relation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_e_relation.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid relation.");
                    tb_add_e_relation.Text = tb_add_e_relation.Text.Remove(tb_add_e_relation.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_e_department_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_e_department.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid department.");
                    tb_add_e_department.Text = tb_add_e_department.Text.Remove(tb_add_e_department.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_e_designation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_e_designation.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid designation.");
                    tb_add_e_designation.Text = tb_add_e_designation.Text.Remove(tb_add_e_designation.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_e_bid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_e_bid.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid id.");
                    tb_add_e_bid.Text = tb_add_e_bid.Text.Remove(tb_add_e_bid.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_e_bankname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_e_bankname.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_add_e_bankname.Text = tb_add_e_bankname.Text.Remove(tb_add_e_bankname.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_e_acno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_e_acno.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid A/C number.");
                    tb_add_e_acno.Text = tb_add_e_acno.Text.Remove(tb_add_e_acno.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_add_e_actype_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_add_e_actype.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid A/C type.");
                    tb_add_e_actype.Text = tb_add_e_actype.Text.Remove(tb_add_e_actype.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
