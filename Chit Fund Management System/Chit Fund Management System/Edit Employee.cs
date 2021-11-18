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
                int Eid = int.Parse(tb_edit_e_eid.Text);
                con.Open();
                cmd = new OleDbCommand("update EmployeeTB set Ename='" + tb_edit_e_name.Text + "', EDob='"+ dtp_edit_e_dob.Text + "', " +
                    "Egname='"+ tb_edit_e_gname.Text + "', Eage='"+ tb_edit_e_age.Text + "', Egender='"+ cb_edit_e_gender.Text + "', " +
                    "Epaddr='"+ tb_edit_e_paddr.Text + "', Emstatus='"+ cb_edit_e_mstatus.Text + "', Enationality='"+ tb_edit_e_nationality.Text + "', " +
                    "Edisability='"+ tb_edit_e_Disability.Text + "', Ebgroup='"+ cb_edit_e_bgroup.Text + "', Eemail='"+ tb_edit_e_eemail.Text + "', " +
                    "Emob='"+ tb_edit_e_emob.Text + "', Eadhaar='"+ tb_edit_e_eadhaar.Text + "', Equalification='"+ tb_edit_e_qualification.Text + "', " +
                    "Epassyear='"+ tb_edit_e_passyear.Text + "', Epercentage='"+ tb_edit_e_percentage.Text + "', Eworkexp='"+ tb_edit_e_workexp.Text + "', " +
                    "Especialization='"+ tb_edit_e_specialization.Text + "', EMname='"+ tb_edit_e_emname.Text + "', EMaddr='"+ tb_edit_e_emaddr.Text + "', " +
                    "EMemail='"+ tb_edit_e_ememail.Text + "', EMmob='"+ tb_edit_e_emmob.Text + "', EMrelation='"+ tb_edit_e_relation.Text + "', " +
                    "Edepartment='"+ tb_edit_e_department.Text + "', Edesignation='"+ tb_edit_e_designation.Text + "', Bid='"+ tb_edit_e_bid.Text + "', " +
                    "Epan='"+ tb_edit_e_epan.Text + "', Ebank='"+ tb_edit_e_bankname.Text + "', Eacno='"+ tb_edit_e_acno.Text + "', " +
                    "Eifsc='"+ tb_edit_e_ifsc.Text + "', Eactype='"+ tb_edit_e_actype.Text + "', Doh='"+ dtp_edit_e_doh.Text + "' where " +
                    "Eid="+ Eid , con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update successfully....");
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
            tb_edit_e_paddr.Clear();
            tb_edit_e_nationality.Clear();
            tb_edit_e_Disability.Clear();
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
