using System;
using System.Drawing;
using System.Windows.Forms;
namespace test
{
    partial class CounterLogin
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbPw = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbPw = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbPcnum = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbPw);
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Controls.Add(this.lbPw);
            this.panel1.Controls.Add(this.lbId);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 339);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 97);
            this.panel1.TabIndex = 2;
            // 
            // tbPw
            // 
            this.tbPw.Location = new System.Drawing.Point(530, 52);
            this.tbPw.Margin = new System.Windows.Forms.Padding(2);
            this.tbPw.Name = "tbPw";
            this.tbPw.PasswordChar = '*';
            this.tbPw.Size = new System.Drawing.Size(133, 21);
            this.tbPw.TabIndex = 2;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(483, 20);
            this.tbId.Margin = new System.Windows.Forms.Padding(2);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(181, 21);
            this.tbId.TabIndex = 2;
            // 
            // lbPw
            // 
            this.lbPw.AutoSize = true;
            this.lbPw.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbPw.Location = new System.Drawing.Point(446, 52);
            this.lbPw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPw.Name = "lbPw";
            this.lbPw.Size = new System.Drawing.Size(85, 20);
            this.lbPw.TabIndex = 1;
            this.lbPw.Text = "Password :";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbId.Location = new System.Drawing.Point(446, 20);
            this.lbId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(34, 20);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "ID :";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(704, 33);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 39);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbPcnum
            // 
            this.lbPcnum.AutoSize = true;
            this.lbPcnum.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold);
            this.lbPcnum.Location = new System.Drawing.Point(2, 7);
            this.lbPcnum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPcnum.Name = "lbPcnum";
            this.lbPcnum.Size = new System.Drawing.Size(367, 65);
            this.lbPcnum.TabIndex = 3;
            this.lbPcnum.Text = "관리자/알바 PC";
            // 
            // CounterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.lbPcnum);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CounterLogin";
            this.Size = new System.Drawing.Size(814, 436);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox tbPw;
        private TextBox tbId;
        private Label lbPw;
        private Label lbId;
        private Button btnLogin;
        private Label lbPcnum;
    }
}
