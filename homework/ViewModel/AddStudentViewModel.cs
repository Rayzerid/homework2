using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using homework.Structs;
using homework.Commands;
using System.Net;

namespace homework.ViewModel
{
    public class AddStudentViewModel : ViewModelBase
    {
        public ICommand SaveAddCommand { get; }
        public GlobalViewModel _globalViewModel;
        public AddStudentViewModel(GlobalViewModel globalViewModel)
        {
            SaveAddCommand = new SaveAddCommand(this);
            _globalViewModel = globalViewModel;
        }

        private string _group;

        public string Groups
        {
            get { return _group; }
            set 
            {
                _group = value;
                OnPropertyChanged();
            }
        }

        private string _fio;

        public string FIOS
        {
            get { return _fio; }
            set 
            {
                _fio = value;
                OnPropertyChanged();
            }
        }

        private string _post;

        public string Posts 
        {
            get { return _post; }
            set
            {
                _post = value;
                OnPropertyChanged();
            }
        }

        private int _experience;

        public int Experience
        {
            get { return _experience; }
            set
            {
                _experience = value;
                OnPropertyChanged();
            }
        }
    }
}
