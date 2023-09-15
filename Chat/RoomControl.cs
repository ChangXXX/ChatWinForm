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
    public partial class RoomControl : UserControl
    {
        public RoomControl()
        {
            InitializeComponent();
        }

        private string _id;
        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
                lb_room_id.Text = value;
            }
        }

        private string _userNames;
        public string UserNames
        {
            get { return _userNames; }
            set
            {
                _userNames = value;
                lb_names.Text = value;
            }
        }
    }
}
