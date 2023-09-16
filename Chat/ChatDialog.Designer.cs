namespace ChatWinForm.Chat
{
    partial class ChatDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_send = new System.Windows.Forms.Button();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.lb_Users = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 36);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_send.FlatAppearance.BorderSize = 0;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.Location = new System.Drawing.Point(215, 486);
            this.btn_send.Margin = new System.Windows.Forms.Padding(0);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(69, 78);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "보내기";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // tb_input
            // 
            this.tb_input.BackColor = System.Drawing.Color.White;
            this.tb_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_input.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_input.Location = new System.Drawing.Point(0, 486);
            this.tb_input.Margin = new System.Windows.Forms.Padding(0);
            this.tb_input.Multiline = true;
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(215, 78);
            this.tb_input.TabIndex = 2;
            // 
            // lb_Users
            // 
            this.lb_Users.AutoEllipsis = true;
            this.lb_Users.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Users.Location = new System.Drawing.Point(12, 9);
            this.lb_Users.Name = "lb_Users";
            this.lb_Users.Size = new System.Drawing.Size(260, 23);
            this.lb_Users.TabIndex = 3;
            this.lb_Users.Text = "label1";
            // 
            // ChatDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 561);
            this.Controls.Add(this.lb_Users);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ChatDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Label lb_Users;
    }
}