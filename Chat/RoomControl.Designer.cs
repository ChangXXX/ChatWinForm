﻿namespace ChatWinForm.Chat
{
    partial class RoomControl
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
            this.lb_room_id = new System.Windows.Forms.Label();
            this.lb_names = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_room_id
            // 
            this.lb_room_id.AutoSize = true;
            this.lb_room_id.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_room_id.Location = new System.Drawing.Point(13, 10);
            this.lb_room_id.Name = "lb_room_id";
            this.lb_room_id.Size = new System.Drawing.Size(43, 17);
            this.lb_room_id.TabIndex = 0;
            this.lb_room_id.Text = "label1";
            // 
            // lb_names
            // 
            this.lb_names.AutoEllipsis = true;
            this.lb_names.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_names.Location = new System.Drawing.Point(12, 37);
            this.lb_names.Name = "lb_names";
            this.lb_names.Size = new System.Drawing.Size(275, 20);
            this.lb_names.TabIndex = 1;
            this.lb_names.Text = "label2";
            // 
            // RoomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lb_names);
            this.Controls.Add(this.lb_room_id);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "RoomControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(284, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_room_id;
        private System.Windows.Forms.Label lb_names;
    }
}
