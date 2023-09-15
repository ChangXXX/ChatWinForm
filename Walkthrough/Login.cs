
using ChatWinForm.Chat;
using System.Windows.Forms;

namespace ChatWinForm.Walkthrough
{
    public partial class Login : Form
    {
        private readonly IFormFactory _formFactory;
        private readonly ILoginService _loginService;
        public Login(IFormFactory formFactory, ILoginService loginService)
        {
            InitializeComponent();
            _loginService = loginService;
            _formFactory = formFactory;
        }

        private async void button1_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_name.Text) && !string.IsNullOrEmpty(tb_pwd.Text))
            {
                var user = await _loginService.Login(tb_name.Text, tb_pwd.Text);
                if (user != null)
                {
                    this.Close();
                    var chat = _formFactory.Create<ChatView>();
                    chat.InitData(user);
                    chat.Show();
                }
            }
        }
    }
}
