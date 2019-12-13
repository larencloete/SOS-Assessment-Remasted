﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace I.C.E.ViewModels
{
    public class SignupORLoginPageViewModel : BindableBase
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private INavigationService _navigationService;
        private DelegateCommand _navigateCommand;
        private DelegateCommand _navigateLoginCommand;

        public DelegateCommand NavigateLoginCommand =>
            _navigateLoginCommand ?? (_navigateLoginCommand = new DelegateCommand(ExecuteNavigateLoginCommand));


        public DelegateCommand NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateSignUpCommand));

        private async void ExecuteNavigateSignUpCommand()
        {
            //logic to go to sign up page

            await _navigationService.NavigateAsync("SignupPage");

        }

        public SignupORLoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Title = "SignUpORlogin";

        }


        private async void ExecuteNavigateLoginCommand()
        {

            await _navigationService.NavigateAsync("LoginPage");

        }
    }
}