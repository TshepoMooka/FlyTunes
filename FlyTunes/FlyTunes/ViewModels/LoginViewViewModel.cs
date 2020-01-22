﻿using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using FlyTunes.Messages.Security;
using FlyTunes.Model.Security;
using FlyTunes.Services.Interfaces;
using FlyTunes.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlyTunes.ViewModels
{
    public class LoginViewViewModel : ViewModelBase
    {
        private ISecurityService _securityService;
        private IEventAggregator _eventAggregator;

        private DelegateCommand _loginCommand;
        public DelegateCommand LoginCommand =>
            _loginCommand ?? (_loginCommand = new DelegateCommand(ExecuteLoginCommand));


        public LoginViewViewModel(INavigationService navigation, ISecurityService securityService, IEventAggregator eventAggregator) : base (navigation)
        {
            _securityService = securityService;

            _eventAggregator = eventAggregator;
        }

        void ExecuteLoginCommand()
        {
            // DO YOUR OWN LOGIN LOGIC AND VALIDATION
            var loginResult =_securityService.LogIn("Test User", "Password");

            // I may have gotten a user profile somewhere..  Use whatever your app does
            var userProfile = new UserProfile();

            if (loginResult)
            {
                _eventAggregator.GetEvent<LoginMessage>().Publish(userProfile);
            }
        }

    }
}
