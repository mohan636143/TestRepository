using System.Windows.Input;
using Prism.Mvvm;

namespace App1.ViewModels
{
    class LoginPageViewModel : BindableBase
    {
        private string _userId;

        public string UserId
        {
            get { return _userId; }
            set { SetProperty(ref _userId, value); }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value);}
        }

        private ICommand _loginCommand;

        public ICommand LoginCommand
        {
            get { return _loginCommand; }
            set { SetProperty(ref _loginCommand, value); }
        }

        public LoginPageViewModel()
        {
            LoginCommand = new RelayCommand(() =>ExecuteLogin(),() => CanExecuteLogin());
        }

        private void ExecuteLogin()
        {
            throw new System.NotImplementedException();
        }


        private bool CanExecuteLogin()
        {
            if (string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(Password))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
