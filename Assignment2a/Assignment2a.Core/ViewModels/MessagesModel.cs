using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace Assignment2a.Core.ViewModels
{
    public class MessagesModel
        : MvxViewModel
    {
        private string _hello = "Start pming bitch!";
        public string Hello
        {
            get { return _hello; }
            set
            {
                if (value != null && value != _hello)
                {
                    _hello = value;
                    RaisePropertyChanged(() => Hello);
                }
            }
        }
        
    }
}
