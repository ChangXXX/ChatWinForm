﻿namespace ChatWinForm
{
    partial class WalkThrough
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.signin = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signin
            // 
            this.signin.Location = new System.Drawing.Point(12, 70);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(100, 40);
            this.signin.TabIndex = 0;
            this.signin.Text = "로그인";
            this.signin.UseVisualStyleBackColor = true;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(162, 70);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(100, 40);
            this.signup.TabIndex = 1;
            this.signup.Text = "회원가입";
            this.signup.UseVisualStyleBackColor = true;
            // 
            // WalkThrough
            // 
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 178);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.signin);
            this.Name = "WalkThrough";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Button signup;
    }
}
