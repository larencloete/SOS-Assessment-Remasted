using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace I.C.E.Remasted.ViewModels
{
    public class My_ContactsViewModel : BindableBase
    {
        private string _title;
        public string Title

        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private INavigationService _navigationService;
        private DelegateCommand _navigateCommand;
        public DelegateCommand NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateLoginCommand));

        private async void ExecuteNavigateLoginCommand()
        {
            //await NavigationService.NavigateAsync("HomePage/NavigationPage/SignupORLoginPage", useModalNavigation: true);
            await _navigationService.NavigateAsync("SOSMessage", useModalNavigation: true);
        }

        //private async void ExecuteNavigateLoginCommand()
        //{
        //    await _navigationService.NavigateAsync("HomePage/NavigationPage/SignupORLoginPage", useModalNavigation: true);
        //}

        public My_ContactsViewModel(INavigationService navigationService)
        {
            Title = "LoginPage";
            _navigationService = navigationService;

        }
    }
}
