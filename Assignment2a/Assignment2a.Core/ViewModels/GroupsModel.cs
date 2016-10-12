using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace Assignment2a.Core.ViewModels
{
    public class GroupsModel 
        : MvxViewModel
    {
        private string _hello = "Shush! Lets have a lunch. dont let mary know";
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
