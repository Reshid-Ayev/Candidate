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
    public partial class frmCandidateExam : Form
    {
        public frmCandidateExam()
        {
            InitializeComponent();
        }
        SqlConnect sqlconnect = new SqlConnect();
        private int exam_ID;
        private int topic_ID;
        private int test_Count;
        private string Period = "";
        private int time, hour, minute, second;
        private int examProcess_ID;
        private List<int> lstTest_ID = new List<int>();
        private int[] randomArray;
        private RadioButton[] rdbtn;
        private int index = 0;
        private int point = 0, Min_Point = 0;
        List<Test> test = new List<Test>();
        Test current_test = new Test();
        public static List<string> lstResult;
        private void FrmCandidateExam_Load(object sender, EventArgs e)
        {
            getExamID();
        }
        private void setTime()
        {
            time = Convert.ToInt32(Period);
            if (time > 60)
            {
                hour = time / 60;
                minute = time % 60;
                second = 0;
            }
            else
            {
                hour = 0;
                minute = time;
                second = 0;
            }
        }
        private void getExamID()
        {
            try
            {
                string query = @"select id, topic_id, test_count,min_point,period from exam
                                 where group_id in (select group_id from group_candidate where candidate_id=@candidate_id)
                                 and begin_date=@login_date
                                 and (@login_time between begin_time and @end_time)";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());
                cmd.Parameters.AddWithValue("@Candidate_ID", frmCandidateLogin.candidatID);
                cmd.Parameters.AddWithValue("@Login_date", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@Login_time", DateTime.Now.ToString("hh:mm tt"));
                cmd.Parameters.AddWithValue("@End_time", DateTime.Now.AddMinutes(50).ToString("hh:mm tt"));
                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                if (dt.Rows.Count != 0)
                {
                    exam_ID = Int32.Parse(Convert.ToString(dt.Rows[0]["ID"]));
                    topic_ID = Int32.Parse(Convert.ToString(dt.Rows[0]["Topic_ID"]));
                    test_Count = Int32.Parse(Convert.ToString(dt.Rows[0]["Test_Count"]));
                    Min_Point = Int32.Parse(Convert.ToString(dt.Rows[0]["Min_point"]));
                    Period = dt.Rows[0]["Period"].ToString();
                    sqlconnect.close();
                    checkExam();
                    setExamProcess();
                    getExamProcessID();
                    getTestIDCount();
                    getRandomNumbers(lstTest_ID.Count, test_Count, ref randomArray);
                    fillExamTests(ref randomArray);
                    createRadioButton();
                    getSetExamTests();
                    rdbtn[0].Checked = true;
                    timerExam.Enabled = true;
                    setTime();
                }
                else
                {
                    MessageBox.Show("İmtahan aktiv deyil");
                    frmCandidateLogin login = new frmCandidateLogin();
                    login.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
        }
        private void checkExam()
        {
            try
            {
                string query = "select event from Exam_process where Candidate_ID=@Candidate_ID and Exam_ID=@Exam_ID";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());
                cmd.Parameters.AddWithValue("@Exam_ID", exam_ID);
                cmd.Parameters.AddWithValue("@Candidate_ID", frmCandidateLogin.candidatID);
                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                if (dt.Rows.Count != 0)
                {
                    int Event = Int32.Parse(Convert.ToString(dt.Rows[0]["Event"]));
                    if (Event == 1)
                    {
                        MessageBox.Show("İmtahan artıq keçirilib!");
                        frmCandidateLogin login = new frmCandidateLogin();
                        login.Show();
                        this.Hide();
                    }
                }
                sqlconnect.close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
        }
        private void setExamProcess()
        {
            try
            {
                string query = "insert into Exam_process(Exam_ID,Candidate_ID,Event) values(@Exam_ID,@Candidate_ID,1)";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());
                cmd.Parameters.AddWithValue("@Exam_ID", exam_ID);
                cmd.Parameters.AddWithValue("@Candidate_ID", frmCandidateLogin.candidatID);
                cmd.ExecuteNonQuery();
                sqlconnect.close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
        }
        private void getExamProcessID()
        {
            try
            {
                string query = "select MAX(ID) as ID from Exam_process where Exam_ID=@Exam_ID and Candidate_ID=@Candidate_ID and Event=1";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());
                cmd.Parameters.AddWithValue("@Exam_ID", exam_ID);
                cmd.Parameters.AddWithValue("@Candidate_ID", frmCandidateLogin.candidatID);
                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                if (dt.Rows.Count != 0)
                {
                    examProcess_ID = Int32.Parse(Convert.ToString(dt.Rows[0]["ID"]));
                    sqlconnect.close();
                }
                else
                {
                    MessageBox.Show("İmtahan tapılmadı");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
        }
        private void getTestIDCount()
        {
            try
            {
                string query = "select ID from Test where Topic_ID=@Topic_ID";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());
                cmd.Parameters.AddWithValue("@Topic_ID", topic_ID);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lstTest_ID.Add(Convert.ToInt32(rd[0].ToString()));
                }
                sqlconnect.close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
        }
        private void getRandomNumbers(int testIDCount, int testCount, ref int[] randomArray)
        {
            if (testIDCount < testCount)
            {
                MessageBox.Show("Bazada lazımi qədər test yoxdur!!!");
                return;
            }
            int i = 0;
            bool t = true;
            Random rd = new Random();
            randomArray = new int[testCount];
            for (; ; )
            {
                if (i == testCount)
                {
                    break;
                }
                t = true;
                randomArray[i] = Convert.ToInt32(rd.Next(0, testIDCount).ToString());
                for (int j = 0; j < i; j++)
                {
                    if (randomArray[j] != randomArray[i])
                    {
                        t = true;
                        continue;
                    }
                    else
                    {
                        t = false;
                        break;
                    }
                }
                if (t)
                {
                    i++;
                }
            }
        }
        private void createRadioButton()
        {
            int h = 5;
            rdbtn = new RadioButton[test_Count];
            for (int i = 0; i < test_Count; i++)
            {
                RadioButton rdo = new RadioButton();
                rdo.Name = "id";
                rdo.Text = " " + (i + 1).ToString();
                rdo.ForeColor = Color.Red;
                rdo.Location = new Point(20, h);
                rdo.BackColor = Color.LightSkyBlue;
                rdo.CheckedChanged += new System.EventHandler(this.Rdo_CheckedChanged);
                pnlTestRadioBtn.Controls.Add(rdo);
                h += 29;
                rdbtn[i] = rdo;
            }
        }
        private void getSetExamTests()
        {
            try
            {
                for (int i = 0; i < test_Count; i++)
                {
                    string query = " insert into Exam_test(Exam_process_ID,Test_ID) values(@Exam_process_ID,@Test_ID)";
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand(query, sqlconnect.connect());
                    cmd.Parameters.AddWithValue("@Exam_process_ID", examProcess_ID);
                    cmd.Parameters.AddWithValue("@Test_ID", lstTest_ID[randomArray[i]]);
                    cmd.ExecuteNonQuery();
                    sqlconnect.close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
        }
        private void fillExamTests(ref int[] randomArray)
        {
            try
            {
                for (int i = 0; i < test_Count; i++)
                {
                    string query = "select * from Test where ID=@Test_ID";
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand(query, sqlconnect.connect());
                    cmd.Parameters.AddWithValue("@Test_ID", lstTest_ID[randomArray[i]]);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        test.Add(new Test(Convert.ToInt32(rd["ID"].ToString()),
                                          rd["Title"].ToString(),
                                          rd["Variant_A"].ToString(),
                                          rd["Variant_B"].ToString(),
                                          rd["Variant_C"].ToString(),
                                          rd["Variant_D"].ToString(),
                                          rd["Variant_E"].ToString(),
                                          rd["True_variant"].ToString()));

                    }
                    sqlconnect.close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
        }
        private void updateAllTests()
        {
            for (int i = 0; i < test_Count; i++)
            {
                try
                {
                    if (test[i].trueV != "F")
                    {
                        if (test[i].trueV == test[i].realTrueV)
                        {
                            point++;
                        }
                        string query = " update  Exam_test set Selection_variant=@Selection_variant where Exam_process_ID=@Exam_process_ID and Test_ID=@Test_ID";
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand(query, sqlconnect.connect());
                        cmd.Parameters.AddWithValue("@Selection_variant", test[i].trueV);
                        cmd.Parameters.AddWithValue("@Exam_process_ID", examProcess_ID);
                        cmd.Parameters.AddWithValue("@Test_ID", test[i].ID);
                        cmd.ExecuteNonQuery();
                        sqlconnect.close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
                }
            }
        }
        private List<string> getResult()
        {
            List<string> lstResult = new List<string>();
            try
            {
                string query = @"select e.Name as exam_name, c.Surname as cSurname, c.Name as cName,c.Pin as cPin from Candidate as c, Exam e 
                                 where c.ID = @cID and e.ID = @eID";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());
                cmd.Parameters.AddWithValue("@eID", exam_ID);
                cmd.Parameters.AddWithValue("@cID", frmCandidateLogin.candidatID);
                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                if (dt.Rows.Count != 0)
                {
                    lstResult.Add(Convert.ToString(dt.Rows[0]["exam_name"]));
                    lstResult.Add(Convert.ToString(dt.Rows[0]["cSurname"]));
                    lstResult.Add(Convert.ToString(dt.Rows[0]["cName"]));
                    lstResult.Add(Convert.ToString(dt.Rows[0]["cPin"]));
                    lstResult.Add(Convert.ToString(point));
                    if (point >= Min_Point)
                    {
                        lstResult.Add("1");
                    }
                    else
                    {
                        lstResult.Add("0");
                    }
                }
                sqlconnect.close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
            return lstResult;
        }
        private void insertResult()
        {
            lstResult = getResult();
            try
            {
                string query = "insert into Result values(@Exam_process_ID,@Exam_name,@Name,@Surname,@Pin,@Point,@Passed)";
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(query, sqlconnect.connect());
                cmd.Parameters.AddWithValue("@Exam_process_ID", Convert.ToInt32(examProcess_ID));
                cmd.Parameters.AddWithValue("@Exam_name", lstResult[0].ToString());
                cmd.Parameters.AddWithValue("@Name", lstResult[1].ToString());
                cmd.Parameters.AddWithValue("@Surname", lstResult[2].ToString());
                cmd.Parameters.AddWithValue("@Pin", lstResult[3]);
                cmd.Parameters.AddWithValue("@Point", Convert.ToInt32(lstResult[4]));
                cmd.Parameters.AddWithValue("@Passed", Convert.ToInt32(lstResult[5]));
                cmd.ExecuteNonQuery();
                sqlconnect.close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
            }
        }
        public void showResult()
        {
            lstResult.Add(point.ToString());
            frmResult frmResult = new frmResult();
            frmResult.ShowDialog();
        }
        private void FrmCandidateExam_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Rdo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            if (rd.Checked)
            {
                index = Convert.ToInt32(rd.Text) - 1;
                if (index == test_Count - 1)
                {
                    btnNext.Text = "İmtahanı bitirmək";
                }
                else
                {
                    btnNext.Text = "Növbəti";
                }
                if (index == 0)
                {
                    btnPrevious.Enabled = false;
                }
                else
                {
                    btnPrevious.Enabled = true;
                }
                current_test = test[index];
                rchtxtTestTitle.Text = current_test.title;
                rchtxtTestVariantA.Text = current_test.vA;
                rchtxtTestVariantB.Text = current_test.vB;
                rchtxtTestVariantC.Text = current_test.vC;
                rchtxtTestVariantD.Text = current_test.vD;
                rchtxtTestVariantE.Text = current_test.vE;
                lblTestTitle.Text = "Sual " + (index + 1).ToString();
                if (current_test.trueV == "A")
                {
                    rdbtnA.Checked = true;
                }
                else if (current_test.trueV == "B")
                {
                    rdbtnB.Checked = true;
                }
                else if (current_test.trueV == "C")
                {
                    rdbtnC.Checked = true;
                }
                else if (current_test.trueV == "D")
                {
                    rdbtnD.Checked = true;
                }
                else if (current_test.trueV == "E")
                {
                    rdbtnE.Checked = true;
                }
                else
                {
                    rdbtnA.Checked = rdbtnB.Checked = rdbtnC.Checked = rdbtnD.Checked = rdbtnE.Checked = false;
                }

            }
            if (!rd.Checked)
            {
                string s = "";
                if (rdbtnA.Checked)
                {
                    s = "A";
                }
                if (rdbtnB.Checked)
                {
                    s = "B";
                }
                if (rdbtnC.Checked)
                {
                    s = "C";
                }
                if (rdbtnD.Checked)
                {
                    s = "D";
                }
                if (rdbtnE.Checked)
                {
                    s = "E";
                }
                try
                {
                    if (s != "")
                    {
                        string query = " update  Exam_test set Selection_variant=@Selection_variant where Exam_process_ID=@Exam_process_ID and Test_ID=@Test_ID";
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand(query, sqlconnect.connect());
                        cmd.Parameters.AddWithValue("@Selection_variant", s);
                        cmd.Parameters.AddWithValue("@Exam_process_ID", examProcess_ID);
                        cmd.Parameters.AddWithValue("@Test_ID", current_test.ID);
                        cmd.ExecuteNonQuery();
                        sqlconnect.close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sistemdə xəta baş verdi, təkrar cəhd edin");
                }
            }
            if (current_test.trueV != "F")
            {
                rd.BackColor = Color.LightSteelBlue;
            }
            else
            {
                rd.BackColor = Color.LightSkyBlue;
            }
        }
        private void RdbtnA_Click(object sender, EventArgs e)
        {
            if (rdbtnA.Checked && current_test.trueV == rdbtnA.Text)
            {
                rdbtnA.Checked = false;
                current_test.trueV = "F";
            }
            else
            {
                current_test.trueV = rdbtnA.Text;
            }
        }
        private void RdbtnB_Click(object sender, EventArgs e)
        {
            if (rdbtnB.Checked && current_test.trueV == rdbtnB.Text)
            {
                rdbtnB.Checked = false;
                current_test.trueV = "F";
            }
            else
            {
                current_test.trueV = rdbtnB.Text;
            }
        }
        private void RdbtnC_Click(object sender, EventArgs e)
        {
            if (rdbtnC.Checked && current_test.trueV == rdbtnC.Text)
            {
                rdbtnC.Checked = false;
                current_test.trueV = "F";
            }
            else
            {
                current_test.trueV = rdbtnC.Text;
            }
        }
        private void RdbtnD_Click(object sender, EventArgs e)
        {
            if (rdbtnD.Checked && current_test.trueV == rdbtnD.Text)
            {
                rdbtnD.Checked = false;
                current_test.trueV = "F";
            }
            else
            {
                current_test.trueV = rdbtnD.Text;
            }
        }

        private void LblTestVariantE_Click(object sender, EventArgs e)
        {

        }

        private void RchtxtTestVariantD_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblTestVariantD_Click(object sender, EventArgs e)
        {

        }

        private void RchtxtTestVariantE_TextChanged(object sender, EventArgs e)
        {

        }

        private void RdbtnA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RdbtnC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RdbtnE_Click(object sender, EventArgs e)
        {
            if (rdbtnE.Checked && current_test.trueV == rdbtnE.Text)
            {
                rdbtnE.Checked = false;
                current_test.trueV = "F";
            }
            else
            {
                current_test.trueV = rdbtnE.Text;
            }
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (index < test_Count - 1)
            {
                rdbtn[index + 1].Checked = true;
            }
            else
            {
                if (MessageBox.Show("İmtahanı bitirmək istədiyinizdən əminsiniz?", "Diqqət", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    updateAllTests();
                    getResult();
                    insertResult();
                    timerExam.Stop();
                    showResult();
                }
            }
        }
        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                rdbtn[index - 1].Checked = true;
            }
        }
        private void TimerExam_Tick(object sender, EventArgs e)
        {
            if (hour == 0 && minute == 0 && second == 0)
            {
                timerExam.Enabled = false;
                MessageBox.Show("İmtahan müddəti başa çatdı");
                updateAllTests();
                getResult();
                insertResult();
                showResult();
            }

            if (minute == 0 && second == 0)
            {
                minute = 59;
                hour--;
            }
            if (second == 0)
            {
                second = 59;
                if (minute != 59)
                {
                    minute--;
                }
            }
            else
            {
                second--;
            }
            if (second < 10)
            {
                lblSecond.Text = "0" + second.ToString();
            }
            else
            {
                lblSecond.Text = second.ToString();
            }
            if (minute < 10)
            {
                lblMinute.Text = "0" + minute.ToString();
            }
            else
            {
                lblMinute.Text = minute.ToString();
            }
            if (hour < 10)
            {
                lblHour.Text = "0" + hour.ToString();
            }
            else
            {
                lblHour.Text = hour.ToString();
            }
        }
    }
}
