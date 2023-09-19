using System;
using System.Windows.Forms;

namespace ChatWinForm.Walkthrough
{
    public partial class SignUp : Form
    {
        private readonly ISignService _signService;
        private readonly IFormFactory _formFactory;
        public SignUp(ISignService signService, IFormFactory formFactory)
        {
            InitializeComponent();
            _signService = signService;
            _formFactory = formFactory;
        }

        private async void btn_signup_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_name.Text) && !string.IsNullOrEmpty(tb_pwd.Text))
            {
                var res = await _signService.Signup(tb_name.Text, tb_name.Text);
                if (res)
                {
                    this.Close();
                }
            }
        }
    }
}
