using ChatWinForm.Walkthrough;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace ChatWinForm.Chat
{
    public partial class ChatDialog : Form
    {
        private User _user;
        private Room _room;
        private HubConnection _connection;
        private static string ConnectChatRoom = "ConnectChatRoom";
        private static string DisconnectConnectChatRoom = "DisconnectConnectChatRoom";
        private static string SendGroupMessage = "SendGroupMessage";
        public ChatDialog()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _connection.SendAsync(DisconnectConnectChatRoom, _room).GetAwaiter().GetResult();
            base.OnFormClosing(e);
        }

        public async void InitData(User user, Room room, HubConnection connection)
        {
            _user = user;
            _room = room;
            lb_Users.Text = string.Join(", ", room.Users);
            _connection = connection;
            await _connection.SendAsync(ConnectChatRoom, room);

            _connection.On<Message>(SendGroupMessage, (msg) =>
            {
                if (msg.Sender.Equals(_user.Name))
                {
                    // add sendcontrol
                    flowLayoutPanel1.Controls.Add(
                        new SendMsgControl
                        {
                            Name = msg.Sender,
                            Message = msg.Msg
                        }
                    );
                }
                else
                {
                    // add receivecontrol
                }
            });
        }

        private async void btn_send_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_input.Text) && !string.IsNullOrWhiteSpace(tb_input.Text))
            {
                var msg = new Message
                {
                    Sender = _user.Name,
                    Msg = tb_input.Text
                };
                await _connection.SendAsync(SendGroupMessage, _room.Id.ToString() , msg);
            }
        }

        private void sendMsgControl1_Load(object sender, EventArgs e)
        {
        }
    }
}
