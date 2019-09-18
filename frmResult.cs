using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candidate
{
    public partial class frmResult : Form
    {
        public frmResult()
        {
            InitializeComponent();
        }
        private void FrmResult_Load(object sender, EventArgs e)
        {        
            string s2;
            if (frmCandidateExam.lstResult[5] == "1")
            {
                s2 = "Təbriklər, siz imtahandan keçdiniz";
            }
            else
            {
                s2 = "İmtahandan keçə bilmədiniz";
            }
            string s1 = frmCandidateExam.lstResult[1] + " " + frmCandidateExam.lstResult[2] + ",  Pin:" + frmCandidateExam.lstResult[3];
            string s3 = "Topladığınız bal: " + frmCandidateExam.lstResult[4];                 
            lblCand.Text = s1;
            lbl1.Text = s2;
            lblPoint.Text = s3;
        }
        private void FrmResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
