using ChatWinForm.Walkthrough;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Runtime.Remoting.Channels;
using System.Threading.Tasks;
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
        public ChatDialog(User user, Room room)
        {
            InitializeComponent();

            _user = user;
            _room = room;
            lb_Users.Text = string.Join(", ", room.Users);
            _connection = new HubConnectionBuilder()
                .WithUrl(ServerUrl.Hub, options =>
                {
                    options.AccessTokenProvider = () => Task.FromResult(_user.Jwt);
                })
                .WithAutomaticReconnect()
                .Build();

            _connection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await _connection.StartAsync();
            };

            setHubMsg();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _connection.SendAsync(DisconnectConnectChatRoom, _room).GetAwaiter().GetResult();
            _connection.DisposeAsync().GetAwaiter().GetResult();
            base.OnFormClosing(e);
        }

        public async void InitData()
        {
            await _connection.StartAsync();
            await _connection.SendAsync(ConnectChatRoom, _room);
        }

        private void setHubMsg()
        {
            _connection.On<Message>(SendGroupMessage, (msg) =>
            {
                var control = new MsgControl
                {
                    Name = msg.Sender,
                    Message = msg.Msg
                };
                if (msg.Sender.Equals(_user.Name))
                {
                    control.IsSend = true;
                    addMsgControl(control);
                }
                else
                {
                    control.IsSend = false;
                    // add receivecontrol
                    addMsgControl(control);
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
                tb_input.Text = string.Empty;
            }
        }

        private void msgControl1_Load(object sender, EventArgs e)
        {
        }

        private void addMsgControl(MsgControl control)
        {
            flowLayoutPanel1.Invoke(new MethodInvoker(delegate
            {
                flowLayoutPanel1.Controls.Add(control);
            }));
        }
    }
}
