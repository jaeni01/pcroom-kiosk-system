using System;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TcpServer.Instance.Start();
            ShowLogin();
        }

        public void ShowLogin()
        {
            this.Controls.Clear();
            CounterLogin login = new CounterLogin();
            login.Dock = DockStyle.Fill;
            this.Controls.Add(login);
        }

        public void ShowAdmin()
        {
            this.Controls.Clear();
            Admin admin = new Admin();
            admin.Dock = DockStyle.Fill;
            this.Controls.Add(admin);
        }

        public void ShowAlba()
        {
            this.SuspendLayout();
            for (int i = this.Controls.Count - 1; i >= 0; i--)
                this.Controls.RemoveAt(i);
            CounterAl alba = new CounterAl();
            alba.Dock = DockStyle.Fill;
            this.Controls.Add(alba);
            this.ResumeLayout();
        }

        public void ShowParttime() { ShowAlba(); }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            TcpServer.Instance.Stop();
            base.OnFormClosing(e);
        }
    }
}
