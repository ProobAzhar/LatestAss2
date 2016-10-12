using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace Assignment2a.Core.ViewModels
{
    public class ContactsModel 
        : MvxViewModel
    {
        private string _hello = "Here will be list of contacts!";
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
