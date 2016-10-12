using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace Assignment2a.Core.ViewModels
{
    public class MainMenuModel 
        : MvxViewModel
    {
        private string _hello = "Welcome to Glados!!";
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
        public ICommand MessagesButton { get; private set; }
        public ICommand ContactsButton { get; private set; }
        public ICommand EventsButton { get; private set; }
        public ICommand GroupsButton { get; private set; }
        public ICommand NotesButton { get; private set; }

        public MainMenuModel()
        {
            MessagesButton= new MvxCommand(() =>
            {
                ShowViewModel<MessagesModel>();
            });
            ContactsButton = new MvxCommand(() =>
            {
                ShowViewModel<ContactsModel>();
            });
            EventsButton = new MvxCommand(() =>
            {
                ShowViewModel<EventsModel>();
            });
            GroupsButton = new MvxCommand(() =>
            {
                ShowViewModel<GroupsModel>();
            });
            NotesButton = new MvxCommand(() =>
            {
                ShowViewModel<NotesModel>();
            });
        }
    }
}
