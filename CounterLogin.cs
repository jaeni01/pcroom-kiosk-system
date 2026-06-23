using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace test
{
    public partial class CounterLogin : UserControl
    {
        // ── 회원가입 패널 관련 컨트롤 ──────────────────
        private Panel pnlRegister;
        private TextBox txtRegId, txtRegName, txtRegBirth, txtRegPw, txtRegPhone;

        public CounterLogin()
        {
            InitializeComponent();
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = tbId.Text.Trim();
            string pw = tbPw.Text.Trim();

            if (id.Length == 0 || pw.Length == 0)
            {
                MessageBox.Show("아이디와 비밀번호를 입력해주세요.");
                return;
            }

            string role = GetRole(id, pw);

            if (role == null)
            {
                MessageBox.Show("아이디 또는 비밀번호가 틀렸습니다.");
                return;
            }

            Form1 parentForm = (Form1)this.FindForm();

            if (role == "관리자")
            {
                parentForm.ShowAdmin();
            }
            else if (role == "알바")
            {
                parentForm.ShowAlba();
            }
            else
            {
                MessageBox.Show("손님은 키오스크를 이용해주세요.");
            }
        }

        // DB에서 아이디/비번 확인 후 role 반환
        private string GetRole(string id, string pw)
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Member.db");
            string connString = "Data Source=" + dbPath + ";Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                string query = "SELECT role FROM Member WHERE id=@ID AND password=@PW";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@PW", pw);
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
            }
        }
    }
}