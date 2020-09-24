using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Contact_C_K.Utilty;

namespace TP_Contact_C_K
{
    public class ViewModel : ObservableObject
    {

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { OnPropertyChanged(ref _currentView, value); }
        }

    }
}

