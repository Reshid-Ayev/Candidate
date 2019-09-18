using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candidate
{
    public partial class frmCandidateLogin : Form
    {
        public frmCandidateLogin()
        {
            InitializeComponent();
        }
        SqlConnect sqlconnect = new SqlConnect();
        public static int candidatID;
        public static DateTime loginDate;
           
        private void FrmCandidateLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();   
        }
        private void BtnCandidateLogin_Click(object sender, EventArgs e)
        {
            try
            {                
                lblCandidateNote.Text = "";
                if (txtCandidatePassword.Text == "")
                {
                    lblCandidateNote.Text = "Parolu daxil edin!";
                    return;
                }
                string query = "Select * from Candidate c where   c.Password=@password";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());
                cmd.Parameters.AddWithValue("@password", txtCandidatePassword.Text);
                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                if (dt.Rows.Count != 0)
                {
                    candidatID = Int32.Parse(Convert.ToString(dt.Rows[0]["ID"]));
                    loginDate = DateTime.Now;
                    sqlconnect.close();
                    this.Hide();
                    frmCandidateExam frmCandidateExam = new frmCandidateExam();
                    frmCandidateExam.Show();
                }
                else
                {
                    lblCandidateNote.Text = "Parol yalnışdır!";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
        }
    }
}
