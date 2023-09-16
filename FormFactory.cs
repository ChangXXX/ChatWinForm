using ChatWinForm.Chat;
using ChatWinForm.Walkthrough;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatWinForm
{
    public class FormFactory : IFormFactory
    {

        private readonly IServiceScope _scope;

        public FormFactory(IServiceScopeFactory scopeFactory)
        {
            _scope = scopeFactory.CreateScope();
        }

        public T Create<T>() where T : Form
        {
            return _scope.ServiceProvider.GetService<T>();
        }
    }

    public interface IFormFactory
    {
        T Create<T>() where T : Form;
    }
}
