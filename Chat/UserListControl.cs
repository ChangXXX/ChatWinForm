using System;
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
    public partial class UserListControl : UserControl
    {
        public UserListControl()
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

        public bool IsChecked
        {
            get
            {
                return cb_add.Checked;
            }
        }
    }
}
