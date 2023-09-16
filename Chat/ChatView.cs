using ChatWinForm.Walkthrough;
using Microsoft.AspNetCore.SignalR.Client;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ChatWinForm.Chat
{
    public partial class ChatView : Form
    {
        private readonly IFormFactory _formFactory;
        private readonly IUserService _userService;
        private HubConnection _connection;
        private User _user;
        private List<RoomControl> _rooms = new List<RoomControl>();

        private static string ReceiveAllMessage = "ReceiveAllMessage";
        private static string ReceiveSystemMessage = "SystemMessage";
        private static string EnterManyUserRoom = "EnterManyUserRoom";
        private static string PrintRooms = "PrintRooms";
        private static string EnterRoom = "EnterRoom";
        public ChatView(IFormFactory formFactory, IUserService userService)
        {
            InitializeComponent();
            _formFactory = formFactory;
            _userService = userService;
        }

        public async void InitData(User user)
        {
            _user = user;
            _connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7239/chatHub/", options =>
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

            _userService.SetAuthorization(_user.Jwt);

            setHubMsg();
            await _connection.StartAsync();
            await _connection.InvokeAsync(PrintRooms);
        }

        private void setHubMsg()
        {
            _connection.On<string, string>(ReceiveAllMessage, (user, msg) =>
            {
                //Console.WriteLine($"{user}: {msg}");
            });

            _connection.On<string>(ReceiveSystemMessage, (msg) =>
            {
                //Console.WriteLine($"시스템 메세지: {msg}");
            });

            _connection.On<List<Room>>(PrintRooms, (room) =>
            {
                if (_rooms.Count > 0 && room.Count > 0 && flowLayoutPanel1.Controls.Count > 0)
                {
                    foreach (RoomControl control in _rooms)
                    {
                        /**
                         * 작업한 스레드가 아닌 다른 스레드에서 작업하여 발생하는 이슈 존재했음
                         * https://manniz.tistory.com/entry/CC-Sharp-%ED%81%AC%EB%A1%9C%EC%8A%A4-%EC%8A%A4%EB%A0%88%EB%93%9C-%EC%9E%91%EC%97%85%EC%9D%B4-%EC%9E%98%EB%AA%BB%EB%90%98%EC%97%88%EC%8A%B5%EB%8B%88%EB%8B%A4-%EB%B0%94%EB%A1%9C-%ED%95%B4%EA%B2%B0%ED%95%98%EA%B8%B0
                         */
                        flowLayoutPanel1.Invoke(new MethodInvoker(delegate
                        {
                            flowLayoutPanel1.Controls.Remove(control);
                            control.Dispose();
                        }));
                    }
                }

                for (int i = 0; i < room.Count; i++)
                {
                    flowLayoutPanel1.Invoke(new MethodInvoker(delegate
                    {
                        RoomControl control = new RoomControl
                        {
                            Id = room[i].Id.ToString(),
                            UserNames = string.Join(", ", room[i].Users)
                        };
                        flowLayoutPanel1.Controls.Add(control);
                        _rooms.Add(control);
                    }));
                }
            });
        }

        private void roomControl1_Load(object sender, EventArgs e)
        {
        }

        private async void btn_refresh_Click(object sender, EventArgs e)
        {
            await _connection.InvokeAsync(PrintRooms);
        }

        private async void btn_create_room_Click(object sender, EventArgs e)
        {
            var users = await _userService.GetUsers();
            var makeRoomDialog = _formFactory.Create<RoomMakeDialog>();
            makeRoomDialog.InitData(_user, users, _connection);
            makeRoomDialog.ShowDialog();
        }
    }
}
