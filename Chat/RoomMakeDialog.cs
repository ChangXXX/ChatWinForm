using ChatWinForm.Walkthrough;
using Microsoft.AspNetCore.SignalR.Client;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChatWinForm.Chat
{
    public partial class RoomMakeDialog : Form
    {
        private User _user;
        private HubConnection _connection;
        private static string CreateRoom = "CreateRoom";


        public RoomMakeDialog()
        {
            InitializeComponent();
        }

        public void InitData(User user, List<string> users, HubConnection connection)
        {
            _user = user;
            _connection = connection;

            for (int i = 0; i < users.Count; i++)
            {
                if (!_user.Name.Equals(users[i]))
                {
                    UserListControl control = new UserListControl
                    {
                        Name = users[i]
                    };
                    flowLayoutPanel1.Controls.Add(control);
                }
            }
        }

        private void userListControl1_Load(object sender, System.EventArgs e)
        {
        }

        private async void btn_create_Click(object sender, System.EventArgs e)
        {
            List<string> checkedList = new List<string>();
            foreach (UserListControl control in flowLayoutPanel1.Controls)
            {
                if (control.IsChecked)
                {
                    checkedList.Add(control.Name);
                }
            }
            if (checkedList.Count > 0)
            {
                checkedList.Insert(0, _user.Name);
                await _connection.InvokeAsync(CreateRoom, checkedList);
                this.Close();
            }
        }
    }
}
