using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlyTunes.ViewModels
{
    public class OtherViewViewModel : ViewModelBase
    {
        private DelegateCommand _myImageCommand;
        public DelegateCommand MyImageCommand =>
            _myImageCommand ?? (_myImageCommand = new DelegateCommand(ExecuteMyImageCommand));

        void ExecuteMyImageCommand()
        {

        }

        public OtherViewViewModel(INavigationService navigation) : base(navigation)
        {
            Title = "Home Page";

         //   var vm = new MapsViewViewModel(;
        }


    }
}
