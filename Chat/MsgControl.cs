﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatWinForm.Chat
{
    public partial class MsgControl : UserControl
    {
        public MsgControl()
        {
            InitializeComponent();
        }

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                lb_name.Text = _name;
            }
        }

        private string _message;
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                lb_msg.Text = _message;
            }
        }

        private bool _isSend;
        public bool IsSend
        {
            get
            {
                return _isSend;
            }
            set
            {
                _isSend = value;
                if (value)
                {
                    this.BackColor = System.Drawing.Color.LightCyan;
                }
                else
                {
                    this.BackColor = System.Drawing.Color.Cyan;
                }
            }
        }
    }
}
