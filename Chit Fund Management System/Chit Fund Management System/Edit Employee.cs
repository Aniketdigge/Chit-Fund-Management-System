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
    public partial class Edit_Employee : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chit-Fund-Management-System\ChitFundDB.accdb");
        OleDbCommand cmd;
        public Edit_Employee()
        {
            InitializeComponent();
        }

        private void bt_edit_e_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("update EmployeeTB Ename=@Ename, EDob=@EDob, Egname=@Egname, Eage=@Eage, Egender=@Egender, Epaddr=@Epaddr, Emstatus=@Emstatus, " +
                    "Enationality=@Enationality, Edisability=@Edisability, Ebgroup=@Ebgroup, Eemail=@Eemail, Emob=@Emob, Eadhaar=@Eadhaar, " +
                    "Equalification=@Equalification, Epassyear=@Epassyear, Epercentage=@Epercentage, Eworkexp=@Eworkexp, Especialization=@Especialization, " +
                    "EMname=@EMname, EMaddr=@EMaddr, EMemail=@EMemail, EMmob=@EMmob, EMrelation=@EMrelation, Edepartment=@Edepartment, Edesignation=@Edesignation, " +
                    "Bid=@Bid, Epan=@Epan, Ebank=@Ebank, Eacno=@Eacno, Eifsc=@Eifsc, Eactype=@Eactype, Doh=@Doh where Eid=@Eid", con);
                cmd.Parameters.AddWithValue("@Eid", tb_edit_e_eid.Text);
                cmd.Parameters.AddWithValue("@Ename", tb_edit_e_name.Text);
                cmd.Parameters.AddWithValue("@EDob", dtp_edit_e_dob.Text);
                cmd.Parameters.AddWithValue("@Egname", tb_edit_e_gname.Text);
                cmd.Parameters.AddWithValue("@Eage", tb_edit_e_age.Text);
                cmd.Parameters.AddWithValue("@Egender", cb_edit_e_gender.Text);
                cmd.Parameters.AddWithValue("@Epaddr", tb_edit_e_paddr.Text);
                cmd.Parameters.AddWithValue("@Emstatus", cb_edit_e_mstatus.Text);
                cmd.Parameters.AddWithValue("@Enationality", tb_edit_e_nationality.Text);
                cmd.Parameters.AddWithValue("@Edisability", tb_edit_e_Disability.Text);
                cmd.Parameters.AddWithValue("@Ebgroup", cb_edit_e_bgroup.Text);
                cmd.Parameters.AddWithValue("@Eemail", tb_edit_e_eemail.Text);
                cmd.Parameters.AddWithValue("@Emob", tb_edit_e_emob.Text);
                cmd.Parameters.AddWithValue("@Eadhaar", tb_edit_e_eadhaar.Text);
                cmd.Parameters.AddWithValue("@Equalification", tb_edit_e_qualification.Text);
                cmd.Parameters.AddWithValue("@Epassyear", tb_edit_e_passyear.Text);
                cmd.Parameters.AddWithValue("@Epercentage", tb_edit_e_percentage.Text);
                cmd.Parameters.AddWithValue("@Eworkexp", tb_edit_e_workexp.Text);
                cmd.Parameters.AddWithValue("@Especialization", tb_edit_e_specialization.Text);
                cmd.Parameters.AddWithValue("@EMname", tb_edit_e_emname.Text);
                cmd.Parameters.AddWithValue("@EMaddr", tb_edit_e_emaddr.Text);
                cmd.Parameters.AddWithValue("@EMemail", tb_edit_e_ememail.Text);
                cmd.Parameters.AddWithValue("@EMmob", tb_edit_e_emmob.Text);
                cmd.Parameters.AddWithValue("@EMrelation", tb_edit_e_relation.Text);
                cmd.Parameters.AddWithValue("@Edepartment", tb_edit_e_department.Text);
                cmd.Parameters.AddWithValue("@Edesignation", tb_edit_e_designation.Text);
                cmd.Parameters.AddWithValue("@Bid", tb_edit_e_bid.Text);
                cmd.Parameters.AddWithValue("@Epan", tb_edit_e_epan.Text);
                cmd.Parameters.AddWithValue("@Ebank", tb_edit_e_bankname.Text);
                cmd.Parameters.AddWithValue("@Eacno", tb_edit_e_acno.Text);
                cmd.Parameters.AddWithValue("@Eifsc", tb_edit_e_ifsc.Text);
                cmd.Parameters.AddWithValue("@Eactype", tb_edit_e_actype.Text);
                cmd.Parameters.AddWithValue("@Doh", dtp_edit_e_doh.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved successfully....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_edit_e_search_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataReader dr;
                DataTable dt = new DataTable();
                con.Open();
                cmd = new OleDbCommand("select * from EmployeeTB where [Eid]=@Eid", con);
                cmd.Parameters.AddWithValue("@Eid", tb_edit_e_eid.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tb_edit_e_name.Text = (dr["Ename"].ToString());
                    dtp_edit_e_dob.Text = (dr["EDob"].ToString());
                    tb_edit_e_gname.Text = (dr["Egname"].ToString());
                    tb_edit_e_age.Text = (dr["Eage"].ToString());
                    cb_edit_e_gender.Text = (dr["Egender"].ToString());
                    tb_edit_e_paddr.Text = (dr["Epaddr"].ToString());
                    cb_edit_e_mstatus.Text = (dr["Emstatus"].ToString());
                    tb_edit_e_nationality.Text = (dr["Enationality"].ToString());
                    tb_edit_e_Disability.Text = (dr["Edisability"].ToString());
                    cb_edit_e_bgroup.Text = (dr["Ebgroup"].ToString());
                    tb_edit_e_eemail.Text = (dr["Eemail"].ToString());
                    tb_edit_e_emob.Text = (dr["Emob"].ToString());
                    tb_edit_e_eadhaar.Text = (dr["Eadhaar"].ToString());
                    tb_edit_e_qualification.Text = (dr["Equalification"].ToString());
                    tb_edit_e_passyear.Text = (dr["Epassyear"].ToString());
                    tb_edit_e_percentage.Text = (dr["Epercentage"].ToString());
                    tb_edit_e_workexp.Text = (dr["Eworkexp"].ToString());
                    tb_edit_e_specialization.Text = (dr["Especialization"].ToString());
                    tb_edit_e_emname.Text = (dr["EMname"].ToString());
                    tb_edit_e_emaddr.Text = (dr["EMaddr"].ToString());
                    tb_edit_e_ememail.Text = (dr["EMemail"].ToString());
                    tb_edit_e_emmob.Text = (dr["EMmob"].ToString());
                    tb_edit_e_relation.Text = (dr["EMrelation"].ToString());
                    tb_edit_e_department.Text = (dr["Edepartment"].ToString());
                    tb_edit_e_designation.Text = (dr["Edesignation"].ToString());
                    tb_edit_e_bid.Text = (dr["Bid"].ToString());
                    tb_edit_e_epan.Text = (dr["Epan"].ToString());
                    tb_edit_e_bankname.Text = (dr["Ebank"].ToString());
                    tb_edit_e_acno.Text = (dr["Eacno"].ToString());
                    tb_edit_e_ifsc.Text = (dr["Eifsc"].ToString());
                    tb_edit_e_actype.Text = (dr["Eactype"].ToString());
                    dtp_edit_e_doh.Text = (dr["Doh"].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_edit_e_del_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("delete from EmployeeTB where Eid=@Eid", con);
                cmd.Parameters.AddWithValue("@Aid", tb_edit_e_eid.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Successfully....");

                tb_edit_e_eid.Clear();
                tb_edit_e_name.Clear();
                tb_edit_e_gname.Clear();
                tb_edit_e_age.Clear();
                cb_edit_e_gender.Items.Clear();
                tb_edit_e_paddr.Clear();
                cb_edit_e_mstatus.Items.Clear();
                tb_edit_e_nationality.Clear();
                tb_edit_e_Disability.Clear();
                cb_edit_e_bgroup.Items.Clear();
                tb_edit_e_eemail.Clear();
                tb_edit_e_emob.Clear();
                tb_edit_e_eadhaar.Clear();
                tb_edit_e_qualification.Clear();
                tb_edit_e_passyear.Clear();
                tb_edit_e_percentage.Clear();
                tb_edit_e_workexp.Clear();
                tb_edit_e_specialization.Clear();
                tb_edit_e_emname.Clear();
                tb_edit_e_emaddr.Clear();
                tb_edit_e_ememail.Clear();
                tb_edit_e_emmob.Clear();
                tb_edit_e_relation.Clear();
                tb_edit_e_department.Clear();
                tb_edit_e_designation.Clear();
                tb_edit_e_bid.Clear();
                tb_edit_e_epan.Clear();
                tb_edit_e_bankname.Clear();
                tb_edit_e_acno.Clear();
                tb_edit_e_ifsc.Clear();
                tb_edit_e_actype.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_edit_e_clear_Click(object sender, EventArgs e)
        {
            tb_edit_e_eid.Clear();
            tb_edit_e_name.Clear();
            tb_edit_e_gname.Clear();
            tb_edit_e_age.Clear();
            cb_edit_e_gender.Items.Clear();
            tb_edit_e_paddr.Clear();
            cb_edit_e_mstatus.Items.Clear();
            tb_edit_e_nationality.Clear();
            tb_edit_e_Disability.Clear();
            cb_edit_e_bgroup.Items.Clear();
            tb_edit_e_eemail.Clear();
            tb_edit_e_emob.Clear();
            tb_edit_e_eadhaar.Clear();
            tb_edit_e_qualification.Clear();
            tb_edit_e_passyear.Clear();
            tb_edit_e_percentage.Clear();
            tb_edit_e_workexp.Clear();
            tb_edit_e_specialization.Clear();
            tb_edit_e_emname.Clear();
            tb_edit_e_emaddr.Clear();
            tb_edit_e_ememail.Clear();
            tb_edit_e_emmob.Clear();
            tb_edit_e_relation.Clear();
            tb_edit_e_department.Clear();
            tb_edit_e_designation.Clear();
            tb_edit_e_bid.Clear();
            tb_edit_e_epan.Clear();
            tb_edit_e_bankname.Clear();
            tb_edit_e_acno.Clear();
            tb_edit_e_ifsc.Clear();
            tb_edit_e_actype.Clear();
        }

        private void bt_edit_e_close_Click(object sender, EventArgs e)
        {
            f_chit_fund_dash_board f_Chit_Fund_Dash_Board = new f_chit_fund_dash_board();
            f_Chit_Fund_Dash_Board.Show();
            this.Hide();
        }

        private void tb_edit_e_eid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_e_eid.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid age.");
                    tb_edit_e_eid.Text = tb_edit_e_eid.Text.Remove(tb_edit_e_eid.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_e_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_e_name.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_edit_e_name.Text = tb_edit_e_name.Text.Remove(tb_edit_e_name.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_e_gname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_e_gname.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_edit_e_gname.Text = tb_edit_e_gname.Text.Remove(tb_edit_e_gname.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_e_age_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_e_age.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid age.");
                    tb_edit_e_age.Text = tb_edit_e_age.Text.Remove(tb_edit_e_age.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_e_nationality_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_e_nationality.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid nationality.");
                    tb_edit_e_nationality.Text = tb_edit_e_nationality.Text.Remove(tb_edit_e_nationality.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_e_emob_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_e_emob.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid mobile number.");
                    tb_edit_e_emob.Text = tb_edit_e_emob.Text.Remove(tb_edit_e_emob.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_e_eadhaar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_e_eadhaar.Text, "[^0-9 ]"))
                {
                    MessageBox.Show("Please enter valid adhaar number.");
                    tb_edit_e_eadhaar.Text = tb_edit_e_eadhaar.Text.Remove(tb_edit_e_eadhaar.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_e_qualification_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_e_qualification.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid qualification.");
                    tb_edit_e_qualification.Text = tb_edit_e_qualification.Text.Remove(tb_edit_e_qualification.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_e_passyear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_e_passyear.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid year.");
                    tb_edit_e_passyear.Text = tb_edit_e_passyear.Text.Remove(tb_edit_e_passyear.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_e_workexp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_e_workexp.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid year count.");
                    tb_edit_e_workexp.Text = tb_edit_e_workexp.Text.Remove(tb_edit_e_workexp.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_e_specialization_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_e_specialization.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid specialization.");
                    tb_edit_e_specialization.Text = tb_edit_e_specialization.Text.Remove(tb_edit_e_specialization.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_e_emname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_e_emname.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_edit_e_emname.Text = tb_edit_e_emname.Text.Remove(tb_edit_e_emname.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_e_emmob_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_e_emmob.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid mobile no.");
                    tb_edit_e_emmob.Text = tb_edit_e_emmob.Text.Remove(tb_edit_e_emmob.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_e_relation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_e_relation.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid relation.");
                    tb_edit_e_relation.Text = tb_edit_e_relation.Text.Remove(tb_edit_e_relation.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_e_department_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_e_department.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid department.");
                    tb_edit_e_department.Text = tb_edit_e_department.Text.Remove(tb_edit_e_department.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_e_designation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_e_designation.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid designation.");
                    tb_edit_e_designation.Text = tb_edit_e_designation.Text.Remove(tb_edit_e_designation.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_e_bid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_e_bid.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid id.");
                    tb_edit_e_bid.Text = tb_edit_e_bid.Text.Remove(tb_edit_e_bid.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_e_bankname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_e_bankname.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid name.");
                    tb_edit_e_bankname.Text = tb_edit_e_bankname.Text.Remove(tb_edit_e_bankname.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_e_acno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_e_acno.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter valid A/C number.");
                    tb_edit_e_acno.Text = tb_edit_e_acno.Text.Remove(tb_edit_e_acno.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_edit_e_actype_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_edit_e_actype.Text, "[^a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid A/C type.");
                    tb_edit_e_actype.Text = tb_edit_e_actype.Text.Remove(tb_edit_e_actype.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
