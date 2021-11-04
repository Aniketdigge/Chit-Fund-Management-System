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
                cmd = new OleDbCommand("insert into MemberTB(Mname, Mdob, Fname, Sname, Mage, Mgender, Mladdr, Memail, Mmob, Madhaar, Moaddr, Mdesign, Salary, Mpan, Nname, " +
                    "Nrelation, Nage, Nemail, Nmob, Nadhaar) values(@Mname, @Mdob, @Fname, @Sname, @Mage, @Mgender, @Mladdr, @Memail, @Memail, @Mmob, @Madhaar, @Moaddr, " +
                    "@Mdesign, @Salary, @Mpan, @Nname, @Nrelation, @Nage, @Nmob, @Nadhaar)", con);
                cmd.Parameters.AddWithValue("@branchaddress", tb_branch_address_add_branch.Text);
                cmd.Parameters.AddWithValue("@branchcity", tb_branch_city_add_branch.Text);
                cmd.Parameters.AddWithValue("@pincode", tb_branch_pincode_add_branch.Text);
                cmd.Parameters.AddWithValue("@branchmanager", tb_branch_manager_add_branch.Text);
                cmd.Parameters.AddWithValue("@branchemail", tb_branch_email_add_branch.Text);
                cmd.Parameters.AddWithValue("@branchphoneno", tb_branch_phone_add_branch.Text);
                cmd.Parameters.AddWithValue("@headofficeaddr", tb_branch_headoffice_address_add_branch.Text);
                cmd.Parameters.AddWithValue("@dateofregistration", dtp_date_of_registration_add_branch.Text);
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
        }
    }
}
