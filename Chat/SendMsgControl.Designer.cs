namespace ChatWinForm.Chat
{
    partial class SendMsgControl
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
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_name.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_name.Location = new System.Drawing.Point(218, 11);
            this.lb_name.Margin = new System.Windows.Forms.Padding(3);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(51, 20);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "label1";
            // 
            // lb_msg
            // 
            this.lb_msg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_msg.AutoSize = true;
            this.lb_msg.BackColor = System.Drawing.Color.Transparent;
            this.lb_msg.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_msg.Location = new System.Drawing.Point(180, 41);
            this.lb_msg.Margin = new System.Windows.Forms.Padding(3);
            this.lb_msg.Name = "lb_msg";
            this.lb_msg.Size = new System.Drawing.Size(89, 20);
            this.lb_msg.TabIndex = 1;
            this.lb_msg.Text = "보낸 메세지";
            this.lb_msg.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SendMsgControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lb_msg);
            this.Controls.Add(this.lb_name);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SendMsgControl";
            this.Size = new System.Drawing.Size(284, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_msg;
    }
}
