using ChatWinForm.Walkthrough;
using System.Windows.Forms;

namespace ChatWinForm
{
    public partial class WalkThrough : Form
    {
        private readonly IFormFactory _formFactory;
        public WalkThrough(IFormFactory formFactory)
        {
            InitializeComponent();
            _formFactory = formFactory;
        }

        private void signin_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            var login = _formFactory.Create<Login>();
            login.Show();
        }
    }
}